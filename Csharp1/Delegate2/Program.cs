using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();
            Func<Product> func1 = new Func<Product>(productFactory.ToyCar);
            Func<Product> func2 = new Func<Product>(productFactory.MakePizza);
            Box box1 = wrapFactory.WrapBox(func1);
            Console.WriteLine(box1.ToString());
            Console.WriteLine(box1.MyProduct.Name);
            Console.ReadLine();
        }
    }
    class Product
    {
        public String Name { get; set; }
    }
    class Box
    {
        public Product MyProduct { get; set; }
    }
    class WrapFactory
    {
        public Box WrapBox(Func<Product> getProduct)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            box.MyProduct = product;
            return box;
        }
    }
    class ProductFactory
    {
        public Product ToyCar()
        {
            return new Product { Name = "car" };
        }
        public Product MakePizza() 
        {
            return new Product { Name = "pizza" };
        }
    }
}
