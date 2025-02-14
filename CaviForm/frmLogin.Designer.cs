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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasenya = new Label();
            txtContrasenya = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(38, 34);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(111, 26);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(152, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblContrasenya
            // 
            lblContrasenya.AutoSize = true;
            lblContrasenya.Location = new Point(38, 62);
            lblContrasenya.Name = "lblContrasenya";
            lblContrasenya.Size = new Size(67, 15);
            lblContrasenya.TabIndex = 2;
            lblContrasenya.Text = "Contraseña";
            // 
            // txtContrasenya
            // 
            txtContrasenya.Location = new Point(111, 54);
            txtContrasenya.Name = "txtContrasenya";
            txtContrasenya.Size = new Size(152, 23);
            txtContrasenya.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(85, 101);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(67, 45);
            btnAceptar.TabIndex = 4;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(169, 101);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.UseCompatibleTextRendering = true;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 158);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtContrasenya);
            Controls.Add(lblContrasenya);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContrasenya;
        private TextBox txtContrasenya;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}