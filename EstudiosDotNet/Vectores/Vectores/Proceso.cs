using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class Proceso
    {

        static void Main(string[] args)
        {
            int elementos = 0;
            string nombre = "vector";

            Console.WriteLine("Introduzca elementos a generar: ");
            

            if (Int32.TryParse(Console.ReadLine(), out elementos))
            {
                //cremos una instancia de clase , pasandole el numero de elementos a crear

                MiVector<string> Vector = new MiVector<string>(elementos, nombre);
                //alimentamos el contenido del vector
                for (int i = 0; i < elementos;) Vector[i] = "Elementos: " + ++i;
                //mostramos el contenido del Vector
                Console.WriteLine("En la instancia: {0} ", Vector.Nombre);
                foreach (string cadena in Vector) Console.WriteLine(cadena);

            }
            else Console.WriteLine("El dato introducido no es correcto");

            Console.ReadLine();

        }


    }
}
