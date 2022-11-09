

using static System.Net.Mime.MediaTypeNames;

Console.Title = "Hesap Makinesi V-1.0";
basaDon:;
Console.WriteLine("1. Toplama");
Console.WriteLine("2. Çıkarma");
Console.WriteLine("3. Çarpma");
Console.WriteLine("4. Bölme");
Console.WriteLine("5. Çıkış");
Console.WriteLine("Lütfen seçim yapınız :");

int gelenDeger = Convert.ToInt32(Console.ReadLine());


switch (gelenDeger)
{
    case 1:
        Console.Clear();
        Console.WriteLine("1. operantı giriniz :");
        int gelenToplamaOperant1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2. operantı giriniz :");
        int gelenToplamaOperant2 = Convert.ToInt32(Console.ReadLine());
        var result = gelenToplamaOperant1 + gelenToplamaOperant2;
        Console.WriteLine($"{gelenToplamaOperant1} + {gelenToplamaOperant2} = {result}");
        basa();
        goto basaDon;

        break;

    case 2:
        Console.Clear();
        Console.WriteLine("1. operantı giriniz :");
        int gelenCikarmaOperant1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2. operantı giriniz :");
        int gelenCikarmaOperant2 = Convert.ToInt32(Console.ReadLine());
        result = gelenCikarmaOperant1 - gelenCikarmaOperant2;
        Console.WriteLine($"{gelenCikarmaOperant1} - {gelenCikarmaOperant2} = {result}");
        basa();
        goto basaDon;
        break;

    case 3:
        Console.Clear();
        Console.WriteLine("1. operantı giriniz :");
        int gelenCarpmaOperant1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2. operantı giriniz :");
        int gelenCarpmaOperant2 = Convert.ToInt32(Console.ReadLine());
        result = gelenCarpmaOperant1 * gelenCarpmaOperant2;
        Console.WriteLine($"{gelenCarpmaOperant1} * {gelenCarpmaOperant2} = {result}");
        basa();
        goto basaDon;
        break;
    case 4:
        Console.Clear();
        Console.WriteLine("1. operantı giriniz :");
        decimal gelenBolmeOperant1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("2. operantı giriniz :");
        decimal gelenBolmeOperant2 = Convert.ToDecimal(Console.ReadLine());
        decimal decimalResult = gelenBolmeOperant1 / gelenBolmeOperant2;
        Console.WriteLine($"{gelenBolmeOperant1} / {gelenBolmeOperant2} = {decimalResult}");
        basa();
        goto basaDon;
        break;
    case 5:
        Environment.Exit(0);
        break;

    default:
        Console.Clear();
        Console.WriteLine("Hatalı seçim yaptınız");
        goto basaDon;
        break;


}



void basa()
{
    Console.WriteLine("Yeni bir işlem yapmak ister misiniz? (e/h)");
    string gelenCevap = Console.ReadLine();
    if (gelenCevap == "e" || gelenCevap == "E")
    {
        Console.Clear();
        
    }
    else if (gelenCevap=="h" || gelenCevap=="H")
    {
        Environment.Exit(0);
    }
}



