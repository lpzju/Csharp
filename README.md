# Csharp

## 语法部分
与C/C++类似，并且与Java又有点像

1. 查看System的Console方法时，其文件是这样写的：
```
#region ...
#endregion

using ...

namespace System;

public static class Console
{
    ...
}
#if false // 反编译日志
缓存中的 9 项
#endif
```
~~不明白为什么他这里的命名为什么是以分号结尾，自己尝试这样写就报错~~

看到有解释是说版本不同：[C#10](https://blog.csdn.net/weixin_42011858/article/details/112752977)，OK暂时解决。

2. 自己下载dotnet进行编译的时候，容易直接下载到C#5，并给予提醒

3. C#指针需要自己手动开启unsafe，感觉不会常用

4. 既然C#已经有GC机制，为什么还要有析构函数

查到的相关的解答，大多是C#完全没有必要写析构函数，还是不理解为什么要有析构函数

5. C#地址解析没搞明白，他的GC到底是怎么一回事

C#的指针操作，取地址操作，用指针访问成员操作，只能用来操作结构体类型，不能用来操作引用类型

6. 父类对象在子类对象创建之前被创建，通过构造函数很容易验证，与其他语言类似

7. 显示类型转换操作符，是一个目标类型的实例的构造器，此构造器不是写在目标类型的类中，而是写在被转换的数据类型中

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitAndImplicit
{
    class Monkey
    {
        public double age;
    }

    class StoneExplicit
    {
        public double age;
        public static explicit operator Monkey(StoneExplicit stone)
        {
            Monkey monkey = new Monkey();
            monkey.age = stone.age / 50;
            return monkey;
        }
    }

    class StoneImplicit
    {
        public double age;
        public static implicit operator Monkey(StoneImplicit stone)
        {
            Monkey monkey = new Monkey();
            monkey.age = stone.age / 50;
            return monkey;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StoneExplicit stoneExplicit = new StoneExplicit();
            stoneExplicit.age = 5000;
            StoneImplicit stoneImplicit = new StoneImplicit();
            stoneImplicit.age = 10000;
            Monkey monkey1 = (Monkey) stoneExplicit;
            Monkey monkey2 = (Monkey) stoneImplicit;
            Console.WriteLine(monkey1.age);
            Console.WriteLine(monkey2.age);
            Console.ReadLine();
        }
    }
}
```


