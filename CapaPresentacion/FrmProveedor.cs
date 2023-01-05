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
    public partial class FrmProveedor : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmProveedor()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtBuscar, "Ingrese la Razón Social o el Número de Documento.");
            this.ttMensaje.SetToolTip(this.txtRazonSocial, "Ingrese la Razon Social del Proveedor.");
            this.ttMensaje.SetToolTip(this.txtNumeroDocumento, "Ingrese el número de documento del Proveedor.");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la dirección del Proveedor.");
            this.ttMensaje.SetToolTip(this.txtCorreos, "Ingrese el correo del Proveedor.");
            this.ttMensaje.SetToolTip(this.txtTelefonos, "Ingrese el teléfono del Proveedor.");
            this.ttMensaje.SetToolTip(this.txtEnlacePagWeb, "Ingrese la página web del Proveedor.");
        }
        //Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtIdproveedor.Text = string.Empty;
            this.txtRazonSocial.Text = string.Empty;
            this.txtNumeroDocumento.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtCorreos.Text = string.Empty;
            this.txtTelefonos.Text = string.Empty;
            this.txtEnlacePagWeb.Text = string.Empty;
        }
        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtIdproveedor.ReadOnly = !valor;
            this.txtRazonSocial.ReadOnly = !valor;
            this.txtNumeroDocumento.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtCorreos.ReadOnly = !valor;
            this.txtTelefonos.ReadOnly = !valor;
            this.txtEnlacePagWeb.ReadOnly = !valor;
            this.cmbxSectorComercial.Enabled = valor;
            this.cmbxTipoDocumento.Enabled = valor;
        }
        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        //Metodo para ocultar columnas del Datalistado
        private void OcultarColumnas()
        {
            if (dataListado.RowCount > 0)
            {
                this.dataListado.Columns[0].Visible = false;
                this.dataListado.Columns[1].Visible = false;
            }
        }
        //Metodo mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NProveedor.Mostrar();
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
            this.tabControl1.SelectedIndex = 0;
        }
        // Metodo BuscarRazonSocial
        private void BuscarRazonSocial()
        {
            this.dataListado.DataSource = NProveedor.BuscarRazonSocial(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        // Metodo BuscarSectorComercial
        private void BuscarSectorComercial()
        {
            this.dataListado.DataSource = NProveedor.BuscarSectorComercial(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        // Metodo BuscarTipoDocumento
        private void BuscarTipoDocumento()
        {
            this.dataListado.DataSource = NProveedor.BuscarTipoDocumento(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        //Metodo BuscarNumeroDocumento
        private void BuscarNumeroDocumento()
        {
            this.dataListado.DataSource = NProveedor.BuscarNumeroDocumento(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        // Metodo BuscarDireccion
        private void BuscarDireccion()
        {
            this.dataListado.DataSource = NProveedor.BuscarDireccion(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        // Metodo BuscarTelefono
        private void BuscarTelefono()
        {
            this.dataListado.DataSource = NProveedor.BuscarTelefono(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        // Metodo BuscarEmail
        private void BuscarEmail()
        {
            this.dataListado.DataSource = NProveedor.BuscarEmail(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        // Metodo BuscarUrl
        private void BuscarUrl()
        {
            this.dataListado.DataSource = NProveedor.BuscarUrl(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        // Iniciar formulario
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (cmbxDocumento.Text)
            {
                case "Razón Social":
                    this.BuscarRazonSocial();
                    break;
                case "Sector Comercial":
                    this.BuscarSectorComercial();
                    break;
                case "Tipo de Documento":
                    this.BuscarTipoDocumento();
                    break;
                case "Número de Documento":
                    this.BuscarNumeroDocumento();
                    break;
                case "Dirección":
                    this.BuscarDireccion();
                    break;
                case "Teléfono":
                    this.BuscarTelefono();
                    break;
                case "Email":
                    this.BuscarEmail();
                    break;
                case "Url":
                    this.BuscarUrl();
                    break;
                default: this.Mostrar();
                    break;
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            switch (cmbxDocumento.Text)
            {
                case "Razón Social":
                    this.BuscarRazonSocial();
                    break;
                case "Sector Comercial":
                    this.BuscarSectorComercial();
                    break;
                case "Tipo de Documento":
                    this.BuscarTipoDocumento();
                    break;
                case "Número de Documento":
                    this.BuscarNumeroDocumento();
                    break;
                case "Dirección":
                    this.BuscarDireccion();
                    break;
                case "Teléfono":
                    this.BuscarTelefono();
                    break;
                case "Email":
                    this.BuscarEmail();
                    break;
                case "Url":
                    this.BuscarUrl();
                    break;
                default: this.Mostrar();
                    break;
            }
        }
        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdproveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Idproveedor"].Value);
            this.txtRazonSocial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["razon_social"].Value);
            this.cmbxSectorComercial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sector_comercial"].Value);
            this.cmbxTipoDocumento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value);
            this.txtNumeroDocumento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["numero_documento"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Direccion"].Value);
            this.txtTelefonos.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Telefono"].Value);
            this.txtCorreos.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.txtEnlacePagWeb.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["url"].Value);
            this.tabControl1.SelectedIndex = 1;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtRazonSocial.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtRazonSocial.Text == string.Empty || this.txtNumeroDocumento.Text == string.Empty ||
                    this.txtDireccion.Text == string.Empty || this.txtCorreos.Text == string.Empty || 
                    this.txtTelefonos.Text == string.Empty || this.txtEnlacePagWeb.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, estos van a ser marcados.");
                    errorIcon.SetError(txtRazonSocial, "Falta ingresar la razón social...");
                    errorIcon.SetError(txtNumeroDocumento, "Falta ingresar el número de documento...");
                    errorIcon.SetError(txtDireccion, "Falta ingresar la dirección...");
                    errorIcon.SetError(txtCorreos, "Falta ingresar el correo...");
                    errorIcon.SetError(txtTelefonos, "Falta ingresar el telefono...");
                    errorIcon.SetError(txtEnlacePagWeb, "Falta ingresar el enlace...");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NProveedor.Insertar(this.txtRazonSocial.Text.Trim(), this.cmbxSectorComercial.Text.Trim(),
                            this.cmbxTipoDocumento.Text.Trim(), this.txtNumeroDocumento.Text.Trim(), this.txtDireccion.Text.Trim(),
                            this.txtCorreos.Text.Trim(), this.txtTelefonos.Text.Trim(), this.txtEnlacePagWeb.Text.Trim());
                        errorIcon.Clear();
                    }
                    else
                    {
                        rpta = NProveedor.Editar(Convert.ToInt32(this.txtIdproveedor.Text.Trim()), this.txtRazonSocial.Text.Trim(),
                            this.cmbxSectorComercial.Text.Trim(), this.cmbxTipoDocumento.Text.Trim(), this.txtNumeroDocumento.Text.Trim(),
                            this.txtDireccion.Text.Trim(), this.txtCorreos.Text.Trim(), this.txtTelefonos.Text.Trim(), this.txtEnlacePagWeb.Text.Trim());
                        errorIcon.Clear();
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo) { this.MensajeOk("Se insertó correctamente el registro"); }
                        else { this.MensajeOk("Se actualizó correctamente el registro"); }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    errorIcon.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdproveedor.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar primero un registro para modificar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            errorIcon.Clear();
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked) 
            { 
                this.dataListado.Columns[0].Visible = true; 
            }
            else 
            { 
                this.dataListado.Columns[0].Visible = false; 
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Esta seguro de eliminar estos registros?",
                    "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NProveedor.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReptoProveedores frm = new Reportes.FrmReptoProveedores();
            frm.ShowDialog();
        }
    }
}
