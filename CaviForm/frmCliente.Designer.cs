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
            txtNotas = new TextBox();
            panel1 = new Panel();
            btnEliminar = new Button();
            btnCerrar = new Button();
            btnGuardar = new Button();
            btnDeshacer = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            listView1 = new ListView();
            panel1.SuspendLayout();
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
            lblTipoDocumento.Size = new Size(103, 15);
            lblTipoDocumento.TabIndex = 2;
            lblTipoDocumento.Text = "Tipo documento *";
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
            lblDocumento.Size = new Size(78, 15);
            lblDocumento.TabIndex = 4;
            lblDocumento.Text = "Documento *";
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
            lblNombreComercial.Size = new Size(116, 15);
            lblNombreComercial.TabIndex = 6;
            lblNombreComercial.Text = "Nombre Comercial *";
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
            lblNombreContacto.Size = new Size(111, 15);
            lblNombreContacto.TabIndex = 8;
            lblNombreContacto.Text = "Nombre Contacto *";
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
            lblApellidosContacto.Size = new Size(116, 15);
            lblApellidosContacto.TabIndex = 10;
            lblApellidosContacto.Text = "Apellidos Contacto *";
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
            lblDireccion.Size = new Size(65, 15);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección *";
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
            lblCodPostal.Size = new Size(89, 15);
            lblCodPostal.TabIndex = 14;
            lblCodPostal.Text = "Código postal *";
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
            lblPoblacion.Size = new Size(68, 15);
            lblPoblacion.TabIndex = 16;
            lblPoblacion.Text = "Población *";
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
            lblProvincia.Size = new Size(64, 15);
            lblProvincia.TabIndex = 18;
            lblProvincia.Text = "Provincia *";
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
            lblMovil.Size = new Size(45, 15);
            lblMovil.TabIndex = 22;
            lblMovil.Text = "Movil *";
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
            lblCorreo.Size = new Size(51, 15);
            lblCorreo.TabIndex = 24;
            lblCorreo.Text = "Correo *";
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
            // txtNotas
            // 
            txtNotas.Location = new Point(152, 280);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(528, 88);
            txtNotas.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnDeshacer);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnNuevo);
            panel1.Location = new Point(176, 392);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 56);
            panel1.TabIndex = 28;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(376, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 43);
            btnEliminar.TabIndex = 24;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(472, 8);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 43);
            btnCerrar.TabIndex = 23;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(200, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 43);
            btnGuardar.TabIndex = 22;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnDeshacer
            // 
            btnDeshacer.Image = (Image)resources.GetObject("btnDeshacer.Image");
            btnDeshacer.Location = new Point(288, 8);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(75, 43);
            btnDeshacer.TabIndex = 21;
            btnDeshacer.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(112, 8);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 43);
            btnEditar.TabIndex = 20;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(24, 8);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 43);
            btnNuevo.TabIndex = 19;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(504, 24);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(89, 15);
            lblBuscar.TabIndex = 29;
            lblBuscar.Text = "Introducir texto";
            lblBuscar.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(600, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(256, 23);
            txtBuscar.TabIndex = 30;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(864, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 40);
            btnBuscar.TabIndex = 31;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(688, 80);
            listView1.Name = "listView1";
            listView1.Size = new Size(248, 288);
            listView1.TabIndex = 32;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 478);
            Controls.Add(listView1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(panel1);
            Controls.Add(txtNotas);
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
            MaximizeBox = false;
            Name = "frmCliente";
            Text = " Cliente";
            Load += frmCliente_Load;
            panel1.ResumeLayout(false);
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
        private TextBox txtNotas;
        private Panel panel1;
        private Button btnCerrar;
        private Button btnGuardar;
        private Button btnDeshacer;
        private Button btnEditar;
        private Button btnNuevo;
        private Button btnEliminar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private ListView listView1;
    }
}