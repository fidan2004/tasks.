using System;
using System.Threading;

namespace TASK_1
{
    public class Program
    {
        static void Main(string[] args)
        {

            var n1 = int.Parse(Console.ReadLine());
            Thread program1Runner = new Thread(() => Program1(n1));
            program1Runner.Start();

            var n2 = int.Parse(Console.ReadLine());
            Thread program2Runner = new Thread(() => Program2(n2));
            program2Runner.Start();

        }

        static void Program1(int n1)
        {
            for (int i = 1; i <= n1; i++)
            {
                Console.WriteLine("program1  " + i);

                Thread.Sleep(20);
                
            }
        }

         static void Program2(int n2)
        {
            for (int i = 1; i <= n2; i++)
            {

                Console.WriteLine("program2  " + i);

                Thread.Sleep(20);
            }
        }
    }
}
