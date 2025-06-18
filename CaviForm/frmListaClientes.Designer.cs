namespace CaviForm
{
    partial class frmListaClientes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaClientes));
            lstResultados = new ListBox();
            txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            groupBoxBusqueda = new GroupBox();
            radioRazonSocial = new RadioButton();
            radioCIF = new RadioButton();
            radioDNI = new RadioButton();
            btnCancelar = new Button();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnBuscar = new Button();
            toolTipListaClientes = new ToolTip(components);
            groupBoxBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // lstResultados
            // 
            lstResultados.BorderStyle = BorderStyle.None;
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(12, 191);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(436, 195);
            lstResultados.TabIndex = 3;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.Window;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 11F);
            txtBuscar.Hint = "";
            txtBuscar.Location = new Point(248, 139);
            txtBuscar.MaxLength = 32767;
            txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PasswordChar = '\0';
            txtBuscar.SelectedText = "";
            txtBuscar.SelectionLength = 0;
            txtBuscar.SelectionStart = 0;
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.TabIndex = 2;
            txtBuscar.TabStop = false;
            txtBuscar.UseSystemPasswordChar = false;
            // 
            // groupBoxBusqueda
            // 
            groupBoxBusqueda.BackColor = SystemColors.Window;
            groupBoxBusqueda.Controls.Add(radioRazonSocial);
            groupBoxBusqueda.Controls.Add(radioCIF);
            groupBoxBusqueda.Controls.Add(radioDNI);
            groupBoxBusqueda.FlatStyle = FlatStyle.Flat;
            groupBoxBusqueda.Font = new Font("Microsoft Sans Serif", 11F);
            groupBoxBusqueda.Location = new Point(12, 86);
            groupBoxBusqueda.Name = "groupBoxBusqueda";
            groupBoxBusqueda.Size = new Size(230, 88);
            groupBoxBusqueda.TabIndex = 0;
            groupBoxBusqueda.TabStop = false;
            groupBoxBusqueda.Text = "Opciones de búsqueda";
            // 
            // radioRazonSocial
            // 
            radioRazonSocial.AutoSize = true;
            radioRazonSocial.FlatStyle = FlatStyle.Flat;
            radioRazonSocial.Font = new Font("Microsoft Sans Serif", 11F);
            radioRazonSocial.Location = new Point(103, 26);
            radioRazonSocial.Name = "radioRazonSocial";
            radioRazonSocial.Size = new Size(114, 22);
            radioRazonSocial.TabIndex = 1;
            radioRazonSocial.TabStop = true;
            radioRazonSocial.Text = "Razón Social";
            radioRazonSocial.UseVisualStyleBackColor = true;
            // 
            // radioCIF
            // 
            radioCIF.AutoSize = true;
            radioCIF.FlatStyle = FlatStyle.Flat;
            radioCIF.Font = new Font("Microsoft Sans Serif", 11F);
            radioCIF.Location = new Point(19, 54);
            radioCIF.Name = "radioCIF";
            radioCIF.Size = new Size(48, 22);
            radioCIF.TabIndex = 2;
            radioCIF.TabStop = true;
            radioCIF.Text = "CIF";
            radioCIF.UseVisualStyleBackColor = true;
            // 
            // radioDNI
            // 
            radioDNI.AutoSize = true;
            radioDNI.FlatStyle = FlatStyle.Flat;
            radioDNI.Font = new Font("Microsoft Sans Serif", 11F);
            radioDNI.Location = new Point(19, 26);
            radioDNI.Name = "radioDNI";
            radioDNI.Size = new Size(78, 22);
            radioDNI.TabIndex = 0;
            radioDNI.TabStop = true;
            radioDNI.Text = "DNI/NIE";
            radioDNI.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(471, 340);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(46, 46);
            btnCancelar.TabIndex = 4;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            btnCancelar.MouseEnter += btnCancelar_MouseEnter;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.FlatStyle = FlatStyle.Flat;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(248, 112);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(194, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Introduzca el texto a buscar";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(471, 215);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(46, 46);
            btnBuscar.TabIndex = 5;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            // 
            // toolTipListaClientes
            // 
            toolTipListaClientes.IsBalloon = true;
            // 
            // frmListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 406);
            Controls.Add(btnBuscar);
            Controls.Add(materialLabel1);
            Controls.Add(btnCancelar);
            Controls.Add(groupBoxBusqueda);
            Controls.Add(txtBuscar);
            Controls.Add(lstResultados);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaClientes";
            Text = "Lista Clientes";
            Load += frmListaClientes_Load;
            groupBoxBusqueda.ResumeLayout(false);
            groupBoxBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstResultados;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private GroupBox groupBoxBusqueda;
        private RadioButton radioRazonSocial;
        private RadioButton radioCIF;
        private RadioButton radioDNI;
        private Button btnCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Button btnBuscar;
        private ToolTip toolTipListaClientes;
    }
}