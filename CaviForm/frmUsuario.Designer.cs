namespace CaviForm
{
    partial class frmUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            lblUsuarioId = new Label();
            txtUsuario = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblContrasenya = new Label();
            txtContrasnya = new TextBox();
            lblRepetirContra = new Label();
            txtRepetirContra = new TextBox();
            lblRol = new Label();
            cboRol = new ComboBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnDeshacer = new Button();
            btnGuardar = new Button();
            btnCerrar = new Button();
            toolTipUsuario = new ToolTip(components);
            SuspendLayout();
            // 
            // lblUsuarioId
            // 
            lblUsuarioId.AutoSize = true;
            lblUsuarioId.Location = new Point(31, 34);
            lblUsuarioId.Name = "lblUsuarioId";
            lblUsuarioId.Size = new Size(47, 15);
            lblUsuarioId.TabIndex = 0;
            lblUsuarioId.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(119, 26);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(174, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(31, 98);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 4;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(119, 90);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(174, 23);
            txtApellidos.TabIndex = 5;
            // 
            // lblContrasenya
            // 
            lblContrasenya.AutoSize = true;
            lblContrasenya.Location = new Point(31, 127);
            lblContrasenya.Name = "lblContrasenya";
            lblContrasenya.Size = new Size(67, 15);
            lblContrasenya.TabIndex = 6;
            lblContrasenya.Text = "Contraseña";
            // 
            // txtContrasnya
            // 
            txtContrasnya.Location = new Point(118, 119);
            txtContrasnya.Name = "txtContrasnya";
            txtContrasnya.Size = new Size(175, 23);
            txtContrasnya.TabIndex = 7;
            // 
            // lblRepetirContra
            // 
            lblRepetirContra.AutoSize = true;
            lblRepetirContra.Location = new Point(302, 31);
            lblRepetirContra.Name = "lblRepetirContra";
            lblRepetirContra.Size = new Size(103, 15);
            lblRepetirContra.TabIndex = 8;
            lblRepetirContra.Text = "Repetir Conraseña";
            // 
            // txtRepetirContra
            // 
            txtRepetirContra.Location = new Point(417, 23);
            txtRepetirContra.Name = "txtRepetirContra";
            txtRepetirContra.Size = new Size(174, 23);
            txtRepetirContra.TabIndex = 9;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(302, 64);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 10;
            lblRol.Text = "Rol";
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(416, 56);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(121, 23);
            cboRol.TabIndex = 11;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(302, 98);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 12;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(415, 90);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(176, 23);
            txtCorreo.TabIndex = 13;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(124, 162);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 43);
            btnNuevo.TabIndex = 14;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.MouseEnter += btnNuevo_MouseEnter;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(205, 162);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 43);
            btnEditar.TabIndex = 15;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.MouseEnter += btnEditar_MouseEnter;
            // 
            // btnDeshacer
            // 
            btnDeshacer.Image = (Image)resources.GetObject("btnDeshacer.Image");
            btnDeshacer.Location = new Point(367, 162);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(75, 43);
            btnDeshacer.TabIndex = 16;
            btnDeshacer.UseVisualStyleBackColor = true;
            btnDeshacer.MouseEnter += btnDeshacer_MouseEnter;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(286, 162);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 43);
            btnGuardar.TabIndex = 17;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.MouseEnter += btnGuardar_MouseEnter;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(448, 162);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 43);
            btnCerrar.TabIndex = 18;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            // 
            // toolTipUsuario
            // 
            toolTipUsuario.IsBalloon = true;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 226);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(btnDeshacer);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(cboRol);
            Controls.Add(lblRol);
            Controls.Add(txtRepetirContra);
            Controls.Add(lblRepetirContra);
            Controls.Add(txtContrasnya);
            Controls.Add(lblContrasenya);
            Controls.Add(txtApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuarioId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUsuario";
            Text = "Gestión Usuario";
            Load += frmUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarioId;
        private TextBox txtUsuario;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Label lblContrasenya;
        private TextBox txtContrasnya;
        private Label lblRepetirContra;
        private TextBox txtRepetirContra;
        private Label lblRol;
        private ComboBox cboRol;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnDeshacer;
        private Button btnGuardar;
        private Button btnCerrar;
        private ToolTip toolTipUsuario;
    }
}