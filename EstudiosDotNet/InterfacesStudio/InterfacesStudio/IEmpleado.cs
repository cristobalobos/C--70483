using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesStudio
{
    public interface IEmpleado
    {
        string nombre { get; set; }
        string apellido { get; set; }
        decimal SueldoDiario { get; set; }

        decimal CalcularPagoMensual(byte diasTrabajados);
        event EventHandler AlDetectarPago;

        bool this[byte index] { get; set; }
    }
}
