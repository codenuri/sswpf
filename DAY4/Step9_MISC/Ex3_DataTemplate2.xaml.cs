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

namespace Step9_MISC
{
    class People
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public partial class Ex3_DataTemplate2 : Window
    {
        private ObservableCollection<People> plist = new ObservableCollection<People>();

        public Ex3_DataTemplate2()
        {
            InitializeComponent();

            plist.Add(new People { Name = "name1", Address = "address1" });
            plist.Add(new People { Name = "name1", Address = "address1" });
            plist.Add(new People { Name = "name2", Address = "address2" });

            listbox.ItemsSource= plist;

        }
    }
}
