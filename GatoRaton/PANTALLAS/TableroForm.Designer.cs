namespace GatoRaton
{
    partial class TableroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pb_controles = new PictureBox();
            pb_tablero = new PictureBox();
            lblMensajePuntucion = new Label();
            lblPuntucion = new Label();
            lblPuntucionAnt = new Label();
            lblMensajePuntuacionAnt = new Label();
            lblJuegoDe = new Label();
            pb_salir = new PictureBox();
            pb_jugador = new PictureBox();
            p_salida = new Panel();
            lblSalida = new Label();
            pb_oponente = new PictureBox();
            lblMensajeControles = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_controles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_tablero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_salir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_jugador).BeginInit();
            p_salida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_oponente).BeginInit();
            SuspendLayout();
            // 
            // pb_controles
            // 
            pb_controles.Image = Properties.Resources.CONTROLES;
            pb_controles.Location = new Point(12, 42);
            pb_controles.Name = "pb_controles";
            pb_controles.Size = new Size(173, 107);
            pb_controles.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_controles.TabIndex = 0;
            pb_controles.TabStop = false;
            // 
            // pb_tablero
            // 
            pb_tablero.Dock = DockStyle.Bottom;
            pb_tablero.Image = Properties.Resources.TABLERO;
            pb_tablero.Location = new Point(0, 155);
            pb_tablero.Name = "pb_tablero";
            pb_tablero.Size = new Size(779, 334);
            pb_tablero.SizeMode = PictureBoxSizeMode.Zoom;
            pb_tablero.TabIndex = 1;
            pb_tablero.TabStop = false;
            // 
            // lblMensajePuntucion
            // 
            lblMensajePuntucion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMensajePuntucion.AutoSize = true;
            lblMensajePuntucion.Location = new Point(620, 137);
            lblMensajePuntucion.Name = "lblMensajePuntucion";
            lblMensajePuntucion.Size = new Size(65, 15);
            lblMensajePuntucion.TabIndex = 2;
            lblMensajePuntucion.Text = "Puntución:";
            // 
            // lblPuntucion
            // 
            lblPuntucion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPuntucion.AutoSize = true;
            lblPuntucion.Location = new Point(691, 137);
            lblPuntucion.Name = "lblPuntucion";
            lblPuntucion.Size = new Size(13, 15);
            lblPuntucion.TabIndex = 3;
            lblPuntucion.Text = "0";
            // 
            // lblPuntucionAnt
            // 
            lblPuntucionAnt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPuntucionAnt.AutoSize = true;
            lblPuntucionAnt.Location = new Point(691, 117);
            lblPuntucionAnt.Name = "lblPuntucionAnt";
            lblPuntucionAnt.Size = new Size(13, 15);
            lblPuntucionAnt.TabIndex = 5;
            lblPuntucionAnt.Text = "0";
            lblPuntucionAnt.Visible = false;
            // 
            // lblMensajePuntuacionAnt
            // 
            lblMensajePuntuacionAnt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMensajePuntuacionAnt.AutoSize = true;
            lblMensajePuntuacionAnt.Location = new Point(576, 117);
            lblMensajePuntuacionAnt.Name = "lblMensajePuntuacionAnt";
            lblMensajePuntuacionAnt.Size = new Size(109, 15);
            lblMensajePuntuacionAnt.TabIndex = 4;
            lblMensajePuntuacionAnt.Text = "Puntución anterior:";
            lblMensajePuntuacionAnt.Visible = false;
            // 
            // lblJuegoDe
            // 
            lblJuegoDe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblJuegoDe.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblJuegoDe.Location = new Point(191, 12);
            lblJuegoDe.Name = "lblJuegoDe";
            lblJuegoDe.Size = new Size(513, 98);
            lblJuegoDe.TabIndex = 6;
            lblJuegoDe.Text = "Juego";
            lblJuegoDe.TextAlign = ContentAlignment.TopCenter;
            // 
            // pb_salir
            // 
            pb_salir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pb_salir.Image = Properties.Resources.SALIR;
            pb_salir.Location = new Point(729, 12);
            pb_salir.Name = "pb_salir";
            pb_salir.Size = new Size(38, 50);
            pb_salir.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_salir.TabIndex = 7;
            pb_salir.TabStop = false;
            pb_salir.Click += pb_salir_Click;
            // 
            // pb_jugador
            // 
            pb_jugador.BackColor = Color.Transparent;
            pb_jugador.BorderStyle = BorderStyle.FixedSingle;
            pb_jugador.Image = Properties.Resources.RATON;
            pb_jugador.Location = new Point(717, 173);
            pb_jugador.Name = "pb_jugador";
            pb_jugador.Size = new Size(35, 30);
            pb_jugador.SizeMode = PictureBoxSizeMode.Zoom;
            pb_jugador.TabIndex = 8;
            pb_jugador.TabStop = false;
            // 
            // p_salida
            // 
            p_salida.BackColor = Color.LimeGreen;
            p_salida.Controls.Add(lblSalida);
            p_salida.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            p_salida.ForeColor = Color.Transparent;
            p_salida.Location = new Point(12, 413);
            p_salida.Name = "p_salida";
            p_salida.Size = new Size(51, 64);
            p_salida.TabIndex = 9;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Dock = DockStyle.Fill;
            lblSalida.Location = new Point(0, 0);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(46, 15);
            lblSalida.TabIndex = 10;
            lblSalida.Text = "Salida";
            lblSalida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pb_oponente
            // 
            pb_oponente.BackColor = Color.Transparent;
            pb_oponente.BorderStyle = BorderStyle.FixedSingle;
            pb_oponente.Image = Properties.Resources.GATO;
            pb_oponente.Location = new Point(23, 369);
            pb_oponente.Name = "pb_oponente";
            pb_oponente.Size = new Size(35, 29);
            pb_oponente.SizeMode = PictureBoxSizeMode.Zoom;
            pb_oponente.TabIndex = 10;
            pb_oponente.TabStop = false;
            // 
            // lblMensajeControles
            // 
            lblMensajeControles.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMensajeControles.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblMensajeControles.Location = new Point(12, 3);
            lblMensajeControles.Name = "lblMensajeControles";
            lblMensajeControles.Size = new Size(173, 36);
            lblMensajeControles.TabIndex = 11;
            lblMensajeControles.Text = "Controles";
            lblMensajeControles.TextAlign = ContentAlignment.TopCenter;
            // 
            // TableroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 489);
            Controls.Add(lblMensajeControles);
            Controls.Add(pb_oponente);
            Controls.Add(p_salida);
            Controls.Add(pb_jugador);
            Controls.Add(pb_salir);
            Controls.Add(lblJuegoDe);
            Controls.Add(lblPuntucionAnt);
            Controls.Add(lblMensajePuntuacionAnt);
            Controls.Add(lblPuntucion);
            Controls.Add(lblMensajePuntucion);
            Controls.Add(pb_tablero);
            Controls.Add(pb_controles);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(714, 489);
            Name = "TableroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gato y el Ratón";
            Load += TableroForm_Load;
            KeyDown += Teclas_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pb_controles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_tablero).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_salir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_jugador).EndInit();
            p_salida.ResumeLayout(false);
            p_salida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_oponente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_controles;
        private PictureBox pb_tablero;
        private Label lblMensajePuntucion;
        private Label lblPuntucion;
        private Label lblPuntucionAnt;
        private Label lblMensajePuntuacionAnt;
        private Label lblJuegoDe;
        private PictureBox pb_salir;
        private PictureBox pb_jugador;
        private Panel p_salida;
        private Label lblSalida;
        private PictureBox pb_oponente;
        private Label lblMensajeControles;
    }
}