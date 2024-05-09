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
    /// <summary>
    /// Ex3_ItemControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3_ItemControl : Window
    {
        public Ex3_ItemControl()
        {
            InitializeComponent();

            // 컨트롤은 크게 2가지 종류가 있습니다.
            // Content Control   : 한개의 값을 보여주는 컨트롤
            // Items Control     : 여러개의 값을 보여주는 컨트로

            listbox.Items.Add("AAA");
            listbox.Items.Add("BBB");

            // combo box 도 items 컨트롤 입니다.
            combobox.Items.Add("AAA");
            combobox.Items.Add("BBB");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // TextBox 의 값을 꺼내서
            string s = txtbox.Text;

            // listbox 에 추가해 보세요
            listbox.Items.Add(s);

            // TextBox 는 비우세요
            txtbox.Clear();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            // listbox 에서 선택된 항목을 

            // obj?.메소드(); // obj 가 null 이면 메소드를 호출하지 말고 null 반환해달라
                        
            string? s = listbox.SelectedItem?.ToString();

            if (s == null) return;

            // combobox 에 추가해 보세요

            combobox.Items.Add(s);


            // listbox 에서는 제거해 보세요
            listbox.Items.RemoveAt(listbox.SelectedIndex);
        }
    }
}
