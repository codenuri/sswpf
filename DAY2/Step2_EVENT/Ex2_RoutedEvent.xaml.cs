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

// 1. 자식에서 발생된 이벤트는 부모윈도우에게도 전달됩니다. ( bubbling event)
// 2. 전달되지 않게 하려면 "e.Handled = true" 로 하면 됩니다.

// 3. 배경으로 Null 브러시를 가지면 이벤트를 받을수 없고,
//    "Transparent 브러시"를 가지면 이벤트를 받을수 있습니다.

// 4. PreivewXXX 이벤트 알아두세요( tunelling event, 부모 윈도우가 먼저 처리)

namespace Step2_EVENT
{
    /// <summary>
    /// Ex2_RoutedEvent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2_RoutedEvent : Window
    {
        public Ex2_RoutedEvent()
        {
            InitializeComponent();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Label_MouseLeftButtonDown");

//          e.Handled = true; // 이벤트를 더이상 부모 윈도우에 보내지 말라
                              // "Routing 중지"
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("StackPanel_MouseLeftButtonDown");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Window_MouseLeftButtonDown");
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Label_PreviewMouseLeftButtonDown");
        }

        private void StackPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("StackPanel_PreviewMouseLeftButtonDown");
        }

        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Window_PreviewMouseLeftButtonDown");
        }
    }
}
