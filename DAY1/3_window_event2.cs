// 3_window_event1.cs
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// 핵심 : window 에서 발생하는 이벤트를 처리하는 방법

// 방법 #1. 약속된 가상 메소드를 override  
// => Window 파생 클래스를 만들어서 약속된 메소드를 override 

// 방법 #2. event(delegate) 에 메소드 등록

// 방법 #1 : Window에서 발생하는 이벤트는 Window 클래스 안에서만 처리!!
//           => 메소드 인자는 한개 이다.!!

// 방법 #2 : Window 에서 발생하는 이벤트를 Window 또는 다른 클래스에서도 처리가능
//          => 메소드 인자는 2개 이다.
//          => 마우스 버튼의 정보 및 이벤트가 발생한 Window 정보(참조)

// XAML 을 사용해서 자동생성되는 코드는 "방법#2" 사용
// => 하지만 "방법#1" 을 사용하는 오픈소스도 아주 많습니다

class MainWindow : Window
{
    public void Foo(object obj, MouseButtonEventArgs e)
    {
        Console.WriteLine("MainWindow Foo");
    }
}
class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        MainWindow win = new MainWindow();

        win.MouseDown += Program.Foo; // static 메소드는 클래스이름.메소드 이름으로등록
        win.MouseDown += win.Foo;     // instance메소드는 객체이름.메소드이름으로 등록

        app.Run(win);
    }

    public static void Foo(object obj, MouseButtonEventArgs e)
    {
        Console.WriteLine("Program Foo");
    }

}

