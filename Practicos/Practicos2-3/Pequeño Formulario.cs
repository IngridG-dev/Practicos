using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicos.Practicos2_3
{
    public partial class Pequeño_Formulario : Form
    {
        public Pequeño_Formulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textApellido.Text) || string.IsNullOrWhiteSpace(textDni.Text)) // Verifica si algún campo está vacío
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Muestra un mensaje de error si algún campo está vacío
                return; // Sale del método si algún campo está vacío
            }
            DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ask == DialogResult.Yes)
            {
                // Muestra el nombre y apellido en el campo de resultado
                LModificar.Text = textNombre.Text + " " + textApellido.Text;
                MessageBox.Show("El cliente " + textNombre.Text + " " + textApellido.Text + " se insertó correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDni_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) //si no es un número ni una tecla de control
            {
                e.Handled = true; //cancela el evento si no es un dígito ni una tecla de control
                MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char) Keys.Back) //permite letras, espacios y backspace
            {
                e.Handled = true; //cancela el evento si no es una letra ni una tecla de control
                MessageBox.Show("Solo se permiten letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back) //permite letras, espacios y backspace
            {
                e.Handled = true; //cancela el evento si no es una letra ni una tecla de control
                MessageBox.Show("Solo se permiten letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Muestra mensaje de advertencia con el foco en "NO"
            DialogResult ask = MessageBox.Show("Está apunto de eliminar el Cliente: " + textNombre.Text + " " + textApellido.Text, "Confirmar Eliminacion", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, // Muestra el ícono del triángulo amarillo de advertencia
                MessageBoxDefaultButton.Button2  // Pone el foco por defecto en el segundo botón ("No")
            );
            // Si presiona "No", no pasa nada (el if se ignora). Si presiona "Sí", muestra el mensaje y limpiamos los campos.
            if (ask == DialogResult.Yes) {
                // Muestra el mensaje de éxito primero (antes de borrar los datos)
                MessageBox.Show("El Cliente: " + textNombre.Text + " " + textApellido.Text + " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpia todos los TextBox 
                textNombre.Clear();
                textApellido.Clear();
                textDni.Clear();
                // Limpiar el Label de resultado
                LModificar.Text = "";
            }
        }

        private void Pequeño_Formulario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVaron.Checked)
            {
                pictureBox1.Image = Properties.Resources.icono_hombre; // Cambia la imagen a icono_hombre.png
            }
        }

        private void radioButtonMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMujer.Checked)
            {
                pictureBox1.Image = Properties.Resources.icono_mujer; // Cambia la imagen a icono_mujer.png
            }
        }

        private void textTel_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Permite el + solamente si es el primer carácter
                if (e.KeyChar == '+' && textTel.Text.Length == 0)
                {
                    return;
                }
                e.Handled = true;
                MessageBox.Show(
                    "Solo permiten números y un signo + al principio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
}
