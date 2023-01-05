
namespace SystemVentas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnFormulario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtFormularios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 207);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(292, 24);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Escribe el nombre del formulario:";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFormulario
            // 
            this.btnFormulario.Depth = 0;
            this.btnFormulario.Location = new System.Drawing.Point(271, 307);
            this.btnFormulario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFormulario.Name = "btnFormulario";
            this.btnFormulario.Primary = true;
            this.btnFormulario.Size = new System.Drawing.Size(164, 47);
            this.btnFormulario.TabIndex = 10;
            this.btnFormulario.Text = "Abrir formulario";
            this.btnFormulario.UseVisualStyleBackColor = true;
            this.btnFormulario.Click += new System.EventHandler(this.btnFormulario_Click);
            // 
            // txtFormularios
            // 
            this.txtFormularios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormularios.Location = new System.Drawing.Point(321, 202);
            this.txtFormularios.Name = "txtFormularios";
            this.txtFormularios.Size = new System.Drawing.Size(275, 30);
            this.txtFormularios.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Formularios";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormularios);
            this.Controls.Add(this.btnFormulario);
            this.Controls.Add(this.materialLabel2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnFormulario;
        private System.Windows.Forms.TextBox txtFormularios;
        private System.Windows.Forms.Label label1;
    }
}

