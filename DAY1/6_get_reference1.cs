// 6_get_reference1.cs
using System;
using System.Security.RightsManagement;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

class MainWindow : Window
{
    public MainWindow() { }
    public void Foo() { Console.WriteLine("MainWindow Foo"); }
}

class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        // #1. 여기서 MainWindow 의 타이틀을 "Start"로 변경해 보세요
        //      Title = "Start"; // error. 현재 클래스는 MainWindow가 아닌 App 이므로
        // Title 속성은 없습니다.

        this.MainWindow.Title = "Start";  // this 없어도 됩니다.
                                          // 2_window2.cs 주석 부분 코드 참고해 보세요

        // #2. MainWindow 에 있는 "Foo" 메소드 호출해 보세요
        // this.MainWindow : Window 타입입니다.
        // 따라서, MainWindow 에서 추가한 멤버에 접근하려면 캐스팅 해야 합니다.
//        this.MainWindow.Foo(); // error
        ((MainWindow)this.MainWindow).Foo();
    }


    public App() { }


    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        app.Run(win);
    }
}

