using System;
using System.Collections.Generic;
using System.IO;
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
    /// Ex4_ItemSource5.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex4_ItemSource5 : Window
    {
        public Ex4_ItemSource5()
        {
            InitializeComponent();
            InitTree();
        }

        public void InitTree()
        {
            treeview.Items.Clear(); // 기존 요소를 비우고


            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = drive.Name;
                item.Tag = drive;

                treeview.Items.Add(item);

                // 삼각형을 나오게 하기 위해서 필요없는 자식 한개를 추가
                // 문자열을 바로 Add 도 가능합니다.
                item.Items.Add("*");
            }
        }

        private void treeview_Expanded(object sender, RoutedEventArgs e)
        {
            // sender : treeview 의 참조입니다.
            // e.OriginalSource : 선택된 TreeViewItem 참조 입니다.

            TreeViewItem item = (TreeViewItem)(e.OriginalSource);

            item.Items.Clear(); // * 를 제거 합니다.


            DirectoryInfo dir;

            // item.Tag 에는 "DriveInfo" 또는 "DirectoryInfo" 가 있습니다.
            // => 어떤 객체가 있는지 조사해서 다르게 처리 합니다
            if (item.Tag is DriveInfo)
            {
                DriveInfo drive = (DriveInfo)item.Tag;

                dir = drive.RootDirectory;
            }
            else
            {
                dir = (DirectoryInfo)item.Tag;
            }


            foreach (DirectoryInfo directory in dir.GetDirectories())
            {
                TreeViewItem child = new TreeViewItem();
                child.Header = directory.Name;
                child.Tag = directory;

                item.Items.Add(child);
                child.Items.Add("*");

            }


        }

        private void treeview_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)treeview.SelectedItem;

            string path = item.Header.ToString();

            while(item != null )
            {
                ItemsControl parent = GetParent(item);

                if (parent is TreeViewItem)
                {
                    item = (TreeViewItem)parent;
                    path = item.Header.ToString() + "\\" + path;
                }
                else
                    break;

            }
            Console.WriteLine(path);

            DirectoryInfo dir = new DirectoryInfo(path);

            listview.ItemsSource = dir.GetFiles();
            datagrid.ItemsSource = dir.GetFiles();

            //listview.ItemsSource = dir.GetDirectories();
        }


        public ItemsControl GetParent(TreeViewItem item)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(item);

            while( !(parent is TreeView || parent is TreeViewItem) )
            {
                parent = VisualTreeHelper.GetParent(parent);
            }
            return (ItemsControl)parent;
        }
    }
}

