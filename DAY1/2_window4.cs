using System;
using System.Windows;
using System.Windows.Media;

// 핵심 : class hierachy 조사

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        Window win = new Window();

        Util.ShowHierachy(app);
        Util.ShowHierachy(win);
        

        app.Run(win);
    }

}
