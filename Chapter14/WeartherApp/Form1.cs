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
            var dClass = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/forecast/{values[1]}.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            var weather = JsonConvert.DeserializeObject<Class1[]>(dClass);
            {
                registarDate.Text = json.reportDatetime.ToString();
                Office.Text = json.publishingOffice;
                tbTodayWeather.Text = weather[0].timeSeries[0].areas[0].weathers[0];
                tbTommorowWeather.Text = weather[0].timeSeries[0].areas[0].weathers[1];
                tbDayAfterTommorowWeather.Text = weather[0].timeSeries[0].areas[0].weathers[2];
                tbWeatherInfo.Text = json.text;
                var todayWeather = weather[0].timeSeries[0].areas[0].weatherCodes[0];
                var tommorrowWeather = weather[0].timeSeries[0].areas[0].weatherCodes[1];
                var dayAfterTommorrowWeather = weather[0].timeSeries[0].areas[0].weatherCodes[2];
                pbToday.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{todayWeather}.png";
                pbTommorowWeather.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{tommorrowWeather}.png";
                pbDayAfterTommorowWeather.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{dayAfterTommorrowWeather}.png";
            }
        }

    }
}
