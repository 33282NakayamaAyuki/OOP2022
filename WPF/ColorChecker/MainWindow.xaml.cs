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

            public static explicit operator MyColor(ComboBox v)
            {
                throw new NotImplementedException();
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
            var color = mycolor.Color;
            stockList.Items.Add(color);
        }

        private class ColorInfo {
            public SolidColorBrush Brush { get; set; }
            public string Name { get; set; }
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LabelColor.Background = (Brush)stockList.SelectedItem;  
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
