using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuenteDeEventos
{
    public delegate void excesoEventHandler
        (object sender, ExcesoVelocidadEventArgs e);

    public class ExcesoVelocidadEventArgs : EventArgs
    {
        public DateTime HoraDeLaInfraccion { get; set; }
    }

    public class Coche
    {

        // public event EventHandler VelocidadExcedida;
        public event excesoEventHandler VelocidadExcedida;


        public string Matricula { get; set; }
        public float LimiteVelocidad { get; set; }
        private float velocidad;
        public float Velocidad
        {

            get { return velocidad; }
            set
            {
                velocidad = value;
                if (velocidad > LimiteVelocidad)
                {
                    // disparar evento
                    if (VelocidadExcedida != null)
                    {
                        ExcesoVelocidadEventArgs e = new ExcesoVelocidadEventArgs();
                        e.HoraDeLaInfraccion = DateTime.Now;
                        VelocidadExcedida(this, e);
                    }
                }
            }

        }

        public  
    }
}
