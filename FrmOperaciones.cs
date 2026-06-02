using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionInmobiliaria
{
    public partial class FrmOperaciones : Form
    {
        // Cree dos lists para simular los datos con propiedade
        private List<object> listaClientesSimulados = new List<object>();
        private List<object> listaInmueblesSimulados = new List<object>();

        public FrmOperaciones()
        {
            InitializeComponent();
            CargarDatosLocales();
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {
            CargarListasDesplegables();
        }

        private void CargarDatosLocales()
        {
            // Clientes
            listaClientesSimulados.Add(new { NombreCompleto = "David Rodríguez" });
            listaClientesSimulados.Add(new { NombreCompleto = "María Alejandra" });
            listaClientesSimulados.Add(new { NombreCompleto = "Juan Pérez" });

            // Inmuebles
            listaInmueblesSimulados.Add(new { Direccion = "Apartamento Playa El Ángel - Pampatar" });
            listaInmueblesSimulados.Add(new { Direccion = "Local Comercial Mercado de Conejeros" });
            listaInmueblesSimulados.Add(new { Direccion = "Quinta Av. Bolívar - Porlamar" });
        }

        private void CargarListasDesplegables()
        {
            try
            {
                // conecte clienes con cmbClientes
                cmbClientes.DataSource = null;
                cmbClientes.DataSource = listaClientesSimulados;
                cmbClientes.DisplayMember = "NombreCompleto";

                // Conecte los inmuebles con cmbInmuebles
                cmbInmuebles.DataSource = null;
                cmbInmuebles.DataSource = listaInmueblesSimulados;
                cmbInmuebles.DisplayMember = "Direccion";

               
                cmbClientes.SelectedIndex = -1;
                cmbInmuebles.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las listas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool tieneError = false;

            if (cmbClientes.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbClientes, "¡Requerido! Debe seleccionar un cliente.");
                tieneError = true;
            }

            if (cmbInmuebles.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbInmuebles, "¡Requerido! Debe seleccionar un inmueble.");
                tieneError = true;
            }

            if (tieneError)
            {
                MessageBox.Show("Por favor, complete las selecciones marcadas en rojo.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // registro que el usuario selecciona
                var inmuebleSeleccionado = cmbInmuebles.SelectedItem;
                var clienteSeleccionado = cmbClientes.SelectedItem;

                // ====================================================================
                // MODIFICACIÓN: AGREGAR EL CONTRATO A LA LISTA ESTÁTICA DE REPORTES
                // ====================================================================
                // Usamos dynamic para leer las propiedades de los objetos anónimos simulados
                dynamic clienteData = clienteSeleccionado;
                dynamic inmuebleData = inmuebleSeleccionado;

                var nuevoContrato = new
                {
                    Cliente = clienteData.NombreCompleto,
                    Inmueble = inmuebleData.Direccion,
                    FechaRegistro = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
                };

                FrmReportes.historialContratos.Add(nuevoContrato);
                // ====================================================================

                MessageBox.Show("¡Contrato generado con éxito y estado del inmueble actualizado!",
                                "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Remueve el inmueble de la lista local para simular que ya se vendió/alquiló
                listaInmueblesSimulados.Remove(inmuebleSeleccionado);

                CargarListasDesplegables();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el contrato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmOperaciones_Load_1(object sender, EventArgs e)
        {
            CargarListasDesplegables();
        }

        private void btnProcesar_Click_1(object sender, EventArgs e)
        {
            btnProcesar_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReportes ventanaReportes = new FrmReportes();

            ventanaReportes.ShowDialog();
        }
    }
}