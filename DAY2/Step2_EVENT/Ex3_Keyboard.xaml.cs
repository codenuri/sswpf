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
    /// Ex3_Keyboard.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3_Keyboard : Window
    {
        public Ex3_Keyboard()
        {
            InitializeComponent();
        }
        // 키보드를 누르면
        // 0. PreviewKeydown
        // 1. Keydown (OS 발생)
        // 2. 눌린 키보드가 문자키라면 TextIntpu 발생 (OS 발생)
        // 3. TextBox 내용이 수정되었으므려 TextChanged ( TextBox가 발생시킨것)
        // 4. PreviewKeyup
        // 5. Keyup
        private void KeyEvent(object sender, KeyEventArgs e)
        {
            string s = "(KEYEVENT) : " + e.RoutedEvent + " Key : " + e.Key;

            Console.WriteLine(s);
        }

        private void txtBox1_TextInput(object sender, TextCompositionEventArgs e)
        {
            string s = "(TextInput) : " + e.RoutedEvent + " Text : " + e.Text;

            Console.WriteLine(s);
        }

        private void txtBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = "(TextChanged) : " + e.RoutedEvent;

            Console.WriteLine(s);
        }
    }
}
