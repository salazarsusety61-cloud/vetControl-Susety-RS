using System;
using System.Drawing;
using System.Windows.Forms;

namespace vetControl
{
    /// <summary>
    /// Formulario principal del sistema VetControl
    /// Permite registrar mascotas y calcular costos de servicios veterinarios
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Valida que todos los campos del formulario estén correctos
        /// Muestra ícono de error junto a cada campo que no cumple con el requisito
        /// </summary>
        /// <returns>true si todos los campos son válidos, false si hay errores</returns>
        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool valido = true;

            // Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Escriba el nombre de la mascota.");
                valido = false;
            }

            // Validar que la especie no esté vacía
            if (string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                errorProvider1.SetError(txtEspecie, "Escriba la especie.");
                valido = false;
            }

            // Validar que la edad sea un número entero entre 0 y 30
            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 0 || edad > 30)
            {
                errorProvider1.SetError(txtEdad, "La edad debe ser un número entero entre 0 y 30.");
                valido = false;
            }

            // Validar que el peso sea un número mayor a 0
            if (!double.TryParse(txtPeso.Text, out double peso) || peso <= 0)
            {
                errorProvider1.SetError(txtPeso, "El peso debe ser un número mayor que 0.");
                valido = false;
            }

            // Validar que el sexo sea M, m, H o h
            if (txtSexo.Text != "M" && txtSexo.Text != "m" &&
                txtSexo.Text != "H" && txtSexo.Text != "h")
            {
                errorProvider1.SetError(txtSexo, "El sexo debe ser M o H.");
                valido = false;
            }

            // Validar que se haya seleccionado un servicio
            if (lstServicios.SelectedItem == null)
            {
                errorProvider1.SetError(lstServicios, "Seleccione un servicio.");
                valido = false;
            }

            return valido;
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Agregar
        /// Crea un objeto Mascota, asigna sus propiedades y muestra los resultados
        /// Todos los cálculos se realizan mediante los métodos del objeto
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Ejecutar validación antes de registrar
            if (!ValidarCampos())
                return;

            // Crear el objeto Mascota con los datos del formulario
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text.Trim();
            mascota.Especie = txtEspecie.Text.Trim();
            mascota.Edad = int.Parse(txtEdad.Text);
            mascota.Peso = double.Parse(txtPeso.Text.Replace('.', ','));
            mascota.Sexo = char.ToUpper(txtSexo.Text[0]);
            mascota.Servicio = lstServicios.SelectedItem.ToString();

            // Obtener y mostrar resultados usando los métodos del objeto
            lblEtapa.Text = mascota.ObtenerEtapa();
            lblEtapa.BackColor = mascota.ObtenerEtapa() == "Cachorro" ? Color.LightGreen :
                                  mascota.ObtenerEtapa() == "Adulto" ? Color.LightSkyBlue : Color.Khaki;

            lblEdadMeses.Text = mascota.CalcularEdadEnMeses().ToString();

            lblDesglose.Text = $"Costo base: ₡{mascota.ObtenerCostoBase():N0}\n" +
                               $"Descuento: ₡{mascota.CalcularDescuento():N0}\n" +
                               $"Subtotal: ₡{(mascota.ObtenerCostoBase() - mascota.CalcularDescuento()):N0}\n" +
                               $"Impuesto 13%: ₡{mascota.CalcularImpuesto():N0}\n" +
                               $"TOTAL: ₡{mascota.CalcularTotal():N0}";

            lstMascotas.Items.Add(mascota.ObtenerResumen());
            lblTotal.Text = $"Mascotas: {lstMascotas.Items.Count}";

            MessageBox.Show("Mascota registrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos después de registrar
            LimpiarCampos();
        }

        /// <summary>
        /// Limpia todos los campos del formulario y borra los mensajes de error
        /// </summary>
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEspecie.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtSexo.Clear();
            lstServicios.ClearSelected();
            errorProvider1.Clear();
            txtNombre.Focus();
        }

        /// <summary>
        /// Controla la entrada de teclado en el campo Edad
        /// Solo permite el ingreso de dígitos
        /// </summary>
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Limpia los campos del formulario al presionar el botón Limpiar
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea limpiar todos los campos?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }

        /// <summary>
        /// Limpia toda la lista de mascotas registradas
        /// </summary>
        private void LimpiarListaToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show("¿Desea limpiar toda la lista de mascotas?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstMascotas.Items.Clear();
                lblTotal.Text = "Mascotas: 0";
                errorProvider1.Clear();
            }
        }

        /// <summary>
        /// Elimina la mascota seleccionada de la lista
        /// </summary>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMascotas.SelectedIndex >= 0)
            {
                if (MessageBox.Show("¿Desea eliminar la mascota seleccionada?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lstMascotas.Items.RemoveAt(lstMascotas.SelectedIndex);
                    lblTotal.Text = $"Mascotas: {lstMascotas.Items.Count}";
                }
            }
        }

        /// <summary>
        /// Cierra la aplicación al presionar el botón Salir
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
