using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
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
    public partial class Ex4_ItemSource : Window
    {
        // 아래 코드는 "컬렉션의 요소(People 객체) 에 대한 변화"는 통보가능합니다.
        // 하지만 "컬렉션 자체의 변화(People 객체의 추가/삭제" 에 대해서는
        // 통보가 되지 않습니다.
        // List 는 INotifyPropertyChange 인터페이스를 구현하지 않았다는 의미

        // private List<People> col = new List<People>();

        // 해결책 : 아래 처럼 하면 컬렉션의 변화도 통보 되어서 UI 가 자동으로 UPDATE
        private ObservableCollection<People> col = new ObservableCollection<People>();

        public Ex4_ItemSource()
        {
            InitializeComponent();

            col.Add(new People { Name = "name1", Address = "address1" });
            col.Add(new People { Name = "name2", Address = "address2" });
            col.Add(new People { Name = "name3", Address = "address3" });


            // items 컨트롤(여러개 항목을 가지는 컨트롤)은
            // collection 과 자동 연결 될수 있습니다.
            // => 연결만 하고 DisplayMemberPath 속성을 지정하지 않으면
            //    Collection 의 모든 객체에 대해서 "ToString()" 결과를 listbox에출력(클래스이름)
            listbox.ItemsSource = col;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            col[0].Name = "UNKNOWN";
        }

        static int cnt = 5;
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string name = string.Format($"name{++cnt}");

            col.Add(new People { Name = name, Address = "address1" });
        }
    }
}
