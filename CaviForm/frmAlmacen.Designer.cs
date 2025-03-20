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
            txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            btnAceptar = new Button();
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
            btnCancelar.Location = new Point(228, 165);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(62, 43);
            btnCancelar.TabIndex = 7;
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
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "Descripción *";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Depth = 0;
            txtDescripcion.Hint = "";
            txtDescripcion.Location = new Point(119, 111);
            txtDescripcion.MaxLength = 32767;
            txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PasswordChar = '\0';
            txtDescripcion.SelectedText = "";
            txtDescripcion.SelectionLength = 0;
            txtDescripcion.SelectionStart = 0;
            txtDescripcion.Size = new Size(290, 23);
            txtDescripcion.TabIndex = 9;
            txtDescripcion.TabStop = false;
            txtDescripcion.UseSystemPasswordChar = false;
            txtDescripcion.Validated += txtDescripcion_Validated;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(162, 165);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(62, 43);
            btnAceptar.TabIndex = 6;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            btnAceptar.MouseEnter += btnAceptar_MouseEnter;
            // 
            // frmAlmacen
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(431, 252);
            Controls.Add(txtDescripcion);
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private Button btnAceptar;
    }
}