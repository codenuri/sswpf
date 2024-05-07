using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// Window 객체는 여러개 만들기도 합니다.(윈도우 창이 여러개 필요할수도 있으므로)
// => 단, app.MainWindow 에는 한개만 등록!!

// Application 객체는 반드시 한개만 만들어야 합니다.
// => 코드에 어디에서도 "Application.Current"로 참조 얻을수 있습니다.


class MainWindow : Window
{
    public MainWindow() { }

    protected override void OnMouseDown(MouseButtonEventArgs e)
    {
        base.OnMouseDown(e);

        // 프로그램을 종료 하려면
        // Application 클래스의 인스턴스 메소드인 "Shutdown()" 을 호출하면 됩니다.
        // 여기서 프로그램을 종료시켜 보세요
        // "app.Shutdown()" 의미의 코드가 필요 합니다.
        //        Application.Current.Shutdown();

        // #2. App 안에 있는 Foo() 메소드 호출해 보세요

        // Application.Current : main 에서 생성한 객체의 참조를 가지고 있지만
        //                      타입이 "Application" 타입 입니다.

        // 따라서, App 클래스에서 추가한 고유 멤버에 접근하려면 캐스팅이 필요 합니다.
        ((App)Application.Current).Foo();
    }
}
class App : Application
{
    public void Foo() { Console.WriteLine("App Foo"); }


    public App() { }

    [STAThread]
    public static void Main()
    {
        App app = new App();
        MainWindow win = new MainWindow();

        app.Run(win);
    }
}

