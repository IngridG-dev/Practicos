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
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.radioButtonVaron = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(13, 16);
            this.LNya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(119, 16);
            this.LNya.TabIndex = 2;
            this.LNya.Text = "Nombre y Apellido";
            this.LNya.Click += new System.EventHandler(this.label1_Click);
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(168, 16);
            this.LModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(62, 16);
            this.LModificar.TabIndex = 3;
            this.LModificar.Text = "modificar";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(13, 76);
            this.LDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(30, 16);
            this.LDni.TabIndex = 4;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(13, 124);
            this.LApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(57, 16);
            this.LApellido.TabIndex = 5;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(13, 169);
            this.LNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(56, 16);
            this.LNombre.TabIndex = 6;
            this.LNombre.Text = "Nombre";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(139, 68);
            this.textDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDni.Name = "textDni";
            this.textDni.ShortcutsEnabled = false;
            this.textDni.Size = new System.Drawing.Size(132, 22);
            this.textDni.TabIndex = 7;
            this.textDni.TextChanged += new System.EventHandler(this.textDni_TextChanged);
            this.textDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDni_KeyDown);
            this.textDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDni_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(139, 165);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.ShortcutsEnabled = false;
            this.textNombre.Size = new System.Drawing.Size(132, 22);
            this.textNombre.TabIndex = 8;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(139, 116);
            this.textApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textApellido.Name = "textApellido";
            this.textApellido.ShortcutsEnabled = false;
            this.textApellido.Size = new System.Drawing.Size(132, 22);
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
            this.panel1.Location = new System.Drawing.Point(73, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 351);
            this.panel1.TabIndex = 10;
            // 
            // checkBoxMaster
            // 
            this.checkBoxMaster.AutoSize = true;
            this.checkBoxMaster.Location = new System.Drawing.Point(165, 311);
            this.checkBoxMaster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMaster.Name = "checkBoxMaster";
            this.checkBoxMaster.Size = new System.Drawing.Size(99, 20);
            this.checkBoxMaster.TabIndex = 15;
            this.checkBoxMaster.Text = "MasterCard";
            this.checkBoxMaster.UseVisualStyleBackColor = true;
            // 
            // checkBoxVisa
            // 
            this.checkBoxVisa.AutoSize = true;
            this.checkBoxVisa.Location = new System.Drawing.Point(165, 283);
            this.checkBoxVisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxVisa.Name = "checkBoxVisa";
            this.checkBoxVisa.Size = new System.Drawing.Size(56, 20);
            this.checkBoxVisa.TabIndex = 14;
            this.checkBoxVisa.Text = "Visa";
            this.checkBoxVisa.UseVisualStyleBackColor = true;
            // 
            // checkBoxNaranja
            // 
            this.checkBoxNaranja.AutoSize = true;
            this.checkBoxNaranja.Location = new System.Drawing.Point(165, 255);
            this.checkBoxNaranja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxNaranja.Name = "checkBoxNaranja";
            this.checkBoxNaranja.Size = new System.Drawing.Size(77, 20);
            this.checkBoxNaranja.TabIndex = 11;
            this.checkBoxNaranja.Text = "Naranja";
            this.checkBoxNaranja.UseVisualStyleBackColor = true;
            // 
            // LTarjetas
            // 
            this.LTarjetas.AutoSize = true;
            this.LTarjetas.Location = new System.Drawing.Point(13, 255);
            this.LTarjetas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTarjetas.Name = "LTarjetas";
            this.LTarjetas.Size = new System.Drawing.Size(120, 16);
            this.LTarjetas.TabIndex = 13;
            this.LTarjetas.Text = "Tarjetas de crédito";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(13, 212);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(61, 16);
            this.LTelefono.TabIndex = 12;
            this.LTelefono.Text = "Teléfono";
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(139, 208);
            this.textTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTel.Name = "textTel";
            this.textTel.ShortcutsEnabled = false;
            this.textTel.Size = new System.Drawing.Size(132, 22);
            this.textTel.TabIndex = 10;
            this.textTel.TextChanged += new System.EventHandler(this.textTel_TextChanged);
            this.textTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTel_KeyPress);
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(543, 294);
            this.radioButtonMujer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(61, 20);
            this.radioButtonMujer.TabIndex = 13;
            this.radioButtonMujer.TabStop = true;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            this.radioButtonMujer.CheckedChanged += new System.EventHandler(this.radioButtonMujer_CheckedChanged);
            // 
            // radioButtonVaron
            // 
            this.radioButtonVaron.AutoSize = true;
            this.radioButtonVaron.Location = new System.Drawing.Point(619, 294);
            this.radioButtonVaron.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonVaron.Name = "radioButtonVaron";
            this.radioButtonVaron.Size = new System.Drawing.Size(64, 20);
            this.radioButtonVaron.TabIndex = 14;
            this.radioButtonVaron.TabStop = true;
            this.radioButtonVaron.Text = "Varon";
            this.radioButtonVaron.UseVisualStyleBackColor = true;
            this.radioButtonVaron.CheckedChanged += new System.EventHandler(this.radioButtonVaron_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(485, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(543, 446);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 54);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(243, 446);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 54);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(35, 446);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 54);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(264, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "NUEVO CLIENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Pequeño_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonVaron);
            this.Controls.Add(this.radioButtonMujer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
    }
}