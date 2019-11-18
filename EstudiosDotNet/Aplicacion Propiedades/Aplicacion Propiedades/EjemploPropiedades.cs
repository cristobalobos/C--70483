using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Propiedades
{
    class EjemploPropiedades
    {
        int _dia; int _mes; int _año; string _codigo; //atributos privados 

        public EjemploPropiedades(string codigo) //constrctor
        {
            _dia = DateTime.Now.Day;
            _mes = DateTime.Now.Month;
            _año = DateTime.Now.Year;
            _codigo = codigo;

        }

        public DateTime Fecha
        { //propiedad para acceder a la fecha almacenada o modificada
            get { return DateTime.Parse(_dia + "/" + _mes + "/" + _año); }
            set
            { //Validamos que la fecha sea superior a la almacenada
                if (value >= Fecha)
                {
                    _dia = value.Day; _mes = value.Month; _año = value.Year;
                }
                else
                {
                    throw new Exception("La fecha ha de ser superior a la actualmente almacenada en el código " + Codigo);
                }

            }

        }

        public void IncrementarFecha(int dias)
        {
            TimeSpan delta = new TimeSpan(dias, 0, 0, 0);
            DateTime Fecha2 = Fecha + delta;
            _dia = Fecha2.Day;
            _mes = Fecha2.Month;
            _año = Fecha2.Year;

        }

        public string Codigo { get { return _codigo; } }
        public override string ToString()
        {
            return "Codigo: " + Codigo + " Fecha Actual: " + Fecha.ToShortDateString();
        }
    }

}
