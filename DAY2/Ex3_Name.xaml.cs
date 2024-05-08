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


// 이소스의 핵심
// 1. XAML 에서 사용하는 "element 이름" 은 결국 타입(클래스) 이름
// => 해당 타입의 객체를 생성해 달라는 의미

// 2. 사용자가 만든 타입의 객체를 생성하려면
// => <local:MyType> 형식으로 사용

// 3. WPF 라이브러리가 아닌 C# 자체의 타입을 사용하려면
// => namespace 추가 ( xaml 파일의 system:String 참고)


// 4. Name 과 x:Name 의 차이점
// Name : "Name" 이라는 속성(property)를 제공하는 타입만 사용가능
//      => WPF 의 기본 타입은 모두 가능 
//      => 사용자 정의 타입이나 C# 기본 타입은 사용할수 없음.

// x:Name : 디폴트 생성자가 있는 모든 타입의 객체에 사용가능

// 디폴트 생성자가 없는 타입은 "resource"에 저장해서 사용하면 됩니다.

namespace Step1_XAML
{
    public class MyType
    {
        public void Foo() { Console.WriteLine("MyType Foo"); }

        public override string ToString()
        {
            return "MyType ToString";
        }
    }


    /// <summary>
    /// Ex3_Name.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex3_Name : Window
    {
        public Ex3_Name()
        {
            InitializeComponent();

            mytype.Foo();
        }
    }
}
