abstract class Calisan
{
    public string Ad { get; set; }
    public string Pozisyon { get; set; }

    public abstract double MaasHesapla();

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Pozisyon: {Pozisyon}");
    }
}

class TamZamanli : Calisan
{
    public double AylikMaas { get; set; }

    public override double MaasHesapla()
    {
        return AylikMaas;
    }
}

class YariZamanli : Calisan
{
    public double SaatlikUcret { get; set; }
    public int CalismaSaati { get; set; }

    public override double MaasHesapla()
    {
        return SaatlikUcret * CalismaSaati;
    }
}

class FreelanceCalisan : Calisan
{
    public int ProjeSayisi { get; set; }
    public double ProjeBasinaUcret { get; set; }

    public override double MaasHesapla()
    {
        return ProjeSayisi * ProjeBasinaUcret;
    }
}

class Program
{
    static void Main()
    {
        TamZamanli x = new TamZamanli
        {
            Ad = "Nisa Malloç",
            Pozisyon = "Yazılım Geliştirici",
            AylikMaas = 20000.0
        };

        YariZamanli y = new YariZamanli
        {
            Ad = "Eda Balcı",
            Pozisyon = "Grafik Tasarımcı",
            SaatlikUcret = 30.0,
            CalismaSaati = 120
        };

        FreelanceCalisan z = new FreelanceCalisan
        {
            Ad = "Azra Baki",
            Pozisyon = "Mobil Geliştirici",
            ProjeSayisi = 2,
            ProjeBasinaUcret = 15000.0
        };

        Calisan[] calisanlar = { x, y, z };

        foreach (var c in calisanlar)
        {
            c.BilgileriYazdir();
            Console.WriteLine($"Maaş: {c.MaasHesapla()} TL\n");
        }
    }
}




//abstract class Calisan
//{
//    public string Ad { get; set; }
//    public string Pozisyon { get; set; }

//    public Calisan(string ad, string pozisyon)
//    {
//        Ad = ad;
//        Pozisyon = pozisyon;
//    }

//    public abstract double MaasHesapla();

//    public void BilgileriYazdir()
//    {
//        Console.WriteLine($"Ad: {Ad}, Pozisyon: {Pozisyon}");
//    }
//}

//class TamZamanli : Calisan
//{
//    public double AylikMaas { get; set; }

//    public TamZamanli(string ad, string pozisyon, double aylikMaas)
//        : base(ad, pozisyon)
//    {
//        AylikMaas = aylikMaas;
//    }

//    public override double MaasHesapla()
//    {
//        return AylikMaas;
//    }
//}

//class YariZamanli : Calisan
//{
//    public double SaatlikUcret { get; set; }
//    public int CalismaSaati { get; set; }

//    public YariZamanli(string ad, string pozisyon, double saatlikUcret, int calismaSaati)
//        : base(ad, pozisyon)
//    {
//        SaatlikUcret = saatlikUcret;
//        CalismaSaati = calismaSaati;
//    }

//    public override double MaasHesapla()
//    {
//        return SaatlikUcret * CalismaSaati;
//    }
//}

//class FreelanceCalisan : Calisan
//{
//    public int ProjeSayisi { get; set; }
//    public double ProjeBasinaUcret { get; set; }

//    public FreelanceCalisan(string ad, string pozisyon, int projeSayisi, double projeBasinaUcret)
//        : base(ad, pozisyon)
//    {
//        ProjeSayisi = projeSayisi;
//        ProjeBasinaUcret = projeBasinaUcret;
//    }

//    public override double MaasHesapla()
//    {
//        return ProjeSayisi * ProjeBasinaUcret;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        TamZamanli x = new TamZamanli("Nisa Malloç", "Yazılım Geliştirici", 20000.0);
//        YariZamanli y = new YariZamanli("Eda Balcı", "Grafik Tasarımcı", 30.0, 120);
//        FreelanceCalisan z = new FreelanceCalisan("Azra Baki", "Mobil Geliştirici", 2, 15000.0);

//        Calisan[] calisanlar = { x, y, z };

//        foreach (var c in calisanlar)
//        {
//            c.BilgileriYazdir();
//            Console.WriteLine($"Maaş: {c.MaasHesapla()} TL\n");
//        }
//    }
//}
