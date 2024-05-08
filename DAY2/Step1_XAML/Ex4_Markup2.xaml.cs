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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Step1_XAML
{
    // "생성자 인자"에 따라 다른 종류의 값을 반환하는 "사용자정의 Markup"
    // => 속성이 아닌 생성자 인자 입니다.!!
    public class Header : MarkupExtension
    {
        private string key;

        public Header( string s) { key = s; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            switch(key)
            {
                case "FontSize": return (Double)30;
                case "Background": return new SolidColorBrush(Colors.Yellow);
            }
            return null;
        }
    }


    public partial class Ex4_Markup2 : Window
    {
        public Ex4_Markup2()
        {
            InitializeComponent();
        }
    }
}
