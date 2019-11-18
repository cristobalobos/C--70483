using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eventos
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("\t****************************");
            Console.WriteLine("\tControl de espacio de disco");
            Console.WriteLine("\t**************************** ");

            Console.WriteLine("Disco \t Espacio Libre \tEspacio total" + "\tPorcentaje Libre ");

            Console.WriteLine("-----\t -------------\t -------------" + "\t--------------");
            
            //Instanciamos la clase que comprobará los discos y lanzara el evento si procecede

            MonitorEspacioEnDisco monitor = new MonitorEspacioEnDisco();

            //asociamos un delegado, que apunta al metodo definido mas abajo
            //al evento de nuestra instancia

            monitor.PocoEspacoEnDisco += new PocoEspacioEnDiscoEventHandler(PresentaAviso);
            //lanzamos la ejecución del proceso de nuestra instancia
            monitor.ComprobarEspacioDisponible();
            //paramos la ejecución para leer los mensajes de la pantalla

            Console.Write("Fin del proceso");
            Console.ReadKey();
        }

        //Metodo lanzado por el delegado si la instancia provoca el evento
        static void PresentaAviso(object sender, PocoEspacioEnDiscoEventArgs e)
        {
            Console.WriteLine(e.Nombre + "\t" + e.EspacioLibre.ToString("N") + "GB \t " + e.EspacioTotal.ToString("N") + "GB \t " + e.PorcentajeLibre.ToString("N") + "%");

        }

        //clase para los datos complementarios a adjuntar al evento
        /**una clase derivada de eventargs para pasar los datos complementarios del evento**/
        public class PocoEspacioEnDiscoEventArgs : EventArgs
        {
            //atributos

            private decimal espacioLibre;
            private decimal espacioTotal;
            private decimal porcentajeLibre;
            private string disco;

            //constructor 
            public PocoEspacioEnDiscoEventArgs(string nombre, decimal discolibre, decimal discoTotal, decimal porcentaje)
            {
                this.disco = nombre;
                this.espacioLibre = discolibre;
                this.espacioTotal = discoTotal;
                this.porcentajeLibre = porcentaje;

            }

            //propiedades de acceso a los atributos

            public string Nombre { get { return this.disco; } }
            public decimal EspacioLibre { get { return this.espacioLibre; } }
            public decimal EspacioTotal { get { return this.espacioTotal; } }
            public decimal PorcentajeLibre { get { return this.porcentajeLibre; } }
        }
        //delegado para asociar el evento
        public delegate void PocoEspacioEnDiscoEventHandler(object sender, PocoEspacioEnDiscoEventArgs e);

        //clase que lanzara el evento cuando se produzca la condición

        public class MonitorEspacioEnDisco
        {
            //atributos

            public event PocoEspacioEnDiscoEventHandler PocoEspacoEnDisco;
            private decimal limite = 80m;
            //Procedimiento que procesa los discos del sistema y determina la necesidad de elanzar el evento

            public void ComprobarEspacioDisponible()
            {
                //Recupera los discos existentes

                DriveInfo[] discos = DriveInfo.GetDrives();
                //los procesa para determinarsi es necesario lanzar el evento
                foreach (DriveInfo disco in discos)
                {
                    if (disco.IsReady)
                    {
                        decimal gigasLibres = disco.TotalFreeSpace / (decimal)Math.Pow(1924, 3);
                        decimal gigasTotales = disco.TotalSize / (decimal)Math.Pow(1924, 3);

                        decimal porcentajeLibre = (gigasLibres / gigasTotales) * 100;

                        if (porcentajeLibre <= this.limite)
                        {
                            //si el disco esta listo y no tiene suficiente espacio
                            OnPocoEspacioEnDisco(new PocoEspacioEnDiscoEventArgs(disco.Name, gigasLibres, gigasTotales, porcentajeLibre));

                        }

                    }
                }


            }

            //metodo para lanzar el evento si hay algun eventHandler asociado al mismo

            protected void OnPocoEspacioEnDisco(PocoEspacioEnDiscoEventArgs e)
            {

                if (PocoEspacoEnDisco != null)
                {
                    PocoEspacoEnDisco(this, e);
                }
            }

        }
    }
}
