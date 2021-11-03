using System;

namespace TamBolen
{
    class Program
    {
        static void deger(int n)//m değerine işlem uygulayacağım metot n tekrar sayım...
        {
            int x = int.Parse(Console.ReadLine());

            if (n % x == 0 || n == x)
            {
                Console.WriteLine(x + " " + n + " sayısının tam bölenidir ");
                Console.WriteLine(n + " mod " + x + " = " + (n % x));
            }
            else
            {
                Console.WriteLine(x + " " + n + " sayısının tam böleni değildir ");
                Console.WriteLine(n + " mod " + x + " = " + (n % x));
            }
        }
        static void Main(string[] args)
        {
            bool kontrol = true;
            bool kontorl2= true;

            while (kontrol)
            {
                Console.Write("Sınamak istediğiniz sayı belirleyiniz :");//m
                int m = int.Parse(Console.ReadLine());
                Console.Write("Kaç kez Sınamak istediğinizi giriniz :");//n
                int a = Convert.ToInt32(Console.ReadLine());

                if (a > 0 && m > 0)
                {
                    for (int i = 1; i <= a; i++)
                    {
                        Console.Write(i + ". " + "Sayıyı giriniz: ");

                        deger(m);

                    }
                }


                else
                {
                    Console.WriteLine("Girdiğiniz sayı/sayılar negatif...");
                }
                while(kontrol2)
                {
                    Console.WriteLine("Tekrar işlem yapmak için A Tuşuna basın ya da çıkmak için Q tuşuna basın...");

                    string q = Console.ReadLine();
                    if (q == "a")
                    {
                        kontrol = true;
                        kontrol2 = false;


                    }
                    else if (q == "q")
                    {
                        kontrol = false;
                        kontrol2= false;
                    }
                    else{
                        Console.WriteLine( "Yanlış bir tuşlama yaptınız"  );
                        kontrol2=true;
                    }
                

                }
            }
        }
    }
}
