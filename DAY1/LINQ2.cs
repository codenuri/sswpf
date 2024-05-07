// LINQ.cs
using System;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ : collection 을 바라보는 시각(view)를 제공하는것

        var view1 = arr.Where(n => n % 2 == 0);

        foreach( var e in view1)
        {
            Console.WriteLine(e);
        }


    }
}
