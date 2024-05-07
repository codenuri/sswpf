using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// step3. 모든 블럭 출력하기
// => 5 * 5 의 grid layout 사용
// => layout 에 24개의 image block 연결. 

class MainWindow : Window
{
    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1; 
    private BitmapImage bitmap = new BitmapImage(new Uri("C:\\WPF_수업\\totoro.jpg"));

    private Grid grid = new Grid();

    private void InitGame()
    {
        // 5 * 5 로 배치
        for(int i = 0; i < COUNT;++i)
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

        for ( int y = 0; y < COUNT; ++y)
        {
            for (int x = 0; x < COUNT; ++x)
            {
                CroppedBitmap block_bitmap = new CroppedBitmap(bitmap,
                                        new Int32Rect(x * w, y * h, w, h));

                Image img = new Image { Source = block_bitmap };

                img.Stretch = Stretch.Fill;
                img.Margin = new Thickness(0.5);
                           // new Thickness(3, 5, 2, 7) 처럼 사용도 가능
                           //           left, top, right, bottom

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

        InitGame();
        DrawGameImage();
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

