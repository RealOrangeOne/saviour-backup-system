using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Background_Worker_Testing
{
    class worker
    {
        public void do_Work()
        {
            while (_ThreadActive)
            {
                Console.WriteLine("Thread Processing with ID " + id);
                System.Threading.Thread.Sleep(id * 755);
            }
        }
        public void request_Stop()
        {
            _ThreadActive = false;
        }
        private volatile bool _ThreadActive = true;
        public volatile int id;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started.");
            worker worker1 = new worker();
            worker worker2 = new worker();
            worker1.id = 1;
            worker2.id = 2;
            Console.WriteLine("Workers defined.");
            Thread thread1 = new Thread(worker1.do_Work);
            Thread thread2 = new Thread(worker2.do_Work);
            Console.WriteLine("Threads Defined");
            thread1.Start();
            while (!thread1.IsAlive);
            Console.WriteLine("Thread 1 has begun!");
            thread2.Start();
            while (!thread2.IsAlive);
            Console.WriteLine("Thread 2 has begun!");

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Stopping Threads...");
            worker1.request_Stop();
            while (thread1.IsAlive);
            worker2.request_Stop();
            while (thread2.IsAlive);
            Console.WriteLine("Threads Stopped.");
            Console.ReadKey();

        }
    }
}
