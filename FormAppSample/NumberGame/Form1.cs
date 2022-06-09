using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        Random rand = new Random();
        private int num;
        private int maxNum;

        public Form1()
        {
            InitializeComponent();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            getRamdom();

            //Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //num = rand.Next(minValue: 1, maxValue: 50);
            //this.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Number.Value == num)
            {
                toolStripStatusLabel.Text = "正解！";

            } else if (Number.Value > num)
            {
                toolStripStatusLabel.Text = Number.Value + "より小さい";

            } else if (Number.Value < num)
            {
                toolStripStatusLabel.Text = Number.Value + "より大きい";

            } else {
                toolStripStatusLabel.Text = "1～50までの数字を入力してください";
            }
        }

        private void getRamdom() {
            maxNum = (int)maxNudNum.Value;
            num = rand.Next(minValue: 1, maxValue: maxNum);
            this.Text = num.ToString();
        }

    }
}
