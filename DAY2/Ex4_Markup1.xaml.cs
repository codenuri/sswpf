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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// 핵심 : 사용자 정의 MARKUP Exntension 을 만드는 방법
// => 클래스 이름에 "Extension" 가 있어도 되고 없어도 됩니다.


namespace Step1_XAML
{
    // MarkupExtension 에서 파생된 타입은 반드시
    // ProvideValue 를 만들어야 합니다.
    //    public class Null : MarkupExtension
    public class NullExtension : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return null;
        }
    }

    public class Yellow : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new SolidColorBrush(Colors.Yellow);
        }
    }

    public partial class Ex4_Markup1 : Window
    {
        public Ex4_Markup1()
        {
            InitializeComponent();
        }
    }
}
