namespace EEB.Presentacion.Vistas.Menu_Principal
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCambioContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCambioUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSueldosJornales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGrupoFamiliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogistica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentaMenor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentaMayor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompraMenor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompraMayor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu,
            this.mnuPersonal,
            this.mnuVenta,
            this.mnuCompra,
            this.mnuSesion,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArticulo,
            this.mnuEmpleado,
            this.mnuProveedor,
            this.mnuCliente,
            this.mnuRecordatorio});
            this.mnuMenu.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.mnuMenu.Image = ((System.Drawing.Image)(resources.GetObject("mnuMenu.Image")));
            this.mnuMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(115, 52);
            this.mnuMenu.Text = "MENU";
            // 
            // mnuPersonal
            // 
            this.mnuPersonal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSueldosJornales,
            this.mnuGrupoFamiliar,
            this.mnuAsistencia,
            this.mnuLogistica});
            this.mnuPersonal.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.mnuPersonal.Image = ((System.Drawing.Image)(resources.GetObject("mnuPersonal.Image")));
            this.mnuPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPersonal.Name = "mnuPersonal";
            this.mnuPersonal.Size = new System.Drawing.Size(155, 52);
            this.mnuPersonal.Text = "PERSONAL";
            // 
            // mnuVenta
            // 
            this.mnuVenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVentaMenor,
            this.mnuVentaMayor});
            this.mnuVenta.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.mnuVenta.Image = ((System.Drawing.Image)(resources.GetObject("mnuVenta.Image")));
            this.mnuVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuVenta.Name = "mnuVenta";
            this.mnuVenta.Size = new System.Drawing.Size(122, 52);
            this.mnuVenta.Text = "VENTA";
            // 
            // mnuCompra
            // 
            this.mnuCompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCompraMenor,
            this.mnuCompraMayor});
            this.mnuCompra.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.mnuCompra.Image = ((System.Drawing.Image)(resources.GetObject("mnuCompra.Image")));
            this.mnuCompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCompra.Name = "mnuCompra";
            this.mnuCompra.Size = new System.Drawing.Size(138, 52);
            this.mnuCompra.Text = "COMPRA";
            // 
            // mnuSesion
            // 
            this.mnuSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCambioContraseña,
            this.mnuCambioUsuario,
            this.mnuBackup});
            this.mnuSesion.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.mnuSesion.Image = ((System.Drawing.Image)(resources.GetObject("mnuSesion.Image")));
            this.mnuSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSesion.Name = "mnuSesion";
            this.mnuSesion.Size = new System.Drawing.Size(127, 52);
            this.mnuSesion.Text = "SESION";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.mnuSalir.Image = ((System.Drawing.Image)(resources.GetObject("mnuSalir.Image")));
            this.mnuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(116, 52);
            this.mnuSalir.Text = "SALIR";
            // 
            // mnuCambioContraseña
            // 
            this.mnuCambioContraseña.Image = ((System.Drawing.Image)(resources.GetObject("mnuCambioContraseña.Image")));
            this.mnuCambioContraseña.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCambioContraseña.Name = "mnuCambioContraseña";
            this.mnuCambioContraseña.Size = new System.Drawing.Size(286, 54);
            this.mnuCambioContraseña.Text = "CAMBIO CONTRASEÑA";
            // 
            // mnuCambioUsuario
            // 
            this.mnuCambioUsuario.Image = ((System.Drawing.Image)(resources.GetObject("mnuCambioUsuario.Image")));
            this.mnuCambioUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCambioUsuario.Name = "mnuCambioUsuario";
            this.mnuCambioUsuario.Size = new System.Drawing.Size(286, 54);
            this.mnuCambioUsuario.Text = "CAMBIO DE USUARIO";
            // 
            // mnuArticulo
            // 
            this.mnuArticulo.Image = ((System.Drawing.Image)(resources.GetObject("mnuArticulo.Image")));
            this.mnuArticulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuArticulo.Name = "mnuArticulo";
            this.mnuArticulo.Size = new System.Drawing.Size(238, 54);
            this.mnuArticulo.Text = "ARTICULO";
            // 
            // mnuEmpleado
            // 
            this.mnuEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("mnuEmpleado.Image")));
            this.mnuEmpleado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEmpleado.Name = "mnuEmpleado";
            this.mnuEmpleado.Size = new System.Drawing.Size(238, 54);
            this.mnuEmpleado.Text = "EMPLEADO";
            // 
            // mnuProveedor
            // 
            this.mnuProveedor.Image = ((System.Drawing.Image)(resources.GetObject("mnuProveedor.Image")));
            this.mnuProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuProveedor.Name = "mnuProveedor";
            this.mnuProveedor.Size = new System.Drawing.Size(238, 54);
            this.mnuProveedor.Text = "PROVEEDOR";
            // 
            // mnuCliente
            // 
            this.mnuCliente.Image = ((System.Drawing.Image)(resources.GetObject("mnuCliente.Image")));
            this.mnuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(238, 54);
            this.mnuCliente.Text = "CLIENTE";
            // 
            // mnuRecordatorio
            // 
            this.mnuRecordatorio.Image = ((System.Drawing.Image)(resources.GetObject("mnuRecordatorio.Image")));
            this.mnuRecordatorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuRecordatorio.Name = "mnuRecordatorio";
            this.mnuRecordatorio.Size = new System.Drawing.Size(238, 54);
            this.mnuRecordatorio.Text = "RECORDATORIO";
            // 
            // mnuSueldosJornales
            // 
            this.mnuSueldosJornales.Image = ((System.Drawing.Image)(resources.GetObject("mnuSueldosJornales.Image")));
            this.mnuSueldosJornales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSueldosJornales.Name = "mnuSueldosJornales";
            this.mnuSueldosJornales.Size = new System.Drawing.Size(288, 54);
            this.mnuSueldosJornales.Text = "SUELDOS Y JORNALES";
            // 
            // mnuGrupoFamiliar
            // 
            this.mnuGrupoFamiliar.Image = ((System.Drawing.Image)(resources.GetObject("mnuGrupoFamiliar.Image")));
            this.mnuGrupoFamiliar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuGrupoFamiliar.Name = "mnuGrupoFamiliar";
            this.mnuGrupoFamiliar.Size = new System.Drawing.Size(288, 54);
            this.mnuGrupoFamiliar.Text = "GRUPO FAMILIAR";
            // 
            // mnuAsistencia
            // 
            this.mnuAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("mnuAsistencia.Image")));
            this.mnuAsistencia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAsistencia.Name = "mnuAsistencia";
            this.mnuAsistencia.Size = new System.Drawing.Size(288, 54);
            this.mnuAsistencia.Text = "ASISTENCIA";
            // 
            // mnuLogistica
            // 
            this.mnuLogistica.Image = ((System.Drawing.Image)(resources.GetObject("mnuLogistica.Image")));
            this.mnuLogistica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuLogistica.Name = "mnuLogistica";
            this.mnuLogistica.Size = new System.Drawing.Size(288, 54);
            this.mnuLogistica.Text = "LOGISTICA";
            // 
            // mnuBackup
            // 
            this.mnuBackup.Image = ((System.Drawing.Image)(resources.GetObject("mnuBackup.Image")));
            this.mnuBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuBackup.Name = "mnuBackup";
            this.mnuBackup.Size = new System.Drawing.Size(286, 54);
            this.mnuBackup.Text = "BACKUP";
            // 
            // mnuVentaMenor
            // 
            this.mnuVentaMenor.Image = ((System.Drawing.Image)(resources.GetObject("mnuVentaMenor.Image")));
            this.mnuVentaMenor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuVentaMenor.Name = "mnuVentaMenor";
            this.mnuVentaMenor.Size = new System.Drawing.Size(184, 54);
            this.mnuVentaMenor.Text = "MENOR";
            // 
            // mnuVentaMayor
            // 
            this.mnuVentaMayor.Image = ((System.Drawing.Image)(resources.GetObject("mnuVentaMayor.Image")));
            this.mnuVentaMayor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuVentaMayor.Name = "mnuVentaMayor";
            this.mnuVentaMayor.Size = new System.Drawing.Size(184, 54);
            this.mnuVentaMayor.Text = "MAYOR";
            // 
            // mnuCompraMenor
            // 
            this.mnuCompraMenor.Image = ((System.Drawing.Image)(resources.GetObject("mnuCompraMenor.Image")));
            this.mnuCompraMenor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCompraMenor.Name = "mnuCompraMenor";
            this.mnuCompraMenor.Size = new System.Drawing.Size(184, 54);
            this.mnuCompraMenor.Text = "MENOR";
            // 
            // mnuCompraMayor
            // 
            this.mnuCompraMayor.Image = ((System.Drawing.Image)(resources.GetObject("mnuCompraMayor.Image")));
            this.mnuCompraMayor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCompraMayor.Name = "mnuCompraMayor";
            this.mnuCompraMayor.Size = new System.Drawing.Size(184, 54);
            this.mnuCompraMayor.Text = "MAYOR";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(797, 394);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonal;
        private System.Windows.Forms.ToolStripMenuItem mnuVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuCambioContraseña;
        private System.Windows.Forms.ToolStripMenuItem mnuCambioUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuArticulo;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpleado;
        private System.Windows.Forms.ToolStripMenuItem mnuProveedor;
        private System.Windows.Forms.ToolStripMenuItem mnuCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuRecordatorio;
        private System.Windows.Forms.ToolStripMenuItem mnuSueldosJornales;
        private System.Windows.Forms.ToolStripMenuItem mnuGrupoFamiliar;
        private System.Windows.Forms.ToolStripMenuItem mnuAsistencia;
        private System.Windows.Forms.ToolStripMenuItem mnuLogistica;
        private System.Windows.Forms.ToolStripMenuItem mnuBackup;
        private System.Windows.Forms.ToolStripMenuItem mnuVentaMenor;
        private System.Windows.Forms.ToolStripMenuItem mnuVentaMayor;
        private System.Windows.Forms.ToolStripMenuItem mnuCompraMenor;
        private System.Windows.Forms.ToolStripMenuItem mnuCompraMayor;
    }
}