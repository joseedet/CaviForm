namespace CaviForm
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblContrasenya = new MaterialSkin.Controls.MaterialLabel();
            txtContrasenya = new MaterialSkin.Controls.MaterialSingleLineTextField();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(174, 279);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(44, 45);
            btnAceptar.TabIndex = 4;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            btnAceptar.MouseEnter += btnAceptar_MouseEnter;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(244, 279);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(51, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.UseCompatibleTextRendering = true;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            btnCancelar.MouseEnter += btnCancelar_MouseEnter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Depth = 0;
            lblUsuario.Font = new Font("Roboto", 11F);
            lblUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblUsuario.Location = new Point(1812, 494);
            lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(61, 19);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.FlatStyle = FlatStyle.Flat;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(85, 217);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(71, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Usuario *";
            // 
            // txtUsuario
            // 
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 11F);
            txtUsuario.Hint = "";
            txtUsuario.Location = new Point(159, 219);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.Size = new Size(151, 23);
            txtUsuario.TabIndex = 8;
            txtUsuario.TabStop = false;
            txtUsuario.UseSystemPasswordChar = false;
            txtUsuario.MouseEnter += txtUsuario_MouseEnter;
            // 
            // lblContrasenya
            // 
            lblContrasenya.AutoSize = true;
            lblContrasenya.Depth = 0;
            lblContrasenya.FlatStyle = FlatStyle.Flat;
            lblContrasenya.Font = new Font("Roboto", 11F);
            lblContrasenya.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblContrasenya.Location = new Point(60, 248);
            lblContrasenya.MouseState = MaterialSkin.MouseState.HOVER;
            lblContrasenya.Name = "lblContrasenya";
            lblContrasenya.Size = new Size(96, 19);
            lblContrasenya.TabIndex = 9;
            lblContrasenya.Text = "Contraseña *";
            // 
            // txtContrasenya
            // 
            txtContrasenya.Depth = 0;
            txtContrasenya.Font = new Font("Microsoft Sans Serif", 11F);
            txtContrasenya.Hint = "";
            txtContrasenya.Location = new Point(159, 248);
            txtContrasenya.MaxLength = 32767;
            txtContrasenya.MouseState = MaterialSkin.MouseState.HOVER;
            txtContrasenya.Name = "txtContrasenya";
            txtContrasenya.PasswordChar = '*';
            txtContrasenya.SelectedText = "";
            txtContrasenya.SelectionLength = 0;
            txtContrasenya.SelectionStart = 0;
            txtContrasenya.Size = new Size(151, 23);
            txtContrasenya.TabIndex = 10;
            txtContrasenya.TabStop = false;
            txtContrasenya.UseSystemPasswordChar = false;
            txtContrasenya.KeyPress += txtContrasenya_KeyPress;
            txtContrasenya.MouseEnter += txtContrasenya_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(159, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 137);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 335);
            Controls.Add(pictureBox1);
            Controls.Add(txtContrasenya);
            Controls.Add(lblContrasenya);
            Controls.Add(txtUsuario);
            Controls.Add(materialLabel1);
            Controls.Add(lblUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            MaximizeBox = false;
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lblContrasenya;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenya;
        private PictureBox pictureBox1;
    }
}