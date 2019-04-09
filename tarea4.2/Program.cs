using System;
using System.Collections.Generic;

/*
2.2.- El error era el punto (D) ya que no puedo crear un objeto de una clase abstracta.

2.1.-   El metodo Afina ya que este no regresa un valor fijo como Display que siempre regresa el nombre.

2.3.- No se ponen llaver en (B) debido a que solo esta declarando que se hara Afina debido a que es una clase abstracta y le heredara ese 
metodo a otras clases, se debe usar cuando se tenga claro que dato va a regresar.

2.5.- Tenemos que ponerle llaves y declararle un dato que deba regresar.*/


interface Musico
{
    void Afina();
    string Display();
}
/* 
abstract class Musico
{
    public string nombre;
    public Musico(string n)
    {
        nombre = n;
    }

    public abstract void Afina();
    public string Display()
    {
        return nombre;
    }
}
*/
class Bajista : Musico
{
    public string nombre;
    public string instrumento;
    public Bajista(string n, string i)
    {
        this.nombre = n;
        instrumento = i;
    }

    public void Afina()
    {
        Console.WriteLine("Afinado");
    }
        public string Display()
    {
        return nombre;
    }

}

class Guitarrista : Musico
{
    public string nombre;
    public string instrumento;
    public Guitarrista(string n, string i)
    {
        this.nombre = n;
        instrumento = i;
    }

    public void Afina()
    {
        Console.WriteLine("Afinado");
    }

    public string Display()
    {
        return nombre;
    }
    
}

class Program
{
     static void Main(string[] args)
    {
        
        Bajista b = new Bajista("Flea","Bajo");
        Guitarrista g = new Guitarrista("Santana","guitarra");

        List<Musico>Musicos = new List<Musico>();
        Musicos.Add(b);
        Musicos.Add(g);

        foreach (Musico p in Musicos)
        {
            Console.WriteLine(p.Display());
        }

    }
}