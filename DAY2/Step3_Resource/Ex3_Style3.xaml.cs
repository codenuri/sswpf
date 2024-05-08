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

namespace Step3_Resource
{
    /// <summary>
    /// Ex3_Style3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3_Style3 : Window
    {
        public Ex3_Style3()
        {
            InitializeComponent();
        }

        public void MyMouseEnter(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Enter");
        }
        public void MyMouseLeave(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Leave");
        }
    }
}
