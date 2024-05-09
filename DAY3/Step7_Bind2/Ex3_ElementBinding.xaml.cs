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

// Binding 을 사용하는 3가지 방식
// 1. 2개의 객체사이에 속성을 직접 연결 ( p.Name <-> textBox.Text )

// 2. Panel 에 DataContext 로 등록후 Panel 안의 모든 컨트롤이 객체 공유

// 3. Collection 과 Items Control 연결


// 1번 연결도 다시 아래의 2개
// 1) Data객체와 UI 객체 연결
// 2) UI 객체 끼리 연결

namespace Step7_Bind2
{

    public partial class Ex3_ElementBinding : Window
    {
        public Ex3_ElementBinding()
        {
            InitializeComponent();

            // 아래 코드는 "Data객체 <-> UI 객체" 의 연결이 아닌
            // "UI객체 <-> UI 객체" 사이의 연결입니다.
            // 흔히 "element binding" 이라고 부르기도 합니다.
            Binding b = new Binding();

            b.Source = slider1;
            b.Path = new PropertyPath("Value");
            b.Mode = BindingMode.OneWay;

            label1.SetBinding(Label.FontSizeProperty, b);
        }
    }
}
