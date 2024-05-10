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

namespace Step8_Command
{
    /// <summary>
    /// Ex4_Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex4_Menu : Window
    {
        public Ex4_Menu()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("One 메뉴 선택");
        }
    }
}
