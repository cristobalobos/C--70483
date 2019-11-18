using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatos
{
    /// <summary>
    /// Primer nivel de herencia
    /// </summary>
    public abstract class Percusion : Instrumento {
        private string _nombre;
        public override void Afinar() {
            Afinando = true;
        }
        public Percusion(string nombre) : base(nombre) { }
    }

    /// <summary>
    ///  Segundo nivel de herencia
    /// </summary>
    public abstract class Baquetas : Percusion { public Baquetas(string nombre) : base(nombre) { } }
    public abstract class Mano : Percusion { public Mano(string nombre) : base(nombre) { } }
    public abstract class Teclas : Percusion { public Teclas(string nombre) : base(nombre) { } }

    /// <summary>
    ///  Tercer nivel de herencia
    /// </summary>
    public class Marimba : Baquetas, ITransportar {
        public Marimba(string nombre) : base(nombre) { Situado = false; }
        public void Transportar() { Situado = true; }
    }
    public class Timbal : Baquetas, ITransportar {
        public Timbal(string nombre) : base(nombre) { Situado = false; }
        public void Transportar() { Situado = true; }
    }
    public class Bongo : Mano                       { public Bongo(string nombre) : base(nombre) { } }
    public class Conga : Mano                       { public Conga(string nombre) : base(nombre) { } }
    public class Clavicordio : Teclas, ITransportar {
        public Clavicordio(string nombre) : base(nombre) { Situado = false; }
        public void Transportar() { Situado = true; }
    }
    public class Piano : Teclas, ITransportar {
        public Piano(string nombre) : base(nombre) { Situado = false; }
        public void Transportar() { Situado = true; }
    }
}
