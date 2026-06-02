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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        // =======================================================
        // MÉTODO MAESTRO DE REFRESCO
        // =======================================================
        private void RefrescarListaEliminar()
        {
            try
            {
                // Paso 1: Desvinculamos la base de datos
                CmbInmuebles.DataSource = null;

                // Paso 2: Destruimos cualquier basura visual que cause la Exception
                CmbInmuebles.Items.Clear();

                // Paso 3: Verificamos y pasamos una "copia fresca" de la lista
                if (SistemaCentral.Instancia.ListaInmuebles.Count > 0)
                {
                    CmbInmuebles.DataSource = new List<Inmueble>(SistemaCentral.Instancia.ListaInmuebles);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error visual al refrescar la lista: " + ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =======================================================
        // MÓDULO DE NAVEGACIÓN
        // =======================================================
        private void BtnAbrirRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRegistrar pantallaRegistro = new FrmRegistrar();
                pantallaRegistro.ShowDialog(); // El código se pausa aquí

                // Al regresar, llamamos a nuestro método maestro
                RefrescarListaEliminar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir registro: " + ex.Message);
            }
        }

        private void BtnAbrirOperaciones_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOperaciones pantallaOperaciones = new FrmOperaciones();
                pantallaOperaciones.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el módulo de Operaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAbrirReportes_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReportes pantallaReportes = new FrmReportes();
                pantallaReportes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el módulo de Reportes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =======================================================
        // MÓDULO DE ELIMINACIÓN Y EVENTOS DEL FORMULARIO
        // =======================================================

        // Refresca la lista automáticamente si el menú vuelve a estar activo
        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            RefrescarListaEliminar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de selección vacía
                if (CmbInmuebles.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un inmueble de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Extracción del objeto Inmueble
                Inmueble inmuebleAEliminar = (Inmueble)CmbInmuebles.SelectedItem;

                // Confirmación de seguridad
                DialogResult respuesta = MessageBox.Show(
                    $"¿Seguro que desea eliminar el inmueble: {inmuebleAEliminar.Tipo}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respuesta == DialogResult.Yes)
                {
                    // Lo eliminamos de la bóveda (Singleton)
                    SistemaCentral.Instancia.ListaInmuebles.Remove(inmuebleAEliminar);
                    MessageBox.Show("Inmueble eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescamos la interfaz llamando a nuestro método maestro
                    RefrescarListaEliminar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =======================================================
        // MÓDULO DE SALIDA
        // =======================================================
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir del Sistema de Gestión Inmobiliaria?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit(); // Cierra todo el programa.
            }
        }

        // Eventos vacíos generados por el diseñador (no borrar para evitar fantasmas)
        private void Label1_Click(object sender, EventArgs e) { }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e) { }
    }
}