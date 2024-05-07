using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// step1. game image 출력하기

class MainWindow : Window
{
    // 게임판의 그림은 "프로그램에서 항상 사용" 됩니다. 멤버 데이타에 보관
    private BitmapImage bitmap = new BitmapImage(new Uri("C:\\WPF_수업\\totoro.jpg"));

    private void DrawGameImage()
    {
        Image img = new Image { Source = bitmap };

        Content = img;
    }
    public MainWindow() 
    {
        Width = 800;
        Height = 600;
        DrawGameImage();
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

