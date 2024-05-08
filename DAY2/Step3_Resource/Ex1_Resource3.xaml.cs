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

// 이번 예제의 핵심
// 1. App.Xaml 에도 Resource 를 만들수 있다.
// 2. 별도의 Resource.xaml 파일(리소스사전)을 만들어서 Merge 해서 사용가능

namespace Step3_Resource
{
  
    public partial class Ex1_Resource3 : Window
    {
        public Ex1_Resource3()
        {
            InitializeComponent();
        }
    }
}
