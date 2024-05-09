using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// <summary>
    /// Ex4_ItemSource3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex4_ItemSource3 : Window
    {
        private ObservableCollection<People> col = new ObservableCollection<People>();

        public Ex4_ItemSource3()
        {
            InitializeComponent();

            col.Add(new People { Name = "name1", Address = "address1" });
            col.Add(new People { Name = "name2", Address = "address2" });
            col.Add(new People { Name = "name3", Address = "address3" });

            
            listview.ItemsSource = col;
        }
    }
}
