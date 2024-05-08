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

namespace Step2_EVENT
{
    /// <summary>
    /// Ex1_EventBasic.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1_EventBasic : Window
    {
        public Ex1_EventBasic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("button1_Click");
        }
        private void Foo(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Foo");
        }

        private void button_handler(object sender, RoutedEventArgs e)
        {
            // sender 가 클릭된 버튼 객체 입니다.
            // Button 타입으로 캐스팅해서 사용하면 됩니다.
            Button btn = (Button)sender;

            Console.WriteLine($"{btn.Name}, {btn.Content}, {btn.Tag}");
        }
    }
}
