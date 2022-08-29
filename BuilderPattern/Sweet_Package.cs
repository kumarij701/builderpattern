using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Sweet_Package
    {
        public static void Main()
        {
            // Create director and builders
            Director director = new Director();
            Builder b1 = new ChildPackage();
            Builder b2 = new AdultPackage();
            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();
            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show1();
            // Wait for user
            Console.ReadKey();
        }
    }
    class Director
    {
        // Builder uses a complex series of steps
        public void Construct(Builder builder)
        {
            builder.sweet();////BuildPartA();
            builder.savory();//BuildPartB();
        }
    }
    abstract class Builder
    {
        public abstract void sweet();
        public abstract void savory();
        public abstract Product GetResult();
    }

    class ChildPackage : Builder
    {
        private Product _product = new Product();
        public override void sweet()
        {
            _product.Add("2 Sweet");
        }
        public override void savory()
        {
            _product.Add("1 Savory");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }


    class AdultPackage : Builder
    {
        private Product _product = new Product();
        public override void sweet()
        {
            _product.Add("2 Sweet");
        }
        public override void savory()
        {
            _product.Add("2 Savory");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }

    class Product
    {
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            _parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\n Child Packages  -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
        public void Show1()
        {
            Console.WriteLine("\n Adult Packages  -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }

}

