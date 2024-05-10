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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Step9_MISC
{
    /// <summary>
    /// Ex1_CodeAnimation.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1_CodeAnimation : Window
    {
        public Ex1_CodeAnimation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Double 값을 가진 속성에 적용하는 Animation
            DoubleAnimation ani = new DoubleAnimation();

            ani.From = redBall.Width;       // 시작값  "100.0" 같은 
            ani.To   = redBall.Width + 500; // 종료값   리터럴로 해도됩니다.
            ani.Duration = new TimeSpan(0, 0, 3);

            //redBall.BeginAnimation(Ellipse.WidthProperty, ani);
            redBall.BeginAnimation(Ellipse.HeightProperty, ani);
        }
    }
}
