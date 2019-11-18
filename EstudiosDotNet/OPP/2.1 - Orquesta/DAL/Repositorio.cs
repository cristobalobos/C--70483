using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDatos;

namespace DAL
{
   public class Repositorio
    {
        // Instanciamos la orquesta, a este nivel para que esté disponible para todo el código
        static List<Instrumento> Orquesta= new List<Instrumento>();

        public List<Instrumento> InicializarOrquesta()
        {
            Orquesta.Add(new Violin("Primer Violin"));
            Orquesta.Add(new Violin("Segundo Violin"));
            Orquesta.Add(new Violin("Tercer Violin"));
            Orquesta.Add(new Violin("Cuarto Violin"));
            Orquesta.Add(new Violin("Quinto Violin"));
            Orquesta.Add(new Violin("Sexto Violin"));
            Orquesta.Add(new Cello("Primer Cello"));
            Orquesta.Add(new Cello("Segundo Cello"));
            Orquesta.Add(new Guitarra("Primera Guitarra"));
            Orquesta.Add(new Guitarra("segunda Guitarra"));
            Orquesta.Add(new Contrabajo("Primer Contrabajo"));
            Orquesta.Add(new Contrabajo("Segundo Contrabajo"));
            Orquesta.Add(new Trompeta("Primera Trompeta"));
            Orquesta.Add(new Trompeta("Segunda Trompeta"));
            Orquesta.Add(new Trompeta("Tercera Trompeta"));
            Orquesta.Add(new Trompeta("Cuarta Trompeta"));
            Orquesta.Add(new Cuerno("Primer Cuerno"));
            Orquesta.Add(new Cuerno("Segundo Cuerno"));
            Orquesta.Add(new Timbal("Primer Timbal"));
            Orquesta.Add(new Timbal("Segundo Timbal"));
            Orquesta.Add(new Marimba("Marimba"));
            Orquesta.Add(new Piano("Piano"));
            Orquesta.Add(new Clavicordio("Clave"));
            Orquesta.Add(new Conga("Congas"));
            Orquesta.Add(new Bongo("Bongos"));

            return Orquesta;

        }


        //public static Instrumento[] InicializarOrquesta() {
        //    //MostrarTítulo(" Inicializamos la orquesta");
        //    //MostrarEstadoOrquesta(); //Mostramos en pantalla el estado actual
        //}


    }
}
