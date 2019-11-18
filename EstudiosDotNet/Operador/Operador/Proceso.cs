using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador
{
    class Proceso
    {
        static void Main(string[] args)
        {
            UnaClase primera = new UnaClase("Primera", 100);
            UnaClase segunda = new UnaClase("Segunda", 222);

            Console.WriteLine(primera + segunda);

            Console.WriteLine(primera + primera);
            Console.ReadKey();


        }


        public class UnaClase
        {
            private string _nombre;
            private int _cantidad;

            public UnaClase(string nombre, int cantidad)
            {
                _nombre = nombre;
                _cantidad = cantidad;
            }

            public static UnaClase operator +(UnaClase a, UnaClase b)
            {
                a._nombre += " Incrementada ";
                a._cantidad += b._cantidad;
                return a;
            }

            public override string ToString()
            {
                return "Nombre: " + _nombre + " , Cantidad" + _cantidad;
            }

        }


    }
}
