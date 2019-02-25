using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_ex1
{
    public class Program
    {
        private static Thread _thread;
        public static void Main(string[] args)
        { //Creating thread object to strat it
            _thread = new Thread(new ThreadStart(ThreadA));
            _thread.Name = "threadA";
            _thread.Start();
            //Pass Parameter
            Thread t = new Thread(() => Print("Hello from t!"));
            t.Start();
            
            Console.WriteLine("Threads started :");
            //Thread Main executes 10Times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread : Main");
            }

            Console.WriteLine("Threads completed");
            Console.ReadKey();
        }
        public static void ThreadA()
        {
            //Executes thread A 10 times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(_thread.Name);
            }
        }

        public static void Print(string message)
        {
            Console.WriteLine("Thread Message : "+message);
        }

    }
}
