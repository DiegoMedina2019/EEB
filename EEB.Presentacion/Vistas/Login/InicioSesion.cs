using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EEB.Dominio;
using EEB.Presentacion.Vistas.Menu_Principal;

namespace EEB.Presentacion.Vistas
{
    public partial class InicioSesion : Form
    {
        private string mensaje = string.Empty;
        private Usuario user;
        private MenuPrincipal menuPrincipal;

        public InicioSesion()
        {
            InitializeComponent();
            user = new Usuario();
            menuPrincipal = new MenuPrincipal();
        }
        bool ValidarTextsBoxes()
        {
            foreach(Control item in this.Controls)
            {
                if(item.Text == string.Empty || item.Text == null)
                {
                    MessageBox.Show("HAY CAMPOS SIN COMPLETAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //item.Focus();
                    return false;
                }
                for(int i = 0; i < item.Text.Length; i++)
                {
                    if (char.IsWhiteSpace(item.Text[i]))
                    {
                        MessageBox.Show("NO PUEDE HABER ESPACIOS EN BLANCO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //item.Focus();
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           if(ValidarTextsBoxes()==true)
           {
                mensaje = user.Login(txtUsuario.Text, txtContraseña.Text);
                switch(mensaje)
                {
                    case "EXISTE":
                        Usuario datos = Usuario.Instance();
                        datos._username = txtUsuario.Text;
                        this.Hide();
                        this.ShowInTaskbar = false;
                        menuPrincipal.ShowDialog();
                        break;
                    case "NO EXISTE":
                        MessageBox.Show("NO EXISTE EL USUARIO, A PESAR DE HABER CARGADO BIEN SU NOMBRE DE USAURIO Y CONTRASEÑA","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "NO ESTA CONECTADO A LA BASE DE DATOS":
                        MessageBox.Show(mensaje,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                    case "CONTRASEÑA CORRECTA PERO USUARIO INCORRECTO":
                        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case "USUARIO CORRECTO PERO CONTRASEÑA INCORRECTA":
                        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case "USUARIO INCORRECTO Y CONTRASEÑA INCORRECTA":
                        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
           }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) || !string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                DialogResult resultado = MessageBox.Show("¿ESTA SEGURO DE RESETEAR?", "", MessageBoxButtons.YesNo);
                switch(resultado)
                {
                    case DialogResult.Yes:
                            txtUsuario.Clear();
                            txtContraseña.Clear();
                            txtUsuario.Focus();
                            break;
                }
            }
            else
            {
                MessageBox.Show("DEBE POR LO MENOS COMPLETAR UN CAMPO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
