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
            int a = 10;
            int? b = 20;
            int? c = null;
            Console.WriteLine(a+c ?? b);

        }
    }
    public  class A
    {
     public virtual  void M()
        {
            Console.Write("constructeur A ");
        }
     
    }

    public class B : A
    {
       public override void M()
        {
            Console.Write("constructeur fils ");
            
        }
    }

}
