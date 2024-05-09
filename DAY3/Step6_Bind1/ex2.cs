using System;

// 속성이 변경될때 외부에 통보(등록된 함수를 호출)
// delegate : 함수를 저장했다가 호출할수 있는 C# 문법(C/C++의 함수 포인터)
// 아래 코드에서 "ChangeHandler" 는 타입(클래스이름)입니다.

delegate void ChangeHandler(object sender, string property_name);

class People
{
    private string name;
    private string address;

    public ChangeHandler changeHandler;

    public string Name 
    {
        get { return name; } 
        set { name = value; changeHandler(this, "Name"); }
    }

    public string Address 
    { 
        get { return  address; }
        set { address = value; changeHandler(this, "Address"); }
    }
}

class ex2
{
    public static void Main()
    {
        People p = new People();

        // p 객체의 속성이 변경되면 통보 받을 함수 등록
        p.changeHandler += ex2.Foo;

        p.Name = "kim";
        p.Address = "seoul";
    }

    public static void Foo(object sender, string property_name)
    {
        Console.WriteLine("속성 변경됨");
    }
}
