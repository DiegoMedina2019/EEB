using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using EEB.Dominio;

namespace EEB.Presentacion.Vistas.Menu_Principal.Menu.Proveedor
{
    public partial class IndiceProveedor : Form
    {
        private Dominio.Proveedor _proveedor;
        private NuevoProveedor nuevoProveedor;
        private EditarProveedor editarProveedor;
        private VerDetallesProveedor verDetalles;

        private PrintDialog Impresora = new PrintDialog();
        private PrintDocument DocumentoParaImprimir = new PrintDocument();

        public IndiceProveedor()
        {
            InitializeComponent();
            cboProveedor.DataSource = OpcionesFiltro();
            lblCambiante.Hide();
            lblCambiante2.Hide();
            txtDescripcion.Hide();
            dtpFecha.Hide();
            cboCambiante.Hide();
            cboLocalidad.Hide();
            nuevoProveedor = new NuevoProveedor();
            editarProveedor = new EditarProveedor();
            _proveedor = new Dominio.Proveedor();
            verDetalles = new VerDetallesProveedor();
        }

        public List<string> OpcionesFiltro()
        {
            List<string> Lista = new List<string>();
            Lista.Add("SELECCIONE EL TIPO DE BUSQUEDA");
            Lista.Add("CUIT");
            Lista.Add("RAZON SOCIAL");
            Lista.Add("NOMBRE DE CONTACTO");
            Lista.Add("CONDICIÓN DE IVA");
            Lista.Add("TELEFONO FIJO");
            Lista.Add("CELULAR");
            Lista.Add("E-MAIL");
            Lista.Add("PROVINCIA");
            Lista.Add("LOCALIDAD");
            Lista.Add("FECHA DE REGISTRO");
            Lista.Add("ESTADO");
            return Lista;
        }

        #region Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevoProveedor.ShowDialog();
        }
        #endregion

        #region Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarProveedor.ShowDialog();
        }
        #endregion

        #region Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Descargar
        public void GenerarDcoumentos(Document document)
        {
            //Se crea un objeto PdfTable con el numero de columnas del dataGridView
            PdfPTable datatable = new PdfPTable(dgvProveedores.ColumnCount);

            //Asignamos algunas de las propiedades para el diseño del pdf
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgvProveedores);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            //Definimos el color de las celdas en el pdf
            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
            //Definimos el color de los bordes
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;
            //La fuente de nuestro texto
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            //Se genera el encabezado de la tabla en el PDF
            for (int i = 0; i < dgvProveedores.ColumnCount; i++)
            {
                objP = new Phrase(dgvProveedores.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_LEFT;
                datatable.AddCell(objP);
            }
            datatable.HeaderRows = 2;
            datatable.DefaultCell.BorderWidth = 1;

            //Se genera el cuerpo del pdf
            for (int i = 0; i < dgvProveedores.RowCount; i++)
            {
                for (int j = 0; j < dgvProveedores.ColumnCount; j++)
                {
                    objP = new Phrase(dgvProveedores[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            //Tomamos el numero de columnas
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                //Tomamos el ancho de cada columna
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.RowCount == 0)
            {
                MessageBox.Show("No hay registros para generar el informe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files(*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    Document doc = new Document(PageSize.A3, 5, 5, 5, 5);
                    Chunk encab = new Chunk("Reporte de Proveedores", FontFactory.GetFont("PROVEEDORES", 18));
                    try
                    {
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                        PdfWriter writer = PdfWriter.GetInstance(doc, file);
                        writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                        writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                        doc.Open();

                        doc.Add(new Paragraph(encab));
                        doc.Add(new Phrase(Environment.NewLine));

                        GenerarDcoumentos(doc);
                        Process.Start(filename);
                        doc.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Generar Informe
        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            Impresora.Document = DocumentoParaImprimir;
            DialogResult Result = Impresora.ShowDialog();
            if(Result == DialogResult.OK)
            {
                DocumentoParaImprimir.DefaultPageSettings.Landscape = false;
                DocumentoParaImprimir.Print();
            }
        }
        #endregion
        
        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboProveedor.Text)
            {
                case "CUIT":
                    lblCambiante.Text = "INGRESE EL CUIT";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    txtDescripcion.Show();
                    txtDescripcion.Focus();
                    dtpFecha.Hide();
                    cboCambiante.Hide();
                    cboLocalidad.Hide();
                    break;
                case "RAZON SOCIAL":
                    lblCambiante.Text = "INGRESE LA RAZON SOCIAL";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    txtDescripcion.Show();
                    txtDescripcion.Focus();
                    dtpFecha.Hide();
                    cboCambiante.Hide();
                    cboLocalidad.Hide();
                    break;
                case "NOMBRE DE CONTACTO":
                    lblCambiante.Text = "INGRESE EL NOMBRE DE CONTACTO";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    txtDescripcion.Show();
                    txtDescripcion.Focus();
                    dtpFecha.Hide();
                    cboCambiante.Hide();
                    cboLocalidad.Hide();
                    break;
                case "CONDICIÓN DE IVA":
                    lblCambiante.Text = "SELECCIONE LA CONDICIÓN DE IVA";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    cboCambiante.Show();
                    cboCambiante.DataSource = _proveedor.ValueComboBox(cboProveedor.Text,string.Empty);
                    txtDescripcion.Hide();
                    dtpFecha.Hide();
                    cboLocalidad.Hide();
                    break;
                case "TELEFONO FIJO":
                    lblCambiante.Text = "INGRESE EL TELEFONO FIJO";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    txtDescripcion.Show();
                    txtDescripcion.Focus();
                    dtpFecha.Hide();
                    cboCambiante.Hide();
                    cboLocalidad.Hide();
                    break;
                case "CELULAR":
                    lblCambiante.Text = "INGRESE EL CELULAR";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    txtDescripcion.Show();
                    txtDescripcion.Focus();
                    dtpFecha.Hide();
                    cboCambiante.Hide();
                    cboLocalidad.Hide();
                    break;
                case "E-MAIL":
                    lblCambiante.Text = "INGRESE EL E-MAIL";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    txtDescripcion.Show();
                    txtDescripcion.Focus();
                    dtpFecha.Hide();
                    cboCambiante.Hide();
                    cboLocalidad.Hide();
                    break;
                case "PROVINCIA":
                    lblCambiante.Text = "SELECCIONE LA PROVINCIA";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    cboCambiante.Show();
                    cboCambiante.DataSource = _proveedor.ValueComboBox(cboProveedor.Text,string.Empty);
                    txtDescripcion.Hide();
                    dtpFecha.Hide();
                    cboLocalidad.Hide();
                    break;
                case "LOCALIDAD":
                    lblCambiante.Text = "SELECCIONE LA PROVINCIA";
                    lblCambiante.Show();
                    lblCambiante2.Text = "SELECCIONE LA LOCALIDAD";
                    lblCambiante2.Show();
                    cboCambiante.Show();
                    cboCambiante.DataSource = _proveedor.ValueComboBox("PROVINCIA",string.Empty);
                    cboLocalidad.Show();
                    txtDescripcion.Hide();
                    dtpFecha.Hide();
                    break;
                case "FECHA DE REGISTRO":
                    lblCambiante.Text = "SELECCIONE LA FECHA DE REGISTRO";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    dtpFecha.Show();
                    txtDescripcion.Hide();
                    cboCambiante.Hide();
                    cboLocalidad.Hide();
                    break;
                case "ESTADO":
                    lblCambiante.Text = "SELECCIONE LA FECHA DE ESTADO";
                    lblCambiante.Show();
                    lblCambiante2.Hide();
                    cboCambiante.Show();
                    cboCambiante.DataSource = _proveedor.ValueComboBox(cboProveedor.Text,string.Empty);
                    txtDescripcion.Hide();
                    dtpFecha.Hide();
                    cboLocalidad.Hide();
                    break;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = _proveedor.ObtenerGrilla();
        }

        public void CabezeraGrilla()
        {
            dgvProveedores.Columns[0].HeaderText = "CUIT";
            dgvProveedores.Columns[1].HeaderText = "RAZON SOCIAL";
            dgvProveedores.Columns[2].HeaderText = "NOMBRE DE CONTACTO";
            dgvProveedores.Columns[3].HeaderText = "CONDICIÓN DE IVA";
            dgvProveedores.Columns[4].HeaderText = "TELEFONO FIJO";
            dgvProveedores.Columns[5].HeaderText = "CELULAR";
            dgvProveedores.Columns[6].HeaderText = "E-MAIL";
            dgvProveedores.Columns[7].HeaderText = "PROVINCIA";
            dgvProveedores.Columns[8].HeaderText = "LOCALIDAD";
            dgvProveedores.Columns[9].HeaderText = "FECHA REGISTRO";
            dgvProveedores.Columns[10].HeaderText = "ESTADO";
            /*ANCHO*/
            dgvProveedores.Columns[0].Width = 100;
            dgvProveedores.Columns[1].Width = 220;
            dgvProveedores.Columns[2].Width = 220;
            dgvProveedores.Columns[3].Width = 220;
            dgvProveedores.Columns[4].Width = 100;
            dgvProveedores.Columns[5].Width = 100;
            dgvProveedores.Columns[6].Width = 220;
            dgvProveedores.Columns[7].Width = 200;
            dgvProveedores.Columns[8].Width = 300;
            dgvProveedores.Columns[9].Width = 100;
            dgvProveedores.Columns[10].Width = 100;

        }

        private void IndiceProveedor_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = _proveedor.ObtenerGrilla();
            CabezeraGrilla();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dominio.Proveedor proveedor = Dominio.Proveedor.Instance();
            string cuit = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            proveedor.cuit = cuit;
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cuit = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            Dominio.Proveedor proveedor = Dominio.Proveedor.Instance();
            proveedor.cuit = cuit;
            verDetalles.ShowDialog();
        }

        private void cboCambiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLocalidad.DataSource = _proveedor.ValueComboBox(cboProveedor.Text, cboCambiante.Text);
        }
    }
}
