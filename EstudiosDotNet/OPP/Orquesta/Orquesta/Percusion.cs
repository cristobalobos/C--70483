using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
    public abstract class Percusion : Instrumento
    {
        public override void Afinar()
        {
            Afinando = true;
        }

        public Percusion(string nombre) : base(nombre) { }
    }

    #region PrimerNivel
    public abstract class Baquetas : Percusion
    {
        public Baquetas(string nombre) : base(nombre) { }
    }

    public abstract class Teclas : Percusion
    {
        public Teclas(string nombre) : base(nombre) { }
    }

    public abstract class Mano : Percusion
    {
        public Mano(string nombre) : base(nombre) { }
    }
    #endregion

    #region SegundoNivel
    public class Timbal : Baquetas, Itransportar
    {
        public Timbal(string nombre) : base(nombre) { Situado = false; }
        public void transportar()
        {
            Situado = true;
        }
    }

    public class Marimba : Baquetas, Itransportar
    {
        public Marimba(string nombre) : base(nombre) { Situado = false; }

        public void transportar()
        {
            Situado = true;
        }
    }

    public class Piano : Teclas, Itransportar
    {
        public Piano(string nombre) : base(nombre) { Situado = false; }

        public void transportar()
        {
            Situado = true;
        }
    }


    public class Clavicordio : Teclas, Itransportar
    {
        public Clavicordio(string nombre) : base(nombre) { Situado = false; }

        public void transportar()
        {
            Situado = true;
        }
    }

    public class Congas : Mano
    {
        public Congas(string nombre) : base(nombre) { }
    }

    public class Bongos : Mano
    {
        public Bongos(string nombre) : base(nombre) { }
    }
    #endregion
}
