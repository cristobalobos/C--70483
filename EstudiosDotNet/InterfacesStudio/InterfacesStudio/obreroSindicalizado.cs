using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesStudio
{
    class obreroSindicalizado : IEmpleado, ISindicalizado
    {
        public bool this[byte index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string apellido
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
                

        public string nombre
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal SueldoDiario
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        decimal ISindicalizado.CuotaSindical
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        decimal ISindicalizado.SueldoDiario
        {
            get { return 0 ;}
        }

        public event EventHandler AlDetectarPago;

        public decimal CalcularPagoMensual(byte diasTrabajados)
        {
            throw new NotImplementedException();
        }
    }
}
