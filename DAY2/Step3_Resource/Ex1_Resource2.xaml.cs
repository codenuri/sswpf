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
    /// Ex1_Resource2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1_Resource2 : Window
    {
        public Ex1_Resource2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["message"] = "ABCD";
        }
    }
}
