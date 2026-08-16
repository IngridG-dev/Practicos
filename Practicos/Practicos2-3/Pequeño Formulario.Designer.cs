namespace Practicos.Practicos2_3
{
    partial class Pequeño_Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pequeño_Formulario));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.LNya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxMaster = new System.Windows.Forms.CheckBox();
            this.checkBoxVisa = new System.Windows.Forms.CheckBox();
            this.checkBoxNaranja = new System.Windows.Forms.CheckBox();
            this.LTarjetas = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.radioButtonVaron = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(26, 362);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 44);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(182, 362);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 44);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(10, 13);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(92, 13);
            this.LNya.TabIndex = 2;
            this.LNya.Text = "Nombre y Apellido";
            this.LNya.Click += new System.EventHandler(this.label1_Click);
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(126, 13);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(49, 13);
            this.LModificar.TabIndex = 3;
            this.LModificar.Text = "modificar";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(10, 62);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 4;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(10, 101);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 5;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(10, 137);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 6;
            this.LNombre.Text = "Nombre";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(104, 55);
            this.textDni.Name = "textDni";
            this.textDni.ShortcutsEnabled = false;
            this.textDni.Size = new System.Drawing.Size(100, 20);
            this.textDni.TabIndex = 7;
            this.textDni.TextChanged += new System.EventHandler(this.textDni_TextChanged);
            this.textDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDni_KeyDown);
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(104, 134);
            this.textNombre.Name = "textNombre";
            this.textNombre.ShortcutsEnabled = false;
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 8;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(104, 94);
            this.textApellido.Name = "textApellido";
            this.textApellido.ShortcutsEnabled = false;
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 9;
            this.textApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellido_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.checkBoxMaster);
            this.panel1.Controls.Add(this.checkBoxVisa);
            this.panel1.Controls.Add(this.checkBoxNaranja);
            this.panel1.Controls.Add(this.LTarjetas);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.textTel);
            this.panel1.Controls.Add(this.textDni);
            this.panel1.Controls.Add(this.textApellido);
            this.panel1.Controls.Add(this.LNya);
            this.panel1.Controls.Add(this.textNombre);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Location = new System.Drawing.Point(55, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 285);
            this.panel1.TabIndex = 10;
            // 
            // checkBoxMaster
            // 
            this.checkBoxMaster.AutoSize = true;
            this.checkBoxMaster.Location = new System.Drawing.Point(124, 253);
            this.checkBoxMaster.Name = "checkBoxMaster";
            this.checkBoxMaster.Size = new System.Drawing.Size(80, 17);
            this.checkBoxMaster.TabIndex = 15;
            this.checkBoxMaster.Text = "MasterCard";
            this.checkBoxMaster.UseVisualStyleBackColor = true;
            // 
            // checkBoxVisa
            // 
            this.checkBoxVisa.AutoSize = true;
            this.checkBoxVisa.Location = new System.Drawing.Point(124, 230);
            this.checkBoxVisa.Name = "checkBoxVisa";
            this.checkBoxVisa.Size = new System.Drawing.Size(46, 17);
            this.checkBoxVisa.TabIndex = 14;
            this.checkBoxVisa.Text = "Visa";
            this.checkBoxVisa.UseVisualStyleBackColor = true;
            // 
            // checkBoxNaranja
            // 
            this.checkBoxNaranja.AutoSize = true;
            this.checkBoxNaranja.Location = new System.Drawing.Point(124, 207);
            this.checkBoxNaranja.Name = "checkBoxNaranja";
            this.checkBoxNaranja.Size = new System.Drawing.Size(63, 17);
            this.checkBoxNaranja.TabIndex = 11;
            this.checkBoxNaranja.Text = "Naranja";
            this.checkBoxNaranja.UseVisualStyleBackColor = true;
            // 
            // LTarjetas
            // 
            this.LTarjetas.AutoSize = true;
            this.LTarjetas.Location = new System.Drawing.Point(10, 207);
            this.LTarjetas.Name = "LTarjetas";
            this.LTarjetas.Size = new System.Drawing.Size(95, 13);
            this.LTarjetas.TabIndex = 13;
            this.LTarjetas.Text = "Tarjetas de crédito";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(10, 172);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 12;
            this.LTelefono.Text = "Teléfono";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(104, 169);
            this.textTel.Name = "textTel";
            this.textTel.ShortcutsEnabled = false;
            this.textTel.Size = new System.Drawing.Size(100, 20);
            this.textTel.TabIndex = 10;
            this.textTel.TextChanged += new System.EventHandler(this.textTel_TextChanged);
            this.textTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTel_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(407, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 44);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(364, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(407, 239);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(51, 17);
            this.radioButtonMujer.TabIndex = 13;
            this.radioButtonMujer.TabStop = true;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            this.radioButtonMujer.CheckedChanged += new System.EventHandler(this.radioButtonMujer_CheckedChanged);
            // 
            // radioButtonVaron
            // 
            this.radioButtonVaron.AutoSize = true;
            this.radioButtonVaron.Location = new System.Drawing.Point(464, 239);
            this.radioButtonVaron.Name = "radioButtonVaron";
            this.radioButtonVaron.Size = new System.Drawing.Size(53, 17);
            this.radioButtonVaron.TabIndex = 14;
            this.radioButtonVaron.TabStop = true;
            this.radioButtonVaron.Text = "Varon";
            this.radioButtonVaron.UseVisualStyleBackColor = true;
            this.radioButtonVaron.CheckedChanged += new System.EventHandler(this.radioButtonVaron_CheckedChanged);
            // 
            // Pequeño_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 418);
            this.Controls.Add(this.radioButtonVaron);
            this.Controls.Add(this.radioButtonMujer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Pequeño_Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.Load += new System.EventHandler(this.Pequeño_Formulario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTarjetas;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.CheckBox checkBoxMaster;
        private System.Windows.Forms.CheckBox checkBoxVisa;
        private System.Windows.Forms.CheckBox checkBoxNaranja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.RadioButton radioButtonVaron;
    }
}