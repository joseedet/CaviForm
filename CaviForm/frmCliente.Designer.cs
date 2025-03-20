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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            cboTipoDocumento = new ComboBox();
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
            listViewResultados = new ListView();
            dataGridViewResultados = new DataGridView();
            lblCodCliente = new MaterialSkin.Controls.MaterialLabel();
            lblTipoDocumento = new MaterialSkin.Controls.MaterialLabel();
            lblDocumento = new MaterialSkin.Controls.MaterialLabel();
            lblNombreComercial = new MaterialSkin.Controls.MaterialLabel();
            toolTip2 = new ToolTip(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).BeginInit();
            SuspendLayout();
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.Font = new Font("Microsoft Sans Serif", 11F);
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(196, 95);
            cboTipoDocumento.Margin = new Padding(3, 4, 3, 4);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(280, 26);
            cboTipoDocumento.TabIndex = 3;
            // 
            // lblNombreContacto
            // 
            lblNombreContacto.AutoSize = true;
            lblNombreContacto.Location = new Point(38, 218);
            lblNombreContacto.Name = "lblNombreContacto";
            lblNombreContacto.Size = new Size(137, 18);
            lblNombreContacto.TabIndex = 8;
            lblNombreContacto.Text = "Nombre Contacto *";
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Location = new Point(196, 212);
            txtNombreContacto.Margin = new Padding(3, 4, 3, 4);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(280, 24);
            txtNombreContacto.TabIndex = 9;
            // 
            // lblApellidosContacto
            // 
            lblApellidosContacto.AutoSize = true;
            lblApellidosContacto.Location = new Point(32, 256);
            lblApellidosContacto.Name = "lblApellidosContacto";
            lblApellidosContacto.Size = new Size(142, 18);
            lblApellidosContacto.TabIndex = 10;
            lblApellidosContacto.Text = "Apellidos Contacto *";
            // 
            // txtApellidosContacto
            // 
            txtApellidosContacto.Location = new Point(196, 250);
            txtApellidosContacto.Margin = new Padding(3, 4, 3, 4);
            txtApellidosContacto.Name = "txtApellidosContacto";
            txtApellidosContacto.Size = new Size(280, 24);
            txtApellidosContacto.TabIndex = 11;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(98, 296);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(81, 18);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección *";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(196, 288);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(280, 24);
            txtDireccion.TabIndex = 13;
            // 
            // lblCodPostal
            // 
            lblCodPostal.AutoSize = true;
            lblCodPostal.Location = new Point(479, 99);
            lblCodPostal.Name = "lblCodPostal";
            lblCodPostal.RightToLeft = RightToLeft.No;
            lblCodPostal.Size = new Size(110, 18);
            lblCodPostal.TabIndex = 14;
            lblCodPostal.Text = "Código postal *";
            lblCodPostal.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(606, 96);
            txtCodPostal.Margin = new Padding(3, 4, 3, 4);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(280, 24);
            txtCodPostal.TabIndex = 15;
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(506, 137);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.RightToLeft = RightToLeft.No;
            lblPoblacion.Size = new Size(84, 18);
            lblPoblacion.TabIndex = 16;
            lblPoblacion.Text = "Población *";
            lblPoblacion.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPoblacion
            // 
            txtPoblacion.Location = new Point(606, 134);
            txtPoblacion.Margin = new Padding(3, 4, 3, 4);
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.Size = new Size(280, 24);
            txtPoblacion.TabIndex = 17;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(512, 176);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.RightToLeft = RightToLeft.No;
            lblProvincia.Size = new Size(79, 18);
            lblProvincia.TabIndex = 18;
            lblProvincia.Text = "Provincia *";
            lblProvincia.TextAlign = ContentAlignment.TopRight;
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(606, 173);
            txtProvincia.Margin = new Padding(3, 4, 3, 4);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(280, 24);
            txtProvincia.TabIndex = 19;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(516, 214);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.RightToLeft = RightToLeft.No;
            lblTelefono.Size = new Size(66, 18);
            lblTelefono.TabIndex = 20;
            lblTelefono.Text = "Teléfono";
            lblTelefono.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(606, 212);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(280, 24);
            txtTelefono.TabIndex = 21;
            // 
            // lblMovil
            // 
            lblMovil.AutoSize = true;
            lblMovil.Location = new Point(536, 252);
            lblMovil.Name = "lblMovil";
            lblMovil.RightToLeft = RightToLeft.No;
            lblMovil.Size = new Size(53, 18);
            lblMovil.TabIndex = 22;
            lblMovil.Text = "Movil *";
            // 
            // txtMovil
            // 
            txtMovil.Location = new Point(606, 250);
            txtMovil.Margin = new Padding(3, 4, 3, 4);
            txtMovil.Name = "txtMovil";
            txtMovil.Size = new Size(280, 24);
            txtMovil.TabIndex = 23;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(528, 291);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.RightToLeft = RightToLeft.No;
            lblCorreo.Size = new Size(65, 18);
            lblCorreo.TabIndex = 24;
            lblCorreo.Text = "Correo *";
            lblCorreo.TextAlign = ContentAlignment.TopRight;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(606, 288);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(280, 24);
            txtCorreo.TabIndex = 25;
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Location = new Point(118, 334);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(48, 18);
            lblNotas.TabIndex = 26;
            lblNotas.Text = "Notas";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(190, 334);
            txtNotas.Margin = new Padding(3, 4, 3, 4);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(697, 105);
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
            panel1.Location = new Point(289, 710);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 68);
            panel1.TabIndex = 28;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(484, 10);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 52);
            btnEliminar.TabIndex = 24;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.MouseEnter += btnEliminar_MouseEnter;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(606, 10);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 52);
            btnCerrar.TabIndex = 23;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(258, 10);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 52);
            btnGuardar.TabIndex = 22;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.MouseEnter += btnGuardar_MouseEnter;
            // 
            // btnDeshacer
            // 
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Image = (Image)resources.GetObject("btnDeshacer.Image");
            btnDeshacer.Location = new Point(370, 10);
            btnDeshacer.Margin = new Padding(3, 4, 3, 4);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(97, 52);
            btnDeshacer.TabIndex = 21;
            btnDeshacer.UseVisualStyleBackColor = true;
            btnDeshacer.MouseEnter += btnDeshacer_MouseEnter;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(144, 10);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 52);
            btnEditar.TabIndex = 20;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.MouseEnter += btnEditar_MouseEnter;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(30, 10);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(97, 52);
            btnNuevo.TabIndex = 19;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.MouseEnter += btnNuevo_MouseEnter;
            btnNuevo.MouseMove += btnNuevo_MouseMove;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(648, 29);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(105, 18);
            lblBuscar.TabIndex = 29;
            lblBuscar.Text = "Introducir texto";
            lblBuscar.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(772, 19);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(328, 24);
            txtBuscar.TabIndex = 30;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1110, 15);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(40, 33);
            btnBuscar.TabIndex = 31;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // listViewResultados
            // 
            listViewResultados.Location = new Point(894, 96);
            listViewResultados.Margin = new Padding(3, 4, 3, 4);
            listViewResultados.Name = "listViewResultados";
            listViewResultados.Size = new Size(318, 345);
            listViewResultados.TabIndex = 32;
            listViewResultados.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridViewResultados
            // 
            dataGridViewResultados.AllowUserToAddRows = false;
            dataGridViewResultados.AllowUserToDeleteRows = false;
            dataGridViewResultados.BackgroundColor = Color.FromArgb(128, 128, 255);
            dataGridViewResultados.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultados.Location = new Point(190, 461);
            dataGridViewResultados.Name = "dataGridViewResultados";
            dataGridViewResultados.ReadOnly = true;
            dataGridViewResultados.Size = new Size(1023, 212);
            dataGridViewResultados.TabIndex = 33;
            // 
            // lblCodCliente
            // 
            lblCodCliente.AutoSize = true;
            lblCodCliente.Depth = 0;
            lblCodCliente.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCodCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCodCliente.Location = new Point(81, 26);
            lblCodCliente.MouseState = MaterialSkin.MouseState.HOVER;
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(85, 19);
            lblCodCliente.TabIndex = 34;
            lblCodCliente.Text = "Cod. Cliente";
            lblCodCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Depth = 0;
            lblTipoDocumento.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTipoDocumento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTipoDocumento.Location = new Point(39, 100);
            lblTipoDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(130, 19);
            lblTipoDocumento.TabIndex = 36;
            lblTipoDocumento.Text = "Tipo Documento *";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Depth = 0;
            lblDocumento.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDocumento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDocumento.Location = new Point(65, 134);
            lblDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(102, 19);
            lblDocumento.TabIndex = 37;
            lblDocumento.Text = " Documento  *";
            lblDocumento.TextAlign = ContentAlignment.MiddleRight;
            lblDocumento.Click += lblDocumento_Click;
            // 
            // lblNombreComercial
            // 
            lblNombreComercial.AutoSize = true;
            lblNombreComercial.Depth = 0;
            lblNombreComercial.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombreComercial.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNombreComercial.Location = new Point(26, 173);
            lblNombreComercial.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombreComercial.Name = "lblNombreComercial";
            lblNombreComercial.Size = new Size(143, 19);
            lblNombreComercial.TabIndex = 39;
            lblNombreComercial.Text = "Nombre Comercial *";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 24);
            textBox1.TabIndex = 40;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 24);
            textBox2.TabIndex = 41;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1256, 820);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblNombreComercial);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(lblCodCliente);
            Controls.Add(dataGridViewResultados);
            Controls.Add(listViewResultados);
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
            Controls.Add(cboTipoDocumento);
            Font = new Font("Microsoft Sans Serif", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmCliente";
            Text = " Cliente";
            Load += frmCliente_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboTipoDocumento;
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
        private ListView listViewResultados;
        private DataGridView dataGridViewResultados;
        private MaterialSkin.Controls.MaterialLabel lblCodCliente;
        //private MaterialSkin.Controls.MaterialSingleLineTextField txtCodCliente;
        private MaterialSkin.Controls.MaterialLabel lblTipoDocumento;
        private MaterialSkin.Controls.MaterialLabel lblDocumento;
        //private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialLabel lblNombreComercial;
        //private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreComercial;
        private ToolTip toolTip2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}