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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Step8_Command
{
    // 메뉴, 버튼 등을 누를때 해야할 일을 
    // 함수가 아닌 클래스로 설계 합니다.
    // => "Command" 디자인 패턴을 WPF 에서 도입한것!!!
    class LogInCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            //return false;
            return true;
        }

        public void Execute(object? parameter)
        {
            Console.WriteLine("LogIn Click");
        }
    }

    // 메뉴가 10개 라면 각각 선택시 해야할일을 정의하는 위와 같은 클래스를
    // 10개 만들게 됩니다.
    // 위 와 같은 명령 객체는 한개만 있으면 됩니다.
    static class MyCommand
    {
        // 모든 명령 객체를 이 static class 안에서 객체 생성해 놓습니다.
        public static LogInCommand cmdLogin = new LogInCommand();
    }



    public partial class Ex1_Command2 : Window
    {
        public Ex1_Command2()
        {
            InitializeComponent();
        }

        private void CheckButtonEnable()
        {
            loginbutton.IsEnabled =
                (!string.IsNullOrEmpty(id_txtbox.Text)) && check.IsChecked.Value;
        }

        private void id_txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {            
        }
        private void check_Checked(object sender, RoutedEventArgs e)
        {            
        }
        private void check_Unchecked(object sender, RoutedEventArgs e)
        {
         
        }
    }


}
