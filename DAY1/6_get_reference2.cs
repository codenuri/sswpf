// 6_get_reference2.cs
using System;
using System.Security.RightsManagement;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

class MainWindow : Window
{
    public MainWindow() { }
}

// 클래스에서 다른 객체의 참조를 얻을때는 객체 가 파괴 되었는지를 꼭 생각하고
// 사용해야 합니다
class App : Application
{
    // 아래 메소드는 app.Run() 에서 호출됩니다.
    // 즉, 아래 메소드에서는 "this.MainWindow" 사용가능.
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        this.MainWindow.Title = "Start";  
    }

    // 아래 메소드는 윈도우 파괴 된후 호출됩니다.
    // 즉, 아래 메소드에서는 "this.MainWindow" 사용안됩니다. null!
    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);

        // 아래 코드는 왜?? 런타임 에러일까요 ?
        // 이유를 생각해 보세요
        //        this.MainWindow.Title = "Exit";

        Console.WriteLine($"{this.MainWindow == null}"); // true
    }

    public App() 
    {
//      this.MainWindow.Title = "Start"; // 안됩니다. App 생성자 호출시점에
                                         // 윈도우는 아직 생성 안되어 있습니다.
    }


    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow win = new MainWindow();
        app.Run(win);
    }
}

