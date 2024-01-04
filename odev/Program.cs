int easy1;
int medium;
int hard;
int kolay;
int orta;
int zor;
int skor = 148;
Random rnd_kolay = new Random();
kolay = rnd_kolay.Next(1, 9);
Console.WriteLine("MERHABA! OYUNA HOŞ GELDİN. BU OYUNDA SENİ BELİRLİ BİR SAYI ARALIĞINDA AKLIMDAN TUTTUĞUM SAYIYI BULABİLECEK MİSİN ONU DENEYECEĞİZ . BİRAZ KOLAYDAN BAŞLAYALIM. SIRASIYLA: KOLAY-ORTA-Zor");
do
{
    Console.WriteLine("1 İLE 9 ARASINDA BİR RAKAM SEÇİNİZ.");
    easy1 = Convert.ToInt32(Console.ReadLine());
    if (easy1 == kolay)
    {
        Console.WriteLine("AFERİn! DOĞRU CEVAP ŞİMDİ SEVİYE ATLADIN YENİ SEVİYEDE ZORLUK : ORTA");
        Random rnd_orta = new Random();
        orta = rnd_orta.Next(1,18 );
        do
        {
            Console.WriteLine("1 İLE 18 ARASI BİR SAYI VEYA RAKAM SEÇİNİZ : ");
           medium = Convert.ToInt32(Console.ReadLine());
            if (medium == orta)
            {
                Console.WriteLine("DOĞRU BİLDİN. SEVİYE ATLADIN. YENİ SEVİYE ZORLUĞU: ZOR");
                Random rnd_zor = new Random();
                zor = rnd_zor.Next(1, 23);

                do
                {
                    Console.WriteLine("1 İLE 23 ARASI RAKAM VEYA SAYI SEÇİMİ YAPINIZ: ");
                    hard = Convert.ToInt32(Console.ReadLine());
                    if (hard == zor)
                    {
                        Console.WriteLine("DOĞRUUU... OYNADIĞIN İÇİN TEŞEKKÜRLER. SKORUN : " + skor);
                        skor = 0;
                    }

                    else
                    {
                        skor -= 6;
                        Console.WriteLine("CEVABINIZ YANLIŞ, HER YANLIŞ TAHMİNİNİZDE 6 PUAN SİLİNECEKTİR. ŞU AN PUANINIZ : " + skor);
                    }
                } while (skor != 0);
            }

            else
            {
                skor -= 8;
                Console.WriteLine("MORALİNİ BOZMA DAHA ŞANSIN VAR. HER YANLIŞ TAHMİNİNDE 8 PUAN SİLİNECEK VE DAHA PUANIN BU KADAR DAHA VAR  : " + skor);
            }

        } while (skor != 0);

    }

    else
    {
        skor -= 12;
        Console.WriteLine("YANLIŞ CEVAP, DAHA BURADA BÖYLE YANLIŞ CEVAPLAR VERMEYE BAŞLADIYSAN İŞİN ÇOK ZOR. HER YANLIŞ TAHMİNDE 12 PUAN SİLİNECEK VE ŞİMDİDEN ŞU KADAR PUANIN VAR : " + skor);
    }

} while (skor != 0); 