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
using System.Windows.Shapes;

namespace Step9_MISC
{
    /// <summary>
    /// Ex3_DataTemplate1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3_DataTemplate1 : Window
    {
        public Ex3_DataTemplate1()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("AAA");
            DragMove();            
        }
    }
}
