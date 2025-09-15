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
            lblContacto = new Label();
            btnAtras = new Button();
            btnSiguiente = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.BackColor = SystemColors.ControlLight;
            lblContacto.Font = new Font("Segoe UI", 30F);
            lblContacto.Location = new Point(175, 97);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(50, 54);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "...";
            lblContacto.Click += lblContacto_Click;
            // 
            // btnAtras
            // 
            btnAtras.Enabled = false;
            btnAtras.Location = new Point(45, 243);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(137, 41);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(213, 243);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(137, 41);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click; 
            // 
            // frmMuestra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 312);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Controls.Add(lblContacto);
            Name = "frmMuestra";
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
    }
}