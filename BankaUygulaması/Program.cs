using System;

namespace BankaUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 0;
            int[] hesap = new int[5];
            for (int i = 0; i < hesap.Length; i++)
            {
                Console.WriteLine(i + 1 + ".hesap bakiyesini gir");
                hesap[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < hesap.Length; i++)
            {
                Console.WriteLine(i + 1 + ".hesap bakiyesi :  " + hesap[i]);
            }
        BasaDon:
            Console.WriteLine("Bankamıza Hoşgeldiniz...");
            Console.WriteLine("Lütfen Yapacağınız İşlemi Seçiniz...");
            Console.WriteLine("1 - Hesap Bilgisi");
            Console.WriteLine("2 - Hesaplar Arası Havale");
            Console.WriteLine("3 - Para Çekme");
            Console.WriteLine("4 - Bakiyesi Bilinen Hesabı Bulma");

            int cevap = Convert.ToInt32(Console.ReadLine());
            switch (cevap)
            {
                case 1:
                    Console.WriteLine("Hesap Seç ( 1 - 2 - 3 - 4 - 5");
                    int hesapNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(hesapNo + " Numaralı Hesabın Bakiyesi : " + hesap[hesapNo - 1]);
                    goto BasaDon;
                case 2:
                    Console.WriteLine("Gönderen Hesabın Numarası : ");
                    int gonderen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Alıcı Hesap Numarası : ");
                    int alici = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Göndermek İstediğiniz Tutar : ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (hesap[gonderen - 1] - tutar < 0)
                    {
                        Console.WriteLine("Hesabın Bakiyesi Yetersiz.");
                    }
                    else
                    {
                        Console.WriteLine("Havale Başarılı.");
                        Console.WriteLine($"Gönderen Hesabın Bakiyesi : {hesap[gonderen - 1] - tutar} - Alıcı Hesabın Bakiyesi ={hesap[alici - 1] + tutar}");
                    }
                    Console.ReadKey();
                    goto BasaDon;
                case 3:
                    Console.WriteLine("Para Çekmek İstediğiniz Hesabı Seçiniz. (1-5)");
                    int secilen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Çekmek İstediğiniz Tutar : ");
                    int cekilenTutar = Convert.ToInt32(Console.ReadLine());
                    if (hesap[secilen-1] - cekilenTutar < 0)
                    {
                        Console.WriteLine("Yetersiz Bakiye!");
                    }
                    else
                    {
                        Console.WriteLine("Para Çekme Başarılı!");
                        Console.WriteLine($"Çekilen Tutar : {cekilenTutar} - Kalan Bakiye : {hesap[secilen - 1] - cekilenTutar}");

                    }
                    goto BasaDon;
                case 4:
                    Console.WriteLine("Bulmak İstediğiniz Hesabın Bakiyesini Girin: ");
                    int bulunanBakiye = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < hesap.Length; i++)
                    {
                        if (hesap[i] == bulunanBakiye)
                        {
                            Console.WriteLine($"Bakiyesi {bulunanBakiye} Olan Hesap No= {i + 1}");
                        }
                    }

                    Console.WriteLine("Arama Tamamlandı.");
                    goto BasaDon;
                    Console.ReadKey();
            }
        }
    }
}
