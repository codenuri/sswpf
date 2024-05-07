using System;
using System.Media;
using System.Security.Cryptography.Xml;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

// step 7. 소요 시간 출력

class MainWindow : Window
{
    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;
    private BitmapImage bitmap = new BitmapImage(new Uri("C:\\WPF_수업\\totoro.jpg"));
    private Grid grid = new Grid();
    int[,] board = new int[COUNT, COUNT];

    DockPanel panel = new DockPanel();

    private bool   isrun = false;
    private double cnt = 0.0;

    private DispatcherTimer timer = new DispatcherTimer();

    private Label label = null;


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

        this.Content = panel;

        label = new Label { Content = "0.0" };
        label.FontSize = 30;
        label.HorizontalAlignment = HorizontalAlignment.Center;

        Button btn = new Button { Content = "Hint" };

        DockPanel.SetDock(label, Dock.Top);
        DockPanel.SetDock(btn, Dock.Top);
        DockPanel.SetDock(grid, Dock.Bottom);

        panel.Children.Add(label);
        panel.Children.Add(btn);
        panel.Children.Add(grid);
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

        if (isrun == false)
        {
            isrun = true;
            timer.Interval = TimeSpan.FromSeconds(0.1); // 간격
            timer.Tick += new EventHandler(ChangeCnt);  // 호출될 메소드
                                        // 메소드 모양은 약속되어 있습니다.
            cnt = 0.0;
            timer.Start();
        }


        Point pt = e.GetPosition(grid);

        int bx = (int)(pt.X / (grid.ActualWidth / COUNT));
        int by = (int)(pt.Y / (grid.ActualHeight / COUNT));

        if (bx < 0 || by < 0 || bx >= COUNT || by >= COUNT) return;


        if (bx < COUNT - 1 && board[by, bx + 1] == EMPTY)
        {
            SwapBlock(bx, by, bx + 1, by);
        }
        else if (bx > 0 && board[by, bx - 1] == EMPTY)
        {
            SwapBlock(bx, by, bx - 1, by);
        }
        else if (by < COUNT - 1 && board[by + 1, bx] == EMPTY)
        {
            SwapBlock(bx, by, bx, by + 1);
        }
        else if (by > 0 && board[by - 1, bx] == EMPTY)
        {
            SwapBlock(bx, by, bx, by - 1);
        }
        else
        {
            SystemSounds.Beep.Play();
            return;
        }
    }

    private void ChangeCnt( object sender, EventArgs e ) 
    {
        cnt += 0.1;

        label.Content = String.Format("{0:0.0}", cnt);
    }

    private void SwapBlock(int x1, int y1, int x2, int y2)
    {
        int temp = board[y1, x1];
        board[y1, x1] = board[y2, x2];
        board[y2, x2] = temp;


        Image img = grid.Children.Cast<Image>().FirstOrDefault(
                img => Grid.GetRow(img) == y1 && Grid.GetColumn(img) == x1);

        if (img != null)
        {
            Grid.SetRow(img, y2);
            Grid.SetColumn(img, x2);
        }

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

