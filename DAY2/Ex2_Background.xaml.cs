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

namespace Step1_XAML
{
    /// <summary>
    /// Ex2_Background.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2_Background : Window
    { 
        public Ex2_Background()
        {
            // 핵심 : InitializeComponent() 안에서 XAML 이 load 되고 초기화 됩니다.
            // => 아래 처럼 InitializeComponent 위에서 button2 를 사용하면 안됩니다.
//            button2.Background = new SolidColorBrush(Colors.Yellow);

            InitializeComponent();

            button2.Background = new SolidColorBrush(Colors.Yellow);
        }
    }
}
