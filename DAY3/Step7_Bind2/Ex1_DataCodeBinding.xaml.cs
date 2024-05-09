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

namespace Step7_Bind2
{

    public partial class Ex1_DataCodeBinding : Window
    {
        private People p = new People { Name = "unknown", Address = "unknown" };

        public Ex1_DataCodeBinding()
        {
            InitializeComponent();

              // 임의의 객체의 속성을 다른 객체의 속성과 연결
            Binding b = new Binding();
            b.Source = p;                       // 이 객체의 
            b.Path = new PropertyPath("Name");  // 이 속성을
            b.Mode = BindingMode.OneWay;        // 단 방향으로

            txtblock1.SetBinding( TextBlock.TextProperty, b );
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string name = txtbox1.Text;
            string address = txtbox2.Text;
                
            // 아래와 같이 객체의 속성이 변경되면 등록된 모든 객체(UI, Control)에
            // 통보가 가고 자동으로 update 됩니다.
            p.Name = name;
            p.Address = address;
        }
    }
}
