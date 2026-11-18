namespace TheGlory
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            nudPrecio = new NumericUpDown();
            nudStock = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cmbEstado = new ComboBox();
            cmbProveedor = new ComboBox();
            cmbCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(97, 58, 38);
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 30);
            label1.TabIndex = 0;
            label1.Text = "  Datos del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 110);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 3;
            label4.Text = "Descripción:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 270);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 4;
            label5.Text = "Categoría:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 173);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 19);
            label6.TabIndex = 5;
            label6.Text = "Precio Unitario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 206);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 19);
            label7.TabIndex = 6;
            label7.Text = "Stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 238);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 19);
            label8.TabIndex = 7;
            label8.Text = "Proveedor:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 303);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 19);
            label9.TabIndex = 8;
            label9.Text = "Estado:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(83, 46);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(167, 23);
            txtCodigo.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 77);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(106, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(104, 110);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(176, 50);
            txtDescripcion.TabIndex = 11;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(125, 174);
            nudPrecio.Margin = new Padding(2);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(126, 23);
            nudPrecio.TabIndex = 12;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(66, 206);
            nudStock.Margin = new Padding(2);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(126, 23);
            nudStock.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(168, 91, 50);
            btnGuardar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(25, 343);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 25);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(168, 91, 50);
            btnCancelar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(180, 343);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 25);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cmbEstado.Location = new Point(83, 303);
            cmbEstado.Margin = new Padding(2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(129, 23);
            cmbEstado.TabIndex = 16;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cmbProveedor.Location = new Point(91, 237);
            cmbProveedor.Margin = new Padding(2);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(110, 23);
            cmbProveedor.TabIndex = 19;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cmbCategoria.Location = new Point(91, 269);
            cmbCategoria.Margin = new Padding(2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(110, 23);
            cmbCategoria.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(339, 376);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbProveedor);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(nudStock);
            Controls.Add(nudPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Datos del Producto";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudStock;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cmbEstado;
        private ComboBox cmbProveedor;
        private ComboBox cmbCategoria;
    }
}