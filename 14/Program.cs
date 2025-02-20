using System;
class A
{
    virtual public void Metot()
    {
        Console.WriteLine("A sınıfı");
    }
}
class B : A
{
    override public void Metot()
    {
        Console.WriteLine("B sınıfı");
    }
    static void Main()
    {
        A nesneA = new A();
        B nesneB = new B();
        nesneA = nesneB;
        nesneA.Metot();
    }
}
