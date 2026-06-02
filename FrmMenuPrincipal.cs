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

             private void BtnAbrirRegistro_Click(object sender, EventArgs e)
             {
            try
            {
                MessageBox.Show("Módulo en desarrollo por WILMER. ¡Pronto estará conectado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el módulo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAbrirOperaciones_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Módulo en desarrollo por DAVID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAbrirReportes_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Módulo en desarrollo por DAVID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =======================================================
        // MÓDULO DE ELIMINACIÓN
        // =======================================================

        // Evento que se dispara al volver al menú, para refrescar la lista
        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            ActualizarListaEliminar();
        }

        // Método auxiliar para mantener el código limpio
        private void ActualizarListaEliminar()
        {
            try
            {
                // Limpiamos la conexión anterior
                CmbInmueblesEliminar.DataSource = null;

                // Verificamos si hay datos en la nube (Singleton) y los cargamos
                if (SistemaCentral.Instancia.ListaInmuebles.Count > 0)
                {
                    CmbInmueblesEliminar.DataSource = SistemaCentral.Instancia.ListaInmuebles;
                }
            }
            catch (Exception ex) // 'ex' es variable local
            {
                MessageBox.Show("Error al cargar inmuebles: " + ex.Message, "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón de eliminar con confirmación y manejo de errores
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación 1: Verificar que haya un elemento seleccionado
                if (CmbInmueblesEliminar.SelectedItem == null)
                {
                    MessageBox.Show("🛑 No hay ningún inmueble seleccionado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución aquí mismo
                }

                // Variable local
                DialogResult respuesta = MessageBox.Show(
                    "⚠️ ¿Está completamente seguro que desea eliminar este inmueble del sistema?",
                    "Confirmación Crítica",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    // Variable local
                    var inmuebleAEliminar = (Inmueble)CmbInmueblesEliminar.SelectedItem;

                    // Se elimina de la base de datos en memoria (Singleton)
                    SistemaCentral.Instancia.ListaInmuebles.Remove(inmuebleAEliminar);

                    MessageBox.Show("✅ El inmueble ha sido eliminado exitosamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescamos visualmente el ComboBox
                    ActualizarListaEliminar();
                }
            }
            catch (Exception ex) // 'ex' es variable local
            {
                MessageBox.Show("🛑 Error crítico al intentar eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}