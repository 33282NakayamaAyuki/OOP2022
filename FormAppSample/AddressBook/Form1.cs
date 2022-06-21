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

namespace AddressBook {
    public partial class Form1 : Form {
       
        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1()
        {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableCheck();
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
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person
            {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
                Registration = dtpResistDate.Value,
                KindNumber = GetCheckKindNumber(),
                TeleNumber = teleNumber.Text,

            };

            
            listPerson.Add(newPerson);
            dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

            EnableCheck();

            setCbCompany(cbCompany.Text);
        }

        private void btPictureClear_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null) return;

            int index = dgvPersons.CurrentRow.Index;

            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            cbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;
            teleNumber.Text = listPerson[index].TeleNumber;

            dtpResistDate.Value = 
                listPerson[index].Registration.Year > 1900 ? listPerson[index].Registration : DateTime.Today;

            groupCheckBoxAllClear();

            foreach (var group in listPerson[index].listGroup)
            {
                switch (group)
                {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }

            foreach (var group in listPerson[index].KindNumber)
            {
                switch (group)
                {
                    case Person.KindNumberType.自宅:
                        cbFamily.Checked = true;
                        break;
                    case Person.KindNumberType.携帯:
                        cbFriend.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }


        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e)
        {

            int index = dgvPersons.CurrentRow.Index;

            listPerson[index].Name = tbName.Text;
            listPerson[index].MailAddress = tbMailAddress.Text;
            listPerson[index].Address = tbAddress.Text;
            listPerson[index].Company = cbCompany.Text;
            listPerson[index].listGroup = GetCheckBoxGroup();
            listPerson[index].Picture = pbPicture.Image;
            listPerson[index].Registration = dtpResistDate.Value;
            dgvPersons.Refresh();

        }

        //削除ボタンのイベントハンドラ
        private void btremove_Click(object sender, EventArgs e)
        {
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);

            EnableCheck();
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化(保存できるようにしている)
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName,FileMode.Create))
                    {
                        bf.Serialize(fs, listPerson);
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   
                }
            }
        }

        //開くボタンのイベントハンドラ
        private void btOpen_Click_1(object sender, EventArgs e)
        {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    //バイナリ形式でシリアル化(保存できるようにしている)
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName,FileMode.Open,FileAccess.Read))
                    {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;

                    }

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cbCompany.Items.Clear();
                foreach (var item in listPerson.Select(p => p.Company))
                {
                    setCbCompany(item);//存在する会社を登録
                }
                
                EnableCheck();
            }
        }


        //使用メソッド

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

        //更新・削除ボタンのマスク処理行う
        private void EnableCheck()
        {

            btremove.Enabled = btUpdate.Enabled = listPerson.Count() > 0 ? true : false;
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

        //コンボボックスに登録
        private void setCbCompany(string company)
        {
            if (!cbCompany.Items.Contains(company))
            {
                cbCompany.Items.Add(company);
            }
        }

        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear()
        {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.KindNumberType> GetCheckKindNumber()
        {
            var listGroup = new List<Person.KindNumberType>();
            if (rbhome.Checked)
            {
                listGroup.Add(Person.KindNumberType.自宅);
            }
            if (rbmobile.Checked)
            {
                listGroup.Add(Person.KindNumberType.携帯);
            }
            return listGroup;
        }
    }
}