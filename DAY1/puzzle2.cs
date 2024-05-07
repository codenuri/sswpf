using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// step2. 한개 블럭만 출력하기
// => CroppedBitmap 알아두세요
// => 한개의 그림에서 일부분만 잘라서 사용하는 기법 알아 두세요
class MainWindow : Window
{
    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;

    private BitmapImage bitmap = new BitmapImage(new Uri("C:\\WPF_수업\\totoro.jpg"));

    private void DrawGameImage()
    {
        int w = (int)(bitmap.Width / COUNT);
        int h = (int)(bitmap.Height / COUNT);

        CroppedBitmap block_bitmap = new CroppedBitmap(bitmap,
                                new Int32Rect(0, 0, w, h));


        Image img = new Image { Source = block_bitmap };

        Content = img;
    }


    public MainWindow()
    {
        Width = 800;
        Height = 600;
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

