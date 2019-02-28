using System;

namespace Dado
{
    class Dado
    {
        private int valor;
        public string color;

    // Constructor
    public Dado(int valor, string color)
    {
        this.valor = valor;
        this.color = color;
    }
    
    // Constructor sobrecargado
    public Dado()
    {
        valor = 0;
        color = "";
    }

    // Operador < sobrecargado
    public static bool operator <(Dado a, Dado b)
    {
        return (a.valor < b.valor);
    }

    // Operador > sobrecargado
    public static bool operator >(Dado a, Dado b)
    {
        return (a.valor > b.valor);
    }

    // Operador == sobrecargado
    public static bool operator ==(Dado a, Dado b)
    {
        return (a.valor == b.valor);
    }        

    // Operador !=sobrecargado
    public static bool operator !=(Dado a, Dado b)
    {
        return (a.valor != b.valor);
    }

    } // fin clase dado
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea un objeto llamando al constructor de la clase dado.
            Dado a = new Dado(8,"Azul");
            Dado b = new Dado(8,"Rojo");
            Dado c = new Dado(8,"Verde");

            // validaciones
            if(a == b && b == c){
                Console.WriteLine("Todos los dados son iguales");
            }
            else
            {
                if(a == b)
                {
                    Console.WriteLine("El dado " + a.color + " es igual al dado " + b.color);
                }
                else
                {
                    if(a == c)
                    {
                        Console.WriteLine("El dado " + a.color + " es igual al dado " + c.color);
                    }
                    else
                    {
                        if(b == c)
                        {
                            Console.WriteLine("El dado " + b.color + " es igual al dado " + c.color);
                        }
                    }
                }
                
                if(a > b)
                {
                    if(a > c)
                    {
                        Console.WriteLine("El dado " + a.color + " es el mayor");
                    }
                    else
                    {
                        Console.WriteLine("El dado " + c.color + " es el mayor");        
                    }
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine("El dado " + b.color + " es el mayor");
                    }
                    else
                    {
                        Console.WriteLine("El dado " + c.color + " es el mayor");
                    }
                }
            }
          
        }
    }
}
