using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscribiryLeerArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string carpeta = SolitarCarpeta();

            // Solicitamos al usuario la carpeta de destino
            if (carpeta == null)
            {
                return;
            }

            // Generemos al nombre del archivo para las pruebas

            string archivo = Path.Combine(carpeta, "Pruebas.txt");

            //Generemos un texto para insertarlo
            string[] lineas = CrearTexto();

            //Concatenamos los elementos para obtener un unico texto

            string texto = "";

            foreach (string linea in lineas)
                texto += linea;

            //Escribir un archivo un texto único

            EscribirTexto(archivo, texto);

            Console.WriteLine("\n Lectura del archivo escrito como un único texto");
            Console.WriteLine("\n ***********************************************");

            string[] lineasLeidas = File.ReadAllLines(archivo);

            foreach (string linea in lineasLeidas)
                Console.WriteLine(linea);

            //Escribimos lineas seleccionadas

            EscribirCondicional(archivo, lineas);
            //leemos y mostramos lo escrito
            Console.WriteLine("\n Lectura del archivo escrito como lineas condicionales");
            Console.WriteLine("\n ***********************************************");

            string[] lineasLei2 = File.ReadAllLines(archivo);

            foreach (string linea in lineasLeidas)
                Console.WriteLine(linea);

            //Añadimos lineas al archivo

            AñadirLineas(archivo, lineas);
            Console.WriteLine("\n Lectura del archivo, despues de añadirle lineas ");
            Console.WriteLine("***************************************************");


            //realizamos un bucle de lectura diferente

            int contador = 0;
            string lineaLeida = "";

            using (StreamReader archivoLeido = new StreamReader(archivo))
            {
                while ((lineaLeida = archivoLeido.ReadLine()) != null)
                {

                    ++contador;
                    Console.WriteLine($"Linea : {contador}, \t {lineaLeida}");
                }
            }

            Console.WriteLine("\n Pulse cualquier tecla para finalizar ......");
            Console.ReadLine();
        }

        static string SolitarCarpeta()
        {
            while (true)
            {
                Console.WriteLine("Por favor indique la ruta de la carpeta con la desea trabajar");
                string carpeta = Console.ReadLine();
                if (carpeta == "")
                {
                    Console.WriteLine("Si se deja el nombre de la carpeta en blanco se cancelara el proceso. Pulse Intro de nuevo para cancelar");

                    carpeta = Console.ReadLine();
                    if (carpeta == "")
                    {
                        return null;
                        
                    }
                    else
                    {
                        if (Directory.Exists(carpeta))
                            return carpeta;
                        else
                            Console.WriteLine("La ruta introducida no existe en el sistema reintentalo");

                    }
                }



            }

        }

        static string[] CrearTexto()
        {
            string[] lineas = { " En un lugar de la Mancha, de cuyo nombre no quiero acordarme, no ha mucho tiempo que vivía un hidalgo de los de lanza en astillero, adarga antigua, rocín flaco y galgo corredor. Una olla de algo más vaca que carnero, salpicón las más noches, duelos y quebrantos los sábados, lantejas los viernes, algún palomino de añadidura los domingos, consumían las tres partes de su hacienda. El resto della concluían sayo de velarte,"
                    , "calzas de velludo para las fiestas, con sus pantuflos de lo mesmo, y los días de entresemana se honraba con su vellorí de lo más fino. Tenía en su casa una ama que pasaba de los cuarenta, y una sobrina que no llegaba a los veinte, y un mozo de campo y plaza, que así ensillaba el rocín como tomaba la podadera. Frisaba la edad de nuestro hidalgo con los cincuenta años; era de complexión recia, seco de carnes, enjuto de rostro, "
                    , "gran madrugador y amigo de la caza. Quieren decir que tenía el sobrenombre de Quijada, o Quesada, que en esto hay alguna diferencia en los autores que deste caso escriben; aunque, por conjeturas verosímiles, se deja entender que se llamaba Quejana. Pero esto importa poco a nuestro cuento; basta que en la narración dél no se salga un punto de la verdad." };

            return lineas;
        }

        static void EscribirTexto(string archivo, string texto)
        {
            //Escribimos una linea de caracteres en el archivo
            File.WriteAllText(archivo, texto);
        }

        static void EscribirLineas(string archivo, string[] lineas)
        {
            //Escribimos una linea de caracteres en el archivo
            File.WriteAllLines(archivo, lineas);
        }

        static void EscribirCondicional(string archivo, string[] lineas)
        {

            using (StreamWriter salida = new StreamWriter(archivo))
            {
                foreach (string linea in lineas)
                {
                    if (linea.Contains("hidalgo"))
                    {
                        salida.WriteLine(linea);
                    }
                }

            }
        }

        static void AñadirLineas(string archivo, string[] lineas)
        {
            //añadimos texto al archivo

            using (StreamWriter salida = new StreamWriter(archivo, true))
            {
                salida.WriteLine();
                salida.WriteLine("\t \t Texto Añadido");
                salida.WriteLine("\t \t--------------");
                salida.WriteLine();

                foreach (string linea in lineas)
                {
                    salida.WriteLine(linea);
                }


            }
        }
    }
}
