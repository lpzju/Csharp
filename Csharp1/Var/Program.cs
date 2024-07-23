

using System;

namespace mySpace { }
public static class Program
{
    //static void Main(string[] args)
    //{
    //    System.Console.WriteLine("test");
    //    var num1 = 1;
    //    var num2 = 2;
    //    var num3 = 0;
    //    num3 = num1 + num2;
    //    System.Console.WriteLine(num3);

    //    System.Console.ReadKey();
    //}
    static void Main(string[] args)
    {
        System.Console.WriteLine("请输入数字");
        string str = System.Console.ReadLine();
        System.Console.WriteLine(str);
        int num1 = int.Parse(str) + 123;
        System.Console.WriteLine(num1);
        //string str2 = str + 123;
        //string str2 = str + 123.ToString();
        str = str + 123.ToString();
        //System.Console.WriteLine(str2);
        System.Console.WriteLine(str);
        var person1 = new { Name = "zhangsan", Age = 18 };
        Object person = new { Name="zhangsan", Age=18};
        Console.WriteLine(person);
        Console.WriteLine(person.GetType().Name);
        System.Console.ReadKey();
    }
}

