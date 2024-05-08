using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Step3_Resource
{
    public partial class Ex1_Resource1 : Window
    {
        public Ex1_Resource1()
        {
            // Window 클래스안에는 "Resources 라는 이름의  Dictionary" 가 한개 있습니다.
            // Dictionary : 키값으로 객체를 보관하는 자료 구조

            this.Resources["Message"] = "Hello, WPF";

            var brush1 = new SolidColorBrush( Colors.Yellow );
            
            var brush2 = new LinearGradientBrush();
            brush2.StartPoint = new Point(0, 0.5);
            brush2.EndPoint = new Point(0.5, 1);

            brush2.GradientStops.Add(new GradientStop(Colors.Aqua, 0.25));
            brush2.GradientStops.Add(new GradientStop(Colors.Blue, 0.50));
            brush2.GradientStops.Add(new GradientStop(Colors.Red, 0.75));
            brush2.GradientStops.Add(new GradientStop(Colors.Green, 1.0));

            this.Resources["MyBrush1"] = brush1;
            this.Resources["MyBrush2"] = brush2;

            // 위 코드는 복잡해 보이지만 결국
            // 자주 사용하는 객체를 미리 만들어서 "Dictionary" 에 등록한것!

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 버튼을 눌렀을때 "확인2, 확인4" 의 변화를 확인해 보세요

            this.Resources["MyBrush1"] = new SolidColorBrush( Colors.Red );
        }
    }
}

// static resource : dictionary 에 있는 객체의 복사본을 사용하는 것
// dynamic resource : dictionary 에 있는 객체의 참조를 사용, dictionary 수정시
//                                                          같이 변경

// 구글 : WPF StaticResource source code