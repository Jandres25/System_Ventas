using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReptoFactura frmfact = new Reportes.FrmReptoFactura();
            frmfact.ShowDialog();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
