//Step1.cs - 어제 소스에서 skeleton 복사해 오세요
// 없으신분은 github.com/codenuri/sswpf 참고

using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;



class MainWindow : Window
{
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

        using (FileStream fs = new FileStream("../../../Step2.xaml", FileMode.Open))
        {
            win = (Window)XamlReader.Load(fs);
        }

        app.Run(win);
    }
}
