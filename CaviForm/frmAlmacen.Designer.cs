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
            btnCancelar.Location = new Point(235, 183);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(62, 43);
            btnCancelar.TabIndex = 5;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            btnCancelar.MouseEnter += btnCancelar_MouseEnter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Depth = 0;
            lblDescripcion.FlatStyle = FlatStyle.Flat;
            lblDescripcion.Font = new Font("Roboto", 11F);
            lblDescripcion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDescripcion.Location = new Point(15, 111);
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
            btnAceptar.Location = new Point(169, 183);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(62, 43);
            btnAceptar.TabIndex = 4;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            btnAceptar.MouseEnter += btnAceptar_MouseEnter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(59, 137);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 22);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Activo";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Depth = 0;
            txtDescripcion.Hint = "";
            txtDescripcion.Location = new Point(122, 107);
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
            // frmAlmacen
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(431, 252);
            Controls.Add(txtDescripcion);
            Controls.Add(checkBox1);
            Controls.Add(lblDescripcion);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Font = new Font("Microsoft Sans Serif", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
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
    }
}