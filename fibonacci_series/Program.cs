using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_series
{
    public class Fibonacci
    {
        int F1 = 0, F2 = 1, F3;

        List<int> fibo  = new List<int>();        

        public List<int> FibonacciSeries(int number)
        {
            fibo.Add(F1);
            fibo.Add(F2);

            for (int i = 2; i < number; i++)
            {
                F3 = F1 + F2;
                fibo.Add(F3);
                F1 = F2;
                F2 = F3;
            }

            return fibo.ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();  
            Console.Write("INPUT: Please enter the number of elements: ");           
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            List<int> fiboSeries = fibo.FibonacciSeries(inputNumber);
            Console.WriteLine();
            Console.WriteLine("OUTPUT: The resultant Fibonacci series is as follows: ");
            Console.WriteLine("======================================================");
            foreach(var item in fiboSeries)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();            
        }
    }
}
