// LINQ.cs
using System;

class Program
{
    public static void Main()
    {
        // int 배열인 경우는 아래처럼 foreach 사용가능
        //      int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 아래 처럼 만들면 foreach 에서 e 의 타입은 int 가 아닌 object 타입
        // 따라서 "e % 2" 연산은 에러!
        // 에러를 피하려면 "((int)e) % 2" 처럼 캐스팅 필요
        object[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach ( var e in arr)
        {
            //            var ret = e % 2 == 0; // 짝수 인지 조사

            var ret = ((int)e) % 2 == 0; // 짝수 인지 조사
        }

        // arr 의 모든 요소를 접근할때 
        // 각 요소를 int로 캐스팅해주는 반복자 얻기
        // result 는 열거 가능한 객체 입니다.
        var result = arr.Cast<int>();

        arr[1] = 100;

        foreach( var e in result)
        {
            var ret = e % 2 == 0;
            Console.WriteLine(e);
        }

        // arr    로 열거하면 : 각 요소는 object 타입
        // result 로 열거하면 : 각 요소는 int 타입



    }
}
