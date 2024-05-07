using System;
using System.Windows;

// 2_window1.cs
// 핵심 1. 모든 WPF 프로그램의 Main 함수는 [STAThread] 방식이어야 합니다
// => 자세한 이야기는 마지막날.. (멀티스레드 관련 이야기)
// 핵심 2. Window 생성하는 방법

class Program
{
    [STAThread]
    public static void Main()
    {
        Window win = new Window();
        win.Show();
        MessageBox.Show("Hello, WPF");
    }
}
