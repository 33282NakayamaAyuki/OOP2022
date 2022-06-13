using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1()
        {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);


            }

        }
        //追加ボタンが押された時の処理
        private void btAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person
            {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };
            if (tbName.Text != "")
            {

                listPerson.Add(newPerson);
            } else {
                MessageBox.Show("名前を入力してください");
            }
            

        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup()
        {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked)
            {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked)
            {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked)
            {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked)
            {
                listGroup.Add(Person.GroupType.その他);
            }
            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e)
        {

        }

        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear()
        {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e)
        {

            int index = dgvPersons.CurrentRow.Index;

            listPerson[index].Name = tbName.Text;
            listPerson[index].MailAddress = tbMailAddress.Text;
            listPerson[index].Address = tbAddress.Text;
            listPerson[index].Company = tbCompany.Text;
            listPerson[index].listGroup = GetCheckBoxGroup();
            listPerson[index].Picture = pbPicture.Image;
            dgvPersons.Refresh();

        }

        private void btremove_Click(object sender, EventArgs e)
        {
            dgvPersons.Rows.RemoveAt(dgvPersons.CurrentRow.Index);
            dgvPersons.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                btUpdate.Enabled = false;//更新ボタンをマスク
                btremove.Enabled = false;//削除ボタンをマスク
                btPictureClear.Enabled = false;//削除ボタンをマスク
                dgvPersons.Refresh();
        }
    }
}
