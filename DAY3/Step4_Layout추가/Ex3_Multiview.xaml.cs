using Microsoft.Win32;
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

namespace Step4_Layout추가
{
    /// <summary>
    /// Ex3_Multiview.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3_Multiview : Window
    {
        public Ex3_Multiview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow win = new FirstWindow();

            //    win.Show(); // modaless 창으로 나타내기
            win.ShowDialog(); // modal 로 나타내기
                                // 자식 창이 나타나 있는 상태에서
                                // 부모창 선택 안됨.
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // 공용 Dialog : OS 가 제공하는 Dialog
            // 파일열기, 저장, 색상 선택, 프린트, 프린트미리보기, 폰트 선택등을 제공

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.FileName = "Document";
            dlg.DefaultExt = "*.txt";
            dlg.Filter = "Text Document(.txt)|*.txt|모든파일(.*)|*.*";

            bool? result = dlg.ShowDialog();

            if ( result == true)
            {
                string filename = dlg.FileName;

                MessageBox.Show(filename);
            }
        }
    }
}
