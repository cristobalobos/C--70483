using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
    class Program
    {
        // Instanciamos la orquesta, a este nivel para que esté disponible para todo el código
        static List<Instrumento> Orquesta;

        public static void Main() {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WindowWidth = 120;
            Console.WindowHeight = 58;
            Console.Clear();
            InicializarOrquesta();                      // Generamos las instancias para rellenar la colección
            TransportarInstrumentos();                  // Transportamos al escenario todos los instrumentos que lo requieran
            Afinar();                                   // Afinamos toda la orquesta
            Parar();                                    // Paramos toda la orquesta
            ComenzarEjecucion(5, 5);                    // Comenzamos a tocar con tempo 5 y volumen 5
            ModificarVolumen(Superclase.Cuerda, 4);     // Subimos en cuatro puntos el volumen de todos los instrumentos de cuerda
            ModificarTempo(Superclase.Mano, 2);         // Subimos en dos puntos el volumen de todos los instrumentos de percusión a mano
            ModificarTempo(Superclase.Baquetas, -2);    // Bajamos en dos puntos el volumen de todos los instrumentos que usen baquetas
            Parar();
        }

        private static void InicializarOrquesta() {
            MostrarTítulo(" Inicializamos la orquesta");
            Orquesta[0] = new Violin("Primer Violin");
            Orquesta[1] = new Violin("Segundo Violin");
            Orquesta[2] = new Violin("Tercer Violin");
            Orquesta[3] = new Violin("Cuarto Violin");
            Orquesta[4] = new Violin("Quinto Violin");
            Orquesta[5] = new Violin("Sexto Violin");
            Orquesta[6] = new Cello("Primer Cello");
            Orquesta[7] = new Cello("Segundo Cello");
            Orquesta[8] = new Guitarra("Primera Guitarra");
            Orquesta[9] = new Guitarra("segunda Guitarra");
            Orquesta[10] = new Contrabajo("Primer Contrabajo");
            Orquesta[11] = new Contrabajo("Segundo Contrabajo");
            Orquesta[12] = new Trompeta("Primera Trompeta");
            Orquesta[13] = new Trompeta("Segunda Trompeta");
            Orquesta[14] = new Trompeta("Tercera Trompeta");
            Orquesta[15] = new Trompeta("Cuarta Trompeta");
            Orquesta[16] = new Cuerno("Primer Cuerno");
            Orquesta[17] = new Cuerno("Segundo Cuerno");
            Orquesta[18] = new Timbal("Primer Timbal");
            Orquesta[19] = new Timbal("Segundo Timbal");
            Orquesta[20] = new Marimba("Marimba");
            Orquesta[21] = new Piano("Piano");
            Orquesta[22] = new Clavicordio("Clave");
            Orquesta[23] = new Conga("Congas");
            Orquesta[24] = new Bongo("Bongos");

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
        /// 
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="modificador"></param>
        private static void TransportarInstrumentos()
        {
            MostrarTítulo(" Transportamos los instrumentos que lo requieren");

            foreach (Instrumento instrumento in Orquesta)
                if ((instrumento) is ITransportar) 
                {
                    ITransportar transportable = (ITransportar)instrumento;
                    transportable.Transportar();
                }
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }  
        
        /// <summary>
        /// Rutina para mostrar el estado de la orquesta en un momento determinado
        /// </summary>
        private static void MostrarEstadoOrquesta()  {
            Console.WriteLine("**********************************  E S T A D O  O R Q U E S T A  ****************************************************");
            Console.WriteLine("SITUADO      " + "AFINANDO     " + "INTERPRETANDO     " + "VOLUMEN        " + "TEMPO         " + "NOMBRE              ");
            Console.WriteLine("===========  " + "===========  " + "================  " + "=============  " + "============  " + "==================  ");
            Console.WriteLine();
            foreach(Instrumento instrumento in Orquesta) {
                string cadena;
                cadena = instrumento.Situado.ToString() + "\t" + "\t";
                cadena += instrumento.Afinando.ToString() + "\t" + "\t";
                cadena += instrumento.Interpretando.ToString() + "\t" ;
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
        
        /// <summary>
        /// Afinamos los instrumentos de la orquesta
        /// </summary>
        /// <remarks></remarks>
        private static void Afinar()  {
            MostrarTítulo(" Afinamos los instrumentos");
            foreach (Instrumento instrumento in Orquesta)
                instrumento.Afinar();
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }  
 
        /// <summary>
        /// Paramos todos los instrumentos de la orquesta
        /// </summary>
        /// <remarks></remarks>
        private static void Parar()
        {
            MostrarTítulo(" Paramos la interpretación o afinación");
            foreach (Instrumento instrumento in Orquesta)
                instrumento.Parar();
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }

        /// <summary>
        /// Comenzamos la ejecución de todos los instrumentos de la orquesta
        /// </summary>
        /// <param name="tempo">El tempo general de todos los instrumentos</param>
        /// <param name="volumen">El volumen general de todos los instrumentos</param>
        /// <remarks></remarks>
        private static void ComenzarEjecucion(int tempo, int volumen)  {
            MostrarTítulo(" Comenzamos a interpretar");
            foreach (Instrumento instrumento in Orquesta)
                instrumento.Interpretar(tempo, volumen);
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }  
 
        /// <summary>
        /// Modificamos el volumen de ciertos instrumentos
        /// </summary>
        /// <param name="tipo">Un enumerador Superclase para identificar la superclase a la que queremos modificar</param>
        /// <param name="modificador">La cantidad en la que vamos a variar el volumen, puede ser positivo o negativo</param>
        /// <remarks></remarks>
        private static void ModificarVolumen(Superclase tipo, int modificador)  {
            MostrarTítulo(" Modificamos el volumen");

            foreach (Instrumento instrumento in Orquesta) {
                switch (tipo)
                {
                    case Superclase.Baquetas:
                        if ((instrumento) is Baquetas) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Teclas:
                        if ((instrumento) is Teclas) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Mano:
                        if ((instrumento) is Mano) instrumento.Volumen = modificador;
                        break;
                    case Superclase.ConArco:
                        if ((instrumento) is ConArco) instrumento.Volumen = modificador;
                        break;
                    case Superclase.SinArco:
                        if ((instrumento) is SinArco) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Percusion:
                        if ((instrumento) is Percusion) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Cuerda:
                        if ((instrumento) is Cuerda) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Viento:
                        if ((instrumento) is Viento) instrumento.Volumen = modificador;
                        break;
                }
            }
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }  
 
        /// <summary>
        /// Modificamos el tempo de ciertos instrumentos
        /// </summary>
        /// <param name="tipo">Un enumerador Superclase para identificar la superclase a la que queremos modificar</param>
        /// <param name="modificador">La cantidad en la que vamos a variar el tempo, puede ser positivo o negativo</param>
        /// <remarks></remarks>
        private static void ModificarTempo(Superclase tipo, int modificador)  {
            MostrarTítulo(" Modificamos el tempo");
            foreach (Instrumento instrumento in Orquesta)
            {
                switch(tipo) {
                    case Superclase.Baquetas:
                        if ((instrumento) is Baquetas) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Teclas:
                        if ((instrumento) is Teclas) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Mano:
                        if ((instrumento) is Mano) instrumento.Tempo = modificador;
                        break;
                    case Superclase.ConArco:
                        if ((instrumento) is ConArco) instrumento.Tempo = modificador;
                        break;
                    case Superclase.SinArco:
                        if ((instrumento) is SinArco) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Percusion:
                        if ((instrumento) is Percusion) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Cuerda:
                        if ((instrumento) is Cuerda) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Viento:
                        if ((instrumento) is Viento) instrumento.Tempo = modificador;
                        break; 
                }
            }
            MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        }  
    }
}
