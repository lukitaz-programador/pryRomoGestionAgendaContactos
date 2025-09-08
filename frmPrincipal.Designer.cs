namespace pryRomoGestionAgendaContactos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblContatoo = new Label();
            lblNumeroo = new Label();
            txtContacto = new TextBox();
            mtbNumero = new MaskedTextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lsbRegistros = new ListBox();
            grbDatos = new GroupBox();
            lblContadorr = new Label();
            lblContador = new Label();
            lblCantidad = new Label();
            grbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblContatoo
            // 
            lblContatoo.AutoSize = true;
            lblContatoo.Font = new Font("Segoe UI", 12F);
            lblContatoo.Location = new Point(12, 29);
            lblContatoo.Name = "lblContatoo";
            lblContatoo.Size = new Size(75, 21);
            lblContatoo.TabIndex = 0;
            lblContatoo.Text = "Contacto:";
            // 
            // lblNumeroo
            // 
            lblNumeroo.AutoSize = true;
            lblNumeroo.Font = new Font("Segoe UI", 12F);
            lblNumeroo.Location = new Point(12, 71);
            lblNumeroo.Name = "lblNumeroo";
            lblNumeroo.Size = new Size(71, 21);
            lblNumeroo.TabIndex = 0;
            lblNumeroo.Text = "Número:";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 12F);
            txtContacto.Location = new Point(104, 26);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(217, 29);
            txtContacto.TabIndex = 1;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Font = new Font("Segoe UI", 12F);
            mtbNumero.Location = new Point(104, 68);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(217, 29);
            mtbNumero.TabIndex = 2;
            mtbNumero.KeyDown += mtbNumero_KeyDown;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.Location = new Point(235, 123);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 29);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(143, 123);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lsbRegistros
            // 
            lsbRegistros.Font = new Font("Segoe UI", 9F);
            lsbRegistros.FormattingEnabled = true;
            lsbRegistros.ItemHeight = 15;
            lsbRegistros.Location = new Point(25, 194);
            lsbRegistros.Name = "lsbRegistros";
            lsbRegistros.Size = new Size(350, 109);
            lsbRegistros.TabIndex = 0;
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(txtContacto);
            grbDatos.Controls.Add(lblContatoo);
            grbDatos.Controls.Add(btnCancelar);
            grbDatos.Controls.Add(lblNumeroo);
            grbDatos.Controls.Add(btnRegistrar);
            grbDatos.Controls.Add(mtbNumero);
            grbDatos.Location = new Point(25, 12);
            grbDatos.Name = "grbDatos";
            grbDatos.Size = new Size(350, 171);
            grbDatos.TabIndex = 0;
            grbDatos.TabStop = false;
            grbDatos.Text = "Datos";
            // 
            // lblContadorr
            // 
            lblContadorr.AutoSize = true;
            lblContadorr.Location = new Point(25, 306);
            lblContadorr.Name = "lblContadorr";
            lblContadorr.Size = new Size(129, 15);
            lblContadorr.TabIndex = 1;
            lblContadorr.Text = "Cantidad de contactos:";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(160, 306);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(0, 15);
            lblContador.TabIndex = 2;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(160, 306);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(0, 15);
            lblCantidad.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 345);
            Controls.Add(lblCantidad);
            Controls.Add(lblContador);
            Controls.Add(lblContadorr);
            Controls.Add(grbDatos);
            Controls.Add(lsbRegistros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Gestión Agenda de Contactos";
            grbDatos.ResumeLayout(false);
            grbDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContatoo;
        private Label lblNumeroo;
        private TextBox txtContacto;
        private MaskedTextBox mtbNumero;
        private Button btnRegistrar;
        private Button btnCancelar;
        private ListBox lsbRegistros;
        private GroupBox grbDatos;
        private Label lblContadorr;
        private Label lblContador;
        private Label lblCantidad;
    }
}
