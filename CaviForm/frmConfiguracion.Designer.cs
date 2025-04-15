
namespace CaviForm
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            panel1 = new Panel();
            btnIva = new Button();
            btnConcepto = new Button();
            btnAlmacen = new Button();
            lblFormularios = new MaterialSkin.Controls.MaterialLabel();
            btnCerrar = new Button();
            panel2 = new Panel();
            btnCambioContrasenya = new Button();
            btnCambiarUsuario = new Button();
            lblGestionUsuarios = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnIva);
            panel1.Controls.Add(btnConcepto);
            panel1.Controls.Add(btnAlmacen);
            panel1.Location = new Point(21, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 200);
            panel1.TabIndex = 0;
            // 
            // btnIva
            // 
            btnIva.BackColor = Color.Transparent;
            btnIva.FlatAppearance.BorderSize = 0;
            btnIva.FlatStyle = FlatStyle.Flat;
            btnIva.Image = (Image)resources.GetObject("btnIva.Image");
            btnIva.Location = new Point(179, 13);
            btnIva.Name = "btnIva";
            btnIva.Size = new Size(63, 55);
            btnIva.TabIndex = 1;
            btnIva.UseVisualStyleBackColor = false;
            btnIva.MouseEnter += btnIva_MouseEnter;
            // 
            // btnConcepto
            // 
            btnConcepto.BackColor = Color.Transparent;
            btnConcepto.FlatAppearance.BorderSize = 0;
            btnConcepto.FlatStyle = FlatStyle.Flat;
            btnConcepto.Image = (Image)resources.GetObject("btnConcepto.Image");
            btnConcepto.Location = new Point(96, 13);
            btnConcepto.Name = "btnConcepto";
            btnConcepto.Size = new Size(63, 55);
            btnConcepto.TabIndex = 1;
            btnConcepto.UseVisualStyleBackColor = false;
            btnConcepto.MouseEnter += btnConcepto_MouseEnter;
            // 
            // btnAlmacen
            // 
            btnAlmacen.BackColor = Color.Transparent;
            btnAlmacen.FlatAppearance.BorderSize = 0;
            btnAlmacen.FlatStyle = FlatStyle.Flat;
            btnAlmacen.Image = (Image)resources.GetObject("btnAlmacen.Image");
            btnAlmacen.Location = new Point(17, 13);
            btnAlmacen.Name = "btnAlmacen";
            btnAlmacen.Size = new Size(63, 55);
            btnAlmacen.TabIndex = 0;
            btnAlmacen.UseVisualStyleBackColor = false;
            btnAlmacen.Click += btnAlmacen_Click;
            btnAlmacen.MouseEnter += btnAlmacen_MouseEnter;
            // 
            // lblFormularios
            // 
            lblFormularios.AutoSize = true;
            lblFormularios.BackColor = Color.Transparent;
            lblFormularios.Depth = 0;
            lblFormularios.FlatStyle = FlatStyle.Flat;
            lblFormularios.Font = new Font("Roboto", 11F);
            lblFormularios.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblFormularios.Location = new Point(26, 80);
            lblFormularios.MouseState = MaterialSkin.MouseState.HOVER;
            lblFormularios.Name = "lblFormularios";
            lblFormularios.Size = new Size(162, 19);
            lblFormularios.TabIndex = 1;
            lblFormularios.Text = "Configuración Maestra";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(962, 673);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(46, 52);
            btnCerrar.TabIndex = 24;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnCambioContrasenya);
            panel2.Controls.Add(btnCambiarUsuario);
            panel2.Location = new Point(654, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 79);
            panel2.TabIndex = 25;
            // 
            // btnCambioContrasenya
            // 
            btnCambioContrasenya.FlatAppearance.BorderSize = 0;
            btnCambioContrasenya.FlatStyle = FlatStyle.Flat;
            btnCambioContrasenya.Image = (Image)resources.GetObject("btnCambioContrasenya.Image");
            btnCambioContrasenya.Location = new Point(105, 13);
            btnCambioContrasenya.Name = "btnCambioContrasenya";
            btnCambioContrasenya.Size = new Size(46, 46);
            btnCambioContrasenya.TabIndex = 1;
            btnCambioContrasenya.UseVisualStyleBackColor = true;
            btnCambioContrasenya.MouseEnter += btnCambioContrasenya_MousEnter;
            // 
            // btnCambiarUsuario
            // 
            btnCambiarUsuario.FlatAppearance.BorderSize = 0;
            btnCambiarUsuario.FlatStyle = FlatStyle.Flat;
            btnCambiarUsuario.Image = (Image)resources.GetObject("btnCambiarUsuario.Image");
            btnCambiarUsuario.Location = new Point(27, 17);
            btnCambiarUsuario.Name = "btnCambiarUsuario";
            btnCambiarUsuario.Size = new Size(46, 46);
            btnCambiarUsuario.TabIndex = 0;
            btnCambiarUsuario.UseVisualStyleBackColor = true;
            btnCambiarUsuario.MouseEnter += btnCambiarUsuario_MouseEnter;
            // 
            // lblGestionUsuarios
            // 
            lblGestionUsuarios.AutoSize = true;
            lblGestionUsuarios.BackColor = Color.Transparent;
            lblGestionUsuarios.FlatStyle = FlatStyle.Flat;
            lblGestionUsuarios.Font = new Font("Microsoft Sans Serif", 11F);
            lblGestionUsuarios.Location = new Point(654, 80);
            lblGestionUsuarios.Name = "lblGestionUsuarios";
            lblGestionUsuarios.Size = new Size(141, 18);
            lblGestionUsuarios.TabIndex = 26;
            lblGestionUsuarios.Text = "Gestión de usuarios";
            // 
            // frmConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 784);
            Controls.Add(lblGestionUsuarios);
            Controls.Add(panel2);
            Controls.Add(btnCerrar);
            Controls.Add(lblFormularios);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmConfiguracion";
            Text = "Configuración";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel panel1;
        private Button btnAlmacen;
        private Button btnConcepto;
        private Button btnIva;
        private MaterialSkin.Controls.MaterialLabel lblFormularios;
        private Button btnCerrar;
        private Panel panel2;
        private Button btnCambiarUsuario;
        private Button btnCambioContrasenya;
        private Label lblGestionUsuarios;
    }
}