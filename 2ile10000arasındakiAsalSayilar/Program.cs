
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ile10000arasındakiAsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> asalSayilar = new List<int>(); //asal sayıların tutulacağı koleksiyon oluşturuldu
            bool asalMi = true; // flag oluşturuldu
            for (int sayi = 2; sayi < 10000 ; sayi++) // ilk döngü 2 ile 10.000 arasındaki sayılar içindir
            {
                for (int bolen = 2; bolen < sayi; bolen++) // ikinci döngü sayinin asal olup olmadığını bulmak içindir
                {
                    asalMi = true; // eğer sayı 'bolen' değeri ile tam bölünmüyorsa asal sayıdır bu nedenle flag değeri true
                    if (sayi % bolen == 0)
                    {
                        asalMi = false; //eğer sayı 'bolen' değeri ile tam bölünüyorsa asal sayı değildir bu nedenle flag değeri false
                        break;
                    }
                    
                }

                if(asalMi) // flag değeri true olan yani asal sayılar bu karar yapısına girecektir
                {
                    asalSayilar.Add(sayi); // asal sayılar oluşturduğumuz koleksiyona ekleniyor
                }
            }

            Console.WriteLine("Aşağıdaki sayılar 2 ile 10000 arasındaki asal sayılardır.");
            foreach (int i in asalSayilar) // koleksiyon içinde bulunan asal sayılar ekrana yazdırılıyor
            {
                Console.Write(i+",");
            }
            Console.ReadKey();
        }
    }
}
