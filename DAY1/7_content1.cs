// 7_content1.cs - skeleton.cs 복사
// 5_skeleton.cs
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

// window 속성 변경
// => 


class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;

    public override string ToString()
    {
        return $"{X}, {Y}";
    }
}

class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "BBB"; // this가 있어도 되고 없어도 됩니다.

        // 다양한 윈도우 속성중 제일 중요한 것은 "Content" 입니다.
        //       this.Content = "Hello"; // 윈도우 위에 보여줄 컨텐츠

        Point pt = new Point { X = 10, Y = 20 };

        this.Content = pt; // 1. pt 가 UI 관련 클래스의 객체라면 정해진규칙 대로 화면에 출력
                           // 2. 그렇지 않으면 "ToString()" 메소드를 호출해서 문자열을 얻어서 출력
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
        win.Title = "AAA";
         
        app.Run(win);
    }
}

