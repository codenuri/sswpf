// 4_application_event1.cs


using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// 핵심 : Application 의 이벤트 처리 방법 #2.
// => delegate(event) 에 메소드 등록 방식

class MainWindow : Window
{
}

class App : Application
{
}
class Program
{
    [STAThread]
    public static void Main()
    {
        App app = new App();

        // 프로그램 처음시작시 아래 Foo 호출되게 해보세요
        // => app 객체의 이벤트에 메소드 등록하라는 의미.
        app.Startup += Program.Foo;


        MainWindow win = new MainWindow();
        app.Run(win);
    }

    public static void Foo(object sender, StartupEventArgs e) // window event2.cs 참고
    {
        Console.WriteLine("Foo");
    }
}

