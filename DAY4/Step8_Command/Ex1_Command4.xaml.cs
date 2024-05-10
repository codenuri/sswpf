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

namespace Step8_Command
{
    class LogInCommand3 : ICommand
    {
        // LogIn 버튼이 아래 델리게이트에 함수를 등록하게 됩니다.

        public event EventHandler? CanExecuteChanged;

        // 아래 함수는 아무 이름이나 사용해도 됩니다.
        public void FireCanExecute()
        {
            // CanExecute 를 다시 호출해 달라고 요청합니다.
            CanExecuteChanged(this, EventArgs.Empty);
        }

        public bool CanExecute(object? parameter)
        {
            Console.WriteLine("Called CanExecute");

            Ex1_Command4 win = (Ex1_Command4)(Application.Current.MainWindow);

            bool b = false;

            if (win != null)
            {
                b = (!string.IsNullOrEmpty(win.id_txtbox.Text)) && win.check.IsChecked.Value;
            }
            return b;
        }

        public void Execute(object? parameter)
        {
            Console.WriteLine("LogIn Click");
        }
    }


    static class MyCommand3
    {
        // 모든 명령 객체를 이 static class 안에서 객체 생성해 놓습니다.
        public static LogInCommand3 cmdLogin = new LogInCommand3();
    }

    public partial class Ex1_Command4 : Window
    {
        public Ex1_Command4()
        {
            InitializeComponent();
        }
        private void id_txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyCommand3.cmdLogin.FireCanExecute();
        }
        private void check_Checked(object sender, RoutedEventArgs e)
        {
            MyCommand3.cmdLogin.FireCanExecute();
        }
        private void check_Unchecked(object sender, RoutedEventArgs e)
        {
            MyCommand3.cmdLogin.FireCanExecute();
        }
    }
}
