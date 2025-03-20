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
            btnAceptar = new Button();
            txtDescripcion = new TextBox();
            lblAlmacien = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(237, 91);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 36);
            btnCancelar.TabIndex = 7;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(80, 91);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 36);
            btnAceptar.TabIndex = 6;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(91, 41);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(232, 23);
            txtDescripcion.TabIndex = 5;
            txtDescripcion.Validating += txtDescripcion_Validating;
            // 
            // lblAlmacien
            // 
            lblAlmacien.AutoSize = true;
            lblAlmacien.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlmacien.Location = new Point(9, 48);
            lblAlmacien.Name = "lblAlmacien";
            lblAlmacien.Size = new Size(76, 16);
            lblAlmacien.TabIndex = 4;
            lblAlmacien.Text = "Almacén *";
            // 
            // frmAlmacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(335, 156);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(lblAlmacien);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAlmacen";
            Text = "Almacén";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtDescripcion;
        private Label lblAlmacien;
    }
}