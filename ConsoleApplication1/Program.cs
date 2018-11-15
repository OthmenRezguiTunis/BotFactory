using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Bar.Instance + "Oops ");

        }
    }
    public abstract class Foo
    {
        static Foo()
        {
            Console.Write("constructeur FOO ");
        }
        public static string Instance;

        public static void SetInstance(string ins)
        {
            Instance = ins;
        }
    }

    public class Bar : Foo
    {
        static Bar()
        {
            Console.Write("constructeur Bar ");
            SetInstance("helo word ");
        }
    }

}
