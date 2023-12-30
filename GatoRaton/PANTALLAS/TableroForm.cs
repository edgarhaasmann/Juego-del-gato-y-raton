using GatoRaton.CLASES;
using GatoRaton.PANTALLAS;

namespace GatoRaton
{
    public partial class TableroForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private string _nombre { set; get; }
        private int _dificultad { set; get; }

        private Form _padre { set; get; }
        private Usuario _usuario { set; get; }
        private Oponente _oponente { set; get; }

        private Funciones func;
        public TableroForm(string nombre, int dificultad, ref Form padre)
        {
            KeyPreview = true;
            InitializeComponent();

            this._nombre = nombre;
            this._dificultad = dificultad;
            this._padre = padre;
            this.func = new Funciones();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

        }

        private void TableroForm_Load(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblPuntucion.Text = func.cronometro();
        }

        //metodo para determinar las teclas
        private void Teclas_KeyDown(object sender, KeyEventArgs e)
        {
            if (this._usuario.vivo == false)
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Down:
                    Abajo();
                    break;

                case Keys.Up:
                    Arriba();
                    break;

                case Keys.Right:
                    Derecha();
                    break;

                case Keys.Left:
                    Izquierda();
                    break;

                case Keys.Escape:
                    Salir();
                    break;

                default:
                    e.Handled = true;
                    return;
            }

            if (e.KeyCode != Keys.Escape)
            {
                this._oponente.Avanza(ref pb_jugador, ref pb_oponente);
                Colisiones();
            }
        }

        private void pb_salir_Click(object sender, EventArgs e)
        {
            Salir();
        }


        private void Colisiones()
        {
            ModalMensajes msg = new ModalMensajes(this._usuario, this);
            if (this._oponente.Colision(pb_jugador, pb_oponente))
            {
                this._usuario.SetJugadas();
                this._usuario.SetTiempo(lblPuntucion.Text);
                this._usuario.setVivo(false);
                msg.Show();
                timer.Stop();

            }
            else if (this._usuario.Colision(ref p_salida, ref pb_jugador))
            {
                this._usuario.SetJugadas();
                this._usuario.SetTiempo(lblPuntucion.Text);
                msg.Show();
                timer.Stop();
            }
        }

        public void Salir()
        {
            this._padre.Show();
            this.Dispose();
            this.Close();
        }

        //metodos para el movimiento del jugador
        private void Abajo()
        {
            pb_jugador.Location = new Point(pb_jugador.Location.X, this._usuario.Abajo(pb_tablero));
        }
        private void Arriba()
        {
            pb_jugador.Location = new Point(pb_jugador.Location.X, _usuario.Arriba(pb_tablero));

        }
        private void Derecha()
        {
            pb_jugador.Location = new Point(_usuario.Derecha(pb_tablero), pb_jugador.Location.Y);

        }
        private void Izquierda()
        {
            pb_jugador.Location = new Point(_usuario.Izquierda(pb_tablero), pb_jugador.Location.Y);

        }

        public void Iniciar()
        {
            CrearJugadores();
            Antecedentes();

            lblJuegoDe.Text = $"Buena suerte {_usuario.nombre}";
            lblPuntucion.Text = "0";

            func.reiniciar();
            timer.Start();
        }

        private void CrearJugadores()
        {
            if (this._usuario == null)
            {
                this._usuario = new Usuario(this._nombre, 0, 0);
                this._oponente = new Oponente("Gato", 0, 0, this._dificultad);
            }

            Dictionary<string, int> jugadorOpciones = new Dictionary<string, int>() { { "minX", 380 }, { "maxX", 729 }, { "minY", 169 }, { "maxY", 412 } };
            Dictionary<string, int> oponenteOpciones = new Dictionary<string, int>() { { "minX", 21 }, { "maxX", 380 }, { "minY", 169 }, { "maxY", 412 } };

            pb_jugador = this._usuario.MovimientoRamdom(jugadorOpciones, ref pb_jugador);
            pb_oponente = this._oponente.MovimientoRamdom(oponenteOpciones, ref pb_oponente);

            this._usuario.setVivo(true);

        }

        private void Antecedentes()
        {
            if (this._usuario.jugadas > 0)
            {
                lblPuntucionAnt.Visible = true;
                lblMensajePuntuacionAnt.Visible = true;
                lblPuntucionAnt.Text = this._usuario.tiempoAnt;
            }


        }
    }
}
