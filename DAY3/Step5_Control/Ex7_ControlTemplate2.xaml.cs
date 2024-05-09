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

// 구글에서 git ms wpf sample
// => 모든 예제가 .net 9(베타) 로 되어 있습니다.
// => .net9 를 설치하거나
// => 아니면 프로젝트를 새로 생성후, 예제에 있는 소스만 복사해서 빌드하면됩니다.

namespace Step5_Control
{
    /// <summary>
    /// Ex7_ControlTemplate2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex7_ControlTemplate2 : Window
    {
        public Ex7_ControlTemplate2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VisualTree vt = new VisualTree();

            vt.BuildVisualTree(this);

            vt.ShowDialog();
        }
    }
}
