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

			int[] arr = new int[9999];

			int counter = 0;

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
					{
						arr[counter] = i;
						counter++;
					}
					prima = true;
				}
				Console.Write("AAAAAAAAAAA"+counter);
				for (int i = 0; i < counter; i++)
				{
					Console.Write(arr[i] + " ");
				}
			}
			else
				Console.WriteLine("Tidak ada bilangan prima yang bisa dituliskan");
			Console.ReadLine();
		}


	}
    
}
