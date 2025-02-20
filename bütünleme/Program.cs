using System;
class A
{
    static A()
    {
        Console.WriteLine("A sınıfının statik yapıcı metodu");
    }
    public A()
    {
        Console.WriteLine("A sınıfının statik olmayan yapıcı metodu");
    }
}
class B : A
{
    static B()
    {
        Console.WriteLine("B sınıfının statik yapıcı metodu");
    }
    public B()
    {
        Console.WriteLine("B sınıfının statik olmayan yapıcı metodu");
    }
}
class Ana
{
    static void Main()
    {
        B b1 = new B();
        Console.WriteLine("-------");
        B b2 = new B();
    }
}
