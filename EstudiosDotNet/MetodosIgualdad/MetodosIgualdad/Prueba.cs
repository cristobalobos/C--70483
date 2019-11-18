using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosIgualdad
{
    class Prueba : IEquatable<Prueba>
    {
        public int numero { get; set; }
        public string cadena { get; set; }

        public Prueba(int numero, string cadena) {
            this.numero = numero;
            this.cadena = cadena;

        }

        public bool Equals(Prueba otra) {
            return otra.numero == this.numero && otra.cadena == this.cadena;
        }

        public static bool operator ==(Prueba a, Prueba b) {
            return a.numero == b.numero && a.cadena == b.cadena;
        }

        

        public static bool operator !=(Prueba a, Prueba b) {
            return !(a.numero == b.numero && a.cadena == b.cadena);
        }

    }
}
