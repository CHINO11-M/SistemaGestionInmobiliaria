using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SistemaGestionInmobiliaria
{
    public partial class FrmReportes : Form
    {
        // Esta es la lista global que voy a usar para guardar los conratos 
        public static BindingList<object> historialContratos = new BindingList<object>();

        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                DgvContratos.DataSource = null;

                // Si la lista tiene elementos ls voy a signar directamente al DataGridView
                if (historialContratos != null && historialContratos.Count > 0)
                {
                    DgvContratos.DataSource = historialContratos;
                    DgvContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los reportes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}