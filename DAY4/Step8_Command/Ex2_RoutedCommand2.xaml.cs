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
    /// <summary>
    /// Ex2_RoutedCommand2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2_RoutedCommand2 : Window
    {
        public Ex2_RoutedCommand2()
        {
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Type t = e.OriginalSource.GetType();

            Console.WriteLine($"Execute Login : {t.Name}");
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            Console.WriteLine("called CmdCanExecute");
            e.CanExecute = (!string.IsNullOrEmpty(id_txtbox.Text)) && check.IsChecked.Value;

        }
    }
}
