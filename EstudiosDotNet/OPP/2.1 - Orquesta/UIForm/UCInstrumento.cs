using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDatos;


namespace UIForm
{
    public partial class UCInstrumento : UserControl
    {

        static public string rutaImagenes = Application.StartupPath + @"\Images\";
        static List<Instrumento> Orquesta;
        static public string nombre ;


        //publi yipo nombre, tempo, voluen, estado image.


        public UCInstrumento()
        {
            InitializeComponent();
        }
    }
}
