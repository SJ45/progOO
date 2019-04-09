using System;
/*
1.1. Regresa un objeto.

1.2. Regresa un string.

1.3. Virtual

 */
class A
{
    public int a;
    public A()
    {
        a = 10;
    }

    public virtual string Display()
    {
        return a.ToString();
    }
}

class B : A
{
    public int b;

    public B() : base()
    {
        b = 15;
    }

    public override string Display()
    {
        return b.ToString();
    }
    // #########################################
    //  #  Después de contestar la pregunta 1                  
    //   #  Redefine el método Display( ) en este espacio,  debe regresar el campo b como string.
    //  #########################################
}

class Program
{
    public static void Main()
    {
        A objA = new A();
        B objB = new B();
        Console.WriteLine(objA.Display()); // (1)
        Console.WriteLine(objB.Display()); // (2)
    }
}