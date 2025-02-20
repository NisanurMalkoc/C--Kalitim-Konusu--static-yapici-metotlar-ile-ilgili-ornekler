using System;

class A
{
    static A()
    {
        Console.WriteLine("A sınıfının statik yapıcı metodu çalıştı.");
    }

    public A()
    {
        Console.WriteLine("A sınıfının instance yapıcı metodu çalıştı.");
    }
}

class B : A
{
    static B()
    {
        Console.WriteLine("B sınıfının statik yapıcı metodu çalıştı.");
    }

    public B()
    {
        Console.WriteLine("B sınıfının instance yapıcı metodu çalıştı.");
    }
}

class C : B  // C sınıfı B sınıfından türedi
{
    static C()
    {
        Console.WriteLine("C sınıfının statik yapıcı metodu çalıştı.");
    }

    public C()
    {
        Console.WriteLine("C sınıfının instance yapıcı metodu çalıştı.");
    }
}

class Program
{
    
    static void Main()
    {
        Console.WriteLine("Birinci nesne B sınıfından:");
        B b1 = new B();

        Console.WriteLine("\nBirinci nesne C sınıfından:");
        C c1 = new C();

        Console.WriteLine("\nİkinci nesne B sınıfından:");
        B b2 = new B();

        Console.WriteLine("\nİkinci nesne C sınıfından:");
        C c2 = new C();

        Console.WriteLine("\nÜçüncü nesne A sınıfından:");
        A a1 = new A();
    }
}
