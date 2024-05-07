// 7_content1.cs - skeleton.cs 복사
// 5_skeleton.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
class MainWindow : Window
{
    public MainWindow()
    {
        // #1. 문자열을 Content 속성에 연결
        //       this.Content = "Hello"; 


        // #2. Control 을 연결
        //        Button btn = new Button();
        //        btn.Content = "확인";
        //        this.Content = btn;

        // 위 3줄은 아래 처럼 한줄로 할수 있습니다.
        //        this.Content = new Button { Content = "확인" };

        // #3. image 연결
        BitmapImage bitmap = new BitmapImage(new Uri("C:\\WPF_수업\\totoro.jpg"));

        Image img = new Image { Source = bitmap };
                    // Image img = new Image();
                    // img.Source = bitmap;

        this.Content = img;
    }
}

// 인터넷에서 그림 하나만 구해 두세요. 600~800 * 800 정도 크기
// 다음 시간 예제 만들때 계속 사용




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

