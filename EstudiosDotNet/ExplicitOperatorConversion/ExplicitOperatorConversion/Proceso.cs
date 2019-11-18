using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitOperatorConversion
{
    class Proceso
    {
        static void Main(string[] args)
        {
            int prueba = 33;
            UnaClase resultado = (UnaClase)prueba;
            Console.WriteLine(resultado);
            Console.ReadLine();

        }
    }
}
