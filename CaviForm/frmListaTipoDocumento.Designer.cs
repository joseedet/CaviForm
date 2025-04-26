namespace CaviForm
{
    partial class frmListaTipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaTipoDocumento));
            btnAceptar = new Button();
            btnCancelar = new Button();
            btnNuevo = new Button();
            dataGridViewTipoDocumentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTipoDocumentos).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(441, 560);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(81, 36);
            btnAceptar.TabIndex = 1;
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(670, 560);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(561, 560);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(81, 36);
            btnNuevo.TabIndex = 3;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTipoDocumentos
            // 
            dataGridViewTipoDocumentos.AllowUserToAddRows = false;
            dataGridViewTipoDocumentos.AllowUserToDeleteRows = false;
            dataGridViewTipoDocumentos.BorderStyle = BorderStyle.None;
            dataGridViewTipoDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTipoDocumentos.Location = new Point(214, 148);
            dataGridViewTipoDocumentos.Name = "dataGridViewTipoDocumentos";
            dataGridViewTipoDocumentos.ReadOnly = true;
            dataGridViewTipoDocumentos.Size = new Size(685, 332);
            dataGridViewTipoDocumentos.TabIndex = 4;
            dataGridViewTipoDocumentos.CellContentClick += this.dataGridViewTipoDocumentos_CellContentClick;
            // 
            // frmListaTipoDocumento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 621);
            Controls.Add(dataGridViewTipoDocumentos);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "frmListaTipoDocumento";
            Text = "Listado de documentos";
            Load += ListaTipoDocumento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTipoDocumentos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnNuevo;
        private DataGridView dataGridViewTipoDocumentos;
    }
}