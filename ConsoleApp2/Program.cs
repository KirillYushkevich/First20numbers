using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            for(int i=2;i<20;i++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i-1]+fibonacciNumbers[i-2]);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }

    }
}
