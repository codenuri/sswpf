using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Step5_Control
{
    /// <summary>
    /// Ex6_VisualTree1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex6_VisualTree1 : Window
    {
        public Ex6_VisualTree1()
        {
            InitializeComponent();
        }

        // 복습 하실때 아래 코드를 먼저 이해 하세요
        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int cnt = VisualTreeHelper.GetChildrenCount(this);

            Console.WriteLine($"직계 자식의 갯수 : {cnt}");

            // 모든 직계 자식의 클래스 이름 열거.
            for (int i = 0; i < cnt; i++)
            {
                var child = VisualTreeHelper.GetChild(this, i);

                Console.WriteLine($"{child.GetType().Name}");
            }
        }
        */

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowChild("", this); // this 의 자식 요소(visual) 열거해 달라.
        }

        private void ShowChild(string separator, DependencyObject obj)
        {
            // 자신의 타입이 이름을 먼저 출력
            Console.WriteLine($"{separator}{obj.GetType().Name}");

            int cnt = VisualTreeHelper.GetChildrenCount(obj);

            for (int i = 0; i < cnt; i++)
            {
                var child = VisualTreeHelper.GetChild(obj, i);

                ShowChild(separator + "    ", child);
            }
        }
    }
}
