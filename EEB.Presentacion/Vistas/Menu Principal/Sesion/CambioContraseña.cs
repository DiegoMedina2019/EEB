using EEB.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEB.Presentacion.Vistas.Menu_Principal.Sesion
{
    public partial class CambioContraseña : Form
    {
        private Usuario usuario;

        public CambioContraseña()
        {
            InitializeComponent();
            usuario = new Usuario();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContraseñaAnterior.Text) && (!string.IsNullOrEmpty(txtNuevaContraseña.Text)))
            {
                Usuario u = Usuario.Instance();
                string mensaje = usuario.ChangePassword(u._username, txtContraseñaAnterior.Text, txtNuevaContraseña.Text);
                if (mensaje == "CONTRASEÑA FUE CAMBIADA EXITOSAMENTE")
                {
                    MessageBox.Show(mensaje + Environment.NewLine + Environment.NewLine + "Su contraseña anterior era: " + txtContraseñaAnterior.Text + Environment.NewLine + "Su nueva contraseña es: " + txtNuevaContraseña.Text);
                    txtContraseñaAnterior.Text = string.Empty;
                    txtNuevaContraseña.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR TODOS LOS CAMPOS");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtContraseñaAnterior.Text) || !string.IsNullOrWhiteSpace(txtNuevaContraseña.Text))
            {
                DialogResult resultado = MessageBox.Show("¿ESTA SEGURO DE RESETEAR?", "", MessageBoxButtons.YesNo);
                switch (resultado)
                {
                    case DialogResult.Yes:
                        txtContraseñaAnterior.Clear();
                        txtNuevaContraseña.Clear();
                        txtContraseñaAnterior.Focus();
                        break;
                }
            }
            else
            {
                MessageBox.Show("DEBE POR LO MENOS COMPLETAR UN CAMPO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecordar_Click(object sender, EventArgs e)
        {
            Usuario u = Usuario.Instance();
            MessageBox.Show("Su contraseña es: "+usuario.PassawordCurrent(u._username));
        }
    }
}
