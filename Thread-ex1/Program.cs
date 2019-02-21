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
            _thread = new Thread(new ThreadStart(ThreadB));
            _thread.Name = "threadB";
            
            _thread = new Thread(new ThreadStart(ThreadA));
            _thread.Name = "threadA";

            Console.WriteLine("Threads started :");
            // Start thread B
            _thread.Start();
            //Thread A executes 10 times
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Thread : A");
            //}

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

        public static void ThreadB()
        {
            //Executes thread B 10 times
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(_thread.Name);
                //if(i>=5)
                //{
                //    _thread.Abort();

                //}
            }
        }
    }
}
