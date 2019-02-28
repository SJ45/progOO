2.1 Declaración de clases: atributos, métodos, encapsulamiento.
 
Una estructura es un shortcut a lo que sería un objeto, por ejemplo “p” puede ser una referencia a un objeto llamado “persona”.
 
Una clase es una forma de agrupar los datos que comparten una similitud, por ejemplo si creamos una clase llamada “persona”, en esa clase se ponen los atributos y acciones que puede hacer una persona.
 
Una estructura es una plantilla que se puede utilizar para cualquier proceso del programa, se puede usar para 2 acciones diferentes en donde cada será independiente de la otra.
 
La encapsulación es un método de seguridad para asegurarse que la información que utilizamos en nuestra clase está protegida.
 
Miembros, todos los métodos, campos, constantes, propiedades y eventos deben declararse dentro de un tipo; se les denomina miembros del tipo.
 
Accesibilidad
Son los modificadores de acceso public, protected, internal, protected internal, private y private protected los cuales se usan para cifrar la información de alguna forma o dejarla pública. 



Herencia
Son un tipo de clase en donde se les heredan los datos principales de otra clase y estos pueden ser utilizados en la clase heredada sin necesidad de escribirlos de nuevo en código.

Tipos estáticos
Las clases (pero no las estructuras) pueden declararse como static. Una clase estática puede contener solo miembros estáticos y no se puede crear una instancia de ellos con la palabra clave new. Una copia de la clase se carga en memoria cuando se carga el programa, y sus miembros son accesibles a través del nombre de clase. Las clases y estructuras pueden contener miembros estáticos. 

Tipos anidados
Una clase o estructura se puede anidar dentro de otra clase o estructura. 

Tipos parciales
Puede definir parte de una clase, estructura o método en un archivo de código y otra parte en un archivo de código independiente. 

Inicializadores de objeto
Puede crear instancias de objetos de clase o estructura y de colecciones de objetos e inicializarlos, sin llamar de forma explícita a su constructor. 
 
Tipos anónimos
En situaciones donde no es conveniente o necesario crear una clase con nombre, por ejemplo al rellenar una lista con estructuras de datos que no tiene que conservar o pasar a otro método, utilice los tipos anónimos.
Métodos de extensión.
Puede "extender" una clase sin crear una clase derivada mediante la creación de un tipo independiente cuyos métodos pueden llamarse como si pertenecieran al tipo original.
 
 
2.2 Instanciación de una clase.
Operador new
Se utiliza para crear objetos o invocar constructores, también es usado para crear instancias de tipos anónimos.
 
En la clase de POO lo estamos utilizando para invocar el método constructor por default de una clase para crear un objeto.
 
 
2.3 Referencia al objeto actual. 
  La palabra clave this hace referencia a la instancia actual de la clase.
Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares.
Escribe un programa donde se utilice this como parámetro.



2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.
Programa: Referencia
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
2.5 Constructores y destructores: declaración, uso y aplicaciones.
Los constructores 
Es el procedimiento que se hace al iniciar la clase, principalmente se utiliza para verificar que los datos estén completos y sean correctos. También llevan el mismo nombre de la clase.
En caso de las clases static, se hace un constructor público a través del compilador.
Para los datos struct se genera un constructor automáticamente por el compilador.
 
Tanto las clases como las structs pueden definir constructores que acepten parámetros. Se debe llamar a constructores que toman parámetros a través de una instrucción new o base.
 
2.6 Sobrecarga de métodos.
En el programa de la 2.7 está documentado en el código como utilizo lo que debe ir en esta parte.
 

2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.
Programa: Dado
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