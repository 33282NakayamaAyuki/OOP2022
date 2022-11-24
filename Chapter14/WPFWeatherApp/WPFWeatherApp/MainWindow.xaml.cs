using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFWeatherApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<string> lists = new List<string>();
        string[] values;

        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(@"Place.csv");
            while (!sr.EndOfStream)
            {
                // CSVファイルの一行を読み込む
                string line = sr.ReadLine();
                lists.Add(line);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

                var todayMax = weather[1].timeSeries[1].areas[0].tempsMax[0];
                var todayMin = weather[1].timeSeries[1].areas[0].tempsMin[0];

                if (todayMax != "") { tbTodayMax.Text = $"{weather[1].timeSeries[1].areas[0].tempsMax[0]}℃"; }
                if (todayMin != "") { tbTodayMax.Text = $"{weather[1].timeSeries[1].areas[0].tempsMax[0]}℃"; }

                tbTodayMin.Text = $"{weather[1].timeSeries[1].areas[0].tempsMin[0]}℃";
                tbTomorrowMax.Text = $"{weather[1].timeSeries[1].areas[0].tempsMax[1]}℃";
                tbTomorrowMin.Text = $"{weather[1].timeSeries[1].areas[0].tempsMin[1]}℃";
                tbDayAfterTomorrowMax.Text = $"{weather[1].timeSeries[1].areas[0].tempsMax[2]}℃";
                tbDayAfterTomorrowMin.Text = $"{weather[1].timeSeries[1].areas[0].tempsMin[2]}℃";
            }
        }
    }
}
