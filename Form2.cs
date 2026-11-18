using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheGlory
{
    public partial class Form2 : Form
    {
        private Persona productoEditar;

        public Form2()
        {
            InitializeComponent();
            productoEditar = null;


            txtCodigo.Enabled = false;
            txtCodigo.Text = "Auto";
        }

        public Form2(Persona p)
        {
            InitializeComponent();
            productoEditar = p; // 


            txtCodigo.Enabled = false;


            txtCodigo.Text = p.codigo.ToString();
            txtNombre.Text = p.nombre;
            txtDescripcion.Text = p.descripcion;
            nudPrecio.Value = p.precio_unitario;
            nudStock.Value = p.stock;
            cmbProveedor.Text = p.proveedor;
            cmbCategoria.Text = p.categoria;
            cmbEstado.Text = p.estado;
        }





        private void Form2_Load(object sender, EventArgs e)
        {
            CargarComboboxManuales();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(cmbCategoria.Text) ||
               string.IsNullOrWhiteSpace(cmbEstado.Text) ||
               string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
               string.IsNullOrWhiteSpace(cmbProveedor.Text) ||
               string.IsNullOrEmpty(nudPrecio.Text) ||
               string.IsNullOrEmpty(nudStock.Text))
            {
                MessageBox.Show("¡Por favor, completa todos los campos obligatorios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Persona nuevoProducto = new Persona();
                nuevoProducto.nombre = txtNombre.Text;
                nuevoProducto.descripcion = txtDescripcion.Text;


                decimal.TryParse(nudPrecio.Text, out decimal precio);
                nuevoProducto.precio_unitario = precio;

                int.TryParse(nudStock.Text, out int stock);
                nuevoProducto.stock = stock;

                nuevoProducto.proveedor = cmbProveedor.Text;
                nuevoProducto.categoria = cmbCategoria.Text;
                nuevoProducto.estado = cmbEstado.Text;

                int resultado = PersonaDAL.Agregar(nuevoProducto);

                if (resultado > 0)
                {
                    MessageBox.Show("¡Producto guardado con éxito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void CargarComboboxManuales()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Bebidas");
            cmbCategoria.Items.Add("Snacks");
            cmbCategoria.Items.Add("Postres");
            cmbCategoria.Items.Add("Comidas");

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");

            cmbProveedor.Items.Clear();
            cmbProveedor.Items.Add("Proveedor 1");
            cmbProveedor.Items.Add("Proveedor 2");
        }
    }
}

