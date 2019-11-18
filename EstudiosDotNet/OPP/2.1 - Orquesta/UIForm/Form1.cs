using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using ModeloDatos;

namespace UIForm
{
    public partial class Form1 : Form
    {
        static List<Instrumento> Orquesta;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfinar_Click(object sender, EventArgs e)
        {
            Afinar();
        }

        private void Afinar()
        {
            Negocio negocio = new Negocio();
            negocio.Afinar();

            btnAfinar.Visible = false;
            btnInterpretar.Visible = true;
            btnTransportar.Visible = false;
        }

        private void btnTransportar_Click(object sender, EventArgs e)
        {
            TransportarInstrumentos();//  Generamos las instancias para rellenar la colección
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            Orquesta = negocio.InicializarOrquesta();


            btnAfinar.Visible = false;
            btnInterpretar.Visible = false;
            btnTransportar.Visible = true;
           
        }

        private void TransportarInstrumentos()
        {
            Negocio negocio = new Negocio();
            negocio.TransportarInstrumentos();

            btnAfinar.Visible = true;
            btnInterpretar.Visible = false;
            btnTransportar.Visible = false;

        }

        private void NumVolumen_ValueChanged(object sender, EventArgs e)
        {
           decimal valor = NumVolumen.Value;

        }

        private void numTempo_ValueChanged(object sender, EventArgs e)
        {
            decimal valor = numTempo.Value;
        }
    }
}
