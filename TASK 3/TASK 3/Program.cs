using System;

namespace TASK_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a string ");

            
            str = Console.ReadLine();
            
            int sum = 0;
           

            for (int i = 0; i < str.Length; i++)
            {

                if ((str[i] >= '0') && (str[i] <= '9'))
                {
                   sum = sum + str[i] - '0';
                }
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
