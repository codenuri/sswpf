using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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

namespace Step5_Control
{
    /// <summary>
    /// Ex5_Tree1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex5_Tree1 : Window
    {
        public Ex5_Tree1()
        {
            InitializeComponent();

            // TreeView 핵심 
            // => 항목 한개를 나타내는 타입은 "TreeViewItem" 타입입니다.

            TreeViewItem item1 = new TreeViewItem();
            item1.Header = "PARENT";

            // #1. treeview 자체에 부착하면 root 요소 입니다.
            treeview.Items.Add(item1);

            TreeViewItem child1 = new TreeViewItem { Header = "child1" };
            TreeViewItem child2 = new TreeViewItem { Header = "child2" };
//          treeview.Items.Add(child1);
//          treeview.Items.Add(child2);

            // #2. 자식 노드로 붙이려면 "부모노드.Items.Add"
            item1.Items.Add(child1);
            item1.Items.Add(child2);

            // #3. child1 아래에 "AAA", "BBB" 붙여 보세요
            child1.Items.Add(new TreeViewItem { Header = "AAA" });
            child1.Items.Add(new TreeViewItem { Header = "BBB" });

        }
    }
}
