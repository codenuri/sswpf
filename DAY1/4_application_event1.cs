// 4_application_event1.cs


using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// 3_window_event1.cs

// Window : GUI 를 위한 클래스
// Application : GUI 는 아니고, 프로그램의 시작/종료 및 event 루프를 담당

// Application 도 이벤트 처리가 가능합니다.
// 방법 #1. 가상 메소드 override 
// 방법 #2. delegate(event)에 메소드 등록.

class MainWindow : Window
{
}

class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        Console.WriteLine("OnStartup : 프로그램 처음 시작시 호출");
    }
    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
        Console.WriteLine("OnExit : 프로그램 종료시 호출");
    }
}
class Program
{
    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        app.Run(win);
    }
}

