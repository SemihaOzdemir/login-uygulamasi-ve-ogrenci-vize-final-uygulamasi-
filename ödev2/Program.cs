using System;

namespace ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV2:KULLANICIDAN ÖĞRENCİ SAYISI İSTENECEK. ÖĞRENCİ SAYISI KADAR VİZE VE FİNAL NOTLARI İSTENECEK.ÖĞRENCİ ORTALAMASI BULUNACAK.
            //1)EN YÜKSEK ORTALAMAYI BULUN
            //2)EN DÜŞÜK ORTALAMAYI BULUN
            //3)GENEL ORTALAMAYI BULUN

            // 1,2,3 maddeleri eksik.


            Console.WriteLine("lütfen öğrenci sayısını giriniz.");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            double enb = 0;
            double enk = 100;
            double genelort = 0;
            double toplam = 0;


            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"lütfen {i + 1} . öğrencinin vize notunu giriniz.");
                int vize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"lütfen {i + 1} . öğrencinin final notunu giriniz.");
                int final = Convert.ToInt32(Console.ReadLine());

                double ort = (vize * 0.4) + (final * 0.6);

                if(ort>enb)
                {
                    enb=ort;
                }
                if(ort<enk)
                {
                    enk=ort;
                }

                toplam += ort;
            }


            genelort = toplam / n;
            Console.WriteLine($"en yüksek ortalama= {enb}");
            Console.WriteLine($"en düşük ortalama= {enk}");
            Console.WriteLine($"genel ortalama= {genelort}");



            Console.ReadKey();
        }


    }
}
