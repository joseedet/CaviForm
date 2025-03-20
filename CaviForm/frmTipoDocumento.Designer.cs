namespace CaviForm
{
    partial class frmTipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoDocumento));
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(168, 148);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(80, 43);
            btnAceptar.TabIndex = 3;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(288, 148);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 43);
            btnCancelar.TabIndex = 4;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Depth = 0;
            lblDescripcion.Font = new Font("Roboto", 11F);
            lblDescripcion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDescripcion.Location = new Point(20, 103);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(99, 19);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción *";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Depth = 0;
            txtDescripcion.Hint = "";
            txtDescripcion.Location = new Point(127, 99);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.MaxLength = 32767;
            txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PasswordChar = '\0';
            txtDescripcion.SelectedText = "";
            txtDescripcion.SelectionLength = 0;
            txtDescripcion.SelectionStart = 0;
            txtDescripcion.Size = new Size(329, 23);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.TabStop = false;
            txtDescripcion.UseSystemPasswordChar = false;
            txtDescripcion.Validated += txtDescripcion_Validated;
            txtDescripcion.Validating += txtDescripcion_Validating;
            // 
            // frmTipoDocumento
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 221);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Font = new Font("Microsoft Sans Serif", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmTipoDocumento";
            Text = "Tipo Documento";
            Load += frmTipoDocumento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
    }
}