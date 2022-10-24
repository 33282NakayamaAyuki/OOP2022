﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
        }


        private void LabelColor_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LabelColor.Background = new SolidColorBrush(Color.FromRgb((byte)SliderRed.Value,(byte)SliderGreen.Value,(byte)SliderBlue.Value));
        }
    }
}
