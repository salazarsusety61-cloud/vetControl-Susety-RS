namespace vetControl
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            limpiarListaToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtEspecie = new TextBox();
            txtEdad = new TextBox();
            txtPeso = new TextBox();
            txtSexo = new TextBox();
            lstServicios = new ListBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            lblEtapa = new Label();
            lblEdadMeses = new Label();
            lblDesglose = new Label();
            lstMascotas = new ListBox();
            lblTotal = new Label();
            errorProvider1 = new ErrorProvider(components);
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(773, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limpiarListaToolStripMenuItem, eliminarToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // limpiarListaToolStripMenuItem
            // 
            limpiarListaToolStripMenuItem.Name = "limpiarListaToolStripMenuItem";
            limpiarListaToolStripMenuItem.Size = new Size(236, 26);
            limpiarListaToolStripMenuItem.Text = "Limpiar lista";
            limpiarListaToolStripMenuItem.Click += limpiarListaToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(236, 26);
            eliminarToolStripMenuItem.Text = "Eliminar seleccionada";
            eliminarToolStripMenuItem.Click += EliminarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 18;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 17;
            label2.Text = "Especie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 16;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 200);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 15;
            label4.Text = "Peso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 246);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 14;
            label5.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 292);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 13;
            label6.Text = "Servicio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 57);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(239, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(120, 103);
            txtEspecie.Margin = new Padding(4, 5, 4, 5);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(239, 27);
            txtEspecie.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(120, 149);
            txtEdad.Margin = new Padding(4, 5, 4, 5);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(79, 27);
            txtEdad.TabIndex = 3;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(120, 195);
            txtPeso.Margin = new Padding(4, 5, 4, 5);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(79, 27);
            txtPeso.TabIndex = 4;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(120, 242);
            txtSexo.Margin = new Padding(4, 5, 4, 5);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(79, 27);
            txtSexo.TabIndex = 5;
            // 
            // lstServicios
            // 
            lstServicios.FormattingEnabled = true;
            lstServicios.Items.AddRange(new object[] { "Consulta general", "Vacunación", "Desparasitación", "Baño" });
            lstServicios.Location = new Point(120, 292);
            lstServicios.Margin = new Padding(4, 5, 4, 5);
            lstServicios.Name = "lstServicios";
            lstServicios.Size = new Size(239, 84);
            lstServicios.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(31, 415);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 46);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(187, 415);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(133, 46);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblEtapa
            // 
            lblEtapa.BackColor = Color.Transparent;
            lblEtapa.BorderStyle = BorderStyle.FixedSingle;
            lblEtapa.Location = new Point(400, 62);
            lblEtapa.Margin = new Padding(4, 0, 4, 0);
            lblEtapa.Name = "lblEtapa";
            lblEtapa.Size = new Size(319, 45);
            lblEtapa.TabIndex = 9;
            lblEtapa.Text = "Etapa";
            lblEtapa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEdadMeses
            // 
            lblEdadMeses.AutoSize = true;
            lblEdadMeses.Location = new Point(400, 138);
            lblEdadMeses.Margin = new Padding(4, 0, 4, 0);
            lblEdadMeses.Name = "lblEdadMeses";
            lblEdadMeses.Size = new Size(123, 20);
            lblEdadMeses.TabIndex = 12;
            lblEdadMeses.Text = "Edad en meses: 0";
            // 
            // lblDesglose
            // 
            lblDesglose.AutoSize = true;
            lblDesglose.Location = new Point(400, 185);
            lblDesglose.Margin = new Padding(4, 0, 4, 0);
            lblDesglose.Name = "lblDesglose";
            lblDesglose.Size = new Size(134, 20);
            lblDesglose.TabIndex = 11;
            lblDesglose.Text = "Desglose de costo:";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(400, 308);
            lstMascotas.Margin = new Padding(4, 5, 4, 5);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(319, 144);
            lstMascotas.TabIndex = 10;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(400, 477);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(86, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Mascotas: 0";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 538);
            Controls.Add(lblTotal);
            Controls.Add(lstMascotas);
            Controls.Add(lblDesglose);
            Controls.Add(lblEdadMeses);
            Controls.Add(lblEtapa);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(lstServicios);
            Controls.Add(txtSexo);
            Controls.Add(txtPeso);
            Controls.Add(txtEdad);
            Controls.Add(txtEspecie);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "VetControl - Registro de Mascotas";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.ListBox lstServicios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Label lblEdadMeses;
        private System.Windows.Forms.Label lblDesglose;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
