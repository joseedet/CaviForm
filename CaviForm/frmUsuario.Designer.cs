
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            btnNuevo = new Button();
            btnEditar = new Button();
            btnDeshacer = new Button();
            btnGuardar = new Button();
            btnCerrar = new Button();
            toolTipUsuario = new ToolTip(components);
            lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblApellidos = new MaterialSkin.Controls.MaterialLabel();
            lblContrenya = new MaterialSkin.Controls.MaterialLabel();
            lblRepetirContra = new MaterialSkin.Controls.MaterialLabel();
            lblRol = new MaterialSkin.Controls.MaterialLabel();
            lblCorreo = new MaterialSkin.Controls.MaterialLabel();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            materialMultiLineTextBox3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            materialMultiLineTextBox4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            cboRol = new ComboBox();
            materialMultiLineTextBox5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            materialMultiLineTextBox6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(166, 291);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 49);
            btnNuevo.TabIndex = 14;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.MouseEnter += btnNuevo_MouseEnter;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(258, 291);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 49);
            btnEditar.TabIndex = 15;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.MouseEnter += btnEditar_MouseEnter;
            // 
            // btnDeshacer
            // 
            btnDeshacer.BackColor = Color.Transparent;
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Image = (Image)resources.GetObject("btnDeshacer.Image");
            btnDeshacer.Location = new Point(443, 291);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(86, 49);
            btnDeshacer.TabIndex = 17;
            btnDeshacer.UseVisualStyleBackColor = false;
            btnDeshacer.MouseEnter += btnDeshacer_MouseEnter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(351, 291);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 49);
            btnGuardar.TabIndex = 16;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.MouseEnter += btnGuardar_MouseEnter;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(536, 291);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(86, 49);
            btnCerrar.TabIndex = 18;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            // 
            // toolTipUsuario
            // 
            toolTipUsuario.IsBalloon = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.FlatStyle = FlatStyle.Flat;
            lblUsuario.Font = new Font("Roboto", 11F);
            lblUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblUsuario.Location = new Point(51, 108);
            lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(65, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = " Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.FlatStyle = FlatStyle.Flat;
            lblNombre.Font = new Font("Roboto", 11F);
            lblNombre.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblNombre.Location = new Point(49, 146);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 19);
            lblNombre.TabIndex = 3;
            lblNombre.Text = " Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Depth = 0;
            lblApellidos.FlatStyle = FlatStyle.Flat;
            lblApellidos.Font = new Font("Roboto", 11F);
            lblApellidos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblApellidos.Location = new Point(39, 181);
            lblApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(76, 19);
            lblApellidos.TabIndex = 4;
            lblApellidos.Text = " Apellidos";
            lblApellidos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblContrenya
            // 
            lblContrenya.AutoSize = true;
            lblContrenya.Depth = 0;
            lblContrenya.FlatStyle = FlatStyle.Flat;
            lblContrenya.Font = new Font("Roboto", 11F);
            lblContrenya.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblContrenya.Location = new Point(21, 221);
            lblContrenya.MouseState = MaterialSkin.MouseState.HOVER;
            lblContrenya.Name = "lblContrenya";
            lblContrenya.Size = new Size(90, 19);
            lblContrenya.TabIndex = 6;
            lblContrenya.Text = " Contraseña";
            lblContrenya.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRepetirContra
            // 
            lblRepetirContra.AutoSize = true;
            lblRepetirContra.Depth = 0;
            lblRepetirContra.FlatStyle = FlatStyle.Flat;
            lblRepetirContra.Font = new Font("Roboto", 11F);
            lblRepetirContra.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblRepetirContra.Location = new Point(393, 105);
            lblRepetirContra.MouseState = MaterialSkin.MouseState.HOVER;
            lblRepetirContra.Name = "lblRepetirContra";
            lblRepetirContra.Size = new Size(135, 19);
            lblRepetirContra.TabIndex = 8;
            lblRepetirContra.Text = "Repetir contraseña";
            lblRepetirContra.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Depth = 0;
            lblRol.FlatStyle = FlatStyle.Flat;
            lblRol.Font = new Font("Roboto", 11F);
            lblRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblRol.Location = new Point(512, 146);
            lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 19);
            lblRol.TabIndex = 10;
            lblRol.Text = "Rol";
            lblRol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Depth = 0;
            lblCorreo.FlatStyle = FlatStyle.Flat;
            lblCorreo.Font = new Font("Roboto", 11F);
            lblCorreo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblCorreo.Location = new Point(485, 184);
            lblCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(55, 19);
            lblCorreo.TabIndex = 12;
            lblCorreo.Text = "Correo";
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Hint = "";
            materialMultiLineTextBox1.Location = new Point(139, 142);
            materialMultiLineTextBox1.MaxLength = 32767;
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.PasswordChar = '\0';
            materialMultiLineTextBox1.SelectedText = "";
            materialMultiLineTextBox1.SelectionLength = 0;
            materialMultiLineTextBox1.SelectionStart = 0;
            materialMultiLineTextBox1.Size = new Size(219, 23);
            materialMultiLineTextBox1.TabIndex = 20;
            materialMultiLineTextBox1.TabStop = false;
            materialMultiLineTextBox1.UseSystemPasswordChar = false;
            // 
            // materialMultiLineTextBox2
            // 
            materialMultiLineTextBox2.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox2.Depth = 0;
            materialMultiLineTextBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox2.Hint = "";
            materialMultiLineTextBox2.Location = new Point(139, 176);
            materialMultiLineTextBox2.MaxLength = 32767;
            materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            materialMultiLineTextBox2.PasswordChar = '\0';
            materialMultiLineTextBox2.SelectedText = "";
            materialMultiLineTextBox2.SelectionLength = 0;
            materialMultiLineTextBox2.SelectionStart = 0;
            materialMultiLineTextBox2.Size = new Size(320, 23);
            materialMultiLineTextBox2.TabIndex = 21;
            materialMultiLineTextBox2.TabStop = false;
            materialMultiLineTextBox2.UseSystemPasswordChar = false;
            // 
            // materialMultiLineTextBox3
            // 
            materialMultiLineTextBox3.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox3.Depth = 0;
            materialMultiLineTextBox3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox3.Hint = "";
            materialMultiLineTextBox3.Location = new Point(139, 210);
            materialMultiLineTextBox3.MaxLength = 32767;
            materialMultiLineTextBox3.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox3.Name = "materialMultiLineTextBox3";
            materialMultiLineTextBox3.PasswordChar = '\0';
            materialMultiLineTextBox3.SelectedText = "";
            materialMultiLineTextBox3.SelectionLength = 0;
            materialMultiLineTextBox3.SelectionStart = 0;
            materialMultiLineTextBox3.Size = new Size(297, 23);
            materialMultiLineTextBox3.TabIndex = 22;
            materialMultiLineTextBox3.TabStop = false;
            materialMultiLineTextBox3.UseSystemPasswordChar = false;
            // 
            // materialMultiLineTextBox4
            // 
            materialMultiLineTextBox4.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox4.Depth = 0;
            materialMultiLineTextBox4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox4.Hint = "";
            materialMultiLineTextBox4.Location = new Point(545, 103);
            materialMultiLineTextBox4.MaxLength = 32767;
            materialMultiLineTextBox4.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox4.Name = "materialMultiLineTextBox4";
            materialMultiLineTextBox4.PasswordChar = '\0';
            materialMultiLineTextBox4.SelectedText = "";
            materialMultiLineTextBox4.SelectionLength = 0;
            materialMultiLineTextBox4.SelectionStart = 0;
            materialMultiLineTextBox4.Size = new Size(203, 23);
            materialMultiLineTextBox4.TabIndex = 23;
            materialMultiLineTextBox4.TabStop = false;
            materialMultiLineTextBox4.UseSystemPasswordChar = false;
            // 
            // cboRol
            // 
            cboRol.BackColor = Color.White;
            cboRol.FlatStyle = FlatStyle.Flat;
            cboRol.Font = new Font("Microsoft Sans Serif", 11F);
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(545, 142);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(213, 26);
            cboRol.TabIndex = 11;
            // 
            // materialMultiLineTextBox5
            // 
            materialMultiLineTextBox5.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox5.Depth = 0;
            materialMultiLineTextBox5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox5.Hint = "";
            materialMultiLineTextBox5.Location = new Point(545, 184);
            materialMultiLineTextBox5.MaxLength = 32767;
            materialMultiLineTextBox5.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox5.Name = "materialMultiLineTextBox5";
            materialMultiLineTextBox5.PasswordChar = '\0';
            materialMultiLineTextBox5.SelectedText = "";
            materialMultiLineTextBox5.SelectionLength = 0;
            materialMultiLineTextBox5.SelectionStart = 0;
            materialMultiLineTextBox5.Size = new Size(280, 23);
            materialMultiLineTextBox5.TabIndex = 24;
            materialMultiLineTextBox5.TabStop = false;
            materialMultiLineTextBox5.UseSystemPasswordChar = false;
            // 
            // materialMultiLineTextBox6
            // 
            materialMultiLineTextBox6.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox6.Depth = 0;
            materialMultiLineTextBox6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox6.Hint = "";
            materialMultiLineTextBox6.Location = new Point(139, 101);
            materialMultiLineTextBox6.MaxLength = 32767;
            materialMultiLineTextBox6.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox6.Name = "materialMultiLineTextBox6";
            materialMultiLineTextBox6.PasswordChar = '\0';
            materialMultiLineTextBox6.SelectedText = "";
            materialMultiLineTextBox6.SelectionLength = 0;
            materialMultiLineTextBox6.SelectionStart = 0;
            materialMultiLineTextBox6.Size = new Size(219, 23);
            materialMultiLineTextBox6.TabIndex = 25;
            materialMultiLineTextBox6.TabStop = false;
            materialMultiLineTextBox6.UseSystemPasswordChar = false;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(857, 377);
            Controls.Add(materialMultiLineTextBox6);
            Controls.Add(materialMultiLineTextBox5);
            Controls.Add(materialMultiLineTextBox4);
            Controls.Add(materialMultiLineTextBox3);
            Controls.Add(materialMultiLineTextBox2);
            Controls.Add(materialMultiLineTextBox1);
            Controls.Add(lblCorreo);
            Controls.Add(lblRol);
            Controls.Add(lblRepetirContra);
            Controls.Add(lblContrenya);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(lblUsuario);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(btnDeshacer);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(cboRol);
            Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            MaximizeBox = false;
            Name = "frmUsuario";
            StartPosition = FormStartPosition.Manual;
            Text = "Gestión Usuario";
            Load += frmUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCerrar_Click (object sender, EventArgs e)
        {
            Close();
        }

        #endregion
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnDeshacer;
        private Button btnGuardar;
        private Button btnCerrar;
        private ToolTip toolTipUsuario;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        //private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldUsuario;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblApellidos;
        private MaterialSkin.Controls.MaterialLabel lblContrenya;
        private MaterialSkin.Controls.MaterialLabel lblRepetirContra;
        private MaterialSkin.Controls.MaterialLabel lblRole;
        private MaterialSkin.Controls.MaterialLabel lblCorreo;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialMultiLineTextBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialMultiLineTextBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialMultiLineTextBox4;
        private ComboBox cboRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialMultiLineTextBox5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialMultiLineTextBox6;
    }
}