using System;
using System.Drawing;
using System.Windows.Forms;

namespace vetControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Valida que todos los campos estén correctos
        /// Muestra ícono de error junto al campo que falla
        /// </summary>
        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool esValido = true;

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Escribe el nombre de la mascota");
                txtNombre.Focus();
                esValido = false;
            }

            // Validar Especie
            if (string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                errorProvider1.SetError(txtEspecie, "Escribe la especie");
                if (esValido) txtEspecie.Focus();
                esValido = false;
            }

            // Validar Edad
            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 0 || edad > 30)
            {
                errorProvider1.SetError(txtEdad, "La edad debe ser un número entre 0 y 30");
                if (esValido) txtEdad.Focus();
                esValido = false;
            }

            // Validar Peso
            string textoPeso = txtPeso.Text.Replace('.', ',');
            if (!double.TryParse(textoPeso, out double peso) || peso <= 0)
            {
                errorProvider1.SetError(txtPeso, "El peso debe ser mayor a 0");
                if (esValido) txtPeso.Focus();
                esValido = false;
            }

            // Validar Sexo
            if (txtSexo.Text != "M" && txtSexo.Text != "m" &&
                txtSexo.Text != "H" && txtSexo.Text != "h")
            {
                errorProvider1.SetError(txtSexo, "Escribe M para Macho o H para Hembra");
                if (esValido) txtSexo.Focus();
                esValido = false;
            }

            // Validar Servicio
            if (lstServicios.SelectedItem == null)
            {
                errorProvider1.SetError(lstServicios, "Selecciona un servicio de la lista");
                if (esValido) lstServicios.Focus();
                esValido = false;
            }

            return esValido;
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Agregar
        /// Crea un objeto Mascota y muestra los resultados
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Primero validamos todos los campos
            if (!ValidarCampos())
                return;

            // Leemos los valores de los campos
            int edad = int.Parse(txtEdad.Text);
            double peso = double.Parse(txtPeso.Text.Replace('.', ','));
            char sexo = char.ToUpper(txtSexo.Text[0]);
            string servicio = lstServicios.SelectedItem.ToString();

            // Creamos el objeto Mascota
            Mascota mascota = new Mascota(
                txtNombre.Text.Trim(),
                txtEspecie.Text.Trim(),
                edad,
                peso,
                sexo,
                servicio
            );

            // Mostramos resultados usando ÚNICAMENTE los métodos del objeto
            lblEtapa.Text = mascota.ObtenerEtapa();
            lblEtapa.BackColor = mascota.ObtenerEtapa() == "Cachorro" ? Color.LightGreen :
                                  mascota.ObtenerEtapa() == "Adulto" ? Color.LightSkyBlue : Color.Khaki;

            lblEdadMeses.Text = mascota.CalcularEdadEnMeses().ToString();

            lblDesglose.Text = $"Costo base: ₡{mascota.CalcularCostoBase():N0}\n" +
                               $"Descuento: ₡{mascota.CalcularDescuento():N0}\n" +
                               $"Subtotal: ₡{mascota.CalcularSubtotal():N0}\n" +
                               $"Impuesto 13%: ₡{mascota.CalcularImpuesto():N0}\n" +
                               $"TOTAL A PAGAR: ₡{mascota.CalcularTotal():N0}";

            lstMascotas.Items.Add(mascota.ObtenerResumen());
            lblTotal.Text = $"Mascotas registradas: {lstMascotas.Items.Count}";

            // Limpiamos los campos para un nuevo ingreso
            LimpiarCampos();
        }

        /// <summary>
        /// Limpia todos los campos del formulario
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
        /// Solo permite números y tecla de borrar en el campo Edad
        /// </summary>
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Limpia toda la lista de mascotas registradas
        /// </summary>
        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstMascotas.Items.Clear();
            lblTotal.Text = "Mascotas registradas: 0";
        }

        /// <summary>
        /// Elimina la mascota seleccionada de la lista
        /// </summary>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMascotas.SelectedIndex >= 0)
            {
                lstMascotas.Items.RemoveAt(lstMascotas.SelectedIndex);
                lblTotal.Text = $"Mascotas registradas: {lstMascotas.Items.Count}";
            }
        }

        /// <summary>
        /// Cierra la aplicación con confirmación
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir de VetControl?", "Confirmar salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
