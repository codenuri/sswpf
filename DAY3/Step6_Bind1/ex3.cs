using System;
using System.ComponentModel;

// 속성 변경시, 통보 가능한 타입을 설계하려면
// 1. INotifyPropertyChanged 인터페이스를 구현하겠다고 표시 합니다.
// 2. INotifyPropertyChanged 의 요구 조건인 "PropertyChanged" 멤버 추가

// 3. 속성이 변경되면 PropertyChanged 에 등록된 메소드를 호출합니다.

class People : INotifyPropertyChanged
{
    private string name;
    private string address;

    public event PropertyChangedEventHandler? PropertyChanged;

    public string Name
    {
        get { return name; }
        set { name = value; PropertyChanged(this, 
                                   new PropertyChangedEventArgs("Name") ); }
    }

    public string Address
    {
        get { return address; }
        set { address = value; PropertyChanged(this,
                new PropertyChangedEventArgs("Address")); }
    }
}

class ex2
{
    public static void Main()
    {
        People p = new People();

        // p 객체의 속성이 변경되면 통보 받을 함수 등록
        p.PropertyChanged += ex2.Foo;

        p.Name = "kim";
        p.Address = "seoul";
    }

    public static void Foo(object sender, PropertyChangedEventArgs arg)
    {
        Console.WriteLine("속성 변경됨");

        Type t = sender.GetType();

        string value = (string)t.GetProperty(arg.PropertyName).GetValue(sender, null);

        Console.WriteLine($"{arg.PropertyName} 이 {value} 로 변경됨");

    }
}

// 핵심
// => 위 People 클래스는 자신의 속성이 변경되면
// => 등록된 메소드를 호출 하면서 자신의 참조와 속성이름을 전달해 줍니다.
// => 위 코드는 "WPF" 가 요구하는 규칙을 완벽하게 지킨 코드 입니다.

// => 따라서, WPF 의 대부분의 컨트롤을 People 객체와 연결할수 있게 됩니다.