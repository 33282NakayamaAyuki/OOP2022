using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeartherApp {
    public partial class Form1 : Form {

        public Form1()
        {
            InitializeComponent();

        }


        private void btWeatherGet_Click(object sender, EventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            ReadPlace();

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            {
                tbWeatherInfo.Text = json.text;
            }
        }
        


        public static void ReadPlace()
        {
            StreamReader sr = new StreamReader(@"Place.csv");
                // 末尾まで繰り返す
                 while (!sr.EndOfStream)
                   {
                    // CSVファイルの一行を読み込む
                    string line = sr.ReadLine();
                    // 読み込んだ一行をカンマ毎に分けて配列に格納する
                    string[] values = line.Split(',');

                    // 配列からリストに格納する
                    List<string> lists = new List<string>();
                    lists.AddRange(values);
            }
        }
    }
}
