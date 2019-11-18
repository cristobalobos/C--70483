using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Fecha = DateTime.Now;
            EjemploPropiedades instancia = new EjemploPropiedades("APS");

            bool seguir = true;
            while (seguir)
            {


                Console.WriteLine(instancia);
                Console.WriteLine("Introduzca la nueva fecha a conservar: ");


                try
                {
                    Fecha = DateTime.Parse(Console.ReadLine());
                    instancia.Fecha = Fecha;
                    Console.WriteLine(instancia);
                    seguir = false;
                }
                catch (ArgumentNullException e) { Console.WriteLine("El dato no es una fecha valida"); }
                catch (FormatException e) { Console.WriteLine("El dato pasado pasado no es una fecha valida"); }
                catch (Exception e) { Console.WriteLine(e.Message); }

            }


            seguir = true;
            while (seguir)
            {

                try
                {




                    Console.WriteLine("Ingrese cuantos dias quiere sumarle a la fecha: ");
                    int dias = Convert.ToInt32(Console.ReadLine());

                    instancia.IncrementarFecha(dias);
                    Console.WriteLine(instancia);
                    seguir = false;
                }

                catch (ArgumentNullException e) { Console.WriteLine("El dato no es un numero valida"); }
                catch (FormatException e) { Console.WriteLine("El dato pasado pasado no es una numero valido"); }
                catch (Exception e) { Console.WriteLine(e.Message); }

            }
            Console.ReadKey();
        }
    }
}
