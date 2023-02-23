using System;

namespace CA_BakiyeislemleriAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] users = { "fatih", "meric", "emre", "eren" };
            string[] passwords = { "1234", "4321", "159753", "789321" };
            string[] islemler = { "", "bakiye görüntüle", "para yatır", "para çek","işlemi sonlandır" };

            string loginUser = "";
            string loginPassword = "";
            bool isAuthencited = false;
            int bakiye = 500;
            int secenek;
            int tutar;

            try
            {
                Console.WriteLine("kullanıcı adı: ");
                loginUser = Console.ReadLine();


                foreach (string user in users)
                {
                    if (user == loginUser)
                    {
                        Console.WriteLine("şifre: ");
                        loginPassword = Console.ReadLine();
                        foreach (string password in passwords)
                        {
                            if (loginPassword == password)
                            {
                                isAuthencited = true;

                            }
                            

                        }
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adı veya şifre hatalı");
                        return;
                    }
                    
                }
                if (isAuthencited)
                {
                    Console.WriteLine($"Hoşgeldin {loginUser}!");
                    Console.WriteLine($"Bakiyeniz {bakiye}");


                }
                for (int i = 1; i < islemler.Length; i++)
                {

                    Console.WriteLine($"{i} : {islemler[i]}");

                }
                while (true)
                {

                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine($"Bakiyeniz {bakiye}");
                    secenek = Convert.ToInt32(Console.ReadLine());
                    if (secenek == 1)
                    {
                        Console.WriteLine($"Bakiyeniz {bakiye}");
                    }
                    else if (secenek == 2)
                    {
                        Console.WriteLine("Yatırılacak tutarı girin");
                        tutar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"yeni bakiyeniz  :{bakiye += tutar}");

                    }
                    else if (secenek == 3)
                    {
                        Console.WriteLine("Çekilecek tutarı girin");
                        tutar = Convert.ToInt32(Console.ReadLine());

                        if (tutar > bakiye)
                        {
                            Console.WriteLine("Bakiyeniz yetersiz");
                            Console.ReadLine();

                        }
                        else if (bakiye >= tutar)
                        {
                            Console.WriteLine($"yeni bakiyeniz  :{bakiye -= tutar}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("İşleminiz sonlandırıldı");
                        break;
                    }

                }
            }
            catch 
            {
                Console.WriteLine("Böyle bir kullanıcı veya şifre yok");
                
            }
            
            
        }
    }
}
