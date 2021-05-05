using System;

namespace BilanganFibonacciKonsepArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibo = new int[0];
            int bilangan;
            Console.Write("Jumlah Suku Bilangan Fibonacci = ");
            bilangan = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < bilangan; i++)
            {
                Array.Resize(ref fibo, fibo.Length + 1);
                if (i == 0 || i == 1)
                {
                    fibo[i] = 1;
                    Console.Write(fibo[i] + " ");

                }

                else
                {
                    fibo[i] = fibo[i - 2] + fibo[i - 1];
                    Console.Write(fibo[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}

 