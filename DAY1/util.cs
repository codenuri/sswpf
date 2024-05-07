// util.cs - 이 파일은 빌드 제외 하지 마세요
using System;

class Util
{
    // ShowHierachy 메소드 복사해 오세요
    public static void ShowHierachy(object obj)
    {
        Type t = obj.GetType();

        while (true)
        {
            Console.Write($"{t.Name}");

            if (t == typeof(object)) break;

            Console.Write(" => ");

            t = t.BaseType;
        }
        Console.WriteLine("");
    }
}

// 참고 : .net Framwork 시절에 작성한 코드 또는 C#9.0 이전의 코드를
// 최신 컴파일러로 컴파일 하면 경고가 발생할 때가 있습니다.

// 원인 : C# 9.0 의 "nullable reference" 문법 때문에!!   
// 해결책 1. C# 9.0 이상 버전에 맞도록 코드를 수정한다.
//       2. nullable reference 문법을 사용하지 않는다.
//          ( 프로젝트 설정 소스에서 <Nullable> 을 disable로 변경 )