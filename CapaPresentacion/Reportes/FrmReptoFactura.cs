using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class FrmReptoFactura : Form
    {
        public FrmReptoFactura()
        {
            InitializeComponent();
        }
        int idventa = 1;
        private void FrmReptoFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spreporte_factura' Puede moverla o quitarla según sea necesario.
            this.spreporte_facturaTableAdapter.Fill(this.dsPrincipal.spreporte_factura,idventa);
            this.reportViewer1.RefreshReport();
        }
    }
}
