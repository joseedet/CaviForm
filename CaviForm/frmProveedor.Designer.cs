﻿namespace CaviForm
{
    partial class frmProveedor
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            txtCorreo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            txtMovil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblMovil = new MaterialSkin.Controls.MaterialLabel();
            txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            txtProvincia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblProvincia = new MaterialSkin.Controls.MaterialLabel();
            txtPoblacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblPoblacion = new MaterialSkin.Controls.MaterialLabel();
            txtCodPostal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblCodPostal = new MaterialSkin.Controls.MaterialLabel();
            txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtApellidosContacto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNombreContacto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtNombreComercial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblDireccion = new MaterialSkin.Controls.MaterialLabel();
            lblApellidosContacto = new MaterialSkin.Controls.MaterialLabel();
            lblNombreContacto = new MaterialSkin.Controls.MaterialLabel();
            lblNombreComercial = new MaterialSkin.Controls.MaterialLabel();
            lblDocumento = new MaterialSkin.Controls.MaterialLabel();
            lblTipoDocumento = new MaterialSkin.Controls.MaterialLabel();
            cboTipoDocumento = new ComboBox();
            panel1 = new Panel();
            btnEliminar = new Button();
            btnCerrar = new Button();
            btnGuardar = new Button();
            btnDeshacer = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            toolTipProveedor = new ToolTip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.Depth = 0;
            txtCorreo.Hint = "";
            txtCorreo.Location = new Point(632, 338);
            txtCorreo.MaxLength = 32767;
            txtCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = '\0';
            txtCorreo.SelectedText = "";
            txtCorreo.SelectionLength = 0;
            txtCorreo.SelectionStart = 0;
            txtCorreo.Size = new Size(367, 23);
            txtCorreo.TabIndex = 50;
            txtCorreo.TabStop = false;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Depth = 0;
            lblCorreo.FlatStyle = FlatStyle.Flat;
            lblCorreo.Font = new Font("Roboto", 11F);
            lblCorreo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCorreo.Location = new Point(552, 342);
            lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(65, 19);
            lblCorreo.TabIndex = 49;
            lblCorreo.Text = "Correo *";
            // 
            // txtMovil
            // 
            txtMovil.BackColor = Color.White;
            txtMovil.Depth = 0;
            txtMovil.Hint = "";
            txtMovil.Location = new Point(632, 298);
            txtMovil.MaxLength = 32767;
            txtMovil.MouseState = MaterialSkin.MouseState.HOVER;
            txtMovil.Name = "txtMovil";
            txtMovil.PasswordChar = '\0';
            txtMovil.SelectedText = "";
            txtMovil.SelectionLength = 0;
            txtMovil.SelectionStart = 0;
            txtMovil.Size = new Size(367, 23);
            txtMovil.TabIndex = 48;
            txtMovil.TabStop = false;
            txtMovil.UseSystemPasswordChar = false;
            // 
            // lblMovil
            // 
            lblMovil.AutoSize = true;
            lblMovil.BackColor = Color.Transparent;
            lblMovil.Depth = 0;
            lblMovil.Font = new Font("Roboto", 11F);
            lblMovil.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblMovil.Location = new Point(561, 300);
            lblMovil.MouseState = MaterialSkin.MouseState.HOVER;
            lblMovil.Name = "lblMovil";
            lblMovil.Size = new Size(56, 19);
            lblMovil.TabIndex = 47;
            lblMovil.Text = "Movil *";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.White;
            txtTelefono.Depth = 0;
            txtTelefono.Hint = "";
            txtTelefono.Location = new Point(630, 259);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.Size = new Size(369, 23);
            txtTelefono.TabIndex = 46;
            txtTelefono.TabStop = false;
            txtTelefono.UseSystemPasswordChar = false;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Depth = 0;
            lblTelefono.FlatStyle = FlatStyle.Flat;
            lblTelefono.Font = new Font("Roboto", 11F);
            lblTelefono.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTelefono.Location = new Point(544, 260);
            lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(73, 19);
            lblTelefono.TabIndex = 45;
            lblTelefono.Text = "Teléfono ";
            // 
            // txtProvincia
            // 
            txtProvincia.BackColor = Color.White;
            txtProvincia.Depth = 0;
            txtProvincia.Hint = "";
            txtProvincia.Location = new Point(630, 216);
            txtProvincia.MaxLength = 32767;
            txtProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            txtProvincia.Name = "txtProvincia";
            txtProvincia.PasswordChar = '\0';
            txtProvincia.SelectedText = "";
            txtProvincia.SelectionLength = 0;
            txtProvincia.SelectionStart = 0;
            txtProvincia.Size = new Size(369, 23);
            txtProvincia.TabIndex = 44;
            txtProvincia.TabStop = false;
            txtProvincia.UseSystemPasswordChar = false;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.BackColor = Color.Transparent;
            lblProvincia.Depth = 0;
            lblProvincia.FlatStyle = FlatStyle.Flat;
            lblProvincia.Font = new Font("Roboto", 11F);
            lblProvincia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblProvincia.Location = new Point(536, 220);
            lblProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(81, 19);
            lblProvincia.TabIndex = 43;
            lblProvincia.Text = "Provincia *";
            // 
            // txtPoblacion
            // 
            txtPoblacion.BackColor = Color.White;
            txtPoblacion.Depth = 0;
            txtPoblacion.Hint = "";
            txtPoblacion.Location = new Point(630, 180);
            txtPoblacion.MaxLength = 32767;
            txtPoblacion.MouseState = MaterialSkin.MouseState.HOVER;
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.PasswordChar = '\0';
            txtPoblacion.SelectedText = "";
            txtPoblacion.SelectionLength = 0;
            txtPoblacion.SelectionStart = 0;
            txtPoblacion.Size = new Size(369, 23);
            txtPoblacion.TabIndex = 42;
            txtPoblacion.TabStop = false;
            txtPoblacion.UseSystemPasswordChar = false;
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.BackColor = Color.Transparent;
            lblPoblacion.Depth = 0;
            lblPoblacion.FlatStyle = FlatStyle.Flat;
            lblPoblacion.Font = new Font("Roboto", 11F);
            lblPoblacion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblPoblacion.Location = new Point(531, 182);
            lblPoblacion.MouseState = MaterialSkin.MouseState.HOVER;
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(86, 19);
            lblPoblacion.TabIndex = 41;
            lblPoblacion.Text = "Población *";
            // 
            // txtCodPostal
            // 
            txtCodPostal.BackColor = Color.White;
            txtCodPostal.Depth = 0;
            txtCodPostal.Hint = "";
            txtCodPostal.Location = new Point(630, 145);
            txtCodPostal.MaxLength = 32767;
            txtCodPostal.MouseState = MaterialSkin.MouseState.HOVER;
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.PasswordChar = '\0';
            txtCodPostal.SelectedText = "";
            txtCodPostal.SelectionLength = 0;
            txtCodPostal.SelectionStart = 0;
            txtCodPostal.Size = new Size(369, 23);
            txtCodPostal.TabIndex = 40;
            txtCodPostal.TabStop = false;
            txtCodPostal.UseSystemPasswordChar = false;
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.BackColor = Color.Transparent;
            lblCodPostal.Depth = 0;
            lblCodPostal.Font = new Font("Roboto", 11F);
            lblCodPostal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCodPostal.Location = new Point(520, 145);
            lblCodPostal.MouseState = MaterialSkin.MouseState.HOVER;
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(97, 19);
            lblCodPostal.TabIndex = 39;
            lblCodPostal.Text = "Cod. Postal *";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.White;
            txtDireccion.Depth = 0;
            txtDireccion.Hint = "";
            txtDireccion.Location = new Point(169, 342);
            txtDireccion.MaxLength = 32767;
            txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PasswordChar = '\0';
            txtDireccion.SelectedText = "";
            txtDireccion.SelectionLength = 0;
            txtDireccion.SelectionStart = 0;
            txtDireccion.Size = new Size(335, 23);
            txtDireccion.TabIndex = 38;
            txtDireccion.TabStop = false;
            txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtApellidosContacto
            // 
            txtApellidosContacto.BackColor = Color.White;
            txtApellidosContacto.Depth = 0;
            txtApellidosContacto.Hint = "";
            txtApellidosContacto.Location = new Point(169, 298);
            txtApellidosContacto.MaxLength = 32767;
            txtApellidosContacto.MouseState = MaterialSkin.MouseState.HOVER;
            txtApellidosContacto.Name = "txtApellidosContacto";
            txtApellidosContacto.PasswordChar = '\0';
            txtApellidosContacto.SelectedText = "";
            txtApellidosContacto.SelectionLength = 0;
            txtApellidosContacto.SelectionStart = 0;
            txtApellidosContacto.Size = new Size(335, 23);
            txtApellidosContacto.TabIndex = 36;
            txtApellidosContacto.TabStop = false;
            txtApellidosContacto.UseSystemPasswordChar = false;
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.BackColor = Color.White;
            txtNombreContacto.Depth = 0;
            txtNombreContacto.Hint = "";
            txtNombreContacto.Location = new Point(169, 260);
            txtNombreContacto.MaxLength = 32767;
            txtNombreContacto.MouseState = MaterialSkin.MouseState.HOVER;
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.PasswordChar = '\0';
            txtNombreContacto.SelectedText = "";
            txtNombreContacto.SelectionLength = 0;
            txtNombreContacto.SelectionStart = 0;
            txtNombreContacto.Size = new Size(335, 23);
            txtNombreContacto.TabIndex = 34;
            txtNombreContacto.TabStop = false;
            txtNombreContacto.UseSystemPasswordChar = false;
            // 
            // txtNombreComercial
            // 
            txtNombreComercial.BackColor = Color.White;
            txtNombreComercial.Depth = 0;
            txtNombreComercial.Hint = "";
            txtNombreComercial.Location = new Point(169, 227);
            txtNombreComercial.MaxLength = 32767;
            txtNombreComercial.MouseState = MaterialSkin.MouseState.HOVER;
            txtNombreComercial.Name = "txtNombreComercial";
            txtNombreComercial.PasswordChar = '\0';
            txtNombreComercial.SelectedText = "";
            txtNombreComercial.SelectionLength = 0;
            txtNombreComercial.SelectionStart = 0;
            txtNombreComercial.Size = new Size(335, 23);
            txtNombreComercial.TabIndex = 32;
            txtNombreComercial.TabStop = false;
            txtNombreComercial.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.White;
            txtDocumento.Depth = 0;
            txtDocumento.Hint = "";
            txtDocumento.Location = new Point(169, 186);
            txtDocumento.MaxLength = 32767;
            txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PasswordChar = '\0';
            txtDocumento.SelectedText = "";
            txtDocumento.SelectionLength = 0;
            txtDocumento.SelectionStart = 0;
            txtDocumento.Size = new Size(335, 23);
            txtDocumento.TabIndex = 30;
            txtDocumento.TabStop = false;
            txtDocumento.UseSystemPasswordChar = false;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Depth = 0;
            lblDireccion.FlatStyle = FlatStyle.Flat;
            lblDireccion.Font = new Font("Roboto", 11F);
            lblDireccion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDireccion.Location = new Point(80, 342);
            lblDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(83, 19);
            lblDireccion.TabIndex = 37;
            lblDireccion.Text = "Direccion *";
            // 
            // lblApellidosContacto
            // 
            lblApellidosContacto.AutoSize = true;
            lblApellidosContacto.BackColor = Color.Transparent;
            lblApellidosContacto.Depth = 0;
            lblApellidosContacto.Font = new Font("Roboto", 11F);
            lblApellidosContacto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblApellidosContacto.Location = new Point(15, 302);
            lblApellidosContacto.MouseState = MaterialSkin.MouseState.HOVER;
            lblApellidosContacto.Name = "lblApellidosContacto";
            lblApellidosContacto.Size = new Size(148, 19);
            lblApellidosContacto.TabIndex = 35;
            lblApellidosContacto.Text = "Apellidos Contacto *";
            // 
            // lblNombreContacto
            // 
            lblNombreContacto.AutoSize = true;
            lblNombreContacto.BackColor = Color.Transparent;
            lblNombreContacto.Depth = 0;
            lblNombreContacto.FlatStyle = FlatStyle.Flat;
            lblNombreContacto.Font = new Font("Roboto", 11F);
            lblNombreContacto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNombreContacto.Location = new Point(24, 264);
            lblNombreContacto.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombreContacto.Name = "lblNombreContacto";
            lblNombreContacto.Size = new Size(139, 19);
            lblNombreContacto.TabIndex = 33;
            lblNombreContacto.Text = "Nombre Contacto *";
            // 
            // lblNombreComercial
            // 
            lblNombreComercial.AutoSize = true;
            lblNombreComercial.BackColor = Color.Transparent;
            lblNombreComercial.Depth = 0;
            lblNombreComercial.Font = new Font("Roboto", 11F);
            lblNombreComercial.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNombreComercial.Location = new Point(17, 225);
            lblNombreComercial.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombreComercial.Name = "lblNombreComercial";
            lblNombreComercial.Size = new Size(146, 19);
            lblNombreComercial.TabIndex = 31;
            lblNombreComercial.Text = "Nombre Comercial *";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.BackColor = Color.Transparent;
            lblDocumento.Depth = 0;
            lblDocumento.FlatStyle = FlatStyle.Flat;
            lblDocumento.Font = new Font("Roboto", 11F);
            lblDocumento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDocumento.Location = new Point(66, 186);
            lblDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(97, 19);
            lblDocumento.TabIndex = 29;
            lblDocumento.Text = "Documento *";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.BackColor = Color.Transparent;
            lblTipoDocumento.Depth = 0;
            lblTipoDocumento.FlatStyle = FlatStyle.Flat;
            lblTipoDocumento.Font = new Font("Roboto", 11F);
            lblTipoDocumento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTipoDocumento.Location = new Point(28, 149);
            lblTipoDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(135, 19);
            lblTipoDocumento.TabIndex = 27;
            lblTipoDocumento.Text = "Tipo Documento * ";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.BackColor = Color.White;
            cboTipoDocumento.FlatStyle = FlatStyle.Flat;
            cboTipoDocumento.Font = new Font("Microsoft Sans Serif", 11F);
            cboTipoDocumento.ForeColor = Color.Black;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(169, 146);
            cboTipoDocumento.Margin = new Padding(3, 4, 3, 4);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(335, 26);
            cboTipoDocumento.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnDeshacer);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnNuevo);
            panel1.Location = new Point(330, 460);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 73);
            panel1.TabIndex = 51;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(229, 16);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(46, 52);
            btnEliminar.TabIndex = 24;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(281, 16);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(46, 52);
            btnCerrar.TabIndex = 23;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(76, 16);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(46, 52);
            btnGuardar.TabIndex = 22;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnDeshacer
            // 
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDeshacer.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Image = (Image)resources.GetObject("btnDeshacer.Image");
            btnDeshacer.Location = new Point(177, 16);
            btnDeshacer.Margin = new Padding(3, 4, 3, 4);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(46, 52);
            btnDeshacer.TabIndex = 21;
            btnDeshacer.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(127, 16);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(46, 52);
            btnEditar.TabIndex = 20;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(26, 16);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(46, 52);
            btnNuevo.TabIndex = 19;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // frmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 567);
            Controls.Add(panel1);
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
            Controls.Add(txtApellidosContacto);
            Controls.Add(txtNombreContacto);
            Controls.Add(txtNombreComercial);
            Controls.Add(txtDocumento);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellidosContacto);
            Controls.Add(lblNombreContacto);
            Controls.Add(lblNombreComercial);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(cboTipoDocumento);
            Name = "frmProveedor";
            Text = "Proveedor";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtCorreo;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMovil;
        private MaterialSkin.Controls.MaterialLabel lblMovil;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProvincia;
        private MaterialSkin.Controls.MaterialLabel lblProvincia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPoblacion;
        private MaterialSkin.Controls.MaterialLabel lblPoblacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodPostal;
        private MaterialSkin.Controls.MaterialLabel lblCodPostal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidosContacto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreContacto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreComercial;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialLabel lblDireccion;
        private MaterialSkin.Controls.MaterialLabel lblApellidosContacto;
        private MaterialSkin.Controls.MaterialLabel lblNombreContacto;
        private MaterialSkin.Controls.MaterialLabel lblNombreComercial;
        private MaterialSkin.Controls.MaterialLabel lblDocumento;
        private MaterialSkin.Controls.MaterialLabel lblTipoDocumento;
        private ComboBox cboTipoDocumento;
        private Panel panel1;
        private Button btnEliminar;
        private Button btnCerrar;
        private Button btnGuardar;
        private Button btnDeshacer;
        private Button btnEditar;
        private Button btnNuevo;
        private ToolTip toolTipProveedor;
    }
}