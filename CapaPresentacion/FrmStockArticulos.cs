using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmStockArticulos : Form
    {
        public FrmStockArticulos()
        {
            InitializeComponent();
        }

        private void FrmStockArticulos_Load(object sender, EventArgs e)
        {
            this.StockArticulos();
        }
        // Metodo StockArticulos
        private void StockArticulos()
        {
            this.dataListado.DataSource = NArticulo.Stock_Articulos();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReptoStockArticulos frm = new Reportes.FrmReptoStockArticulos();
            frm.ShowDialog();
        }
    }
}
