using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using MaterialSkin;

namespace SystemVentas
{
    public partial class FrmPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey900, Primary.Red500, Accent.Green700, TextShade.WHITE);
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            switch (txtFormularios.Text)
            {
                case "Articulo":
                    FrmArticulo FrmArt = new FrmArticulo(); 
                    FrmArt.Show(); 
                    break;
                case "Categoria":
                    FrmCategoria FrmCat = new FrmCategoria();
                    FrmCat.Show();
                    break;
                case "Cliente":
                    FrmCliente FrmCli = new FrmCliente();
                    FrmCli.Show();
                    break;
                case "Factura":
                    FrmReporte FrmFac = new FrmReporte();
                    FrmFac.Show();
                    break;
                case "Ingreso":
                    FrmIngreso FrmIng = new FrmIngreso();
                    FrmIng.Show();
                    break;
                case "Stock":
                    FrmStockArticulos FrmSt = new FrmStockArticulos();
                    FrmSt.Show();
                    break;
                case "Trabajador":
                    FrmTrabajador FrmTra = new FrmTrabajador();
                    FrmTra.Show();
                    break;
                default:
                    FrmProveedor FrmPro = new FrmProveedor();
                    FrmPro.Show();
                    break;
            }
        }
    }
}
