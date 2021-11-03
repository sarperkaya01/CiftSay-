using System;

namespace CiftSayi
{
    class Program
    {
        static void ciftSayi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı Tektir.");
            }
            else
            {
                Console.WriteLine("Sayı çifttir");
            }
        }
        static void Main(string[] args)
        {
            bool kontrol = true;
            bool kontrol2 = true;

            while (kontrol)
            {

                Console.Write("Denemek istediğiniz sayı miktarını giriniz :");


                int a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                {
                    for (int i = 1; i <= a; i++)
                    {
                        Console.Write(i + ". " + "Sayıyı giriniz: ");
                        int b = int.Parse(Console.ReadLine());
                        ciftSayi(b);
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı negatif...");
                }
                while(kontrol2){Console.WriteLine("Tekrar işlem yapmak için A Tuşuna basın ya da çıkmak için Q tuşuna basın...");

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
                    kontrol2=false;
                }
                

                }
                
            }
        }
    }
}
