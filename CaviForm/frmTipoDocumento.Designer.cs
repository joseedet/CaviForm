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
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoDocumento));
            lblTipoDocumento = new Label();
            txtDescripcion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(32, 40);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(96, 15);
            lblTipoDocumento.TabIndex = 0;
            lblTipoDocumento.Text = "Tipo Documento";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(134, 32);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(232, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(122, 89);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 36);
            btnAceptar.TabIndex = 2;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(239, 89);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 36);
            btnCancelar.TabIndex = 3;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmTipoDocumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 155);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(lblTipoDocumento);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmTipoDocumento";
            Text = "Tipo Documento";
            Load += frmTipoDocumento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoDocumento;
        private TextBox txtDescripcion;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}