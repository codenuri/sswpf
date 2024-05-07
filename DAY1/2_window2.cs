using System;
using System.Windows;

// 핵심 : GUI 를 만든 경우
// => 프로그램을 종료하지 않고, 이벤트를 처리할수 있도록
// => 이벤트 루프를 수행해야 한다.

// => Application 객체를 생성한후, "app.Run(win)" 수행

class Program
{
    [STAThread]
    public static void Main()
    {
        /*
        Window win = new Window();
        win.Show();

        Application app = new Application();
        app.MainWindow = win;

        app.Run();  // 프로그램을 종료하지 않고 윈도우에서 발생하는
                    // 이벤트 처리하는 코드를 실행해 달라는 것
        */
        // 일반적인 코딩 관례는 아래 코드
        Application app = new Application();

        Window win = new Window();

        app.Run(win);  
    }
}
