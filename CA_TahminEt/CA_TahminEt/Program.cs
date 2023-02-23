using System;

namespace CA_TahminEt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tutulanSayi = rnd.Next(1, 10);
            int tahminEdilenSayi = 0;
            int tahminHak = 5;
            int seviye = 1;
            int seviyeCarpan = 10;
            while (true)
            {
                try
                {
                     
                    if (tahminHak > 0)
                    {
                        Console.WriteLine($"**tutulan sayı:{tutulanSayi}**");
                        Console.WriteLine("bir sayı girin: ");
                        tahminEdilenSayi = int.Parse(Console.ReadLine());
                        if (tutulanSayi == tahminEdilenSayi)//bilinmesi durumunda
                        {
                            Console.WriteLine("TEBRİKLER DOĞRU TAHMİN!");
                            seviye++;
                            Console.WriteLine($"seviye {seviye}");
                            tutulanSayi = rnd.Next(1, seviye*seviyeCarpan+1);
                           
                            tahminHak = 5;
                            Console.WriteLine($"tahmin hakkı: {tahminHak}");
                        }
                        else if (tahminEdilenSayi < tutulanSayi)//küçük tahmin edilmesinde
                        {
                            Console.WriteLine("daha büyük bir sayı girin: ");
                            tahminHak--;
                            Console.WriteLine($"Tahmin hak: {tahminHak}");
                        }
                        else if (tahminEdilenSayi > tutulanSayi)//büyük tahmin edilmesinde
                        {
                            Console.WriteLine("daha küçük bir sayı girin: ");
                            tahminHak--;
                            Console.WriteLine($"Tahmin hak: {tahminHak}");
                        }
                    }
                    else//tahmin hakkı bittiğinde
                    {
                        Console.WriteLine("tahmin hakkınız bitti. oyuna devam edemezsiniz!");
                        break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}

