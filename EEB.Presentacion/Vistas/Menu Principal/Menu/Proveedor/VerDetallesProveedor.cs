using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEB.Presentacion.Vistas.Menu_Principal.Menu.Proveedor
{
    public partial class VerDetallesProveedor : Form
    {
        public VerDetallesProveedor()
        {
            InitializeComponent();
        }

        private void VerDetallesProveedor_Load(object sender, EventArgs e)
        {
            Dominio.Proveedor _proveedor = Dominio.Proveedor.Instance();
            /*Obtener detalles en una lista*/
            
        }
    }
}
