using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //車用データ管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        int count = 0;
        
        Settings settings = Settings.getInstance();

        public Form1()
        {
            InitializeComponent();
            dgvDataGridView.DataSource = listCarReport;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            EnableCheck();
            //設定ファイルを逆シリアル化して背景の色を設定
            try
            {
                using (var reader = XmlReader.Create("setting.xml"))
                {
                    var serializer = new XmlSerializer(typeof(Settings)); //p185
                    settings = serializer.Deserialize(reader) as Settings;//as Novel キャストしている
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            } catch (Exception)
            {


            }

        }

        //壁画の色を保存する
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //設定ファイルをシリアル化
            EnableCheck();
            if (File.Exists("setting.xml"))
            {
                using (var writer = XmlWriter.Create("setting.xml"))
                {
                    var serializer = new XmlSerializer(settings.GetType()); //p185
                    serializer.Serialize(writer, settings);
                }
            }
        }

        //画像を開くイベントハンドラ
        private void btOpenPicture_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }
        //画像を消すイベントハンドラ
        private void btDeletePicture_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        //追加のイベントハンドラ
        private void btAddArticle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbReporter.Text))
            {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            CarReport newCarReport = new CarReport
            {
                Date = dtpDateTimePicker.Value,
                Auther = cbReporter.Text,
                Maker = GetCheckBoxGroup(),
                CarName = cbCarName.Text,
                Report = tbAddress.Text,
                Picture = pbPicture.Image,
            };


            listCarReport.Add(newCarReport);

            dgvDataGridView.Rows[dgvDataGridView.RowCount - 1].Selected = true;

            EnableCheck();
            setCbReporter(cbReporter.Text);
            setCbCarName(cbCarName.Text);

            for (int row_index = 0; row_index < dgvDataGridView.Rows.Count; row_index++) {
                dgvDataGridView.Rows[row_index].Height = 30;
            }
        }

        //修正のイベントハンドラ
        private void btReviseArticle_Click(object sender, EventArgs e)
        {

            int index = dgvDataGridView.CurrentRow.Index;

            listCarReport[index].Date = dtpDateTimePicker.Value;
            listCarReport[index].Auther = cbReporter.Text;
            listCarReport[index].Maker = GetCheckBoxGroup();
            listCarReport[index].CarName = cbCarName.Text;
            listCarReport[index].Report = tbAddress.Text;
            listCarReport[index].Picture = pbPicture.Image;
            dgvDataGridView.Refresh();
        }

        //削除のイベントハンドラ
        private void btDeleteArticle_Click(object sender, EventArgs e)
        {
            listCarReport.RemoveAt(dgvDataGridView.CurrentRow.Index);
            EnableCheck();
        }

        //記録を開くイベントハンドラ
        private void btOpenArticle_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    //バイナリ形式でシリアル化(保存できるようにしている)
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvDataGridView.DataSource = null;
                        dgvDataGridView.DataSource = listCarReport;

                    }

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cbCarName.Items.Clear();
                cbReporter.Items.Clear();
                foreach (var item in listCarReport.Select(p => p.CarName))
                {
                    setCbCarName(item);//存在する会社を登録
                }

                foreach (var item in listCarReport.Select(p => p.Report))
                {
                    setCbReporter(item);//存在する会社を登録
                }

                EnableCheck();
            }
        }

        //記録を保存するイベントハンドラ
        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化(保存できるようにしている)
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveFileDialog.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, listCarReport);
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //色設定を反映イベントハンドラ
        private void 設定ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cdColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cdColorDialog.Color;
                settings.MainFormColor = cdColorDialog.Color.ToArgb();
            }
        }

        //終了のイベントハンドラ
        private void btFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //メソッド
        //チェックボックスにセットされている値をリストとして取り出す
        private CarReport.MakerGroup GetCheckBoxGroup()
        {
            var Group = new CarReport.MakerGroup();
            if (rbToyota.Checked)
            {
                Group = CarReport.MakerGroup.トヨタ;
            }else if (rbNissan.Checked)
            {
                Group = CarReport.MakerGroup.日産;
            }else if (rbHonda.Checked)
            {
                Group = CarReport.MakerGroup.ホンダ;
            }else if (rbSubaru.Checked)
            {
                Group = CarReport.MakerGroup.スバル;
            }else if (rbOutsideCar.Checked)
            {
                Group = CarReport.MakerGroup.外国車;
            }else if (rbOther.Checked)
            {
                Group = CarReport.MakerGroup.その他;
            }
            return Group;
        }

        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear()
        {
            rbToyota.Checked = rbNissan.Checked = rbHonda.Checked = rbSubaru.Checked = rbOutsideCar.Checked
                = rbOther.Checked = false;
        }
        //コンボボックスに登録
        private void setCbCarName(string carName)
        {
            if (!cbCarName.Items.Contains(carName ))
            {
                cbCarName.Items.Add(carName);
            }
        }
        //コンボボックスに登録
        private void setCbReporter(string reporter)
        {
            if (!cbReporter.Items.Contains(reporter))
            {
                cbReporter.Items.Add(reporter);
            }
        }
        //更新・削除ボタンのマスク処理行う
        private void EnableCheck()
        {

            btReviseArticle.Enabled = btDeleteArticle.Enabled = listCarReport.Count() > 0 ? true : false;
            #region
            //if (listPerson.Count() > 0)
            //{
            //    //マスク解除
            //    btremove.Enabled = true;
            //    btUpdate.Enabled = true;
            //} else
            //{
            //    //マスク設定
            //    btremove.Enabled = false;
            //    btUpdate.Enabled = false;
            //}
            #endregion//上の内容
        }
    }
}
