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
    public partial class Ex4_ItemSource2 : Window
    {
        public Ex4_ItemSource2()
        {
            InitializeComponent();

            // Fonts.SystemFontFamilies : 시스템에 설치된 폰트 목록을 가진
            //                            Collection 입니다.
            listbox.ItemsSource = Fonts.SystemFontFamilies;
        }
    }
}
