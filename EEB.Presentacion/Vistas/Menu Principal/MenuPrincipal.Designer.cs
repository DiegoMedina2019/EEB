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
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCambioContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCambioUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSesion,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.mnuSalir.Image = ((System.Drawing.Image)(resources.GetObject("mnuSalir.Image")));
            this.mnuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(116, 52);
            this.mnuSalir.Text = "SALIR";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuSesion
            // 
            this.mnuSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCambioContraseña,
            this.mnuCambioUsuario});
            this.mnuSesion.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.mnuSesion.Image = ((System.Drawing.Image)(resources.GetObject("mnuSesion.Image")));
            this.mnuSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSesion.Name = "mnuSesion";
            this.mnuSesion.Size = new System.Drawing.Size(127, 52);
            this.mnuSesion.Text = "SESION";
            // 
            // mnuCambioContraseña
            // 
            this.mnuCambioContraseña.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.mnuCambioContraseña.Image = ((System.Drawing.Image)(resources.GetObject("mnuCambioContraseña.Image")));
            this.mnuCambioContraseña.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCambioContraseña.Name = "mnuCambioContraseña";
            this.mnuCambioContraseña.Size = new System.Drawing.Size(311, 54);
            this.mnuCambioContraseña.Text = "CAMBIO DE CONTRASEÑA";
            this.mnuCambioContraseña.Click += new System.EventHandler(this.mnuCambioContraseña_Click);
            // 
            // mnuCambioUsuario
            // 
            this.mnuCambioUsuario.Image = ((System.Drawing.Image)(resources.GetObject("mnuCambioUsuario.Image")));
            this.mnuCambioUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCambioUsuario.Name = "mnuCambioUsuario";
            this.mnuCambioUsuario.Size = new System.Drawing.Size(311, 54);
            this.mnuCambioUsuario.Text = "CAMBIO DE USAURIO";
            this.mnuCambioUsuario.Click += new System.EventHandler(this.mnuCambioUsuario_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuCambioContraseña;
        private System.Windows.Forms.ToolStripMenuItem mnuCambioUsuario;
    }
}