using System;

namespace CA_sayisalLotoAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] sayiDizisi = new int[6];

            Console.WriteLine("Sayısal Loto");
            for (int i = 0; i < 6; i++)
            {


                int rastgele = rnd.Next(1, 50);
                sayiDizisi[i] = rastgele;
                for (int z = 0; z < i; z++)
                {
                    if (sayiDizisi[z] == sayiDizisi[i])
                    {
                        i--;
                        continue;
                    }
                }



            }
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }

        }
    }

