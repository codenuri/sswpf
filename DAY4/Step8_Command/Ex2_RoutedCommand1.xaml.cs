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
    
    // Command4.cs 소스를 생각하면
    // => LogInCommand 의 add,remove 는 결국 모든 명령에서 동일하게 사용됩니다.
    // => 단지, 달라지는 것은 CanExecute 와 Execute 의 구현입니다.
    
    // WPF 에는 add, remove 부분을 제공하는 RoutedCommand 라는 클래스를 제공합니다.

    static class MyCommand4
    {
        // 앞에서 만든 LogInCommand 대신 RoutedCommand 사용
        // => add, remove 제공
        // => 하지만 Execute 와 CanExecute 는 사용자가 만들어야 합니다!!
        public static RoutedCommand cmdLogin = new RoutedCommand();
    }


    public partial class Ex2_RoutedCommand1 : Window
    {
        public Ex2_RoutedCommand1()
        {
            InitializeComponent();

            // cmdLogin 객체에 사용자 함수 연결
            CommandBinding binding = new CommandBinding(MyCommand4.cmdLogin);

            binding.Executed += CmdExecute;
            binding.CanExecute += CmdCanExecute;

            CommandBindings.Add(binding);
        }

        private void CmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            Console.WriteLine("called CmdCanExecute");
            e.CanExecute = (!string.IsNullOrEmpty(id_txtbox.Text)) && check.IsChecked.Value;
        }
        private void CmdExecute(object sender, ExecutedRoutedEventArgs e)
        {
            Console.WriteLine("Execute Login");
        }

    }
}
