namespace GatoRaton
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            label1 = new Label();
            lblInformacion = new Label();
            cb_dificultad = new ComboBox();
            txtNombre = new TextBox();
            btnIniciar = new Button();
            pb_salir = new PictureBox();
            lblMensajeNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_salir).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(122, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(312, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Juego del Gato y el Ratón";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(226, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(105, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Ingrese su nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 159);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione la difucultad";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformacion.ForeColor = Color.DeepSkyBlue;
            lblInformacion.Location = new Point(255, 266);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(300, 23);
            lblInformacion.TabIndex = 4;
            lblInformacion.Text = "Para salir  presione \"Esc.\"";
            // 
            // cb_dificultad
            // 
            cb_dificultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_dificultad.FormattingEnabled = true;
            cb_dificultad.Items.AddRange(new object[] { "Facil", "Normal", "Dificil" });
            cb_dificultad.Location = new Point(150, 187);
            cb_dificultad.Name = "cb_dificultad";
            cb_dificultad.Size = new Size(246, 23);
            cb_dificultad.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(312, 23);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.LimeGreen;
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.Transparent;
            btnIniciar.Location = new Point(122, 227);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(312, 36);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pb_salir
            // 
            pb_salir.Image = Properties.Resources.SALIR;
            pb_salir.Location = new Point(506, 9);
            pb_salir.Name = "pb_salir";
            pb_salir.Size = new Size(44, 47);
            pb_salir.SizeMode = PictureBoxSizeMode.Zoom;
            pb_salir.TabIndex = 8;
            pb_salir.TabStop = false;
            pb_salir.Click += pb_salir_Click;
            // 
            // lblMensajeNombre
            // 
            lblMensajeNombre.AutoSize = true;
            lblMensajeNombre.BackColor = Color.FromArgb(224, 224, 224);
            lblMensajeNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensajeNombre.ForeColor = Color.Red;
            lblMensajeNombre.Location = new Point(122, 133);
            lblMensajeNombre.Name = "lblMensajeNombre";
            lblMensajeNombre.Size = new Size(163, 15);
            lblMensajeNombre.TabIndex = 9;
            lblMensajeNombre.Text = "Favor de ingresar el nombre";
            lblMensajeNombre.Visible = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MENUINICIOFONT;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(559, 291);
            Controls.Add(lblMensajeNombre);
            Controls.Add(pb_salir);
            Controls.Add(btnIniciar);
            Controls.Add(txtNombre);
            Controls.Add(cb_dificultad);
            Controls.Add(lblInformacion);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            Load += MainMenuForm_Load;
            KeyDown += MainMenuForm_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pb_salir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblNombre;
        private Label label1;
        private Label lblInformacion;
        private ComboBox cb_dificultad;
        private TextBox txtNombre;
        private Button btnIniciar;
        private PictureBox pb_salir;
        private Label lblMensajeNombre;
    }
}