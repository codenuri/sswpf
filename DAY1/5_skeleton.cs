// 5_skeleton.cs
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// WPF 프로그램의 기본 구조
// => "Window" 에서 파생된 클래스를 만들고("MainWindow")
// => "Application" 에서 파생된 클래스를 만들어서("App")
// => 프로그램을 작성
// => Main 메소드도 App 에 포함

// 아래 코드가 WPF 프로그램의 기본 구조 입니다.
class MainWindow : Window
{
    public MainWindow() { }
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

