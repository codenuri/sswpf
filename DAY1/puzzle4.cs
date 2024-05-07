using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// step4. 게임판의 상태를 나타내는 2차원 배열 도입

class MainWindow : Window
{
    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;
    private BitmapImage bitmap = new BitmapImage(new Uri("C:\\WPF_수업\\totoro.jpg"));

    private Grid grid = new Grid();

    int[,] board = new int[COUNT, COUNT];

    private void InitBoard()
    {
        // 0 ~ 24로 채우기
        for ( int y = 0; y < COUNT; ++y )
        {
            for (int x = 0; x < COUNT; ++x)
            {
                board[y, x] = y * COUNT + x;
            }
        }
        board[0, 0] = 10; // test 용
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

                // 11번 블럭은 x=1, y=2 에 위치한 블럭이다.
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

        InitBoard(); // 배열 초기화
        InitGame();  // Grid 초기화 
        DrawGameImage(); // 그림을 Grid 에 붙이기. 
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

