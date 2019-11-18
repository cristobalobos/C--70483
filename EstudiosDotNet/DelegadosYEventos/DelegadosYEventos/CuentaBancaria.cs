using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosYEventos
{
    delegate void ErrorHandler(string info);

    class CuentaBancaria
    {
        private decimal SaldoActual;
        public ErrorHandler Apuntador { get; set; }
        public decimal Retirar(decimal importe)
        {

            if (SaldoActual >= importe)
            {
                SaldoActual = SaldoActual - importe;

                if (SaldoActual == 0)
                {
                    if (Apuntador != null)
                    {
                        Apuntador("Saldos en cero");
                    }
                }
            }
            else
            {
                if (Apuntador != null)
                {
                    Apuntador("Saldos no disponible");
                }
            }
            return SaldoActual;
        }

        public decimal Depositar(decimal importe)
        {
            SaldoActual = SaldoActual + importe;
            return SaldoActual;
        }

    }

}

