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
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            checkBoxActivo = new CheckBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(160, 190);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(81, 36);
            btnAceptar.TabIndex = 3;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(293, 190);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Depth = 0;
            lblDescripcion.Font = new Font("Roboto", 11F);
            lblDescripcion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblDescripcion.Location = new Point(37, 110);
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
            txtDescripcion.Location = new Point(144, 106);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.MaxLength = 32767;
            txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PasswordChar = '\0';
            txtDescripcion.SelectedText = "";
            txtDescripcion.SelectionLength = 0;
            txtDescripcion.SelectionStart = 0;
            txtDescripcion.Size = new Size(264, 23);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.TabStop = false;
            txtDescripcion.UseSystemPasswordChar = false;
            txtDescripcion.Validated += txtDescripcion_Validated;
            txtDescripcion.Validating += txtDescripcion_Validating;
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.BackColor = Color.Transparent;
            checkBoxActivo.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxActivo.Checked = true;
            checkBoxActivo.CheckState = CheckState.Checked;
            checkBoxActivo.FlatAppearance.BorderSize = 0;
            checkBoxActivo.FlatStyle = FlatStyle.Flat;
            checkBoxActivo.Location = new Point(72, 136);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(64, 22);
            checkBoxActivo.TabIndex = 5;
            checkBoxActivo.Text = "Activo";
            checkBoxActivo.UseVisualStyleBackColor = false;
            // 
            // frmTipoDocumento
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 239);
            Controls.Add(checkBoxActivo);
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
        private CheckBox checkBoxActivo;
    }
}