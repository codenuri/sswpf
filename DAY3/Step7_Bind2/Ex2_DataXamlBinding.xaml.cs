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

namespace Step7_Bind2
{
    public partial class Ex2_DataXamlBinding : Window
    {
        // 아래 객체를 XAML 의 Resource 로 만들어도 됩니다.
        private People p = new People { Name = "unknown", Address = "unknown" };

        public Ex2_DataXamlBinding()
        {
            InitializeComponent();

            // #1. 객체를 Window 또는 Panel 에 DataContext로 등록하면
            // panel 안의 모든 컨트롤 에서 Binding 해서 사용가능 합니다.
            canvas.DataContext = p;


        }
    }
}
