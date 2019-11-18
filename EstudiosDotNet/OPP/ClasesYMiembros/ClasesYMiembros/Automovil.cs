using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYMiembros
{
    public class Automovil
    {

        public string Modelo;
        public string Color {
            get; set; }
        public string Marca {
            get; set;}

        public void Arrancar() { }
        public void Detener() { }
        public void Caminar() { }

        public event EventHandler GasolinaAgotada;

        #region Constructor
        public Automovil(string modelo){
            Modelo = modelo;
        }
        #endregion
    }
}
