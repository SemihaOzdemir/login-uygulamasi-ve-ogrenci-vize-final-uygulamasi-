using System;

namespace ödev_20211107
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖDEV1: ÖRNEKTE OLDUĞU GİBİ KULLANICI ADI ADMİN VE ŞİFRE 123 İSE HOŞGELDİN ADMİN MESAJI VERİLECEK. EĞER KULLANICI BİLGİLERİ HATALI GİRERSE
            //KULLANICIYA 3 ADET HAK VERİLECEK. 3 KERE YANLIŞ GİRERSEDE UYGULAMA SONLANDIRILACAK.PERŞEMBE 24:00'E KADAR GÖNDERİLECEK.GİTHUB ÜZERİNDEN.LİNKİ HOCAYA AT.

            //ÖDEV2:KULLANICIDAN ÖĞRENCİ SAYISI İSTENECEK. ÖĞRENCİ SAYISI KADAR VİZE VE FİNAL NOTLARI İSTENECEK.ÖĞRENCİ ORTALAMASI BULUNACAK.
            //1)EN YÜKSEK ORTALAMAYI BULUN
            //2)EN DÜŞÜK ORTALAMAYI BULUN
            //3)GENEL ORTALAMAYI BULUN

            int hak_sayisi = 3;

            while(true)
            {
                Console.WriteLine("kullanıcı adınızı giriniz.");
                string kullaniciadi = Console.ReadLine();

                Console.WriteLine("şifrenizi giriniz.");
                string sifre = Console.ReadLine();

                if (kullaniciadi=="admin" && sifre=="123")
                {
                    Console.WriteLine("hoşgeldin admin");
                    break;
                }
                else
                {
                    Console.WriteLine("kullanıcı adınız veya şifreniz hatalı!");

                    if (hak_sayisi>0)
                    {
                        hak_sayisi -= 1;
                    }
                    if (hak_sayisi==0)
                    {
                        Console.WriteLine("hakkınız dolmuştur.Erişim izniniz iptal edilmiştir.");
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
