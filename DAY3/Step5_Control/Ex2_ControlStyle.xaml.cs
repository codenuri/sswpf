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
    /// Ex2_ControlStyle.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2_ControlStyle : Window
    {
        public Ex2_ControlStyle()
        {
            InitializeComponent();
        }

        private void Color_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            Brush brush = (Brush)rb.Tag;

            label.Background = brush;
        }
        private void Size_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;


            int size;
            bool b = int.TryParse(rb.Tag.ToString(), out size);

            label.FontSize = size;
        }

    }
}


