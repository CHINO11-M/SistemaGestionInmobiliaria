using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // Importante para poder filtrar listas
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionInmobiliaria
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
            // Eliminamos la carga de datos locales falsos
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {
            CargarListasDesplegables();
        }

        private void CargarListasDesplegables()
        {
            try
            {
                // 1. Conectar Clientes desde el Singleton real
                cmbClientes.DataSource = null;
                if (SistemaCentral.Instancia.ListaClientes.Count > 0)
                {
                    // Usamos la clonación en memoria que aprendimos para evitar Exceptions
                    cmbClientes.DataSource = new List<Cliente>(SistemaCentral.Instancia.ListaClientes);
                }

                // 2. Conectar Inmuebles desde el Singleton (SOLO LOS DISPONIBLES)
                cmbInmuebles.DataSource = null;

                // Filtramos la lista buscando solo los que tengan Disponible == true
                var inmueblesDisponibles = SistemaCentral.Instancia.ListaInmuebles.Where(i => i.Disponible).ToList();

                if (inmueblesDisponibles.Count > 0)
                {
                    cmbInmuebles.DataSource = inmueblesDisponibles;
                }

                // Limpiamos la selección visual por defecto
                cmbClientes.SelectedIndex = -1;
                cmbInmuebles.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las listas desde la central: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool tieneError = false;

            // Validaciones visuales
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
                // 1. Extraemos los objetos REALES con Casteo explícito
                Cliente clienteSeleccionado = (Cliente)cmbClientes.SelectedItem;
                Inmueble inmuebleSeleccionado = (Inmueble)cmbInmuebles.SelectedItem;

                // 2. Creamos el objeto Contrato usando la estructura de tu Bóveda
                Contrato nuevoContrato = new Contrato
                {
                    ClienteAsociado = clienteSeleccionado,
                    InmuebleAsociado = inmuebleSeleccionado,
                    FechaOperacion = DateTime.Now
                };

                // 3. Lo inyectamos en la lista global de contratos
                SistemaCentral.Instancia.ListaContratos.Add(nuevoContrato);

                // 4. ¡LA MAGIA! Marcamos el inmueble como NO disponible en vez de borrarlo
                inmuebleSeleccionado.Disponible = false;

                MessageBox.Show("¡Contrato generado con éxito! El inmueble ha cambiado su estado a No Disponible.",
                                "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Refrescamos las listas (esto hará que el inmueble vendido desaparezca visualmente)
                CargarListasDesplegables();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el contrato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========================================================
        // EVENTOS DUPLICADOS DEL DISEÑADOR (Mantenemos para no crear fantasmas)
        // ========================================================
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