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

namespace Step2_EVENT
{
    /// <summary>
    /// Ex3_Keyboard2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3_Keyboard2 : Window
    {
        public Ex3_Keyboard2()
        {
            InitializeComponent();
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            short value;

            // 입력된 문자를 숫자로 변경해 보고. 실패한 경우는 더이상 routing 되지않게
            bool b = Int16.TryParse(e.Text, out value);

            if (b == false)
            {
                e.Handled = true;
            }
        }

        private void StackPanel_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // 핵심
            // sender : stack panel 의 참조
            // e.Source : stack panel 로 전달한 TextBox 의 참조(즉, 이벤트의 원래소스)
            // e.OriginalSource : TextBox 같은 컨트롤이 다시 자식 컨트롤이 있을때
            //                    그 자식 컨트롤의 참조


            if (ReferenceEquals( e.Source, txt2 ) == true)
            //if ( e.Source == txt2)
                return;


            // 문자만 입력되도록
            short value;

            bool b = Int16.TryParse(e.Text, out value);

            if (b == true)
            {
                e.Handled = true;
            }
        }
    }
}
