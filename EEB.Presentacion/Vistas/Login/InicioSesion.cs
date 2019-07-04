using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEB.Presentacion.Vistas
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        bool ValidarTextsBoxes()
        {
            foreach(Control item in this.Controls)
            {
                if(item.Text == string.Empty || item.Text == null)
                {
                    MessageBox.Show("Hay campos sin completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    item.Focus();
                    return false;
                }
                for(int i = 0; i < item.Text.Length; i++)
                {
                    if (char.IsWhiteSpace(item.Text[i]))
                    {
                        MessageBox.Show("No puede haber espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        item.Focus();
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
                
           }
           
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) || !string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro de resetear", "", MessageBoxButtons.YesNo);
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
                MessageBox.Show("Debe por lo menos completar un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
