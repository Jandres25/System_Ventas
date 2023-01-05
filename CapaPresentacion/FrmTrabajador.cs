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
    public partial class FrmTrabajador : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmTrabajador()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre del trabajador.");
            this.txtContra.PasswordChar = '*';
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Mantenimiento de trabajadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mostrar mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Mantenimiento de trabajadores", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtIdtrabajador.Text = string.Empty;
            this.txtNumerodocumento.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtContra.Text = string.Empty;

            this.cbGenero.SelectedIndex = cbGenero.FindStringExact("F");            
            this.cbAcceso.SelectedIndex = cbAcceso.FindStringExact("Vendedor");
            this.dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtIdtrabajador.ReadOnly = !valor;
            this.txtNumerodocumento.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.txtUsuario.ReadOnly = !valor;
            this.txtContra.ReadOnly = !valor;

            //this.cbGenero.Enabled = !valor;
            //this.cbAcceso.Enabled = !valor;
            //this.dtpFechaNacimiento.Enabled = !valor;
        }

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
        private void OcultarColumnas()
        {
            if (dataListado.RowCount > 0)
            {
                this.dataListado.Columns[0].Visible = false;
                this.dataListado.Columns[1].Visible = false;
            }
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = NTrabajador.Mostrar();
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            this.tabControl1.SelectedIndex = 0;
        }

        private void BuscarApellidos()
        {
            this.dataListado.DataSource = NTrabajador.BuscarTrabajadorApellidos(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void BuscarDocumento()
        {
            this.dataListado.DataSource = NTrabajador.BuscarTrabajadorNumDocumento(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta seguro de eliminar estos registro?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NTrabajador.Eliminar(int.Parse(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino correctamente");
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
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.cbCriterio.Text == "Apellidos")
            {
                this.BuscarApellidos();
            }
            else
            {
                this.BuscarDocumento();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cbCriterio.Text == "Apellidos")
            {
                this.BuscarApellidos();
            }
            else
            {
                this.BuscarDocumento();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty && this.txtApellido.Text == string.Empty && txtNumerodocumento.Text == string.Empty && txtDireccion.Text == string.Empty && txtTelefono.Text == string.Empty &&
                    txtEmail.Text == string.Empty && cbAcceso.Text == string.Empty && txtUsuario.Text == string.Empty && txtContra.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, estos seran marcados...");
                    errorIcono.Text = "Rellene todos los espacios";
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NTrabajador.Insertar(this.txtNombre.Text, this.txtApellido.Text, Convert.ToChar(cbGenero.Text), dtpFechaNacimiento.Value,
                            txtNumerodocumento.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, cbAcceso.Text, txtUsuario.Text, txtContra.Text);
                    }
                    else
                    {
                        rpta = NTrabajador.Editar(int.Parse(this.txtIdtrabajador.Text), this.txtNombre.Text, this.txtApellido.Text, Convert.ToChar(cbGenero.Text), dtpFechaNacimiento.Value,
                            txtNumerodocumento.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, cbAcceso.Text, txtUsuario.Text, txtContra.Text);
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se inserto correctamente el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizo correctamente el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();

                    
                    this.Limpiar();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdtrabajador.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idtrabajador"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidos"].Value);
            this.cbGenero.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["genero"].Value);
            this.dtpFechaNacimiento.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_nac"].Value); //falla aquí
            this.txtNumerodocumento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["numero_documento"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.cbAcceso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["acceso"].Value);
            this.txtUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["usuario"].Value);
            this.txtContra.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["clave"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdtrabajador.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar primero un registro para modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Reportes.FrmReporteCategoria frm = new Reportes.FrmReporteCategoria();
            //frm.Texto = txtBuscar.Text;
            //frm.ShowDialog();
        }

        private void txtIdtrabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
