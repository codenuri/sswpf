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

namespace Step5_Control
{
    public partial class VisualTree : Window
    {
        public VisualTree()
        {
            InitializeComponent();
        }

        public void BuildVisualTree(DependencyObject root)
        {
            treeview.Items.Clear(); // 기존 항목을 모두 제거하고

            ProcessVisualTree(root, null); // 재귀 호출로 tree 채우기
        }
        
        private void ProcessVisualTree(DependencyObject obj, TreeViewItem parent)
        {
            // 자신의 타입이 이름을 먼저 tree에 넣기
            TreeViewItem item = new TreeViewItem();
            item.Header = obj.GetType().Name;

            if (parent == null)
            {
                // 부모 노드가 없으면 treeview 자체에 추가
                treeview.Items.Add(item);
            }
            else
            {
                // 부모가 있을때는 부모 item 에 추가
                parent.Items.Add(item);
            }
            

            int cnt = VisualTreeHelper.GetChildrenCount(obj);

            for (int i = 0; i < cnt; i++)
            {
                var child = VisualTreeHelper.GetChild(obj, i);

                ProcessVisualTree(child, item);
            }
        }
    }
}
