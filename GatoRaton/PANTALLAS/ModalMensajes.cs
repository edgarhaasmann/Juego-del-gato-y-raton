using GatoRaton.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatoRaton.PANTALLAS
{
    public partial class ModalMensajes : Form
    {
        private Usuario _jugador { set; get; }
        private TableroForm _padre { set; get; }
        public ModalMensajes(Usuario jugador, TableroForm padre)
        {
            InitializeComponent();
            this._jugador = jugador;
            this._padre = padre;
        }

        private void ModalMensajes_Load(object sender, EventArgs e)
        {
            Bitmap ruta;
            lblMensaje.Location = new Point(23, 173);

            if (this._jugador.vivo)
            {
                ruta = Properties.Resources.gg;


            }
            else
            {
                ruta = Properties.Resources.VuleveAIntentar;
            }

            lblMensaje.Text = this._jugador.Terminar();
            pb_imagen.Image = ruta;


        }

        private void btnVolverIniciar_Click(object sender, EventArgs e)
        {
            _padre.Iniciar();
            this.Dispose();
            this.Close();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this._padre.Salir();
            this._padre.Dispose();
            this._padre.Close();
            this.Dispose();
            this.Close();


        }


    }
}
