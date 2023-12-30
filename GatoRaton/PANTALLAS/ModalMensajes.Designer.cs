namespace GatoRaton.PANTALLAS
{
    partial class ModalMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalMensajes));
            pb_imagen = new PictureBox();
            lblMensaje = new Label();
            btnVolverIniciar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_imagen).BeginInit();
            SuspendLayout();
            // 
            // pb_imagen
            // 
            pb_imagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_imagen.Image = (Image)resources.GetObject("pb_imagen.Image");
            pb_imagen.Location = new Point(46, 12);
            pb_imagen.Name = "pb_imagen";
            pb_imagen.Size = new Size(309, 177);
            pb_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_imagen.TabIndex = 0;
            pb_imagen.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.FlatStyle = FlatStyle.Popup;
            lblMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMensaje.ForeColor = SystemColors.ControlText;
            lblMensaje.Location = new Point(14, 130);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(368, 59);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Mensaje";
            lblMensaje.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnVolverIniciar
            // 
            btnVolverIniciar.BackColor = Color.LimeGreen;
            btnVolverIniciar.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnVolverIniciar.ForeColor = Color.Transparent;
            btnVolverIniciar.Location = new Point(12, 212);
            btnVolverIniciar.Name = "btnVolverIniciar";
            btnVolverIniciar.Size = new Size(182, 46);
            btnVolverIniciar.TabIndex = 2;
            btnVolverIniciar.Text = "Jugar de Nuevo";
            btnVolverIniciar.UseVisualStyleBackColor = false;
            btnVolverIniciar.Click += btnVolverIniciar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Yellow;
            btnRegresar.ForeColor = Color.Black;
            btnRegresar.Location = new Point(200, 212);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(182, 46);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar al Menú";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ModalMensajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 263);
            Controls.Add(btnRegresar);
            Controls.Add(btnVolverIniciar);
            Controls.Add(lblMensaje);
            Controls.Add(pb_imagen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModalMensajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Información";
            Load += ModalMensajes_Load;
            ((System.ComponentModel.ISupportInitialize)pb_imagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_imagen;
        private Label lblMensaje;
        private Button btnVolverIniciar;
        private Button btnRegresar;
    }
}