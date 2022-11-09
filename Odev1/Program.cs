
#region 1.	Size göre en doğru döngüyü kullanarak ekranda 10 kez Merhaba yazan uygulamayı geliştirin.

//Console.WriteLine("10 kere merhaba yazan uygulama");
//byte yazdır = 1;
//while (yazdır <= 10)
//{
//    Console.WriteLine("Merhaba");
//    yazdır++;
//}
#endregion

#region 2.	Kullanıcıdan alacağı değeri ekrana 5 kez yazdıran uygulamayı geliştirin.

//Console.WriteLine("Gelen değeri 5 kere yazdıran uygulama");
//Console.WriteLine("Değer Girin: ");
//string gelenDeger = Console.ReadLine();
//int yazdır1 = 1;
//Console.Clear();
//while (yazdır1 <= 5)
//{
//    Console.WriteLine(yazdır1 + "-" + gelenDeger);
//    yazdır1++;
//}
#endregion


#region 3.	0 – 10 aralığındaki (0 ve 10 dahil) tüm sayıların toplamını hesaplayıp ekrana yazan uygulamayı geliştirin
//Console.WriteLine("0 – 10 aralığındaki (0 ve 10 dahil) tüm sayıların toplamını hesaplayıp ekrana yazan uygulama");
//int a = 0;
//for (int i = 1; i <= 10; i++)
//{
//    a = a + i;

//}
//Console.WriteLine("Toplam : " + a);
#endregion



#region 4.	0 dan başlayarak kullanıcıdan alacağınız sayıya kadar ki tüm sayıların toplamını bulan uygulamayı geliştirin
//Console.WriteLine("0 dan başlayarak kullanıcıdan alacağınız sayıya kadar ki tüm sayıların toplamını bulan uygulama");
//Console.WriteLine("Sayı giriniz : ");
//int gelenDeger1 = Convert.ToInt32(Console.ReadLine());
//Console.Clear();


//for (int i = gelenDeger1; i > 0; i--)  // i >= 0; i--) olunca neden 14 çıkıyor. 0-1= -1 olduğu için mi
//{
//    gelenDeger1 = gelenDeger1 + (i - 1);
//}
//Console.WriteLine(gelenDeger1);
#endregion


#region 5.	Kullanıcıdan alınan sayının tek ya da çift olduğunu bulup ekrana “Tek” ya da “Çift” yazan uygulamayı geliştirin.

//Console.WriteLine("Tek veya Çift Tam Sayı Giriniz");
//int gelenDeger2 = Convert.ToInt32(Console.ReadLine());
//if (gelenDeger2%2==0)
//{
//    Console.WriteLine($"{gelenDeger2} çift sayıdır");
//}
//else
//{
//    Console.WriteLine($"{gelenDeger2} tek sayıdır");
//}

#endregion


#region 6.	Kullanıcıdan alınan sayıya kadar ki tek ve çift sayıların toplamını alarak ayrı ayrı ekrana yazan uygulamayı geliştirin.

//Console.WriteLine("Sayı giriniz : ");
//int gelenDeger3 = Convert.ToInt32(Console.ReadLine());
//Console.Clear();


//int ciftSayiToplam = 0;
//int tekSayitoplam = 0;

//for (int i = gelenDeger3; i >= 0; i--)
//{
//    if (i %2==0)
//    {
//        ciftSayiToplam = ciftSayiToplam + i;
//        //ciftSayiToplam += i;
//    }
//    else
//    {
//        tekSayitoplam = tekSayitoplam + i;

//    }
//}

//Console.WriteLine($"Çift sayılar toplamı {ciftSayiToplam}");
//Console.WriteLine($"Tek sayılar toplamı {tekSayitoplam}");

#endregion

#region  7.	Kullanıcıdan 10 adet sayı alan ve bu sayıların 50 den küçük olanlarının TOPLAMINI bulup ekrana yazan uygulamayı geliştirin

//int ellidenKucukToplam = 0;
//int ellidenBuyukToplam = 0;
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{i} .  sayıyı giriniz : ");
//	int gelenDeger4 = Convert.ToInt32(Console.ReadLine());
//	if (gelenDeger4<50)
//	{
//		ellidenKucukToplam += gelenDeger4;
//	}
//	else
//	{
//		ellidenBuyukToplam += gelenDeger4;
//	}

//}
//Console.Clear();
//Console.WriteLine($" 50 den küçük sayılar toplamı : {ellidenKucukToplam}");
//Console.WriteLine($" 50 den büyük sayılar toplamı : {ellidenBuyukToplam}");

#endregion

#region  7.	Kullanıcıdan 10 adet sayı alan ve bu sayıların 50 den küçük olanlarının SAYISINI bulup ekrana yazan uygulamayı geliştirin

//int ellidenKucuk = 0;
//int ellidenBuyuk = 0;
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{i} .  sayıyı giriniz : ");
//    int gelenDeger4 = Convert.ToInt32(Console.ReadLine());
//    if (gelenDeger4 < 50)
//    {
//        ellidenKucuk++;
//    }
//    else
//    {
//        ellidenBuyuk++;
//    }

//}
//Console.Clear();
//Console.WriteLine($" 50 den küçük sayılar adedi : {ellidenKucuk}");
//Console.WriteLine($" 50 den büyük sayılar adedi : {ellidenBuyuk}");

#endregion

#region 8.	Kullanıcıdan kaç tane sayıyı toplamak istediğini alan sonrasında toplanacak sayı adedi kadar sayıyı kullanıcıdan tek tek alıp bu sayıların toplamını ekrana yazan programı geliştirin

Console.WriteLine("Kaç Sayı toplamak istersiniz : ");
int kacSayi = Convert.ToInt32(Console.ReadLine());
int toplamGelen = 0;
Console.Clear();
for (int i = 1; i <= kacSayi; i++)
{
    Console.WriteLine($"{i} . sayıyı girin");
    int toplamGelen1=Convert.ToInt32(Console.ReadLine());
    toplamGelen += toplamGelen1;

}
Console.WriteLine($"Toplam gelen sayı toplamı : {toplamGelen}");


#endregion




