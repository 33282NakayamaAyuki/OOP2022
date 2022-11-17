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

        List<string> lists = new List<string>();
        string[] values;

        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(@"Place.csv");
            // 末尾まで繰り返す
            while (!sr.EndOfStream)
            {
                // CSVファイルの一行を読み込む
                string line = sr.ReadLine();
                lists.Add(line);
            }
        }

        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listsSelection = lists[cbPlace.SelectedIndex];
            values = listsSelection.Split(',');
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{values[1]}.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            {
                tbWeatherInfo.Text = json.text;
                tbDatetime.Text = json.reportDatetime.ToString();
                tbOffice.Text = json.publishingOffice;
                if (json.text.Contains("晴れ"))
                {
                    tbWeather.Text = "晴れ";
                } else if (json.text.Contains("曇り")) {
                    tbWeather.Text = "曇り";
                }

            }
        }

        private void GetWeatherPicture()
        {
            switch (int.Parse(values[2]))
            {
                case 1:
                    tbWeather.Text = "晴れ";
                    break;
                case 2:
                    tbWeather.Text = "曇り";
                    break;
                case 3:
                    tbWeather.Text = "雨";
                    break;
                case 4:
                    tbWeather.Text = "晴れまたは曇り";
                    break;
                case 5:
                    tbWeather.Text = "晴れまたは雨";
                    break;
                case 6:
                    tbWeather.Text = "曇りまたは雨";
                    break;
            }
        }
    }
}
