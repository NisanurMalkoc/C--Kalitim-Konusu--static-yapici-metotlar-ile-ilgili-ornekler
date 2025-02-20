using System;

class A
{
    public A(string message)
    {
        Console.WriteLine($"A sınıfının instance yapıcı metodu çalıştı: {message}");
    }
}

class B : A
{
    public B(string message, int value) : base(message)
    {
        Console.WriteLine($"B sınıfının instance yapıcı metodu çalıştı: {value}");
    }
}

class C : A
{
    public C(string message, double number) : base(message)
    {
        Console.WriteLine($"C sınıfının instance yapıcı metodu çalıştı: {number}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("B sınıfından nesne oluşturuluyor:");
        B b = new B("B'ye ait mesaj", 42);

        Console.WriteLine("\nC sınıfından nesne oluşturuluyor:");
        C c = new C("C'ye ait mesaj", 3.14);
    }
}
