﻿//Step1.cs - 어제 소스에서 skeleton 복사해 오세요
// 없으신분은 github.com/codenuri/sswpf 참고

using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;


namespace Step3
{
    class MainWindow : Window
    {
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            Console.WriteLine("MouseDown");
        }

        public MainWindow()
        {
        }
    }

    class App : Application
    {
        public App() { }

        [STAThread]
        public static void Main()
        {
            App app = new App();

            Window win = null;

            using (FileStream fs = new FileStream("../../../Step3.xaml", FileMode.Open))
            {
                win = (Window)XamlReader.Load(fs);
            }

            app.Run(win);
        }
    }

}

