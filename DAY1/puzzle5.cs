using System;
using System.Media;
using System.Security.Cryptography.Xml;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// step5. 마우스 클릭시 블럭 이동

class MainWindow : Window
{
    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;
    private BitmapImage bitmap = new BitmapImage(new Uri("C:\\WPF_수업\\totoro.jpg"));
    private Grid grid = new Grid();
    int[,] board = new int[COUNT, COUNT];

    private void InitBoard()
    {
        for (int y = 0; y < COUNT; ++y)
        {
            for (int x = 0; x < COUNT; ++x)
            {
                board[y, x] = y * COUNT + x;
            }
        }
    }



    private void InitGame()
    {
        for (int i = 0; i < COUNT; ++i)
        {
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
        }

        this.Content = grid;
    }


    private void DrawGameImage()
    {
        int w = (int)(bitmap.Width / COUNT);
        int h = (int)(bitmap.Height / COUNT);

        Console.WriteLine($"{w}, {h}");

        for (int y = 0; y < COUNT; ++y)
        {
            for (int x = 0; x < COUNT; ++x)
            {
                if (board[y, x] == EMPTY)
                    continue;

                int bx = board[y, x] % COUNT;
                int by = board[y, x] / COUNT;

                CroppedBitmap block_bitmap = new CroppedBitmap(bitmap,
                                        new Int32Rect(bx * w, by * h, w, h));

                Image img = new Image { Source = block_bitmap };

                img.Stretch = Stretch.Fill;
                img.Margin = new Thickness(0.5);

                Grid.SetRow(img, y);
                Grid.SetColumn(img, x);

                grid.Children.Add(img);
            }
        }
    }

    public MainWindow()
    {
        Width = 800;
        Height = 600;

        InitBoard(); 
        InitGame();  
        DrawGameImage();
    }

    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        base.OnMouseLeftButtonDown(e);

//      Point pt = e.GetPosition(this); // MainWindow 기준 좌표
        Point pt = e.GetPosition(grid); // grid 기준 좌표

        // 클릭된 좌표가 grid 의 몇번째 칸인가 ?
        int bx = (int)(pt.X / (grid.ActualWidth / COUNT));
        int by = (int)(pt.Y / (grid.ActualHeight / COUNT));

        if (bx < 0 || by < 0 || bx >= COUNT || by >= COUNT) return;

        // 상하좌우에 빈곳(EMPTY)가 있는지 조사

        if ( bx < COUNT-1 && board[by, bx + 1] == EMPTY) // right is empty
        {
            SwapBlock(bx, by, bx + 1, by);
        }
        else if (bx > 0 && board[by, bx -1 ] == EMPTY) // left is empty
        {
            SwapBlock(bx, by, bx - 1, by);
        }
        else if(by < COUNT - 1 && board[by + 1, bx] == EMPTY) // down is empty
        {
            SwapBlock(bx, by, bx, by + 1);
        }
        else if(by > 0 && board[by-1, bx] == EMPTY) // top is empty
        {
            SwapBlock(bx, by, bx, by-1);
        }
        else
        {
            SystemSounds.Beep.Play();
            return;
        }
        // 한번이라도 이동한 경우, 다 맞추었는지 확인!!
    }

    private void SwapBlock(int x1, int y1, int x2, int y2) 
    {
        // #1. board 배열의 값 교환
        int temp = board[y1, x1];
        board[y1, x1] = board[y2, x2];
        board[y2, x2] = temp;

        // #2. grid 의 x1, y1 위치에 있는 Image 참조를 얻어서
        //     x2, y2 위치로 이동

        //        Image img = grid.Children.FirstOfDefault(함수);
        // => grid의 모든 자식을 함수에 보내서 참을 반환하는 
        //    첫번째 요소 찾기. 조건을 만족하는 요소가 없으면 
        //    디폴트 값(null) 반환.

        // 아래 람다표현식의 의미는 "아래 부분의 Foo" 참고 하세요
        Image img = grid.Children.Cast<Image>().FirstOrDefault(
                img => Grid.GetRow(img) == y1 && Grid.GetColumn(img) == x1 );  

        if ( img != null)
        {
            Grid.SetRow(img, y2);
            Grid.SetColumn(img, x2);
        }

    }

    // 위 람다 표현식의 의미는 아래 함수 입니다.
    /*
    public bool Foo( Image img )
    {
        if (Grid.GetRow(img) == y1 && Grid.GetColumn(img) == x1)
            return true;
        return false;
    }
    */
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

