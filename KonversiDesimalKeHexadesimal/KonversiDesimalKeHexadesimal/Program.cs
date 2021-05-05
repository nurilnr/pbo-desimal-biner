using System;

namespace KonversiDesimalKeHexadesimal
{
    class Program
    {
         static void Main(string[] args)
         {
            int desimal, quotient;
            int x = 1, y, temp = 0;
            char[] hexadesimal = new char[100];
            char temp1;
            Console.WriteLine("Bilangan Desimal : ");
            desimal = int.Parse(Console.ReadLine());
            quotient = desimal;
            while (quotient != 0)
            {
                temp = quotient % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = + 55;
                temp1 = Convert.ToChar(temp);
                hexadesimal[x++] = temp1;
                quotient = quotient / 16;
            }
            Console.Write("Hasil Hexadesimal : ");
            for (y = x - 1; y > 0; y--)
                Console.Write(hexadesimal[y]);
            Console.ReadLine();


        }
    }
}
