using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{

    /// <summary>
    /// Primer nivel de herencia
    /// </summary>
    public abstract class Cuerda : Instrumento
    {
        public override void Afinar()
        {
            Afinando = true;
        }

        public Cuerda(string nombre) : base(nombre) { }
    }


    public abstract class ConArco: Cuerda
    {
        public ConArco(string nombre) : base(nombre)  { }   
    }
    public abstract class SinArco : Cuerda
    {
        public SinArco(string nombre) : base(nombre) { }
    }

    public class Violin : ConArco
    {
        public Violin(string nombre) : base(nombre) { }
    }

    public class Chelo : ConArco, Itransportar
    {
        public Chelo(string nombre) : base(nombre) { Situado = false; }

        public void transportar()
        {
            Situado = true; 
        }
   }

    public class Guitarra : SinArco
    {
        public Guitarra(string nombre) : base(nombre) { }
    }

    public class Contrabajo : SinArco, Itransportar
    {
        public Contrabajo(string nombre) : base(nombre) { Situado = false; }
        public void transportar() { Situado = true; }
    }


}
