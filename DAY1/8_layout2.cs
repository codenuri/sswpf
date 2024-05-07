using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

class MainWindow : Window
{
    public MainWindow() 
    {
        // Grid Layout : 엑셀 같은 격자 모양으로 자식 윈도우를 배치하는 
        //               layout

        // #1. Grid 생성
        Grid grid = new Grid();

        this.Content = grid;

        // #2. Row, Collumn 갯수 지정 - 객체를 생성해서 전달

        //      grid.SetRows(3); // 이렇게 하지 않습니다.

        // => ROW 도 높이, 색상등의 다양한 속성이 있을수 있습니다.
        // => 따라서, 아래 처럼 객체 지향으로 설계되어 있습니다.

        grid.RowDefinitions.Add(new RowDefinition());
        grid.RowDefinitions.Add(new RowDefinition {  });
        grid.RowDefinitions.Add(new RowDefinition());

        grid.ColumnDefinitions.Add(new ColumnDefinition());
        grid.ColumnDefinitions.Add(new ColumnDefinition());
        grid.ColumnDefinitions.Add(new ColumnDefinition());

        grid.ShowGridLines = true;

        // #3. Grid 위에 컨트롤 배치 
        Button btn1 = new Button { Content = "확인1" };
        Button btn2 = new Button { Content = "확인2" };

        //      grid.SetRowCol(0, 0, btn1); // 이런 방식이 아닙니다.!!

        Grid.SetRow(btn1, 0);
        Grid.SetColumn(btn1, 0); // 이러게 하면 결국 grid의 어느위치에 놓일지를
                                 // btn1 자신이 알고 있게 됩니다.
        grid.Children.Add(btn1);

        // 실행해서 위코드의 결과를 확인하고
        // 2, 1 의 위치에 btn2 배치해 보세요
        Grid.SetRow(btn2, 2);
        Grid.SetColumn(btn2, 1);
        grid.Children.Add(btn2);

        // 아래 코드를 생각해 보세요
        // grid.Children.Add("aa");  // error

        // Content : object 타입이므로 대부분의 객체를 연결 가능
        // grid.Children.Add(child) : child 는 반드시 UIElement로 부터
        //                              파생된 타입이어야 한다.


        // 다양한 Layout 의 클래스 계층도 확인해 두세요.
        Util.ShowHierachy(grid);
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

