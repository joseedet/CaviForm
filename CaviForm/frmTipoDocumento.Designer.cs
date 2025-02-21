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
            lstResultados = new ListBox();
            btnNuevo = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(38, 12);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(96, 15);
            lblTipoDocumento.TabIndex = 0;
            lblTipoDocumento.Text = "Tipo Documento";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(38, 30);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(232, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(38, 294);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 36);
            btnAceptar.TabIndex = 2;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(195, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 36);
            btnCancelar.TabIndex = 3;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(38, 79);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(232, 184);
            lstResultados.TabIndex = 4;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(276, 94);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 36);
            btnNuevo.TabIndex = 5;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(276, 151);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(273, 209);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            // 
            // frmTipoDocumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 342);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnNuevo);
            Controls.Add(lstResultados);
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
        private ListBox lstResultados;
        private Button btnNuevo;
        private Button button1;
        private Button button2;
    }
}