namespace CaviForm
{
    partial class frmCambioUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioUsuario));
            groupBoxCambio = new GroupBox();
            radioButtonCambioUsuario = new RadioButton();
            radioButtonCambioContraseña = new RadioButton();
            lblContrasenya = new MaterialSkin.Controls.MaterialLabel();
            txtContrasenya = new MaterialSkin.Controls.MaterialSingleLineTextField();
            lblRepetirContrasenya = new MaterialSkin.Controls.MaterialLabel();
            txtRepetirContrasenya = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnGuardar = new Button();
            btnCerrar = new Button();
            groupBoxCambio.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCambio
            // 
            groupBoxCambio.BackColor = Color.Transparent;
            groupBoxCambio.Controls.Add(radioButtonCambioUsuario);
            groupBoxCambio.Controls.Add(radioButtonCambioContraseña);
            groupBoxCambio.FlatStyle = FlatStyle.Flat;
            groupBoxCambio.Location = new Point(32, 89);
            groupBoxCambio.Name = "groupBoxCambio";
            groupBoxCambio.Size = new Size(169, 82);
            groupBoxCambio.TabIndex = 0;
            groupBoxCambio.TabStop = false;
            // 
            // radioButtonCambioUsuario
            // 
            radioButtonCambioUsuario.AutoSize = true;
            radioButtonCambioUsuario.Location = new Point(16, 49);
            radioButtonCambioUsuario.Name = "radioButtonCambioUsuario";
            radioButtonCambioUsuario.Size = new Size(125, 19);
            radioButtonCambioUsuario.TabIndex = 1;
            radioButtonCambioUsuario.TabStop = true;
            radioButtonCambioUsuario.Text = "Cambio de usuario";
            radioButtonCambioUsuario.UseVisualStyleBackColor = true;
            // 
            // radioButtonCambioContraseña
            // 
            radioButtonCambioContraseña.AutoSize = true;
            radioButtonCambioContraseña.Location = new Point(16, 22);
            radioButtonCambioContraseña.Name = "radioButtonCambioContraseña";
            radioButtonCambioContraseña.Size = new Size(144, 19);
            radioButtonCambioContraseña.TabIndex = 0;
            radioButtonCambioContraseña.TabStop = true;
            radioButtonCambioContraseña.Text = "Cambio de contraseña";
            radioButtonCambioContraseña.UseVisualStyleBackColor = true;
            // 
            // lblContrasenya
            // 
            lblContrasenya.AutoSize = true;
            lblContrasenya.BackColor = Color.Transparent;
            lblContrasenya.Depth = 0;
            lblContrasenya.FlatStyle = FlatStyle.Flat;
            lblContrasenya.Font = new Font("Roboto", 11F);
            lblContrasenya.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblContrasenya.Location = new Point(221, 101);
            lblContrasenya.MouseState = MaterialSkin.MouseState.HOVER;
            lblContrasenya.Name = "lblContrasenya";
            lblContrasenya.Size = new Size(152, 19);
            lblContrasenya.TabIndex = 1;
            lblContrasenya.Text = "Introducir contraseña";
            lblContrasenya.Click += lblContrasenya_Click;
            // 
            // txtContrasenya
            // 
            txtContrasenya.Depth = 0;
            txtContrasenya.Hint = "";
            txtContrasenya.Location = new Point(394, 97);
            txtContrasenya.MaxLength = 32767;
            txtContrasenya.MouseState = MaterialSkin.MouseState.HOVER;
            txtContrasenya.Name = "txtContrasenya";
            txtContrasenya.PasswordChar = '\0';
            txtContrasenya.SelectedText = "";
            txtContrasenya.SelectionLength = 0;
            txtContrasenya.SelectionStart = 0;
            txtContrasenya.Size = new Size(187, 23);
            txtContrasenya.TabIndex = 2;
            txtContrasenya.TabStop = false;
            txtContrasenya.UseSystemPasswordChar = false;
            txtContrasenya.MouseEnter += txtContrasenya_MouseEnter;
            // 
            // lblRepetirContrasenya
            // 
            lblRepetirContrasenya.AutoSize = true;
            lblRepetirContrasenya.BackColor = Color.Transparent;
            lblRepetirContrasenya.Depth = 0;
            lblRepetirContrasenya.FlatStyle = FlatStyle.Flat;
            lblRepetirContrasenya.Font = new Font("Roboto", 11F);
            lblRepetirContrasenya.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblRepetirContrasenya.Location = new Point(238, 142);
            lblRepetirContrasenya.MouseState = MaterialSkin.MouseState.HOVER;
            lblRepetirContrasenya.Name = "lblRepetirContrasenya";
            lblRepetirContrasenya.Size = new Size(135, 19);
            lblRepetirContrasenya.TabIndex = 3;
            lblRepetirContrasenya.Text = "Repetir contraseña";
            // 
            // txtRepetirContrasenya
            // 
            txtRepetirContrasenya.Depth = 0;
            txtRepetirContrasenya.Hint = "";
            txtRepetirContrasenya.Location = new Point(394, 138);
            txtRepetirContrasenya.MaxLength = 32767;
            txtRepetirContrasenya.MouseState = MaterialSkin.MouseState.HOVER;
            txtRepetirContrasenya.Name = "txtRepetirContrasenya";
            txtRepetirContrasenya.PasswordChar = '\0';
            txtRepetirContrasenya.SelectedText = "";
            txtRepetirContrasenya.SelectionLength = 0;
            txtRepetirContrasenya.SelectionStart = 0;
            txtRepetirContrasenya.Size = new Size(187, 23);
            txtRepetirContrasenya.TabIndex = 4;
            txtRepetirContrasenya.TabStop = false;
            txtRepetirContrasenya.UseSystemPasswordChar = false;
            txtRepetirContrasenya.MouseEnter += txtRepetirContrasenya_MouseEnter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(276, 188);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 36);
            btnGuardar.TabIndex = 5;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.MouseEnter += btnGuardar_MouseEnter;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(394, 188);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(81, 36);
            btnCerrar.TabIndex = 6;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            // 
            // frmCambioUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 255);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtRepetirContrasenya);
            Controls.Add(lblRepetirContrasenya);
            Controls.Add(txtContrasenya);
            Controls.Add(lblContrasenya);
            Controls.Add(groupBoxCambio);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "frmCambioUsuario";
            Text = "Cambio de usuario y contraseña";
            Load += frmCambioUsuario_Load;
            groupBoxCambio.ResumeLayout(false);
            groupBoxCambio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCambio;
        private RadioButton radioButtonCambioUsuario;
        private RadioButton radioButtonCambioContraseña;
        private MaterialSkin.Controls.MaterialLabel lblContrasenya;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasenya;
        private MaterialSkin.Controls.MaterialLabel lblRepetirContrasenya;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRepetirContrasenya;
        private Button btnGuardar;
        private Button btnCerrar;
    }
}