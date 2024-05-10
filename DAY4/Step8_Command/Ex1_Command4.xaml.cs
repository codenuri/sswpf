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
        //        public event EventHandler? CanExecuteChanged;


        // 버튼에 "이 클래스 객체" 를 연결할때
        // 버튼은 자신의 함수를 CanExecuteChanged 에 등록하게 됩니다.
        // 이때 "add" 부분이 호출됩니다.

        public event EventHandler? CanExecuteChanged
        {
            add 
            {
                // 아래 코드에서 value 는 버튼의 이 등록한 함수 입니다.
                // 즉, "CanExecuteChanged" 에 등록한 함수.
                CommandManager.RequerySuggested += value;
            }
            remove 
            {
                CommandManager.RequerySuggested -= value;
            }
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
        
    }
}
