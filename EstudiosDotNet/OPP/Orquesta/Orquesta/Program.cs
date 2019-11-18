using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
    class Program
    {
        static Instrumento[] Orquesta = new Instrumento[25];

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WindowWidth = 120;
            Console.WindowHeight = 50;

            Console.Clear();

            InicializarOrquesta();
            TransportarInstrumentos();
            Afinar();
            Parar();
            ComenzarEjecucion(5, 5);
            ModificarVolumen(Superclase.Cuerda, 4);
            //ModificarTempo(SuperClase.Mano, 2);
           //ModificarTempo(Superclase.Baquetas, -2);
           Parar();

        }


        private static void InicializarOrquesta()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("**************************************");
            Console.WriteLine(" Iniciar la arquesta ");
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Orquesta[0] = new Violin("Primer Violin");
            Orquesta[1] = new Violin("Segundo Violin");
            Orquesta[2] = new Violin("Tercero Violin");
            Orquesta[3] = new Violin("Cuarto Violin");
            Orquesta[4] = new Violin("Quiento Violin");
            Orquesta[5] = new Violin("Sexto Violin");
            Orquesta[6] = new Chelo("Primer Chelo");
            Orquesta[7] = new Chelo("Segundo Chelo");
            Orquesta[8] = new Guitarra("Primera Guitarra");
            Orquesta[9] = new Guitarra("Segunda Guitarra");
            Orquesta[10] = new Contrabajo("Primer Contrabajo");
            Orquesta[11] = new Contrabajo("Segundo Contrabajo");
            Orquesta[12] = new Trompeta("Primera Trompeta");
            Orquesta[13] = new Trompeta("Segunda Trompeta");
            Orquesta[14] = new Trompeta("Tercera Trompeta");
            Orquesta[15] = new Trompeta("Cuarta Trompeta");
            Orquesta[16] = new Cuerno("Primer Cuerno");
            Orquesta[17] = new Cuerno("Segundo Cuerno");
            Orquesta[18] = new Timbal("Primer timbal");
            Orquesta[19] = new Timbal("Segundo timbal");
            Orquesta[20] = new Marimba("Primer Marimba");
            Orquesta[21] = new Piano("Primer paino");
            Orquesta[22] = new Clavicordio("Primer Clavicornio");
            Orquesta[23] = new Congas("Primera congas");
            Orquesta[24] = new Bongos("Primer bongos");

            mostrarEstadoOrquesta();

        }

        private static void mostrarEstadoOrquesta()
        {
            Console.WriteLine("********************** ESTADO *****************");
            Console.WriteLine("SITUADO    " + "AFINADO     " + "    INTEPRETADO      " + "VOLUMEN      " + "    TEMPO      " + "          NOMBRE      ");

            Console.WriteLine("========    " + " ============ " + " ============   " + " ============ " + " ============ " + "          ============ ");

            foreach (Instrumento instrumento in Orquesta)
            {
                string cadena;
                cadena = instrumento.Situado.ToString() + "\t" + "\t";
                cadena += instrumento.Afinando.ToString() + "\t" + "\t";
                cadena += instrumento.Interpretando.ToString() + "\t" + "\t";
                cadena += instrumento.Volumen.ToString() + "\t" + "\t";
                cadena += instrumento.Tempo.ToString() + "\t" + "\t";
                cadena += instrumento.Nombre;
                Console.WriteLine(cadena);
            }
            Console.ReadKey();

        }



        private static void TransportarInstrumentos()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*************************************");
            Console.WriteLine(" Transportamos los instrumentos que requieran ");

            Console.WriteLine("*************************************");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            foreach (Instrumento instrumento in Orquesta)
            {
                if ((instrumento) is Itransportar)
                {
                    Itransportar transportable = (Itransportar)instrumento;
                    transportable.transportar();
                }
            }
            mostrarEstadoOrquesta();//Mostramos en pantalla el estado actual

        }


        private static void Afinar()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************");
            Console.WriteLine(" Afinamos los instrumentos ");
            Console.WriteLine("*********************************");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (Instrumento instrumento in Orquesta)
            {
                instrumento.Afinar();
            }

            mostrarEstadoOrquesta();


        }


        private static void Parar()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************");
            Console.WriteLine(" Paramos la interpretacion de los instrumento ");
            Console.WriteLine("*********************************");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (Instrumento instrumento in Orquesta)
            {
                instrumento.Parar();
            }

            mostrarEstadoOrquesta();


        }


        public static void ComenzarEjecucion(int tempo, int volumen)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************");
            Console.WriteLine(" Comenzamos la ejecución ");
            Console.WriteLine("*********************************");


            foreach (Instrumento instrumento in Orquesta)
                instrumento.Intepretar(tempo, volumen);
            mostrarEstadoOrquesta();

        }

        /// <summary>
        /// Modificamos el volumen de ciertos intrumento
        /// </summary>
        /// <param name="tipo">Un enumero Superclase para identificar para la superclase</param>
        /// <param name="modificar">La cantidaden que vamos a variar el volumen</param>
        public static void ModificarVolumen(Superclase tipo, int modificar)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************");
            Console.WriteLine(" Modificar el volumen ");
            Console.WriteLine("*********************************");


            foreach (Instrumento instrumento in Orquesta)
            {
                switch (tipo)
                {
                    case Superclase.Baquetas:
                        if ((instrumento) is Baquetas) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Teclas:
                        if ((instrumento) is Teclas) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Mano:
                        if ((instrumento) is Mano) instrumento.Tempo = modificar;
                        break;
                    case Superclase.ConArco:
                        if ((instrumento) is ConArco) instrumento.Tempo = modificar;
                        break;
                    case Superclase.SinArco:
                        if ((instrumento) is SinArco) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Timbal:
                        if ((instrumento) is Timbal) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Bongos:
                        if ((instrumento) is Bongos) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Chelo:
                        if ((instrumento) is Chelo) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Clavicordio:
                        if ((instrumento) is Clavicordio) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Cuerno:
                        if ((instrumento) is Cuerno) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Guitarra:
                        if ((instrumento) is Guitarra) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Trompeta:
                        if ((instrumento) is Trompeta) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Percusión:
                        if ((instrumento) is Percusion) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Cuerda:
                        if ((instrumento) is Cuerda) instrumento.Tempo = modificar;
                        break;
                    case Superclase.Viento:
                        if ((instrumento) is Viento) instrumento.Tempo = modificar;
                        break;




                }
            }

        }



    }

}


