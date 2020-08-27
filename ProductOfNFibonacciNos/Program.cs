using System;

namespace ProductOfNFibonacciNos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number!");
                int input;
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input , Enter only number");
                    Console.WriteLine("Please enter a number!");
                }

                if (input < 1)
                {
                    Console.WriteLine("Value can not be less than 1");
                }
                else if (input > 83)
                {
                    Console.WriteLine("Can not calculate the product of Fibonacci nos greater than 83");
                }
                else
                {
                    var output = FibonacciSeries(input);
                    Console.WriteLine("Product of first {0} Fibonacci no is {1}", input, output);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPS, Expection Occured :( {0}",ex.Message);
            }
           
        }

        public static ulong FibonacciSeries(int n)
        {
            try
            {
                ulong prev = 0, cur = 1, pmul = 1, newm = 1;
                for (int i = 1; i < n; i++)
                {
                    ulong newv = prev + cur;
                    newm = newv * pmul;
                    pmul = newm;
                    prev = cur;
                    cur = newv;
                }
                return newm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
