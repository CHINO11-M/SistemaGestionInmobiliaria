namespace SistemaGestionInmobiliaria
{
    partial class FrmMenuPrincipal
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
            this.BtnAbrirRegistro = new System.Windows.Forms.Button();
            this.BtnAbrirOperaciones = new System.Windows.Forms.Button();
            this.BtnAbrirReportes = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.CmbInmuebles = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAbrirRegistro
            // 
            this.BtnAbrirRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbrirRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirRegistro.Location = new System.Drawing.Point(243, 48);
            this.BtnAbrirRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAbrirRegistro.Name = "BtnAbrirRegistro";
            this.BtnAbrirRegistro.Size = new System.Drawing.Size(277, 62);
            this.BtnAbrirRegistro.TabIndex = 0;
            this.BtnAbrirRegistro.Text = "👤 Registrar Inmuebles y Clientes";
            this.BtnAbrirRegistro.UseVisualStyleBackColor = true;
            this.BtnAbrirRegistro.Click += new System.EventHandler(this.BtnAbrirRegistro_Click);
            // 
            // BtnAbrirOperaciones
            // 
            this.BtnAbrirOperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbrirOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirOperaciones.Location = new System.Drawing.Point(683, 48);
            this.BtnAbrirOperaciones.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAbrirOperaciones.Name = "BtnAbrirOperaciones";
            this.BtnAbrirOperaciones.Size = new System.Drawing.Size(247, 62);
            this.BtnAbrirOperaciones.TabIndex = 1;
            this.BtnAbrirOperaciones.Text = "🤝 Generar Contratos";
            this.BtnAbrirOperaciones.UseVisualStyleBackColor = true;
            this.BtnAbrirOperaciones.Click += new System.EventHandler(this.BtnAbrirOperaciones_Click);
            // 
            // BtnAbrirReportes
            // 
            this.BtnAbrirReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbrirReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirReportes.Location = new System.Drawing.Point(1096, 48);
            this.BtnAbrirReportes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAbrirReportes.Name = "BtnAbrirReportes";
            this.BtnAbrirReportes.Size = new System.Drawing.Size(221, 62);
            this.BtnAbrirReportes.TabIndex = 2;
            this.BtnAbrirReportes.Text = "📊 Ver Reportes del Sistema";
            this.BtnAbrirReportes.UseVisualStyleBackColor = true;
            this.BtnAbrirReportes.Click += new System.EventHandler(this.BtnAbrirReportes_Click);
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(31, 585);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(473, 20);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Zona de Administración: Seleccione un inmueble para eliminar";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // CmbInmuebles
            // 
            this.CmbInmuebles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbInmuebles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInmuebles.FormattingEnabled = true;
            this.CmbInmuebles.Location = new System.Drawing.Point(36, 625);
            this.CmbInmuebles.Margin = new System.Windows.Forms.Padding(4);
            this.CmbInmuebles.Name = "CmbInmuebles";
            this.CmbInmuebles.Size = new System.Drawing.Size(240, 26);
            this.CmbInmuebles.TabIndex = 4;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(34, 669);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(242, 33);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "❌ Eliminar Inmueble Seleccionado";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(1393, 661);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(144, 41);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "🚪 Salir del Sistema";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1570, 735);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.CmbInmuebles);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnAbrirReportes);
            this.Controls.Add(this.BtnAbrirOperaciones);
            this.Controls.Add(this.BtnAbrirRegistro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión Inmobiliaria - Panel Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrirRegistro;
        private System.Windows.Forms.Button BtnAbrirOperaciones;
        private System.Windows.Forms.Button BtnAbrirReportes;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox CmbInmuebles;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
    }
}

