﻿using System;

namespace KelimeSayisiBulma
{
    class Program
    {
        static void harf(string metin)
        {
            
            int space = 0;
            int noktalama =0 ;
            for (int i = 0; i < metin.Length; i++)
            {
                
                if (metin[i].ToString() == " ")// metindeki boşluklar karakter olacağı için harf gibi işlem görmesini istemiyorum...
                {
                    space++;                    
                }
                if (metin[i].ToString()=="."|| metin[i].ToString() == "," || metin[i].ToString() == "!" || metin[i].ToString() == "?" || metin[i].ToString() == "'" )//noktalama işaretlerni harf olarak lamasını istemiyorum
                {
                    
                    noktalama ++;
                    
                }
                
            }
            Console.WriteLine("Cümledeki kelime sayısı : "+(space+1));//son boşluktan sonraki kelimeyi de dahil edersem cümledeki toplam kelime sayısını bulurum
            Console.WriteLine("Metindeki harf sayısı : " + (metin.Count()-space-noktalama));

        }
        static void Main(string[] args)
        {
            bool kontrol = true;
            bool kontrol2= true;
             while (kontrol)
             {
                Console.WriteLine("Cümle Giriniz:");
                string cumle = Console.ReadLine();
                ;
                harf(cumle);
                                
                
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
