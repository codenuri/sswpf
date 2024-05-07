using System;
using System.Windows;
using System.Windows.Media;

// 핵심 : Window 의 다양한 속성(property) 변경

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        Window win = new Window();

        win.Title = "Hello";
        win.Width = 500;
        win.Height = 500;
        win.Background = new SolidColorBrush(Colors.Yellow);
        win.Topmost = true; 
       

        app.Run(win);
    }
}
