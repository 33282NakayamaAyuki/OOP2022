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
        
        Settings settings = Settings.getInstance();

        public Form1()
        {
            InitializeComponent();
            //dgvDataGridView.DataSource = listCarReport;
        }
        
        //フォームロード
        private void Form1_Load(object sender, EventArgs e)
        {

            // this.carReportDBTableAdapter.Fill(this.infosys202225DataSet.CarReportDB);
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

#if dtvversion
            //CarReport newCarReport = new CarReport
            //{
            //    Date = dtpDateTimePicker.Value,
            //    Auther = cbReporter.Text,
            //    Maker = GetCheckBoxGroup(),
            //    CarName = cbCarName.Text,
            //    Report = tbAddress.Text,
            //    Picture = pbPicture.Image,
            //};


            //listCarReport.Add(newCarReport);

            //dgvDataGridView.Rows[dgvDataGridView.RowCount - 1].Selected = true;
#endif

            DataRow newRow = infosys202225DataSet.CarReportDB.NewRow();
            newRow[0] = dtpDateTimePicker.Value;
            newRow[1] = cbReporter.Text;
            newRow[2] = GetCheckBoxGroup();
            newRow[3] = cbCarName.Text;
            newRow[4] = tbAddress.Text;
            newRow[5] = ImageToByteArray(pbPicture.Image);
            //データセットへ新しいレコードを追加
            infosys202225DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202225DataSet.CarReportDB);

            EnableCheck();
            setCbReporter(cbReporter.Text);
            setCbCarName(cbCarName.Text);
            this.Validate();
            this.carReportDBDataGridView.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202225DataSet);

            for (int row_index = 0; row_index < carReportDBDataGridView.Rows.Count; row_index++)
            {
                carReportDBDataGridView.Rows[row_index].Height = 30;
            }
        }

        //更新のイベントハンドラ
        private void btUpdateArticle_Click(object sender, EventArgs e)
        {
#if dgvversion
            int index = dgvDataGridView.CurrentRow.Index;

            listCarReport[index].Date = dtpDateTimePicker.Value;
            listCarReport[index].Auther = cbReporter.Text;
            listCarReport[index].Maker = GetCheckBoxGroup();
            listCarReport[index].CarName = cbCarName.Text;
            listCarReport[index].Report = tbAddress.Text;
            listCarReport[index].Picture = pbPicture.Image;
            dgvDataGridView.Refresh();
#endif
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpDateTimePicker.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbReporter.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetCheckBoxGroup();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbAddress.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = pbPicture.Image;

            this.Validate();
            this.carReportDBDataGridView.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202225DataSet);

        }

        //削除のイベントハンドラ
        private void btDeleteArticle_Click(object sender, EventArgs e)
        {
            EnableCheck();
            carReportDBBindingSource.RemoveAt(carReportDBDataGridView.CurrentRow.Index);
            //listCarReport.RemoveAt(dgvDataGridView.CurrentRow.Index);
            this.Validate();
            this.carReportDBDataGridView.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202225DataSet);
        }

        //記録を開くイベントハンドラ
        #region
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
                        //dgvDataGridView.DataSource = null;
                        //dgvDataGridView.DataSource = listCarReport;

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
        #endregion

        //記録を保存するイベントハンドラ
        #region
        private void btSave_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //色設定を反映イベントハンドラ
        private void 設定ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cdColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cdColorDialog.Color;
                settings.MainFormColor = cdColorDialog.Color.ToArgb();
            }
        }
        
        //データを保存
        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportDBDataGridView.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202225DataSet);
        }

        //データベースに接続
        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.carReportDBTableAdapter.Fill(this.infosys202225DataSet.CarReportDB);
            EnableCheck();
        }

        //DataGridViewの行をクリックしたとき
        private void carReportDBDataGridView_Click(object sender, EventArgs e)
        {
            if (carReportDBDataGridView.CurrentRow == null)
                return;

            dtpDateTimePicker.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbReporter.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            GetRbInfomation();
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbAddress.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull))
            {
                pbPicture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            } else
            {
                pbPicture.Image = null;
            }
        }

        //エラーをなくす
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //名前検索のイベントハンドラ
        private void btSearchName_Click(object sender, EventArgs e)
        {
            carReportDBTableAdapter.FillBy(infosys202225DataSet.CarReportDB, tbSearchName.Text);
            EnableCheck();
        }

        //名前検索削除のイベントハンドラ
        private void btSearchClear_Click(object sender, EventArgs e)
        {
            tbSearchName = null;
            carReportDBTableAdapter.Fill(infosys202225DataSet.CarReportDB);
        }

        //終了のイベントハンドラ
        private void btFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        
        //ここからメソッド
        //チェックボックスにセットされている値をリストとして取り出す
        private string GetCheckBoxGroup()
        {

            if (rbToyota.Checked)
            {
               return "トヨタ";
            } else if (rbNissan.Checked)
            {
                return "日産";
            } else if (rbHonda.Checked)
            {
                return "ホンダ";
            } else if (rbSubaru.Checked)
            {
                return "スバル";
            } else if (rbOutsideCar.Checked)
            {
                return "外国車";
            }
            return "その他";
       
        }

        //ラジオボタンに反映
        private void GetRbInfomation()
        {
            switch (carReportDBDataGridView.CurrentRow.Cells[3].Value)
            {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外国車":
                    rbOutsideCar.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                default: break;
            }

        }

        //コンボボックスに登録（Name）
        private void setCbCarName(string carName)
        {
            if (!cbCarName.Items.Contains(carName ))
            {
                cbCarName.Items.Add(carName);
            }
        }

        //コンボボックスに登録（Reporter）
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

            btupdateArticle.Enabled = btDeleteArticle.Enabled =  carReportDBDataGridView.RowCount > 0 ? true : false;
            #region
            //if (carReportDBDataGridView.RowCount > 0)
            //{
            //    //マスク解除
            //    btupdateArticle.Enabled = true;
            //    btDeleteArticle.Enabled = true;
            //} else
            //{
            //    //マスク設定
            //    btupdateArticle.Enabled = false;
            //    btDeleteArticle.Enabled = false;
            //}
            #endregion
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

    }
}
