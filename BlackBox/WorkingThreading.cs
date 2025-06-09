using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox
{
    public class WorkingThreading
    {
        public static void ThreadMain()
        {
            Thread thread = new Thread(PrintNumber);
            thread.Start();

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine($"Main thread: {i}");
                Thread.Sleep(500);
            }
            thread.Join();
            Console.WriteLine("Main thread finished.");

        }

        public static void PrintNumber()
        {
            for(int i = 0; i <5; i++)
            {
                Console.WriteLine($"Worker thread: {i}");
                Thread.Sleep(300);
            }
        }
    }
}
