using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        MyColor mycolor;
        List<MyColor> colorList = new List<MyColor>();

        public MainWindow()
        {
            InitializeComponent();
            LabelColor.Background = new SolidColorBrush(Color.FromRgb((byte)SliderRed.Value, (byte)SliderGreen.Value, (byte)SliderBlue.Value));
            DataContext = GetColorList();
        }

        

        private MyColor[] GetColorList()
        {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"R:{Color.R} G:{Color.G} B:{Color.B}";
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LabelColor.Background = new SolidColorBrush(Color.FromRgb((byte)SliderRed.Value, (byte)SliderGreen.Value, (byte)SliderBlue.Value));
        }


        private void Border_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;

            LabelColor.Background = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
            TextBoxRed.Text = color.R.ToString();
            TextBoxGreen.Text = color.G.ToString();
            TextBoxBlue.Text = color.B.ToString();
        }

        private void ButtonStack_Click(object sender, RoutedEventArgs e)
        {
            MyColor item = new MyColor { Color = Color.FromRgb((byte)SliderRed.Value, (byte)SliderGreen.Value, (byte)SliderBlue.Value) };

            var colorName = ((IEnumerable<MyColor>)DataContext)
                            .Where(c => c.Color.R == item.Color.R &&
                                        c.Color.G == item.Color.G &&
                                        c.Color.B == item.Color.B).FirstOrDefault();

            stockList.Items.Insert(0,colorName?.Name ?? "R:" + TextBoxRed.Text + " G:" + TextBoxGreen.Text + " B:" + TextBoxBlue);

            colorList.Insert(0, item);

        }

        private class ColorInfo {
            public SolidColorBrush Brush { get; set; }
            public string Name { get; set; }
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (stockList.SelectedIndex != -1) {
                SliderRed.Value = colorList[stockList.SelectedIndex].Color.R;
                SliderGreen.Value = colorList[stockList.SelectedIndex].Color.G;
                SliderBlue.Value = colorList[stockList.SelectedIndex].Color.B;
            }
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (stockList.SelectedItem != null)
            {
                int sel = stockList.SelectedIndex;
                stockList.Items.RemoveAt(sel);
            }
        }
    }
}
