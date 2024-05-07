// 8_layout1.cs - skeleton.cs 복사

// 5_skeleton.cs
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


class MainWindow : Window
{
    public MainWindow() 
    {
        // 1. 윈도우에 보여주고 싶은 것은 "Content" 속성에 연결하면 됩니다.
        // 2. 그런데, Content 에는 "한개" 만 연결가능합니다.

        // 3. 여러개의 요소를 보여 주고 싶다면!!!
        // => 다양한 Layout 사용하면 됩니다.

        // #1. Layout(Panel) 의 객체를 만들어서 window 의 Content 에 연결
        StackPanel sp = new StackPanel();

        this.Content = sp;

        // #2. 이제 다양한 자식 컨트롤은 Layout(panel)에 부착
        sp.Children.Add(new Button { Content = "확인1" });
        sp.Children.Add(new Button { Content = "확인2" , 
                                     Margin = new Thickness(3)});

        sp.Children.Add(new Button { Content = "확인3" });

        // #3. Layout(panel) 도 다양한 속성을 변경할수 있습니다.
        sp.Orientation = Orientation.Horizontal;


        // #4. Layout 의 종류는 7개 정도 됩니다.
        // => 모두 사용법이 쉽고 단순한데, 
        // => 핵심은 중첩이 됩니다.
        StackPanel sp2 = new StackPanel();

        sp2.Orientation = Orientation.Vertical;

        sp.Children.Add(sp2); 

        sp2.Children.Add(new Button { Content = "확인4"});
        sp2.Children.Add(new Button { Content = "확인5" });
        sp2.Children.Add(new Button { Content = "확인6" });

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
        app.Run(win);
    }
}

