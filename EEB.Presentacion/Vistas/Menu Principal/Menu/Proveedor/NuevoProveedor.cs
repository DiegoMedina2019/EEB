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
namespace EEB.Presentacion.Vistas.Menu_Principal.Menu.Proveedor
{
    public partial class NuevoProveedor : Form
    {
        private EEB.Dominio.Proveedor _proveedor;

        public NuevoProveedor()
        {
            InitializeComponent();
            _proveedor = new EEB.Dominio.Proveedor();
        }
        bool ValidarTextsBoxes()
        {
            foreach (Control item in this.Controls)
            {
                if (item.Text == string.Empty || item.Text == null)
                {
                    MessageBox.Show("HAY CAMPOS SIN COMPLETAR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //item.Focus();
                    return false;
                }
                if (item is ComboBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Debe seleccionar un Tipo de Ejercicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        item.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void NuevoProveedor_Load(object sender, EventArgs e)
        {
            cboCondicionIva.DataSource = _proveedor.ValueComboBox("CONDICIÓN DE IVA", string.Empty);
            cboEstado.DataSource = _proveedor.ValueComboBox("ESTADO", string.Empty);
            cboProvincia.DataSource = _proveedor.ValueComboBox("PROVINCIA", string.Empty);
            cboLocalidad.DataSource = _proveedor.ValueComboBox("LOCALIDAD", cboProvincia.Text);
            txtCodigoPostal.Text = _proveedor.CodePostal(cboLocalidad.Text);
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("d");
            txtFechaRegistro.Text = fecha.ToString();
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLocalidad.DataSource = _proveedor.ValueComboBox("LOCALIDAD", cboProvincia.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarTextsBoxes() == true)
            {
                _proveedor.Create(txtCuit.Text, txtRazonSocial.Text, txtNombreContacto.Text,
                cboCondicionIva.Text, txtPreTelefonoFijo.Text + txtTelefonoFijo.Text, txtPreCelular.Text + txtCelular.Text,
                txtEmail.Text, cboEstado.Text, cboProvincia.Text, cboLocalidad.Text, txtCalle.Text, txtBarrio.Text,
                txtNCasa.Text, txtMza.Text, txtZona.Text, txtSector.Text, txtPiso.Text, txtDepto.Text);
            }
        }

        private void cboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoPostal.Text = _proveedor.CodePostal(cboLocalidad.Text);
        }
    }
}
