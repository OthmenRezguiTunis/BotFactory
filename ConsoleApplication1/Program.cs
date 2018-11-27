using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = null;
            str.Substring(3,5);


            //Thread t = new Thread(()=>Count(10));
            //t.Start();
            //new Thread(() =>
            //{
            //    Count(5);
            //    Count(6);
            //}
            //).Start();
                
                
            //    ;


            //var account = new BankAccount(10);
            //Thread[] threadarray = new Thread[15];
            //Thread.CurrentThread.Name = "main";

            //for(var i =0; i<15; i++)
            //{
            //    Thread t = new Thread (new ThreadStart(account.IssueWithdraw));
            //    t.Name = i.ToString();
            //    threadarray[i] = t;
            //}

            //for (var i = 0; i < 15; i++)
            //{
            //    Console.WriteLine("Thread is Alive" , threadarray[i].Name , threadarray[i].IsAlive);
            //    threadarray[i].Start();
            //    Console.WriteLine(threadarray[i].IsAlive);
            //    Console.WriteLine(Thread.CurrentThread.Priority);
            //}


        }
        static void Count(int Maxnumber)
        {
            for(var i =0; i < Maxnumber; i++)

            {
                Console.WriteLine(i);
            }


        }
        //class BankAccount
        //{
        //    private static Object acclock = new object();
        //    double Balance { get; set; }

        //    public BankAccount(double balance)
        //    {
        //        this.Balance = balance;

        //    }
        //    public double Withdraw(double Ammount)
        //    {
        //        if (Balance - Ammount < 0)
        //        {
        //            Console.WriteLine("Sorry your balance is " + Balance);

        //        }

        //        if (Balance - Ammount > 0)
        //        {
        //            Console.WriteLine("removed {0} , left in account {1}", Ammount, Balance - Ammount);
        //            Balance -= Ammount;

        //        }
        //        return Balance;

        //    }

        //    public void IssueWithdraw()
        //    {
        //        lock (acclock)
        //        {
        //            Withdraw(1);
        //        }

        //    }

        //}


    }
}

