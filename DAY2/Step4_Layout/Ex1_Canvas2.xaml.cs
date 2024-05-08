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

namespace Step4_Layout
{
    /// <summary>
    /// Ex1_Canvas2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1_Canvas2 : Window
    {
        public Ex1_Canvas2()
        {
            InitializeComponent();
        }

        private Point cp = new Point();

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // MouseDown : 왼쪽/오른쪽 중 한개라도 누를때 호출
            //             어느 버튼인지 알고 싶다면 아래 처럼
            if ( e.LeftButton == MouseButtonState.Pressed ) 
            {
                cp = e.GetPosition(this);
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point pt = e.GetPosition(this);

                // WPF 에는 Point, Line, Rect, Ellipse 등의 대부분으
                // 도형이 타입으로 이미 제공됩니다. 
                Line line = new Line();

                line.Stroke = SystemColors.WindowFrameBrush;

                line.X1 = cp.X;
                line.Y1 = cp.Y;
                line.X2 = pt.X;
                line.Y2 = pt.Y;

                canvas.Children.Add(line); // 이코드가 선을 그린것(잘 설계된 객체지향 개념)

                cp = pt; // 현재 점을 다시 cp 로
            }
        }
    }
}
