using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesStudio
{
    class Gerente : IEmpleado
    {
        public bool this[byte index]
        {
            get
            {
                return true; 
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string apellido
        {
            get; set;
        }

        public string nombre
        {
            get; set;
        }

        public decimal SueldoDiario
        {
            get
            {
                return 1000;
            }
        }

        public event EventHandler AlDetectarPago;

        public decimal CalcularPagoMensual(byte diasTrabajados)
        {
            return diasTrabajados * SueldoDiario 
                + PrestacionesGenerales;
        }

        public decimal PrestacionesGenerales { get; set; }
    }
}
