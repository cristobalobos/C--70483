using FuenteDeEventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumidorDeEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VARIABLES_REFERENCIA
            Coche c1 = new Coche();
            c1.Matricula = "Algo";
            Coche c2 = c1;
            c2.Matricula = "otra cosa";
            #endregion

            Coche utilitario = new Coche();
            utilitario.Matricula = "UTIL001";
            utilitario.LimiteVelocidad = 80;
            utilitario.Velocidad = 0;
            utilitario.VelocidadExcedida += Utilitario_VelocidadExcedida;
            Console.WriteLine("El coche esta parado");
            Console.WriteLine("El coche acelera");

            utilitario.VelocidadExcedida += PonerMulta;

            utilitario.Velocidad = 100;
            Console.WriteLine("Vamos deprisa");
            Console.ReadLine();
        }

        private static void Utilitario_VelocidadExcedida(object sender, ExcesoVelocidadEventArgs e)
        {
            Coche c = (Coche)sender;

            Console.WriteLine($"Velocidad excedida. Matricula {c.Matricula}");
        }

        static void PonerMulta(object sender, ExcesoVelocidadEventArgs e)
        {

            Console.WriteLine($"Hemos multado al conductor. Hora {e.HoraDeLaInfraccion}");
        }
    }
}
