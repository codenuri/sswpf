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
    /// Ex7_ControlTemplate1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex7_ControlTemplate1 : Window
    {
        public Ex7_ControlTemplate1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //          VisualTree vt = new VisualTree();
            Step5_Control.VisualTree vt = new Step5_Control.VisualTree();

            vt.BuildVisualTree(this);

            vt.ShowDialog();
        }
    }


}
