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
            string[] colors = new string[]{ "a", "b" };
            //var lis = new List<string>(){colors};
         


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
