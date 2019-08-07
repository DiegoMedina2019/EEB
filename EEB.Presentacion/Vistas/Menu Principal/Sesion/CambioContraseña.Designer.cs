namespace EEB.Presentacion.Vistas.Menu_Principal.Sesion
{
    partial class CambioContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioContraseña));
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.txtContraseñaAnterior = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRecordar = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Font = new System.Drawing.Font("Arial Narrow", 19F);
            this.lblContraseñaActual.ForeColor = System.Drawing.Color.White;
            this.lblContraseñaActual.Location = new System.Drawing.Point(12, 20);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(384, 31);
            this.lblContraseñaActual.TabIndex = 1;
            this.lblContraseñaActual.Text = "INGRESE SU CONTRASEÑA ACTUAL";
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Arial Narrow", 19F);
            this.lblNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(12, 94);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(369, 31);
            this.lblNuevaContraseña.TabIndex = 2;
            this.lblNuevaContraseña.Text = "INGRESE LA NUEVA CONTRASEÑA";
            // 
            // txtContraseñaAnterior
            // 
            this.txtContraseñaAnterior.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaAnterior.Location = new System.Drawing.Point(18, 56);
            this.txtContraseñaAnterior.Name = "txtContraseñaAnterior";
            this.txtContraseñaAnterior.PasswordChar = '*';
            this.txtContraseñaAnterior.Size = new System.Drawing.Size(369, 32);
            this.txtContraseñaAnterior.TabIndex = 3;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContraseña.Location = new System.Drawing.Point(18, 130);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(369, 32);
            this.txtNuevaContraseña.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(18, 177);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 46);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRecordar
            // 
            this.btnRecordar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordar.Location = new System.Drawing.Point(148, 177);
            this.btnRecordar.Name = "btnRecordar";
            this.btnRecordar.Size = new System.Drawing.Size(109, 46);
            this.btnRecordar.TabIndex = 6;
            this.btnRecordar.Text = "RECORDAR";
            this.btnRecordar.UseVisualStyleBackColor = true;
            this.btnRecordar.Click += new System.EventHandler(this.btnRecordar_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.Location = new System.Drawing.Point(278, 177);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(109, 46);
            this.btnResetear.TabIndex = 7;
            this.btnResetear.Text = "RESETEAR";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // CambioContraseña
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(406, 242);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnRecordar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtContraseñaAnterior);
            this.Controls.Add(this.lblNuevaContraseña);
            this.Controls.Add(this.lblContraseñaActual);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CambioContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIO DE CONTRASEÑA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.TextBox txtContraseñaAnterior;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRecordar;
        private System.Windows.Forms.Button btnResetear;
    }
}