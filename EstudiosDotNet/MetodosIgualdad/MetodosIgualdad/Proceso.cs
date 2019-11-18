    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosIgualdad
{
    class Proceso
    {
        static void Main(string[] args)
        {
            Prueba a = new Prueba(1, "Hola");
            Prueba b = new Prueba(1, "Hola");
            bool areEqual = System.Object.ReferenceEquals(a, b);

            System.Console.WriteLine("Las referencias de a y b son iguales = {0}", areEqual);

            System.Console.WriteLine("Las valores de a y b son iguales = {0}", a.Equals(b));

            System.Console.WriteLine(a == b);

            b = a;

            areEqual = System.Object.ReferenceEquals(a, b);

            System.Console.WriteLine("Las referencias de a y b son iguales = {0}",areEqual);

            Console.ReadKey();
            
        }
    }
}
