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

// WPF 가 제공하는 Layout 종류
// 1. Canvas
// 2. StackPanel
// 3. DockPanel
// 4. WrapPanel
// 5. Grid
// 6. UniformGrid
// => 이 외에 사용자가 Custom 으로 만드는 것도 가능합니다.
// => 또는 다른 회사에서 만들어서 판매하기도 합니다.


namespace Step4_Layout추가
{
    /// <summary>
    /// Ex2_WrapPanel.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2_WrapPanel : Window
    {
        public Ex2_WrapPanel()
        {
            InitializeComponent();
        }
    }
}
