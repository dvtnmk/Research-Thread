using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Thread_State
{
    class Program
    {
        static void Main(string[] args)
        {   // Creating and initializing threads 
            Thread TR1 = new Thread(new ThreadStart(job));
            Thread TR2 = new Thread(new ThreadStart(job));

            Console.WriteLine("ThreadState of TR1 thread" +
                             " is: {0}", TR1.ThreadState);

            Console.WriteLine("ThreadState of TR2 thread" +
                             " is: {0}", TR2.ThreadState);

            // Running state  TR1
            TR1.Start();

            Console.WriteLine("ThreadState of TR1 thread " +
                               "is: {0}", TR1.ThreadState);
            // Stopped || Not Runnable state
            Thread.Sleep(4000);
            Console.WriteLine("ThreadState of TR1 thread " +
                   "is: {0}", TR1.ThreadState);

            //Aborted
            TR1.Abort();
            Console.WriteLine("ThreadState of TR1 thread " +
                   "is: {0}", TR1.ThreadState);

            //Running state TR2
            TR2.Start();
            Console.WriteLine("ThreadState of TR2 thread" +
                             " is: {0}", TR2.ThreadState);

            Console.WriteLine("Threads completed");
            Console.ReadKey();
        }

        // Static method 
        public static void job()
        {
            Thread.Sleep(2000);
        }
    }
}
