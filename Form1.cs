namespace TheGlory
{
    public partial class btnProductos : Form
    {
        public btnProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            CargarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDatos.AutoGenerateColumns = false;
            AlternarControles(false);
            CargarGrid();
        }

        private void AlternarControles(bool estado)
        {
            txtCodigoActualizar.Enabled = false;
            txtNombreActualizar.Enabled = estado;
            txtDescripcionActualizar.Enabled = estado;
            nudPrecioActualizar.Enabled = estado;
            nudStockActualizar.Enabled = estado;
            cmbProveedorActualizar.Enabled = estado;
            cmbCategoriaActualizar.Enabled = estado;
            cmbEstadoActualizar.Enabled = estado;
        }
        private void CargarGrid()
        {
            dgvDatos.DataSource = PersonaDAL.Listar();
            dgvDatos.DataSource = null;
            dgvDatos.Columns.Clear();
            dgvDatos.AutoGenerateColumns = false;
            var lista = PersonaDAL.Listar();
            dgvDatos.DataSource = new System.ComponentModel.BindingList<Persona>(lista);


            dgvDatos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "codigo", HeaderText = "Código", Width = 60 });
            dgvDatos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "nombre", HeaderText = "Nombre", Width = 140 });
            dgvDatos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "descripcion", HeaderText = "Descripción", Width = 160 });
            dgvDatos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "precio_unitario", HeaderText = "Precio", Width = 90 });
            dgvDatos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "stock", HeaderText = "Stock", Width = 60 });
            dgvDatos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "proveedor", HeaderText = "Proveedor", Width = 100 });
            dgvDatos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "categoria", HeaderText = "Categoría", Width = 100 });
            dgvDatos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "estado", HeaderText = "Estado", Width = 80 });

            dgvDatos.DataSource = PersonaDAL.Listar();


            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.ReadOnly = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDatos.DataSource = PersonaDAL.Listar();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                // Extraer directamente el objeto de la fila seleccionada
                if (dgvDatos.SelectedRows[0].DataBoundItem is Persona p)
                {
                    DialogResult respuesta = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar este producto?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (respuesta == DialogResult.Yes)
                    {
                        PersonaDAL.Eliminar(p.codigo);
                        MessageBox.Show("¡Producto eliminado con éxito!");
                        CargarGrid(); // Refresca la tabla
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto de la tabla para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtBuscarCodigo.Text, out int codigo);
            string nombre = txtBuscarNombre.Text.Trim();

            dgvDatos.DataSource = PersonaDAL.BuscarPersona(nombre, codigo);
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                Persona personaSeleccionada = (Persona)dgvDatos.SelectedRows[0].DataBoundItem;

                Form2 frm = new Form2();
                frm.ShowDialog();
                CargarGrid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la tabla para editar.");
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                if (dgvDatos.SelectedRows[0].DataBoundItem is Persona p)
                {
                    productoSeleccionado = p;


                    AlternarControles(true);


                    txtCodigoActualizar.Text = p.codigo.ToString();
                    txtNombreActualizar.Text = p.nombre;
                    txtDescripcionActualizar.Text = p.descripcion;
                    nudPrecioActualizar.Value = p.precio_unitario;
                    nudStockActualizar.Value = p.stock;
                    cmbProveedorActualizar.Text = p.proveedor;
                    cmbCategoriaActualizar.Text = p.categoria;
                    cmbEstadoActualizar.Text = p.estado;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private Persona productoSeleccionado = null;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado != null)
            {

                productoSeleccionado.nombre = txtNombreActualizar.Text;
                productoSeleccionado.descripcion = txtDescripcionActualizar.Text;
                productoSeleccionado.precio_unitario = nudPrecioActualizar.Value;
                productoSeleccionado.stock = (int)nudStockActualizar.Value;
                productoSeleccionado.proveedor = cmbProveedorActualizar.Text;
                productoSeleccionado.categoria = cmbCategoriaActualizar.Text;
                productoSeleccionado.estado = cmbEstadoActualizar.Text;


                PersonaDAL.Modificar(productoSeleccionado);

                MessageBox.Show("¡Información actualizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
                AlternarControles(false);
                productoSeleccionado = null;
            }
        }

        private void cmbCategoriaActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoriaActualizar.Items.Add("Bebidas");
            cmbCategoriaActualizar.Items.Add("Snacks");
            cmbCategoriaActualizar.Items.Add("Postres");
            cmbCategoriaActualizar.Items.Add("Comida Rápida");
        }

        private void cmbProveedorActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProveedorActualizar.Items.Add("Proveedor 1");
            cmbProveedorActualizar.Items.Add("Proveedor 2");
            cmbProveedorActualizar.Items.Add("Proveedor 3");
        }
    }
}

