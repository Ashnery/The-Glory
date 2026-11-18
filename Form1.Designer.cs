namespace TheGlory
{
    partial class btnProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnProductos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnActualizar = new Button();
            btnEli = new Button();
            pictureBox1 = new PictureBox();
            btnNuevo = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnBuscar = new Button();
            txtBuscarNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBuscarCodigo = new TextBox();
            dgvDatos = new DataGridView();
            dgvProducto = new DataGridViewTextBoxColumn();
            dgvCategoría = new DataGridViewTextBoxColumn();
            dgvStock = new DataGridViewTextBoxColumn();
            dgActualizacion = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            btnEditar = new DataGridViewTextBoxColumn();
            btnVer = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            nudStockActualizar = new NumericUpDown();
            nudPrecioActualizar = new NumericUpDown();
            txtDescripcionActualizar = new TextBox();
            txtCodigoActualizar = new TextBox();
            txtNombreActualizar = new TextBox();
            label13 = new Label();
            btnGuardarActualizacion = new Button();
            cmbEstadoActualizar = new ComboBox();
            cmbCategoriaActualizar = new ComboBox();
            cmbProveedorActualizar = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActualizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioActualizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 58, 38);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnEli);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 584);
            panel1.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(97, 58, 38);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(23, 133);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(129, 33);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnProveedores_Click;
            // 
            // btnEli
            // 
            btnEli.BackColor = Color.FromArgb(97, 58, 38);
            btnEli.FlatAppearance.BorderSize = 0;
            btnEli.FlatStyle = FlatStyle.Flat;
            btnEli.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEli.ForeColor = SystemColors.ButtonHighlight;
            btnEli.Location = new Point(17, 182);
            btnEli.Margin = new Padding(2);
            btnEli.Name = "btnEli";
            btnEli.Size = new Size(135, 35);
            btnEli.TabIndex = 9;
            btnEli.Text = "Eliminar";
            btnEli.UseVisualStyleBackColor = false;
            btnEli.Click += btnprod_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(168, 91, 50);
            btnNuevo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Location = new Point(553, 3);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(178, 40);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "     Nuevo Producto";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(168, 91, 50);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(560, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 37);
            label1.TabIndex = 5;
            label1.Text = "+";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(97, 58, 38);
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(181, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(337, 37);
            label2.TabIndex = 6;
            label2.Text = "Listado de Productos";
            label2.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtBuscarNombre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtBuscarCodigo);
            panel2.Location = new Point(181, 52);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 54);
            panel2.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(168, 91, 50);
            btnBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(421, 13);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 34);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(211, 28);
            txtBuscarNombre.Margin = new Padding(2);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(183, 23);
            txtBuscarNombre.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InactiveCaptionText;
            label3.Location = new Point(12, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 10;
            label3.Text = "código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(211, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 11;
            label4.Text = "Nombre:";
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(12, 28);
            txtBuscarCodigo.Margin = new Padding(2);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(187, 23);
            txtBuscarCodigo.TabIndex = 12;
            txtBuscarCodigo.TextChanged += textBox1_TextChanged;
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(97, 58, 38);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { dgvProducto, dgvCategoría, dgvStock, dgActualizacion, Column5, btnEditar, btnVer, btnEliminar });
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.Location = new Point(181, 119);
            dgvDatos.Margin = new Padding(2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.Size = new Size(550, 413);
            dgvDatos.TabIndex = 8;
            dgvDatos.CellContentClick += dataGridView1_CellContentClick;
            dgvDatos.CellEndEdit += dgvDatos_CellEndEdit;
            // 
            // dgvProducto
            // 
            dgvProducto.HeaderText = "Producto";
            dgvProducto.MinimumWidth = 8;
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            // 
            // dgvCategoría
            // 
            dgvCategoría.HeaderText = "Categoría";
            dgvCategoría.MinimumWidth = 8;
            dgvCategoría.Name = "dgvCategoría";
            dgvCategoría.ReadOnly = true;
            // 
            // dgvStock
            // 
            dgvStock.HeaderText = "Stock";
            dgvStock.MinimumWidth = 8;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            // 
            // dgActualizacion
            // 
            dgActualizacion.HeaderText = "Última actualización";
            dgActualizacion.MinimumWidth = 8;
            dgActualizacion.Name = "dgActualizacion";
            dgActualizacion.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Acciones";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.UseColumnTextForButtonValue = true;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.MinimumWidth = 8;
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            // 
            // btnVer
            // 
            btnVer.HeaderText = "Ver";
            btnVer.MinimumWidth = 8;
            btnVer.Name = "btnVer";
            btnVer.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.MinimumWidth = 8;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(755, 147);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 10;
            label5.Text = "Código:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(755, 182);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 11;
            label6.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(755, 227);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 19);
            label7.TabIndex = 12;
            label7.Text = "Descripción:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(755, 296);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 19);
            label8.TabIndex = 13;
            label8.Text = "Precio Unitario:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(755, 334);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(48, 19);
            label9.TabIndex = 14;
            label9.Text = "Stock:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(755, 371);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(76, 19);
            label10.TabIndex = 15;
            label10.Text = "Proveedor:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(759, 403);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 19);
            label11.TabIndex = 16;
            label11.Text = "Categoría:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(765, 440);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(53, 19);
            label12.TabIndex = 17;
            label12.Text = "Estado:";
            // 
            // nudStockActualizar
            // 
            nudStockActualizar.Location = new Point(834, 330);
            nudStockActualizar.Margin = new Padding(2);
            nudStockActualizar.Name = "nudStockActualizar";
            nudStockActualizar.Size = new Size(126, 23);
            nudStockActualizar.TabIndex = 21;
            // 
            // nudPrecioActualizar
            // 
            nudPrecioActualizar.Location = new Point(865, 292);
            nudPrecioActualizar.Margin = new Padding(2);
            nudPrecioActualizar.Name = "nudPrecioActualizar";
            nudPrecioActualizar.Size = new Size(126, 23);
            nudPrecioActualizar.TabIndex = 22;
            // 
            // txtDescripcionActualizar
            // 
            txtDescripcionActualizar.Location = new Point(845, 227);
            txtDescripcionActualizar.Margin = new Padding(2);
            txtDescripcionActualizar.Multiline = true;
            txtDescripcionActualizar.Name = "txtDescripcionActualizar";
            txtDescripcionActualizar.Size = new Size(176, 50);
            txtDescripcionActualizar.TabIndex = 23;
            // 
            // txtCodigoActualizar
            // 
            txtCodigoActualizar.Location = new Point(824, 143);
            txtCodigoActualizar.Margin = new Padding(2);
            txtCodigoActualizar.Name = "txtCodigoActualizar";
            txtCodigoActualizar.ReadOnly = true;
            txtCodigoActualizar.Size = new Size(167, 23);
            txtCodigoActualizar.TabIndex = 24;
            // 
            // txtNombreActualizar
            // 
            txtNombreActualizar.Location = new Point(824, 182);
            txtNombreActualizar.Margin = new Padding(2);
            txtNombreActualizar.Name = "txtNombreActualizar";
            txtNombreActualizar.Size = new Size(106, 23);
            txtNombreActualizar.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(803, 80);
            label13.Name = "label13";
            label13.Size = new Size(206, 30);
            label13.TabIndex = 26;
            label13.Text = "Ingrese los cambios";
            label13.Click += label13_Click;
            // 
            // btnGuardarActualizacion
            // 
            btnGuardarActualizacion.BackColor = Color.FromArgb(168, 91, 50);
            btnGuardarActualizacion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarActualizacion.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarActualizacion.Location = new Point(985, 507);
            btnGuardarActualizacion.Margin = new Padding(2);
            btnGuardarActualizacion.Name = "btnGuardarActualizacion";
            btnGuardarActualizacion.Size = new Size(95, 25);
            btnGuardarActualizacion.TabIndex = 27;
            btnGuardarActualizacion.Text = "Guardar";
            btnGuardarActualizacion.UseVisualStyleBackColor = false;
            btnGuardarActualizacion.Click += btnGuardar_Click;
            // 
            // cmbEstadoActualizar
            // 
            cmbEstadoActualizar.FormattingEnabled = true;
            cmbEstadoActualizar.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cmbEstadoActualizar.Location = new Point(831, 440);
            cmbEstadoActualizar.Margin = new Padding(2);
            cmbEstadoActualizar.Name = "cmbEstadoActualizar";
            cmbEstadoActualizar.Size = new Size(110, 23);
            cmbEstadoActualizar.TabIndex = 18;
            // 
            // cmbCategoriaActualizar
            // 
            cmbCategoriaActualizar.FormattingEnabled = true;
            cmbCategoriaActualizar.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cmbCategoriaActualizar.Location = new Point(831, 403);
            cmbCategoriaActualizar.Margin = new Padding(2);
            cmbCategoriaActualizar.Name = "cmbCategoriaActualizar";
            cmbCategoriaActualizar.Size = new Size(110, 23);
            cmbCategoriaActualizar.TabIndex = 30;
            // 
            // cmbProveedorActualizar
            // 
            cmbProveedorActualizar.FormattingEnabled = true;
            cmbProveedorActualizar.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cmbProveedorActualizar.Location = new Point(831, 371);
            cmbProveedorActualizar.Margin = new Padding(2);
            cmbProveedorActualizar.Name = "cmbProveedorActualizar";
            cmbProveedorActualizar.Size = new Size(110, 23);
            cmbProveedorActualizar.TabIndex = 31;
            // 
            // btnProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1091, 584);
            Controls.Add(cmbProveedorActualizar);
            Controls.Add(cmbCategoriaActualizar);
            Controls.Add(btnGuardarActualizacion);
            Controls.Add(label13);
            Controls.Add(txtNombreActualizar);
            Controls.Add(txtCodigoActualizar);
            Controls.Add(txtDescripcionActualizar);
            Controls.Add(nudPrecioActualizar);
            Controls.Add(nudStockActualizar);
            Controls.Add(cmbEstadoActualizar);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(dgvDatos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNuevo);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaption;
            Margin = new Padding(2);
            Name = "btnProductos";
            Text = "V";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActualizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecioActualizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnNuevo;
        private Label label1;
        private Label label2;
        private Button btnEli;
        private Button btnActualizar;
        private Panel panel2;
        private Label label3;
        private DataGridView dgvDatos;
        private Label label4;
        private TextBox txtBuscarCodigo;
        private TextBox txtBuscarNombre;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn dgvProducto;
        private DataGridViewTextBoxColumn dgvCategoría;
        private DataGridViewTextBoxColumn dgvStock;
        private DataGridViewTextBoxColumn dgActualizacion;
        private DataGridViewButtonColumn Column5;
        private DataGridViewTextBoxColumn btnEditar;
        private DataGridViewTextBoxColumn btnVer;
        private DataGridViewTextBoxColumn btnEliminar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private NumericUpDown nudStockActualizar;
        private NumericUpDown nudPrecioActualizar;
        private TextBox txtDescripcionActualizar;
        private TextBox txtCodigoActualizar;
        private TextBox txtNombreActualizar;
        private Label label13;
        private Button btnGuardarActualizacion;
        private ComboBox cmbEstadoActualizar;
        private ComboBox cmbCategoriaActualizar;
        private ComboBox cmbProveedorActualizar;
    }
}
