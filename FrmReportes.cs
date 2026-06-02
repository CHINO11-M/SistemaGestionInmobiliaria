using System;
using System.ComponentModel;
using System.Linq; // ¡Súper importante para darle formato a la tabla!
using System.Windows.Forms;

namespace SistemaGestionInmobiliaria
{
    public partial class FrmReportes : Form
    {
        // Ya no la necesitamos porque ahora somos una arquitectura Singleton real.

        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                DgvContratos.DataSource = null;

                // 1. Verificamos si hay contratos reales guardados en la Bóveda (Singleton)
                if (SistemaCentral.Instancia.ListaContratos.Count > 0)
                {
                    // 2.Transformamos los objetos complejos en una tabla limpia
                    var reportesFormateados = SistemaCentral.Instancia.ListaContratos.Select(contrato => new
                    {
                        Cliente = contrato.ClienteAsociado.ToString(),
                        Inmueble = contrato.InmuebleAsociado.ToString(),
                        Fecha_Operacion = contrato.FechaOperacion.ToString("dd/MM/yyyy hh:mm tt")
                    }).ToList();

                    // 3. Conectamos los datos formateados a la grilla visual
                    DgvContratos.DataSource = reportesFormateados;

                    // 4. Ajustamos las columnas para que ocupen todo el ancho de la pantalla
                    DgvContratos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los reportes: " + ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}