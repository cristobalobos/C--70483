using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModificadores
{
    public class MisEventArgs : EventArgs //clase para evento personalizado
    {
        public MisEventArgs(string s)
        {
            Mensaje = s;
        }

        private string _mensaje;

        public string Mensaje
        {
            get
            {
                return _mensaje;
            }

            set
            {
                _mensaje = value;
            }
        }
    }


    class Publicador //esta clase publicara el evento
    {
        public event EventHandler<MisEventArgs> LanzarMiEvento; //declaramos el evento con EventHandler<T>

        public void HacerAlgo()
        {
            //Aquí hariamos algo y luego lanzariamos el evento
            LanzarEvento(new MisEventArgs("Finalizado"));
        }
        protected virtual void LanzarEvento(MisEventArgs e) //lanzamos el evento personalizado
        {
            //  Copia previa del delegado para evitar referencias nulas si el ultimo cliente se borra antes de lanzarlo
            EventHandler<MisEventArgs> delegado = LanzarMiEvento;
            if (delegado != null)
            {
                e.Mensaje += String.Format("A las {0}", DateTime.Now.ToString());
                delegado(this, e); //lanzamos el evento con el metodo ()

            }

        }
    }


    class Cliente 
    {
        //Clase que subcribe el evento
        private string id;
        public Cliente(string ID, Publicador pub)
        {
            id = ID;
            pub.LanzarMiEvento += HandleCustomEvent; //Nos subcribimos al evento
        }

        private void HandleCustomEvent(object sender, MisEventArgs e) //Gestionamos el evento
        {
            Console.WriteLine("Desde " + id + " Se ha recibido este mensaje: {0}", e.Mensaje);
        }
    }

    class Proceso
    {
        static void Main(string[] args)
        {
            Publicador pub = new Publicador();
            Cliente sub1 = new Cliente("sub1", pub);
            Cliente sub2 = new Cliente("sub2", pub);
            pub.HacerAlgo();//llamada el metodo que lanza el evento
            Console.ReadLine();
        }
    }
}
