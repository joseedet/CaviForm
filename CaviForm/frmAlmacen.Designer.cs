namespace CaviForm
{
    partial class frmAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmacen));
            btnCancelar = new Button();
            lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            btnAceptar = new Button();
            checkBox1 = new CheckBox();
            txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtProvincia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            txtPoblacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblPoblacion = new MaterialSkin.Controls.MaterialLabel();
            txtCodPostal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblCodPostal = new MaterialSkin.Controls.MaterialLabel();
            txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblDireccion = new MaterialSkin.Controls.MaterialLabel();
            btnNuevo = new Button();
            btnModificar = new Button();
            btnDeshacer = new Button();
            btnEliminar = new Button();
            lblProvinicia = new MaterialSkin.Controls.MaterialLabel();
            txtProvin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(525, 480);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(46, 46);
            btnCancelar.TabIndex = 5;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            btnCancelar.MouseEnter += btnCancelar_MouseEnter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Depth = 0;
            lblDescripcion.FlatStyle = FlatStyle.Flat;
            lblDescripcion.Font = new Font("Roboto", 11F);
            lblDescripcion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDescripcion.Location = new Point(239, 140);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(99, 19);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción *";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(341, 480);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(46, 46);
            btnAceptar.TabIndex = 4;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            btnAceptar.MouseEnter += btnAceptar_MouseEnter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(283, 166);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 22);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Activo";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Depth = 0;
            txtDescripcion.Hint = "";
            txtDescripcion.Location = new Point(346, 136);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.MaxLength = 32767;
            txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PasswordChar = '\0';
            txtDescripcion.SelectedText = "";
            txtDescripcion.SelectionLength = 0;
            txtDescripcion.SelectionStart = 0;
            txtDescripcion.Size = new Size(246, 23);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.TabStop = false;
            txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtProvincia
            // 
            txtProvincia.Depth = 0;
            txtProvincia.Hint = "";
            txtProvincia.Location = new Point(1077, 479);
            txtProvincia.MaxLength = 32767;
            txtProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            txtProvincia.Name = "txtProvincia";
            txtProvincia.PasswordChar = '\0';
            txtProvincia.SelectedText = "";
            txtProvincia.SelectionLength = 0;
            txtProvincia.SelectionStart = 0;
            txtProvincia.Size = new Size(247, 23);
            txtProvincia.TabIndex = 13;
            txtProvincia.TabStop = false;
            txtProvincia.UseSystemPasswordChar = false;
            // 
            // txtPoblacion
            // 
            txtPoblacion.Depth = 0;
            txtPoblacion.Hint = "";
            txtPoblacion.Location = new Point(344, 262);
            txtPoblacion.MaxLength = 32767;
            txtPoblacion.MouseState = MaterialSkin.MouseState.HOVER;
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.PasswordChar = '\0';
            txtPoblacion.SelectedText = "";
            txtPoblacion.SelectionLength = 0;
            txtPoblacion.SelectionStart = 0;
            txtPoblacion.Size = new Size(247, 23);
            txtPoblacion.TabIndex = 20;
            txtPoblacion.TabStop = false;
            txtPoblacion.UseSystemPasswordChar = false;
            txtPoblacion.Validated += txtPoblacion_Validated;
            txtPoblacion.Validating += txtPoblacion_Validating;
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.BackColor = Color.Transparent;
            lblPoblacion.Depth = 0;
            lblPoblacion.FlatStyle = FlatStyle.Flat;
            lblPoblacion.Font = new Font("Roboto", 11F);
            lblPoblacion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblPoblacion.Location = new Point(232, 266);
            lblPoblacion.MouseState = MaterialSkin.MouseState.HOVER;
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(106, 19);
            lblPoblacion.TabIndex = 19;
            lblPoblacion.Text = "  Población   * ";
            lblPoblacion.TextAlign = ContentAlignment.TopRight;
            lblPoblacion.Click += lblPoblacion_Click;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Depth = 0;
            txtCodPostal.Hint = "";
            txtCodPostal.Location = new Point(346, 230);
            txtCodPostal.MaxLength = 32767;
            txtCodPostal.MouseState = MaterialSkin.MouseState.HOVER;
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.PasswordChar = '\0';
            txtCodPostal.SelectedText = "";
            txtCodPostal.SelectionLength = 0;
            txtCodPostal.SelectionStart = 0;
            txtCodPostal.Size = new Size(245, 23);
            txtCodPostal.TabIndex = 18;
            txtCodPostal.TabStop = false;
            txtCodPostal.UseSystemPasswordChar = false;
            txtCodPostal.Validated += txtCodPostal_Validated;
            txtCodPostal.Validating += txtCodPostal_Validating;
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.BackColor = Color.Transparent;
            lblCodPostal.Depth = 0;
            lblCodPostal.FlatStyle = FlatStyle.Flat;
            lblCodPostal.Font = new Font("Roboto", 11F);
            lblCodPostal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCodPostal.Location = new Point(241, 234);
            lblCodPostal.MouseState = MaterialSkin.MouseState.HOVER;
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.Size = new Size(93, 19);
            lblCodPostal.TabIndex = 17;
            lblCodPostal.Text = "Cod.Postal *";
            // 
            // txtDireccion
            // 
            txtDireccion.Depth = 0;
            txtDireccion.Hint = "";
            txtDireccion.Location = new Point(347, 198);
            txtDireccion.MaxLength = 32767;
            txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PasswordChar = '\0';
            txtDireccion.SelectedText = "";
            txtDireccion.SelectionLength = 0;
            txtDireccion.SelectionStart = 0;
            txtDireccion.Size = new Size(245, 23);
            txtDireccion.TabIndex = 16;
            txtDireccion.TabStop = false;
            txtDireccion.UseSystemPasswordChar = false;
            txtDireccion.Validated += txtDireccion_Validated;
            txtDireccion.Validating += txtDireccion_Validating;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Depth = 0;
            lblDireccion.FlatStyle = FlatStyle.Flat;
            lblDireccion.Font = new Font("Roboto", 11F);
            lblDireccion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDireccion.Location = new Point(243, 202);
            lblDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(91, 19);
            lblDireccion.TabIndex = 15;
            lblDireccion.Text = "Dirección   *";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(295, 480);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(46, 46);
            btnNuevo.TabIndex = 21;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.MouseEnter += btnNuevo_MouseEnter;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Transparent;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.Location = new Point(387, 480);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(46, 46);
            btnModificar.TabIndex = 22;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.MouseEnter += btnModificar_MouseEnter;
            // 
            // btnDeshacer
            // 
            btnDeshacer.BackColor = Color.Transparent;
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDeshacer.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Image = (Image)resources.GetObject("btnDeshacer.Image");
            btnDeshacer.Location = new Point(433, 480);
            btnDeshacer.Margin = new Padding(4);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(46, 46);
            btnDeshacer.TabIndex = 23;
            btnDeshacer.UseVisualStyleBackColor = false;
            btnDeshacer.MouseEnter += btnDeshacer_MouseEnter;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(479, 480);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(46, 46);
            btnEliminar.TabIndex = 24;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.MouseEnter += btnEliminar_MouseEnter;
            // 
            // lblProvinicia
            // 
            lblProvinicia.AutoSize = true;
            lblProvinicia.BackColor = Color.Transparent;
            lblProvinicia.Depth = 0;
            lblProvinicia.FlatStyle = FlatStyle.Flat;
            lblProvinicia.Font = new Font("Roboto", 11F);
            lblProvinicia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblProvinicia.Location = new Point(249, 298);
            lblProvinicia.MouseState = MaterialSkin.MouseState.HOVER;
            lblProvinicia.Name = "lblProvinicia";
            lblProvinicia.Size = new Size(85, 19);
            lblProvinicia.TabIndex = 25;
            lblProvinicia.Text = "Provincia  *";
            // 
            // txtProvin
            // 
            txtProvin.Depth = 0;
            txtProvin.Hint = "";
            txtProvin.Location = new Point(344, 294);
            txtProvin.MaxLength = 32767;
            txtProvin.MouseState = MaterialSkin.MouseState.HOVER;
            txtProvin.Name = "txtProvin";
            txtProvin.PasswordChar = '\0';
            txtProvin.SelectedText = "";
            txtProvin.SelectionLength = 0;
            txtProvin.SelectionStart = 0;
            txtProvin.Size = new Size(247, 23);
            txtProvin.TabIndex = 26;
            txtProvin.TabStop = false;
            txtProvin.UseSystemPasswordChar = false;
            txtProvin.Validated += txtProvin_Validated;
            txtProvin.Validating += txtProvin_Validating;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Depth = 0;
            lblTelefono.Font = new Font("Roboto", 11F);
            lblTelefono.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTelefono.Location = new Point(243, 327);
            lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(91, 19);
            lblTelefono.TabIndex = 27;
            lblTelefono.Text = "Teléfono    *";
            // 
            // txtTelefono
            // 
            txtTelefono.Depth = 0;
            txtTelefono.Hint = "";
            txtTelefono.Location = new Point(344, 323);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.Size = new Size(247, 23);
            txtTelefono.TabIndex = 28;
            txtTelefono.TabStop = false;
            txtTelefono.UseSystemPasswordChar = false;
            txtTelefono.Validated += txtTelefono_Validated;
            txtTelefono.Validating += txtTelefono_Validating;
            // 
            // frmAlmacen
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(867, 539);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtProvin);
            Controls.Add(lblProvinicia);
            Controls.Add(btnEliminar);
            Controls.Add(btnDeshacer);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(txtProvincia);
            Controls.Add(txtPoblacion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblPoblacion);
            Controls.Add(checkBox1);
            Controls.Add(txtCodPostal);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCodPostal);
            Controls.Add(btnCancelar);
            Controls.Add(txtDireccion);
            Controls.Add(btnAceptar);
            Controls.Add(lblDireccion);
            Font = new Font("Microsoft Sans Serif", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAlmacen";
            Text = "Almacén";
            Activated += frmAlmacen_Activated;
            Load += frmAlmacen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private Button btnAceptar;
        private CheckBox checkBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProvincia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPoblacion;
        private MaterialSkin.Controls.MaterialLabel lblPoblacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodPostal;
        private MaterialSkin.Controls.MaterialLabel lblCodPostal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialLabel lblDireccion;
        private Button btnNuevo;
        private Button btnModificar;
        private Button btnDeshacer;
        private Button btnEliminar;
        private MaterialSkin.Controls.MaterialLabel lblProvinicia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProvin;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
    }
}