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
    public partial class FrmVistaProveedor_ingreso : Form
    {
        public FrmVistaProveedor_ingreso()
        {
            InitializeComponent();
        }
        private void FrmVistaProveedor_ingreso_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
        // Metodo para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = true;
        }
        // Metodo mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NProveedor.Mostrar();
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        // Metodo BuscarRazon_Social
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = NProveedor.BuscarRazonSocial(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        // Metodo Numero_Documento
        private void BuscarNumero_Documento()
        {
            this.dataListado.DataSource = NProveedor.BuscarNumeroDocumento(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNumero_Documento();
            }
            else if (cbBuscar.Text.Equals("Razon_Social"))
            {
                this.BuscarRazon_Social();
            }
        }
        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmIngreso form = FrmIngreso.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["idproveedor"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Razon_social"].Value);
            form.setProveedor(par1, par2);
            this.Hide();
        }
    }
}
