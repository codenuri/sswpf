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

// 지금 까지 내용 정리
// 하나의 명령은 
// 1. 실행될때 "해야 할일" 
// 2. "실행가능한가" 를 판단하는 (UI 의 enable/disable) 판단
// => 2개의 함수 필요

// 명령을 만들려면
// 1. RoutedCommand 타입의 객체한개를 생성하세요
// 2. 2개의 함수를 만든후에 1번객체에 2개의 함수를 연결하세요 
// 3. 단축키가 필요하면 InputBinding 객체도 만드세요

// 의미
// 하나의 명령을 "여러가지 소스를 통해서" 실행가능
// => 버튼, 단축키, 메뉴, 툴바 등.. 



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


            // #1. 단축키 객체를 생성해서 명령 객체와 연결
            InputBinding ib = new InputBinding(MyCommand4.cmdLogin, 
                                        new KeyGesture(Key.L, ModifierKeys.Control));

            // 모든 윈도우는 "단축키를 관리하는 Collection" 을 가지고 있습니다.
            // 단축키 객체를 만든후에는 Collection 에 등록해야 합니다.
            this.InputBindings.Add(ib);
        }

        private void CmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            Console.WriteLine("called CmdCanExecute");
            e.CanExecute = (!string.IsNullOrEmpty(id_txtbox.Text)) && check.IsChecked.Value;
        }
        private void CmdExecute(object sender, ExecutedRoutedEventArgs e)
        {
            // 어떤 객체를 통해서 실행되었는지 확인하는 코드
            // => 버튼을 눌러서 명령이 실행되었는지
            // => 단축키를 통해서 실행되었는지
            //Type t = sender.GetType();
            Type t = e.OriginalSource.GetType();

            Console.WriteLine($"Execute Login : {t.Name}");            
            
        }

    }
}
