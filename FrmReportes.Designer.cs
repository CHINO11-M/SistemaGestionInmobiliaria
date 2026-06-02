using System.Collections.Generic;

namespace SistemaGestionInmobiliaria
{
    partial class FrmReportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.DgvContratos = new System.Windows.Forms.DataGridView();
            this.DgvInmuebles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInmuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvContratos
            // 
            this.DgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContratos.Location = new System.Drawing.Point(0, 0);
            this.DgvContratos.Name = "DgvContratos";
            this.DgvContratos.RowHeadersWidth = 62;
            this.DgvContratos.RowTemplate.Height = 28;
            this.DgvContratos.Size = new System.Drawing.Size(459, 437);
            this.DgvContratos.TabIndex = 0;
            // 
            // DgvInmuebles
            // 
            this.DgvInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInmuebles.Location = new System.Drawing.Point(465, 0);
            this.DgvInmuebles.Name = "DgvInmuebles";
            this.DgvInmuebles.RowHeadersWidth = 62;
            this.DgvInmuebles.RowTemplate.Height = 28;
            this.DgvInmuebles.Size = new System.Drawing.Size(459, 437);
            this.DgvInmuebles.TabIndex = 1;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 666);
            this.Controls.Add(this.DgvInmuebles);
            this.Controls.Add(this.DgvContratos);
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            // ESTA ES LA LÍNEA QUE FALTABA:
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInmuebles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvContratos;
        private System.Windows.Forms.DataGridView DgvInmuebles;
    }
}