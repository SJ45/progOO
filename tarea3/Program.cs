using System;
using System.Collections.Generic;
/* 
Clase Base: Es la clase que se utiliza para dar una herencia a otra.
Clase Derivada: es la clase que hereda de la clase base propiedades y datos de ella.

Herencia Simple: Cuando se hereda a 1 clase solamente.
Herencia Multiple: Cuando se puede heredar a multiples clases.

Base: Se usa para llamar al metodo que esta de la clase base.
*/
namespace tarea3
{
    class Vector2d
    {
        public int x, y;
        //Constructor
        public Vector2d(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}", x, y);
        }
    }

    // Clase Base
    class Figura
    {
        public Vector2d position;
        public string fill ,border;

        //Constructor 
        public Figura():this( new Vector2d(100, 100))
        {
        
        }
        //Sobrecarga
        public Figura(Vector2d pos)
        {
            position= pos;
            fill= "white";
            border= "black";
        }

        public virtual void Dibuja()
        {
            Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
        }
    }


    // Clase Derivada
    class Circulo : Figura
    {
     private int radio;

    //Constructor
     public Circulo(Vector2d pos, int radio):base(pos)
     {
         this.radio= radio;
     }
     //Sobrecarga
     public Circulo ():base()
     {
         this.radio= 10;
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
     }
    }
 
     // Clase Derivada
    class Rectangulo : Figura
    {
     
    //Constructor
     public Rectangulo(Vector2d pos):base(pos)
     {
         
     }

     //Sobrecarga
     public Rectangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}", position, fill);
     }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(new Vector2d(150,150),11));
            figuras.Add(new Rectangulo(new Vector2d(200,200) ));
            foreach(Figura f in figuras)
            f.Dibuja();
           
        }
    }
}