using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        //ボタンクリックイベントハンドラ
        private void btRandom_Click(object sender, EventArgs e)
        {
            //Number01.Value = rand.Next(minValue: 1, maxValue: 6);
            textBox.Text = rand.Next(minValue: (int)Number01.Value, maxValue: (int)Number02.Value+1).ToString();    
        }
        //イベントハンドラ（起動時に１度だけ実行）
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Text = rand.Next(minValue: 1, maxValue: 6).ToString();
        }
    }
}
