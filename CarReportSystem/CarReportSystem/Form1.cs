using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //車用データ管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btOpenPicture_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btDeletePicture_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

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

            setCbReporter(cbReporter.Text);
            setCbCarName(cbCarName.Text);
        }


        private void btDeleteArticle_Click(object sender, EventArgs e)
        {
            listCarReport.RemoveAt(dgvDataGridView.CurrentRow.Index);
        }
        //チェックボックスにセットされている値をリストとして取り出す
        private List<CarReport.MakerGroup> GetCheckBoxGroup()
        {
            var listGroup = new List<CarReport.MakerGroup>();
            if (cbToyota.Checked)
            {
                listGroup.Add(CarReport.MakerGroup.トヨタ);
            }
            if (cbNissan.Checked)
            {
                listGroup.Add(CarReport.MakerGroup.日産);
            }
            if (cbHonda.Checked)
            {
                listGroup.Add(CarReport.MakerGroup.ホンダ);
            }
            if (cbSubaru.Checked)
            {
                listGroup.Add(CarReport.MakerGroup.スバル);
            }
            if (cbOutsideCar.Checked)
            {
                listGroup.Add(CarReport.MakerGroup.外国車);
            }
            if (cbOther.Checked)
            {
                listGroup.Add(CarReport.MakerGroup.その他);
            }
            return listGroup;
        }

        
        //コンボボックスに登録
        private void setCbReporter(string company)
        {
            if (!cbReporter.Items.Contains(company))
            {
                cbReporter.Items.Add(company);
            }
        }
        private void setCbCarName(string company)
        {
            if (!cbCarName.Items.Contains(company))
            {
                cbCarName.Items.Add(company);
            }
        }

        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear()
        {
            cbToyota.Checked = cbNissan.Checked = cbHonda.Checked = cbSubaru.Checked = cbOutsideCar.Checked
                = cbOther.Checked = false;
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
