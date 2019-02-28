using System;

namespace Referencia
{

    class Miembro
    {
        public string nombre;

    public Miembro(string nombre)
    {
        this.nombre = nombre;
    }

    public void imprime()
    {
        Console.WriteLine("Mi nombre es " + nombre);
    }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Miembro  m = new Miembro("Johann");
            m.imprime();
        }
    }
}
