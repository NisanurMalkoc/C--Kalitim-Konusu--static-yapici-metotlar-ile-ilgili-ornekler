using System;

abstract class Tasit
{
    public int MevcutHiz { get; set; }
    public int MaxHiz { get; set; }
    public string Model { get; set; }

    // Yapıcı metot (Constructor)
    public Tasit(string model, int mevcutHiz, int maxHiz)
    {
        Model = model;
        MevcutHiz = mevcutHiz;
        MaxHiz = maxHiz;
    }

    public abstract void Hizlan(int artisMiktari);

    public void HiziGoster()
    {
        Console.WriteLine($"Model: {Model} şu an {MevcutHiz} km/s hızında.");
    }
}

class Araba : Tasit
{
    public Araba(string model, int mevcutHiz, int maxHiz)
        : base(model, mevcutHiz, maxHiz) { }

    public override void Hizlan(int artisMiktari)
    {
        MevcutHiz += artisMiktari;
        if (MevcutHiz > MaxHiz)
        {
            MevcutHiz = MaxHiz;
        }
        Console.WriteLine($"{Model} hızlanıyor! Yeni hız: {MevcutHiz} km/s");
    }
}

class Bisiklet : Tasit
{
    public Bisiklet(string model, int mevcutHiz, int maxHiz)
        : base(model, mevcutHiz, maxHiz) { }

    public override void Hizlan(int artisMiktari)
    {
        MevcutHiz += artisMiktari;
        if (MevcutHiz > MaxHiz)
        {
            MevcutHiz = MaxHiz;
        }
        Console.WriteLine($"{Model} pedal çeviriyor. Yeni hız: {MevcutHiz} km/s");
    }
}

class Ucak : Tasit
{
    public Ucak(string model, int mevcutHiz, int maxHiz)
        : base(model, mevcutHiz, maxHiz) { }

    public override void Hizlan(int artisMiktari)
    {
        MevcutHiz += artisMiktari;
        if (MevcutHiz > MaxHiz)
        {
            MevcutHiz = MaxHiz;
        }
        Console.WriteLine($"{Model} hızlanıyor! Yeni hız: {MevcutHiz} km/s");
    }
}

class Program
{
    static void Main()
    {
        // Nesneler oluşturulurken model, mevcut hız ve maksimum hız zorunlu olarak atanıyor.
        Araba x = new Araba("Mercedes", 100, 300);
        Bisiklet y = new Bisiklet("Porsche", 0, 100);
        Ucak z = new Ucak("BMW", 0, 900);

        Tasit[] tasitlar = { x, y, z };

        foreach (var t in tasitlar)
        {
            t.Hizlan(50);
            t.HiziGoster();
        }
    }
}

