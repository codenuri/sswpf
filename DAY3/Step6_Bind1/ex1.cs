// Step6_Bind1 - ex1.cs
using System;

class People
{
    public string Name { get; set; }
    public string Address { get; set; }
}

class ex1
{
    public static void Main()
    {
        People p = new People();
        p.Name = "kim";
        p.Address = "seoul";
    }
}
