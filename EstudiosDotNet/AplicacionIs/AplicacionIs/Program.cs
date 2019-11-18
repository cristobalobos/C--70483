using System;
 
namespace AplicacionIs
{
    
    class Program
    {

        class ClaseA { }
        class ClaseB { }
        class ClaseC : ClaseB { }

        class Principal
        {
            static void Prueba(object o)
            {
                ClaseA a;
                ClaseB b;

                if (o is ClaseA)
                {
                    Console.WriteLine("El objeto es Clase A");
                    a = (ClaseA)o;
                }
                else

                if (o is ClaseB)
                {
                    Console.WriteLine("El objeto es Clase B");
                    b = (ClaseB)o;
                }
                else
                { Console.WriteLine("El objeto no es A ni B"); }
            }

            static void Main(string[] args)
            {
                ClaseA c1 = new ClaseA();
                ClaseB c2 = new ClaseB();
                ClaseC c3 = new ClaseC();

                Prueba(c1);
                Prueba(c2);
                Prueba(c3);
                Prueba("Una cadena");
                Console.ReadLine();

            }
        }
    }
}
