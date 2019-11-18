using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using ModeloDatos;

namespace UIConsola
{
    class Program
    {
        static List<Instrumento> Orquesta;
        static void Main(string[] args)
        {
            Negocio negocio = new Negocio();

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WindowWidth = 120;
            Console.WindowHeight = 58;
            Console.Clear();
            
            Orquesta = negocio.InicializarOrquesta();
            TransportarInstrumentos();//  Generamos las instancias para rellenar la colección
            Afinar();                                   // Afinamos toda la orquesta
            ComenzarEjecucion(5, 5);                    // Comenzamos a tocar con tempo 5 y volumen 5
            ModificarVolumen(Superclase.Cuerda, 4);     // Subimos en cuatro puntos el volumen de todos los instrumentos de cuerda
            ModificarTempo(Superclase.Mano, 2);         // Subimos en dos puntos el volumen de todos los instrumentos de percusión a mano
            ModificarTempo(Superclase.Baquetas, -2);    // Bajamos en dos puntos el volumen de todos los instrumentos que usen baquetas
            Parar();

        }

        /// <summary>
        /// Paramos todos los instrumentos de la orquesta
        /// </summary>
        /// <remarks></remarks>
        private static void Parar()
        {
            Negocio negocio = new Negocio();
            MostrarTítulo(" Paramos la interpretación o afinación");
            negocio.Parar();
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }


        /// <summary>
        /// Afinamos los instrumentos de la orquesta
        /// </summary>
        /// <remarks></remarks>
        private static void Afinar()
        {
            Negocio negocio = new Negocio();
            MostrarTítulo(" Afinamos los instrumentos");
            negocio.Afinar();
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }

        private static void MostrarTítulo(string título)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine(título);
            Console.WriteLine("**********************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }

        /// <summary>
        /// Rutina para mostrar el estado de la orquesta en un momento determinado
        /// </summary>
        private static void MostrarEstadoOrquesta()
        {
            Console.WriteLine("**********************************  E S T A D O  O R Q U E S T A  ****************************************************");
            Console.WriteLine("SITUADO      " + "AFINANDO     " + "INTERPRETANDO     " + "VOLUMEN        " + "TEMPO         " + "NOMBRE              ");
            Console.WriteLine("===========  " + "===========  " + "================  " + "=============  " + "============  " + "==================  ");
            Console.WriteLine();
            foreach (Instrumento instrumento in Orquesta)
            {
                string cadena;
                cadena = instrumento.Situado.ToString() + "\t" + "\t";
                cadena += instrumento.Afinando.ToString() + "\t" + "\t";
                cadena += instrumento.Interpretando.ToString() + "\t";
                cadena += instrumento.Volumen + "\t" + "\t";
                cadena += instrumento.Tempo + "\t" + "\t";
                cadena += instrumento.Nombre;
                Console.WriteLine(cadena);
            }
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void TransportarInstrumentos()
        {
            MostrarTítulo(" Transportamos los instrumentos que lo requieren");

            Negocio negocio = new Negocio();
            negocio.TransportarInstrumentos();
            
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }


        /// <summary>
        /// Comenzamos la ejecución de todos los instrumentos de la orquesta
        /// </summary>
        /// <param name="tempo">El tempo general de todos los instrumentos</param>
        /// <param name="volumen">El volumen general de todos los instrumentos</param>
        /// <remarks></remarks>
        private static void ComenzarEjecucion(int tempo, int volumen)
        {
            Negocio negocio = new Negocio();
            MostrarTítulo(" Comenzamos a interpretar");
            negocio.ComenzarEjecucion(tempo, volumen);
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }

        private static void ModificarVolumen(Superclase tipo, int modificador)
        {
            Negocio negocio = new Negocio();
            MostrarTítulo(" Modificamos el volumen");
            negocio.ModificarVolumen(tipo, modificador);
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }

        /// <summary>
        /// Modificamos el tempo de ciertos instrumentos
        /// </summary>
        /// <param name="tipo">Un enumerador Superclase para identificar la superclase a la que queremos modificar</param>
        /// <param name="modificador">La cantidad en la que vamos a variar el tempo, puede ser positivo o negativo</param>
        /// <remarks></remarks>
        private static void ModificarTempo(Superclase tipo, int modificador)
        {
            Negocio negocio = new Negocio();
            MostrarTítulo(" Modificamos el tempo");

            negocio.ModificarTempo(tipo, modificador);

            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }

    }
}
