using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulleable
{
    class Program
    {/// <summary>
    /// Clase main
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {   
      
            int? numero = null;
            Nullable<int> numero2 = null;
            
            if (numero.HasValue == true)
            {
                System.Console.WriteLine("Valor del numero: "+ numero.Value);
            }
            else
            {
                System.Console.WriteLine("El numero contiene null");
            }

            //En este caso y se inicializa a 0

            int y = numero.GetValueOrDefault();
            Console.WriteLine($"El valor de y es: {y}");

            //en este caso se lanza una excepcion si Value es null

            try
            {
                y = numero2.Value;
            }catch(System.InvalidOperationException e){
                System.Console.WriteLine(e);
            }
            Console.ReadKey();

        }
    }
}
