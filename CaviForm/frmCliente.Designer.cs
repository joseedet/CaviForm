namespace CaviForm
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            lblClienteId = new Label();
            txtClienteId = new TextBox();
            lblTipoDocumento = new Label();
            cboTipoDocumento = new ComboBox();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            lblNombreComercial = new Label();
            txtNombreComercial = new TextBox();
            lblNombreContacto = new Label();
            txtNombreContacto = new TextBox();
            lblApellidosContacto = new Label();
            txtApellidosContacto = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblCodPostal = new Label();
            txtCodPostal = new TextBox();
            lblPoblacion = new Label();
            txtPoblacion = new TextBox();
            lblProvincia = new Label();
            txtProvincia = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblMovil = new Label();
            txtMovil = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblNotas = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblClienteId
            // 
            lblClienteId.AutoSize = true;
            lblClienteId.Location = new Point(48, 24);
            lblClienteId.Name = "lblClienteId";
            lblClienteId.Size = new Size(77, 15);
            lblClienteId.TabIndex = 0;
            lblClienteId.Text = "Num. Cliente";
            // 
            // txtClienteId
            // 
            txtClienteId.Enabled = false;
            txtClienteId.Location = new Point(152, 16);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(218, 23);
            txtClienteId.TabIndex = 1;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(50, 88);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(95, 15);
            lblTipoDocumento.TabIndex = 2;
            lblTipoDocumento.Text = "Tipo documento";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(152, 80);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(218, 23);
            cboTipoDocumento.TabIndex = 3;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(75, 120);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 4;
            lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(152, 112);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(218, 23);
            txtDocumento.TabIndex = 5;
            // 
            // lblNombreComercial
            // 
            lblNombreComercial.AutoSize = true;
            lblNombreComercial.Location = new Point(37, 152);
            lblNombreComercial.Name = "lblNombreComercial";
            lblNombreComercial.Size = new Size(108, 15);
            lblNombreComercial.TabIndex = 6;
            lblNombreComercial.Text = "Nombre Comercial";
            lblNombreComercial.TextAlign = ContentAlignment.TopRight;
            // 
            // txtNombreComercial
            // 
            txtNombreComercial.Location = new Point(152, 144);
            txtNombreComercial.Name = "txtNombreComercial";
            txtNombreComercial.Size = new Size(218, 23);
            txtNombreComercial.TabIndex = 7;
            // 
            // lblNombreContacto
            // 
            lblNombreContacto.AutoSize = true;
            lblNombreContacto.Location = new Point(42, 184);
            lblNombreContacto.Name = "lblNombreContacto";
            lblNombreContacto.Size = new Size(103, 15);
            lblNombreContacto.TabIndex = 8;
            lblNombreContacto.Text = "Nombre Contacto";
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Location = new Point(152, 176);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(218, 23);
            txtNombreContacto.TabIndex = 9;
            // 
            // lblApellidosContacto
            // 
            lblApellidosContacto.AutoSize = true;
            lblApellidosContacto.Location = new Point(37, 216);
            lblApellidosContacto.Name = "lblApellidosContacto";
            lblApellidosContacto.Size = new Size(108, 15);
            lblApellidosContacto.TabIndex = 10;
            lblApellidosContacto.Text = "Apellidos Contacto";
            // 
            // txtApellidosContacto
            // 
            txtApellidosContacto.Location = new Point(152, 208);
            txtApellidosContacto.Name = "txtApellidosContacto";
            txtApellidosContacto.Size = new Size(218, 23);
            txtApellidosContacto.TabIndex = 11;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(88, 248);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(152, 240);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(218, 23);
            txtDireccion.TabIndex = 13;
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.Location = new Point(378, 88);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.RightToLeft = RightToLeft.No;
            lblCodPostal.Size = new Size(81, 15);
            lblCodPostal.TabIndex = 14;
            lblCodPostal.Text = "Código postal";
            lblCodPostal.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(464, 80);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(218, 23);
            txtCodPostal.TabIndex = 15;
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(399, 120);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.RightToLeft = RightToLeft.No;
            lblPoblacion.Size = new Size(60, 15);
            lblPoblacion.TabIndex = 16;
            lblPoblacion.Text = "Población";
            lblPoblacion.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPoblacion
            // 
            txtPoblacion.Location = new Point(464, 112);
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.Size = new Size(218, 23);
            txtPoblacion.TabIndex = 17;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(403, 152);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.RightToLeft = RightToLeft.No;
            lblProvincia.Size = new Size(56, 15);
            lblProvincia.TabIndex = 18;
            lblProvincia.Text = "Provincia";
            lblProvincia.TextAlign = ContentAlignment.TopRight;
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(464, 144);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(218, 23);
            txtProvincia.TabIndex = 19;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(407, 184);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.RightToLeft = RightToLeft.No;
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 20;
            lblTelefono.Text = "Teléfono";
            lblTelefono.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(464, 176);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(218, 23);
            txtTelefono.TabIndex = 21;
            // 
            // lblMovil
            // 
            lblMovil.AutoSize = true;
            lblMovil.Location = new Point(422, 216);
            lblMovil.Name = "lblMovil";
            lblMovil.RightToLeft = RightToLeft.No;
            lblMovil.Size = new Size(37, 15);
            lblMovil.TabIndex = 22;
            lblMovil.Text = "Movil";
            // 
            // txtMovil
            // 
            txtMovil.Location = new Point(464, 208);
            txtMovil.Name = "txtMovil";
            txtMovil.Size = new Size(218, 23);
            txtMovil.TabIndex = 23;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(416, 248);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.RightToLeft = RightToLeft.No;
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 24;
            lblCorreo.Text = "Correo";
            lblCorreo.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(464, 240);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(218, 23);
            txtCorreo.TabIndex = 25;
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Location = new Point(104, 280);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(38, 15);
            lblNotas.TabIndex = 26;
            lblNotas.Text = "Notas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 280);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(528, 88);
            textBox1.TabIndex = 27;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 435);
            Controls.Add(textBox1);
            Controls.Add(lblNotas);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtMovil);
            Controls.Add(lblMovil);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtProvincia);
            Controls.Add(lblProvincia);
            Controls.Add(txtPoblacion);
            Controls.Add(lblPoblacion);
            Controls.Add(txtCodPostal);
            Controls.Add(lblCodPostal);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtApellidosContacto);
            Controls.Add(lblApellidosContacto);
            Controls.Add(txtNombreContacto);
            Controls.Add(lblNombreContacto);
            Controls.Add(txtNombreComercial);
            Controls.Add(lblNombreComercial);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(cboTipoDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(txtClienteId);
            Controls.Add(lblClienteId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCliente";
            Text = "frmCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClienteId;
        private TextBox txtClienteId;
        private Label lblTipoDocumento;
        private ComboBox cboTipoDocumento;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private Label lblNombreComercial;
        private TextBox txtNombreComercial;
        private Label lblNombreContacto;
        private TextBox txtNombreContacto;
        private Label lblApellidosContacto;
        private TextBox txtApellidosContacto;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblCodPostal;
        private TextBox txtCodPostal;
        private Label lblPoblacion;
        private TextBox txtPoblacion;
        private Label lblProvincia;
        private TextBox txtProvincia;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblMovil;
        private TextBox txtMovil;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblNotas;
        private TextBox textBox1;
    }
}