﻿using System;
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
    public partial class FrmReptoStockArticulos : Form
    {
        public FrmReptoStockArticulos()
        {
            InitializeComponent();
        }

        private void FrmReptoStockArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spstock_articulos' Puede moverla o quitarla según sea necesario.
            this.spstock_articulosTableAdapter.Fill(this.dsPrincipal.spstock_articulos);
            this.reportViewer.RefreshReport();
        }
    }
}
