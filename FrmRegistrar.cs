using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestionInmobiliaria
{
    public partial class FrmRegistrar : Form
    {
        // 1. Instanciación de Objetos Visuales en Memoria
        TextBox txtNombre = new TextBox() { Location = new Point(20, 50), Width = 200 };
        TextBox txtCedula = new TextBox() { Location = new Point(20, 100), Width = 200 };
        TextBox txtTelefono = new TextBox() { Location = new Point(20, 150), Width = 200 };
        DateTimePicker dtpFechaNac = new DateTimePicker() { Location = new Point(20, 200), Width = 200, Format = DateTimePickerFormat.Short };
        Button btnGuardarCliente = new Button() { Text = "Guardar Cliente", Location = new Point(20, 250), Width = 200, BackColor = Color.LightGreen, Cursor = Cursors.Hand };

        ComboBox cmbTipo = new ComboBox() { Location = new Point(300, 50), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
        NumericUpDown numHabitaciones = new NumericUpDown() { Location = new Point(300, 100), Width = 200, Maximum = 10 };
        TextBox txtMetraje = new TextBox() { Location = new Point(300, 150), Width = 200 };
        TextBox txtPrecio = new TextBox() { Location = new Point(300, 200), Width = 200 };
        Button btnGuardarInmueble = new Button() { Text = "Guardar Inmueble", Location = new Point(300, 250), Width = 200, BackColor = Color.LightGreen, Cursor = Cursors.Hand };

        Button btnLimpiar = new Button() { Text = "Limpiar Campos", Location = new Point(160, 310), Width = 200, BackColor = Color.LightGray, Cursor = Cursors.Hand };

        public FrmRegistrar()
        {
            InitializeComponent();
            ConfigurarUI(); // Llamamos al constructor de la interfaz
        }

        // 2. Configuración de Propiedades y Adición de Controles
        private void ConfigurarUI()
        {
            this.Text = "Módulo de Registro de Datos";
            this.Size = new Size(550, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            cmbTipo.Items.AddRange(new string[] { "Casa", "Apartamento", "Local", "Terreno" });

            this.Controls.Add(new Label() { Text = "Nombre del Cliente:", Location = new Point(20, 30), Width = 150 });
            this.Controls.Add(txtNombre);
            this.Controls.Add(new Label() { Text = "Cédula:", Location = new Point(20, 80) });
            this.Controls.Add(txtCedula);
            this.Controls.Add(new Label() { Text = "Teléfono:", Location = new Point(20, 130) });
            this.Controls.Add(txtTelefono);
            this.Controls.Add(new Label() { Text = "Fecha de Nacimiento:", Location = new Point(20, 180), Width = 150 });
            this.Controls.Add(dtpFechaNac);
            this.Controls.Add(btnGuardarCliente);

            this.Controls.Add(new Label() { Text = "Tipo de Inmueble:", Location = new Point(300, 30), Width = 150 });
            this.Controls.Add(cmbTipo);
            this.Controls.Add(new Label() { Text = "Habitaciones:", Location = new Point(300, 80) });
            this.Controls.Add(numHabitaciones);
            this.Controls.Add(new Label() { Text = "Metraje (m2):", Location = new Point(300, 130) });
            this.Controls.Add(txtMetraje);
            this.Controls.Add(new Label() { Text = "Precio (USD):", Location = new Point(300, 180) });
            this.Controls.Add(txtPrecio);
            this.Controls.Add(btnGuardarInmueble);

            this.Controls.Add(btnLimpiar);

            btnGuardarCliente.Click += BtnGuardarCliente_Click;
            btnGuardarInmueble.Click += BtnGuardarInmueble_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
        }

        // 4. Lógica de Validación y Almacenamiento (Cliente)
        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
                    throw new Exception("Todos los campos del cliente son obligatorios.");

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                    throw new Exception("Error: El Nombre solo puede contener letras y espacios.");

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtCedula.Text, @"^\d+$"))
                    throw new Exception("Error: La Cédula solo debe contener números enteros.");

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^\d+$"))
                    throw new Exception("Error: El Teléfono solo debe contener números enteros.");

                Cliente nuevoCliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Cedula = txtCedula.Text,
                    Telefono = txtTelefono.Text,
                    FechaNacimiento = dtpFechaNac.Value
                };

                SistemaCentral.Instancia.ListaClientes.Add(nuevoCliente);
                MessageBox.Show("¡Cliente guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLimpiar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 5. Lógica de Validación y Almacenamiento (Inmueble)
        private void BtnGuardarInmueble_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validación de campos vacíos
                if (cmbTipo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMetraje.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
                    throw new Exception("Todos los campos del inmueble son obligatorios.");

                // 2. Validación estricta de Decimales (Comprueba si es un número real válido antes de guardar)
                if (!double.TryParse(txtMetraje.Text, out double metrajeValido))
                    throw new Exception("Error: El Metraje introducido no es un número válido.");

                if (!decimal.TryParse(txtPrecio.Text, out decimal precioValido))
                    throw new Exception("Error: El Precio introducido no es un número válido.");

                Inmueble nuevoInmueble = new Inmueble
                {
                    Tipo = cmbTipo.SelectedItem.ToString(),
                    Habitaciones = (int)numHabitaciones.Value,
                    Metraje = metrajeValido, // Usamos la variable ya validada
                    PrecioUSD = precioValido, // Usamos la variable ya validada
                    Disponible = true // Por defecto inicia disponible
                };

                SistemaCentral.Instancia.ListaInmuebles.Add(nuevoInmueble);
                MessageBox.Show("¡Inmueble guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLimpiar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Lógica del botón extra: Limpieza Visual
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            dtpFechaNac.Value = DateTime.Now;

            cmbTipo.SelectedIndex = -1;
            numHabitaciones.Value = 0;
            txtMetraje.Clear();
            txtPrecio.Clear();
        }
    }
}