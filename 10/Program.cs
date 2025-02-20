using System;

class A
{
    public A(string message)
    {
        Console.WriteLine($"A sınıfının yapıcı metodu çalıştı: {message}");
    }
}

class B : A
{
    public B(string message, int value) : base(message)
    {
        Console.WriteLine($"B sınıfının yapıcı metodu çalıştı: {value}");
    }
}

class C : B
{
    public C(string message, int value, double number) : base(message, value)
    {
        Console.WriteLine($"C sınıfının yapıcı metodu çalıştı: {number}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("C sınıfından nesne oluşturuluyor:");
        C c = new C("C'ye ait mesaj", 42, 3.14);
    }
}

