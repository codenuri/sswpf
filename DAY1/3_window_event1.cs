// 3_window_event1.cs
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// 핵심 : window 에서 발생하는 이벤트를 처리하는 방법

// 방법 #1. 약속된 가상 메소드를 override  
// => Window 파생 클래스를 만들어서 약속된 메소드를 override 

// WPF 에서 가상 메소드 재정의시 코딩 관례
// => 기본 클래스의 가상 메소드를 먼저 호출하는 것이 관례..
// => 필요 없는 경우도 있지만 정확히 알지 못할때는 대부분 자동 생성되는 코드 사용

class MainWindow : Window
{
    protected override void OnMouseDown(MouseButtonEventArgs e)
    {
        base.OnMouseDown(e);

        Point pt = e.GetPosition(this);

        Console.WriteLine($"{pt.X}, {pt.Y}");
    }
} 
class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();
//      Window win = new Window();
        MainWindow win = new MainWindow();

        app.Run(win);
    }

}

