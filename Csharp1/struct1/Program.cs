using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
};

// 结构声明
struct MyStruct
{
    public int X;
    public int Y;

    // 结构不能有无参数的构造函数
    // public MyStruct()
    // {
    // }

    // 有参数的构造函数
    public MyStruct(int x, int y)
    {
        X = x;
        Y = y;
    }

    // 结构不能继承
    // struct MyDerivedStruct : MyBaseStruct
    // {
    // }
}

// 类声明
class MyClass
{
    public int X;
    public int Y;

    // 类可以有无参数的构造函数
    public MyClass()
    {
    }

    // 有参数的构造函数
    public MyClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    // 类支持继承
    // class MyDerivedClass : MyBaseClass
    // {
    // }
}

namespace struct1
{
    internal class Program
    {

        // 获取引用类型的内存地址方法
        public static string getMemory(object obj)
        {
            GCHandle handle = GCHandle.Alloc(obj, GCHandleType.WeakTrackResurrection);
            IntPtr addr = GCHandle.ToIntPtr(handle);
            return $"0x{addr.ToString("X")}";
        }

        static void Main(string[] args)
        {
            Books Book1;        /* 声明 Book1，类型为 Books */
            Books Book2;        /* 声明 Book2，类型为 Books */

            /* book 1 详述 */
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

            /* book 2 详述 */
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;

            /* 打印 Book1 信息 */
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            /* 打印 Book2 信息 */
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

            // 结构是值类型，分配在栈上
            MyStruct structInstance1 = new MyStruct(1, 2);
            MyStruct structInstance2 = structInstance1; // 复制整个结构

            // 类是引用类型，分配在堆上
            MyClass classInstance1 = new MyClass(3, 4);
            MyClass classInstance2 = classInstance1; // 复制引用，指向同一个对象

            // 修改结构实例不影响其他实例
            structInstance1.X = 5;
            Console.WriteLine($"Struct: {structInstance1.X}, {structInstance2.X}");

            // 修改类实例会影响其他实例
            classInstance1.X = 6;
            Console.WriteLine($"Class: {classInstance1.X}, {classInstance2.X}");

            unsafe
            {
                int number = 27;
                int* pointerToNumber = &number;

                Console.WriteLine($"Value of the variable: {number}");
                Console.WriteLine($"Address of number: {(long)pointerToNumber:X}");
                String test1 = "hello";
                String* t1 = &test1;
                String* t2 = &test1;
                Console.WriteLine($"Address of string: {(long)t1:X}");
                Console.WriteLine($"Address of string: {(long)t2:X}");
                Console.WriteLine($"Address of string: {(long)&test1:X}");
                test1 = "world";
                Console.WriteLine($"Address of string: {(long)t1:X}");

                MyStruct structInstance3 = new MyStruct(5, 6);
                MyStruct structInstance4 = structInstance3; // 复制整个结构
                Console.WriteLine($"Address of string: {(long)&structInstance3:X}");
                Console.WriteLine($"Address of string: {(long)&structInstance4:X}");
                // 类是引用类型，分配在堆上
                MyClass classInstance3 = new MyClass(7, 8);
                MyClass classInstance4 = classInstance3; // 复制引用，指向同一个对象
                Console.WriteLine($"Address of string: {(long)&classInstance3:X}");
                Console.WriteLine($"Address of string: {(long)&classInstance4:X}");
                Console.WriteLine(getMemory(structInstance3));
                Console.WriteLine(getMemory(structInstance4));
                Console.WriteLine(getMemory(classInstance3));
                Console.WriteLine(getMemory(classInstance4));
                Console.WriteLine("-------------");
                Console.WriteLine(getMemory(*t1));
                Console.WriteLine(getMemory(*t1));
                Console.WriteLine(getMemory(*t2));
                Console.WriteLine(getMemory(*t2));

            }

            Console.ReadKey();
        }
    }
}
