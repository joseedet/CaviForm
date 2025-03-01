﻿namespace CaviForm
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStripPrincipal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemConectar = new ToolStripMenuItem();
            toolStripMenuItemDesconectar = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemCambiarUsuario = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItemBloquear = new ToolStripMenuItem();
            toolStripMenuItemDesBloquear = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripMenuItemClave = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripMenuItemSalir = new ToolStripMenuItem();
            MaestrosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemAlmacen = new ToolStripMenuItem();
            toolStripMenuItemCliente = new ToolStripMenuItem();
            toolStripMenuItemConcepto = new ToolStripMenuItem();
            toolStripMenuItemProducto = new ToolStripMenuItem();
            toolStripMenuItemDepartamentos = new ToolStripMenuItem();
            toolStripMenuItemIVAs = new ToolStripMenuItem();
            toolStripMenuItemProductos = new ToolStripMenuItem();
            toolStripMenuItemUnidadesMedidas = new ToolStripMenuItem();
            toolStripMenuItemProveedor = new ToolStripMenuItem();
            toolStripMenuItemTipoDocumento = new ToolStripMenuItem();
            MovimientosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemCompras = new ToolStripMenuItem();
            toolStripMenuItemDevoluciones = new ToolStripMenuItem();
            toolStripMenuItemSalidas = new ToolStripMenuItem();
            toolStripMenuItemTraslados = new ToolStripMenuItem();
            toolStripMenuItemVentas = new ToolStripMenuItem();
            ConsultasToolStripMenuItem = new ToolStripMenuItem();
            InformesToolStripMenuItem = new ToolStripMenuItem();
            AyudaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemAyuda1 = new ToolStripMenuItem();
            toolStripMenuItemAcerca = new ToolStripMenuItem();
            statusStripPrincipal = new StatusStrip();
            menuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, MaestrosToolStripMenuItem, MovimientosToolStripMenuItem, ConsultasToolStripMenuItem, InformesToolStripMenuItem, AyudaToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(1035, 24);
            menuStripPrincipal.TabIndex = 0;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemConectar, toolStripMenuItemDesconectar, toolStripSeparator1, toolStripMenuItemCambiarUsuario, toolStripSeparator2, toolStripMenuItemBloquear, toolStripMenuItemDesBloquear, toolStripSeparator3, toolStripMenuItemClave, toolStripSeparator4, toolStripMenuItemSalir });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // toolStripMenuItemConectar
            // 
            toolStripMenuItemConectar.Image = (Image)resources.GetObject("toolStripMenuItemConectar.Image");
            toolStripMenuItemConectar.Name = "toolStripMenuItemConectar";
            toolStripMenuItemConectar.Size = new Size(180, 22);
            toolStripMenuItemConectar.Text = "&Conectar";
            toolStripMenuItemConectar.ToolTipText = "Ingresar a la aplicación";
            toolStripMenuItemConectar.Click += toolStripMenuItemConectar_Click;
            // 
            // toolStripMenuItemDesconectar
            // 
            toolStripMenuItemDesconectar.Image = (Image)resources.GetObject("toolStripMenuItemDesconectar.Image");
            toolStripMenuItemDesconectar.Name = "toolStripMenuItemDesconectar";
            toolStripMenuItemDesconectar.Size = new Size(180, 22);
            toolStripMenuItemDesconectar.Text = "&Dessconectar";
            toolStripMenuItemDesconectar.ToolTipText = "Desconectar ";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // toolStripMenuItemCambiarUsuario
            // 
            toolStripMenuItemCambiarUsuario.Image = (Image)resources.GetObject("toolStripMenuItemCambiarUsuario.Image");
            toolStripMenuItemCambiarUsuario.Name = "toolStripMenuItemCambiarUsuario";
            toolStripMenuItemCambiarUsuario.Size = new Size(180, 22);
            toolStripMenuItemCambiarUsuario.Text = "Cambiar &Usuario";
            toolStripMenuItemCambiarUsuario.ToolTipText = "Cambiar de Usuario";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // toolStripMenuItemBloquear
            // 
            toolStripMenuItemBloquear.Image = (Image)resources.GetObject("toolStripMenuItemBloquear.Image");
            toolStripMenuItemBloquear.Name = "toolStripMenuItemBloquear";
            toolStripMenuItemBloquear.Size = new Size(180, 22);
            toolStripMenuItemBloquear.Text = "&Bloquear";
            // 
            // toolStripMenuItemDesBloquear
            // 
            toolStripMenuItemDesBloquear.Image = (Image)resources.GetObject("toolStripMenuItemDesBloquear.Image");
            toolStripMenuItemDesBloquear.Name = "toolStripMenuItemDesBloquear";
            toolStripMenuItemDesBloquear.Size = new Size(180, 22);
            toolStripMenuItemDesBloquear.Text = "D&esbloquear";
            toolStripMenuItemDesBloquear.ToolTipText = "Desbloquear";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // toolStripMenuItemClave
            // 
            toolStripMenuItemClave.Image = (Image)resources.GetObject("toolStripMenuItemClave.Image");
            toolStripMenuItemClave.Name = "toolStripMenuItemClave";
            toolStripMenuItemClave.Size = new Size(180, 22);
            toolStripMenuItemClave.Text = "C&ambio de Clave";
            toolStripMenuItemClave.ToolTipText = "Cambiar Clave";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // toolStripMenuItemSalir
            // 
            toolStripMenuItemSalir.Image = (Image)resources.GetObject("toolStripMenuItemSalir.Image");
            toolStripMenuItemSalir.Name = "toolStripMenuItemSalir";
            toolStripMenuItemSalir.Size = new Size(180, 22);
            toolStripMenuItemSalir.Text = "&Salir";
            toolStripMenuItemSalir.Click += toolStripMenuItemSalir_Click;
            // 
            // MaestrosToolStripMenuItem
            // 
            MaestrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAlmacen, toolStripMenuItemCliente, toolStripMenuItemConcepto, toolStripMenuItemProducto, toolStripMenuItemProveedor, toolStripMenuItemTipoDocumento });
            MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem";
            MaestrosToolStripMenuItem.Size = new Size(67, 20);
            MaestrosToolStripMenuItem.Text = "&Maestros";
            // 
            // toolStripMenuItemAlmacen
            // 
            toolStripMenuItemAlmacen.Image = (Image)resources.GetObject("toolStripMenuItemAlmacen.Image");
            toolStripMenuItemAlmacen.Name = "toolStripMenuItemAlmacen";
            toolStripMenuItemAlmacen.Size = new Size(163, 22);
            toolStripMenuItemAlmacen.Text = "&Almacén";
            toolStripMenuItemAlmacen.Click += toolStripMenuItemAlmacen_Click;
            // 
            // toolStripMenuItemCliente
            // 
            toolStripMenuItemCliente.Image = (Image)resources.GetObject("toolStripMenuItemCliente.Image");
            toolStripMenuItemCliente.Name = "toolStripMenuItemCliente";
            toolStripMenuItemCliente.Size = new Size(163, 22);
            toolStripMenuItemCliente.Text = "&Clientes";
            // 
            // toolStripMenuItemConcepto
            // 
            toolStripMenuItemConcepto.Image = (Image)resources.GetObject("toolStripMenuItemConcepto.Image");
            toolStripMenuItemConcepto.Name = "toolStripMenuItemConcepto";
            toolStripMenuItemConcepto.Size = new Size(163, 22);
            toolStripMenuItemConcepto.Text = "C&onceptos";
            // 
            // toolStripMenuItemProducto
            // 
            toolStripMenuItemProducto.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemDepartamentos, toolStripMenuItemIVAs, toolStripMenuItemProductos, toolStripMenuItemUnidadesMedidas });
            toolStripMenuItemProducto.Image = (Image)resources.GetObject("toolStripMenuItemProducto.Image");
            toolStripMenuItemProducto.Name = "toolStripMenuItemProducto";
            toolStripMenuItemProducto.Size = new Size(163, 22);
            toolStripMenuItemProducto.Text = "&Productos";
            // 
            // toolStripMenuItemDepartamentos
            // 
            toolStripMenuItemDepartamentos.Name = "toolStripMenuItemDepartamentos";
            toolStripMenuItemDepartamentos.Size = new Size(182, 22);
            toolStripMenuItemDepartamentos.Text = "&Departamentos";
            // 
            // toolStripMenuItemIVAs
            // 
            toolStripMenuItemIVAs.Name = "toolStripMenuItemIVAs";
            toolStripMenuItemIVAs.Size = new Size(182, 22);
            toolStripMenuItemIVAs.Text = "&IVAs";
            // 
            // toolStripMenuItemProductos
            // 
            toolStripMenuItemProductos.Name = "toolStripMenuItemProductos";
            toolStripMenuItemProductos.Size = new Size(182, 22);
            toolStripMenuItemProductos.Text = "P&roductos";
            // 
            // toolStripMenuItemUnidadesMedidas
            // 
            toolStripMenuItemUnidadesMedidas.Name = "toolStripMenuItemUnidadesMedidas";
            toolStripMenuItemUnidadesMedidas.Size = new Size(182, 22);
            toolStripMenuItemUnidadesMedidas.Text = "Unidades de Medida";
            // 
            // toolStripMenuItemProveedor
            // 
            toolStripMenuItemProveedor.Image = (Image)resources.GetObject("toolStripMenuItemProveedor.Image");
            toolStripMenuItemProveedor.Name = "toolStripMenuItemProveedor";
            toolStripMenuItemProveedor.Size = new Size(163, 22);
            toolStripMenuItemProveedor.Text = "P&roveedores";
            // 
            // toolStripMenuItemTipoDocumento
            // 
            toolStripMenuItemTipoDocumento.Image = (Image)resources.GetObject("toolStripMenuItemTipoDocumento.Image");
            toolStripMenuItemTipoDocumento.Name = "toolStripMenuItemTipoDocumento";
            toolStripMenuItemTipoDocumento.Size = new Size(163, 22);
            toolStripMenuItemTipoDocumento.Text = "&Tipo Documento";
            toolStripMenuItemTipoDocumento.Click += toolStripMenuItemTipoDocumento_Click;
            // 
            // MovimientosToolStripMenuItem
            // 
            MovimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemCompras, toolStripMenuItemDevoluciones, toolStripMenuItemSalidas, toolStripMenuItemTraslados, toolStripMenuItemVentas });
            MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem";
            MovimientosToolStripMenuItem.Size = new Size(89, 20);
            MovimientosToolStripMenuItem.Text = "M&ovimientos";
            // 
            // toolStripMenuItemCompras
            // 
            toolStripMenuItemCompras.Image = (Image)resources.GetObject("toolStripMenuItemCompras.Image");
            toolStripMenuItemCompras.Name = "toolStripMenuItemCompras";
            toolStripMenuItemCompras.Size = new Size(145, 22);
            toolStripMenuItemCompras.Text = "&Compras";
            toolStripMenuItemCompras.ToolTipText = "Compras";
            // 
            // toolStripMenuItemDevoluciones
            // 
            toolStripMenuItemDevoluciones.Image = (Image)resources.GetObject("toolStripMenuItemDevoluciones.Image");
            toolStripMenuItemDevoluciones.Name = "toolStripMenuItemDevoluciones";
            toolStripMenuItemDevoluciones.Size = new Size(145, 22);
            toolStripMenuItemDevoluciones.Text = "&Devoluciones";
            toolStripMenuItemDevoluciones.ToolTipText = "Devoluciones";
            // 
            // toolStripMenuItemSalidas
            // 
            toolStripMenuItemSalidas.Image = (Image)resources.GetObject("toolStripMenuItemSalidas.Image");
            toolStripMenuItemSalidas.Name = "toolStripMenuItemSalidas";
            toolStripMenuItemSalidas.Size = new Size(145, 22);
            toolStripMenuItemSalidas.Text = "&Salidas";
            toolStripMenuItemSalidas.ToolTipText = "Salidas de materiales";
            // 
            // toolStripMenuItemTraslados
            // 
            toolStripMenuItemTraslados.Image = (Image)resources.GetObject("toolStripMenuItemTraslados.Image");
            toolStripMenuItemTraslados.Name = "toolStripMenuItemTraslados";
            toolStripMenuItemTraslados.Size = new Size(145, 22);
            toolStripMenuItemTraslados.Text = "&Traslados";
            // 
            // toolStripMenuItemVentas
            // 
            toolStripMenuItemVentas.Image = (Image)resources.GetObject("toolStripMenuItemVentas.Image");
            toolStripMenuItemVentas.Name = "toolStripMenuItemVentas";
            toolStripMenuItemVentas.Size = new Size(145, 22);
            toolStripMenuItemVentas.Text = "&Ventas";
            toolStripMenuItemVentas.ToolTipText = "Ventas";
            // 
            // ConsultasToolStripMenuItem
            // 
            ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem";
            ConsultasToolStripMenuItem.Size = new Size(71, 20);
            ConsultasToolStripMenuItem.Text = "&Consultas";
            // 
            // InformesToolStripMenuItem
            // 
            InformesToolStripMenuItem.Name = "InformesToolStripMenuItem";
            InformesToolStripMenuItem.Size = new Size(66, 20);
            InformesToolStripMenuItem.Text = "&Informes";
            // 
            // AyudaToolStripMenuItem
            // 
            AyudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAyuda1, toolStripMenuItemAcerca });
            AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            AyudaToolStripMenuItem.Size = new Size(53, 20);
            AyudaToolStripMenuItem.Text = "A&yuda";
            // 
            // toolStripMenuItemAyuda1
            // 
            toolStripMenuItemAyuda1.Name = "toolStripMenuItemAyuda1";
            toolStripMenuItemAyuda1.Size = new Size(126, 22);
            toolStripMenuItemAyuda1.Text = "Ay&uda";
            // 
            // toolStripMenuItemAcerca
            // 
            toolStripMenuItemAcerca.Name = "toolStripMenuItemAcerca";
            toolStripMenuItemAcerca.Size = new Size(126, 22);
            toolStripMenuItemAcerca.Text = "A&cerca de";
            // 
            // statusStripPrincipal
            // 
            statusStripPrincipal.Location = new Point(0, 648);
            statusStripPrincipal.Name = "statusStripPrincipal";
            statusStripPrincipal.Size = new Size(1035, 22);
            statusStripPrincipal.TabIndex = 2;
            statusStripPrincipal.Text = "statusStrip1";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 670);
            Controls.Add(statusStripPrincipal);
            Controls.Add(menuStripPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStripPrincipal;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CAVIC";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemConectar;
        private ToolStripMenuItem toolStripMenuItemCambiarUsuario;
        private ToolStripMenuItem toolStripMenuItemBloquear;
        private ToolStripMenuItem toolStripMenuItemDesconectar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemSalir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItemDesBloquear;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItemClave;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MaestrosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemCliente;
        private ToolStripMenuItem toolStripMenuItemAlmacen;
        private ToolStripMenuItem toolStripMenuItemProveedor;
        private ToolStripMenuItem toolStripMenuItemConcepto;
        private ToolStripMenuItem toolStripMenuItemProducto;
        private StatusStrip statusStripPrincipal;
        private ToolStripMenuItem toolStripMenuItemDepartamentos;
        private ToolStripMenuItem toolStripMenuItemIVAs;
        private ToolStripMenuItem toolStripMenuItemProductos;
        private ToolStripMenuItem toolStripMenuItemUnidadesMedidas;
        private ToolStripMenuItem MovimientosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemCompras;
        private ToolStripMenuItem toolStripMenuItemDevoluciones;
        private ToolStripMenuItem toolStripMenuItemSalidas;
        private ToolStripMenuItem toolStripMenuItemTraslados;
        private ToolStripMenuItem toolStripMenuItemVentas;
        private ToolStripMenuItem ConsultasToolStripMenuItem;
        private ToolStripMenuItem InformesToolStripMenuItem;
        private ToolStripMenuItem AyudaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemAyuda1;
        private ToolStripMenuItem toolStripMenuItemAcerca;
        private ToolStripMenuItem toolStripMenuItemTipoDocumento;
    }
}
