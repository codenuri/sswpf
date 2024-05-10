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

// 핵심 
// 로그인 버튼은
// => "눌렀을때 해야 할일" 과 "버튼의 Enable 조건을 판단" 하는 함수로 구성되어있습니다.
// => 그런데, 2개의 함수가 각각 따로 작성됩니다.
// => 하나의 클래스로 합칠수 없을까요 ??


namespace Step8_Command
{
    
    public partial class Ex1_Command1 : Window
    {
        public Ex1_Command1()
        {
            InitializeComponent();
        }

        public void login_click(object sender, RoutedEventArgs e)
        {

        }

        // 아래 코드가 중재자 패턴 입니다.
        // 객체들의 상호 관계가 복잡할때는 객체가 서로를 조사(관찰)하지 말고
        // => 중재자(Mediator)를 도입해서
        // => N:M 의 관계를 객체와 중재자 사이의 1:N 의 관례로 만드는 패턴
        private void CheckButtonEnable()
        {
            loginbutton.IsEnabled =
                (!string.IsNullOrEmpty(id_txtbox.Text)) && check.IsChecked.Value;
        }

        private void id_txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckButtonEnable();
        }
        private void check_Checked(object sender, RoutedEventArgs e)
        {
            CheckButtonEnable();
        }
        private void check_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckButtonEnable();
        }
    }
}
