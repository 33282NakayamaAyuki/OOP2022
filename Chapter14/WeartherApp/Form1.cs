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

            try
            {
                var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{values[1]}.json");
                var dClass = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/forecast/{values[1]}.json");
                var json = JsonConvert.DeserializeObject<Rootobject>(dString);
                var weather = JsonConvert.DeserializeObject<Class1[]>(dClass);
                registarDate.Text = $"記録日：{json.reportDatetime}";
                office.Text = $"気象局：{json.publishingOffice}";

                lbTodayWeather.Text = weather[0].timeSeries[0].areas[0].weathers[0];
                lbTommorowWeather.Text = weather[0].timeSeries[0].areas[0].weathers[1];
                try
                {
                    lbDayAfterTommorowWeather.Text = weather[0].timeSeries[0].areas[0].weathers[2];
                } catch (Exception)
                {


                }
                weatherInfo.Text = $"概要：{json.text}";

                var todayWeather = weather[0].timeSeries[0].areas[0].weatherCodes[0];
                pbToday.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{todayWeather}.png";
                var tommorrowWeather = weather[0].timeSeries[0].areas[0].weatherCodes[1];
                pbTommorowWeather.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{tommorrowWeather}.png";
                try
                {
                    var dayAfterTommorrowWeather = weather[0].timeSeries[0].areas[0].weatherCodes[2];
                    pbDayAfterTommorowWeather.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{dayAfterTommorrowWeather}.png";
                } catch (Exception)
                {

                }

                var todayMax = weather[1].timeSeries[1].areas[0].tempsMax[0];
                var todayMin = weather[1].timeSeries[1].areas[0].tempsMin[0];

                if (todayMax != "") { lbTodayMax.Text = $"{weather[1].timeSeries[1].areas[0].tempsMax[0]}℃"; }
                if (todayMin != "") { lbTodayMax.Text = $"{weather[1].timeSeries[1].areas[0].tempsMax[0]}℃"; }
                lbTomorrowMax.Text = $"{weather[1].timeSeries[1].areas[0].tempsMax[1]}℃";
                lbTomorrowMin.Text = $"{weather[1].timeSeries[1].areas[0].tempsMin[1]}℃";
                lbDayAfterTomorrowMax.Text = $"{weather[1].timeSeries[1].areas[0].tempsMax[2]}℃";
                lbDayAfterTomorrowMin.Text = $"{weather[1].timeSeries[1].areas[0].tempsMin[2]}℃";

                label101.Text = "今日";
                label102.Text = "明日";
                label103.Text = "明後日";
                label104.Text = "天気";
                label105.Text = "最高気温";
                label106.Text = "最低気温";
            } catch (Exception)
            {
                MessageBox.Show("インターネットに接続してください");
            }
        }
    }
}
