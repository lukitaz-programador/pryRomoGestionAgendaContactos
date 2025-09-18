namespace pryRomoGestionAgendaContactos
{
    partial class frmMuestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuestra));
            lblContacto = new Label();
            btnAtras = new Button();
            btnSiguiente = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblNumero = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.BackColor = SystemColors.ControlLight;
            lblContacto.Font = new Font("Segoe UI", 15F);
            lblContacto.Location = new Point(45, 62);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(305, 33);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "...";
            lblContacto.Click += lblContacto_Click;
            // 
            // btnAtras
            // 
            btnAtras.Enabled = false;
            btnAtras.Location = new Point(45, 119);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(137, 41);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(213, 119);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(137, 41);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(45, 36);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(92, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Primer contacto";
            lblNumero.UseMnemonic = false;
            // 
            // frmMuestra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 214);
            Controls.Add(lblNumero);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMuestra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Muestra de Contactos";
            Load += frmMuestra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Button btnAtras;
        private Button btnSiguiente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblNumero;
    }
}