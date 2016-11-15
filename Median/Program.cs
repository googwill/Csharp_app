using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //user enter numbers 
            Console.WriteLine("Please enter a stream of integers and space between numbers!");
            string s = Console.ReadLine();
            int mid;

            //convert string array to integer array and sort it
            int[] iarr = s.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            Array.Sort(iarr);

            int count = iarr.Length;

            foreach (int value in iarr)
            {
                Console.Write(value);
                Console.Write(' ');              
            }

            //odd number
            if (count % 2 != 0)
            {
                mid = ((count + 1) / 2);
                int oddMid = iarr[mid - 1];  
                Console.WriteLine("\n----If there are Odd number, median number ----");
                Console.WriteLine(oddMid);
            }
            //even number
            else if (count % 2 == 0)
            {
                mid = (count / 2);
                double a = Convert.ToDouble(iarr[mid - 1]);
                double b = Convert.ToDouble(iarr[mid]);
                double eveMid = (a + b)/2;
                Console.WriteLine("\n----If there are even numbers, median number  ----");
                Console.WriteLine(eveMid);
            }
        
            Console.ReadKey();
        }
    }
}
