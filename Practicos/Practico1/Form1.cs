using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicos.Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Muestra el nombre y apellido en el campo de resultado
            textResultado.Text = textApellido.Text + " " + textNombre.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Limpia los campos de texto
            textResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            this.Close();
        }

        private void btnSalir_KeyDown(object sender, KeyEventArgs e)
        {
            // Detecta si se presionó Ctrl + S
            if (e.Control && e.KeyCode == Keys.S) {
                this.Close();
            }
        }
    }
}
