using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitOperatorConversion
{
    class UnaClase
    {
        private string _nombre;
        private int _cantidad;

        public UnaClase() : this("Resultado de la conversión", 0) { }
        public UnaClase(string nombre, int cantidad)
        {
            _nombre = nombre;
            _cantidad = cantidad;
        }

        public override string ToString()
        {
            return "Nombre: " + _nombre + ", Cantidad: " + _cantidad;
        }

        public static explicit operator UnaClase(int cifra) {
            UnaClase temporal = new UnaClase();
            temporal._cantidad = cifra;
            return temporal;
        }

    }
}
