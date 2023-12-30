namespace GatoRaton
{
    public partial class MainMenuForm : Form
    {
        private Form _padre;
        public MainMenuForm()
        {
            KeyPreview = true;
            _padre = this;
            InitializeComponent();
            
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.Focus();
            cb_dificultad.SelectedIndex = 0;
            Console.WriteLine("Algo");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void pb_salir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void MainMenuForm_KeyPress(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Iniciar();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                Cerrar();
            }

        }


        private void Iniciar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblMensajeNombre.Visible = true;
                return;
            }


            TableroForm table = new TableroForm(txtNombre.Text, cb_dificultad.SelectedIndex, ref _padre);
            table.Show();
            table.Focus();
            this.Hide();
        }

        private void Cerrar()
        {
            this.Dispose();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) == true)
            {
                lblMensajeNombre.Visible = true;
            }
            else
            {
                lblMensajeNombre.Visible = false;
            }
        }
    }
}