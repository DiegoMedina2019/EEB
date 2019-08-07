﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EEB.Presentacion.Vistas.Menu_Principal.Menu.Proveedor;
using EEB.Presentacion.Vistas.Menu_Principal.Sesion;

namespace EEB.Presentacion.Vistas.Menu_Principal
{
    public partial class MenuPrincipal : Form
    {
        private CambioContraseña cambioContraseña;
        private IndiceProveedor indiceProveedor;

        public MenuPrincipal()
        {
            InitializeComponent();
            cambioContraseña = new CambioContraseña();
            indiceProveedor = new IndiceProveedor();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿ESTA SEGURO DE SALIR?", "", MessageBoxButtons.YesNo);
            switch (resultado)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }

        private void mnuCambioContraseña_Click(object sender, EventArgs e)
        {
            cambioContraseña.ShowDialog();
        }

        private void mnuCambioUsuario_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿ESTA SEGURO DE CAMBIAR DE USUARIO?", "", MessageBoxButtons.YesNo);
            switch (resultado)
            {
                case DialogResult.Yes:
                    InicioSesion inicio = new InicioSesion();
                    this.Hide();
                    inicio.ShowDialog();
                    break;
            }
        }

        private void mnuProveedor_Click(object sender, EventArgs e)
        {
            indiceProveedor.ShowDialog();
        }
    }
}
