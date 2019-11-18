using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orquesta
{
    /// <summary>
    /// Primer nivel de herencia
    /// </summary>
    public abstract class Viento : Instrumento {
        private string _nombre;
        public override void Afinar() {
            Afinando = true;
        }
        public Viento(string nombre) : base(nombre) { }
    }

    /// <summary>
    ///  Segundo nivel de herencia
    /// </summary>
    public class Cuerno : Viento    { public Cuerno(string nombre) : base(nombre) { } }
    public class Trompeta : Viento  { public Trompeta(string nombre) : base(nombre) { } }
}
