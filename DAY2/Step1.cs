//Step1.cs - 어제 소스에서 skeleton 복사해 오세요
// 없으신분은 github.com/codenuri/sswpf 참고

using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

// XAML 파일을 직접 추가한 경우 주의 사항
// 1. 빌드 설정은 - 없음
// 2. 파일 형식은 "UTF-8" 로 저장해야 합니다
// => 다른이름으로 저장해서 "encoding" 변경하면 됩니다.

class MainWindow : Window
{
    public MainWindow()
    {
        StackPanel panel = null;

        using (FileStream fs = new FileStream("../../../Step1.xaml", FileMode.Open))
        {
            panel = (StackPanel)XamlReader.Load(fs);
        }
        this.Content = panel;

        Button button1 = (Button)panel.FindName("button1");

        button1.Click += Button1_Click;
    }

    private void Button1_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("button click");
    }
}

class App : Application
{
    public App() { }

    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        app.Run(win);
    }
}
