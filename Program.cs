using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        public static string[] list = new string[5];
        public static int[] harfsayisi = new int[5];
        public static int[] karaktersayisi = new int[5];
        public static int[] Adres = new int[5];
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {

                Console.Write("Kelime Giriniz:");
                list[i] = Console.ReadLine();

            }
            HarfSayisi();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Girilen Kelimeler ve Harf Sayıları:");
            for (int sayac = 0; sayac < list.Length; sayac++)
            {
                Console.WriteLine("{0}) {1}, {2} harflidir.", sayac + 1, list[sayac], harfsayisi[sayac]);
            }
            KarakterSayisi();
            Adresleme();
            Sıralama();
            Console.ReadKey();


        }
        static void HarfSayisi()
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != null)
                {
                    int h0 = Convert.ToInt32(list[i].Length);
                    harfsayisi[i] = h0;
                }
            }

        }
        static void KarakterSayisi()
        {

            for (int i = 0; i < list.Length; i++)
            {
                int toplam = 0, toplam2 = 0;
                char i_harf = Convert.ToChar(list[i][0]);
                char s_harf = Convert.ToChar(list[i][Convert.ToInt32(list[i].Length - 1)]);
                Console.WriteLine("{0} Harfi İçin:", i_harf);
                String[] ilkharf = Array.FindAll(list, element => element.StartsWith(i_harf.ToString(), StringComparison.Ordinal)); //ilk harf için ilk harflere bakıyor.
                String[] sonharf = Array.FindAll(list, element => element.EndsWith(i_harf.ToString(), StringComparison.Ordinal)); //ilk harf için son harflere bakıyor.
                String[] s_sonharf = Array.FindAll(list, element => element.EndsWith(s_harf.ToString(), StringComparison.Ordinal)); //son karakter için son karaktere bakıyor.
                foreach (string a in ilkharf)
                    Console.WriteLine(a);
                foreach (string b in sonharf)
                    Console.WriteLine(b);
                Console.WriteLine("{0} Harfi İçin:", s_harf);
                foreach (string c in s_sonharf)
                    Console.WriteLine(c);
                toplam = ilkharf.Length + sonharf.Length;
                toplam2 = s_sonharf.Length;
                Console.WriteLine((i_harf, "Bu Harfin Toplamı:", toplam));
                Console.WriteLine((s_harf, "Bu Harfin Toplamı:", toplam2));
                karaktersayisi[i] = toplam + toplam2;
                Console.WriteLine((list[i], "için toplam puan:", karaktersayisi[i]));
                Console.WriteLine("********************************************************************************");



            }

            Console.WriteLine("Toplam Puanlar:");
            for (int i = 0; i < karaktersayisi.Length; i++)
            {

                Console.WriteLine((list[i], karaktersayisi[i]));
            }
            Console.WriteLine("********************************************************************************");
        }

        static void Sıralama() {
          

            Console.WriteLine("Puana Göre Sıralama:");
            Array.Sort(karaktersayisi);
            Array.Reverse(karaktersayisi);


            for (int i = 0; i < karaktersayisi.Length; i++)
            {

                Console.WriteLine(karaktersayisi[i]);
            }
           
        }
        static void Adresleme()
            {
            Console.WriteLine("Adresler:");
            for (int i = 0; i < list.Length; i++)
                {
                    Adres[i] = karaktersayisi[i] + harfsayisi[i];
                    Console.WriteLine((list[i],Adres[i]));

                }
            Console.WriteLine("********************************************************************************");
        }


       
    }
}