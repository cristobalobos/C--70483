using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
    public abstract class Viento : Instrumento
    {
        public override void Afinar()
        {
            Afinando = true;
        }

        public Viento(string nombre) : base(nombre) { }
    }


    public class Trompeta : Viento {
        public Trompeta(string nombre) : base(nombre) { }
    }

    public class Cuerno : Viento    {
        public Cuerno(string nombre) : base(nombre) { }
    }
}
