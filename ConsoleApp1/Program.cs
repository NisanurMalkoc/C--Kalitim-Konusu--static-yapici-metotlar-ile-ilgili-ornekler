using System;

class A
{
    static A()
    {
        Console.WriteLine("A sınıfının static yapıcı metodu çalıştı.");
    }

    public A()
    {
        Console.WriteLine("A sınıfının static olmayan yapıcı metodu çalıştı.");
    }
}

class B : A
{
    static B()
    {
        Console.WriteLine("B sınıfının static yapıcı metodu çalıştı.");
    }

    public B()
    {
        Console.WriteLine("B sınıfının static olmayan yapıcı metodu çalıştı.");
    }
}

class C : A
{
    static C()
    {
        Console.WriteLine("C sınıfının static yapıcı metodu çalıştı.");
    }

    public C()
    {
        Console.WriteLine("C sınıfının static olmayan yapıcı metodu çalıştı.");
    }
}

class Program
{
    static void Main()
    {
        A nesne1 = new C();
        Console.WriteLine();

        A nesne2 = new B();
        Console.WriteLine();

        C nesne3 = new C();
    }
}
