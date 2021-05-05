using System;

namespace BilanganPrimaArray
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Masukkan Batas Bilangan Prima : ");

			bool prima = true;

			int bilangan = int.Parse(Console.ReadLine());

			Console.WriteLine("Bilangan Primanya adalah: ");

			if (bilangan >= 2)
			{
				for (int i = 2; i <= bilangan; i++)
				{
					for (int j = 2; j < i; j++)
					{
						if ((i % j) == 0)
						{
							prima = false;
							break;
						}
					}

					if (prima)
						Console.Write(i + " ");
					prima = true;
				}
			}
			else
				Console.WriteLine("Tidak ada bilangan prima yang bisa dituliskan");
			Console.ReadLine();
		}


	}
    
}
