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
    public partial class EditarProveedor : Form
    {
        EEB.Dominio.Proveedor _proveedor;

        public EditarProveedor()
        {
            InitializeComponent();
            _proveedor = new Dominio.Proveedor();
        }

        private void EditarProveedor_Load(object sender, EventArgs e)
        {
            Dominio.Proveedor proveedor = Dominio.Proveedor.Instance();
        }
    }
}
