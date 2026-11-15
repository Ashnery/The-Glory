using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using TheGlory;


namespace TheGlory
{
    public class PersonaDAL
    {
        // Guardar producto
        public static int Agregar(Persona p)
        {
            SqlConnection conexion = Conexion.ObtenerConexion();
            string query = "INSERT INTO productos (nombre, descripcion, precio_unitario, stock, proveedor, categoria, estado, ultima_actualizacion) " +
                           "VALUES (@nombre, @desc, @precio, @stock, @proveedor, @cat, @estado, @fecha)";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@codigo", p.codigo);
            comando.Parameters.AddWithValue("@nombre", p.nombre);
            comando.Parameters.AddWithValue("@desc", p.descripcion);
            comando.Parameters.AddWithValue("@precio", p.precio_unitario);
            comando.Parameters.AddWithValue("@stock", p.stock);
            comando.Parameters.AddWithValue("@proveedor", p.proveedor);
            comando.Parameters.AddWithValue("@cat", p.categoria);
            comando.Parameters.AddWithValue("@estado", p.estado);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now);

            int filas = comando.ExecuteNonQuery();
            conexion.Close();
            return filas;
        }

       
        public static List<Persona> Listar()
        {
            List<Persona> lista = new List<Persona>();
            SqlConnection conexion = Conexion.ObtenerConexion();

            string query = "SELECT * FROM productos";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Persona p = new Persona();
               p.codigo = reader.GetInt32(0);
                p.nombre = reader.GetString(1);
                p.descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2);
                p.precio_unitario = reader.GetDecimal(3);
                p.stock = reader.GetInt32(4);
                p.proveedor = reader.IsDBNull(5) ? "" : reader.GetString(5);
                p.categoria = reader.GetString(6);
                p.estado = reader.GetString(7);
                p.ultima_actualizacion = reader.GetDateTime(8);

                lista.Add(p);
            }

            conexion.Close();
            return lista;
        }

        
        public static int Modificar(Persona p)
        {
            SqlConnection conexion = Conexion.ObtenerConexion();
            string query = "UPDATE productos SET nombre=@nombre, descripcion=@desc, precio_unitario=@precio, " +
                           "stock=@stock, proveedor=@prov, categoria=@cat, estado=@estado, ultima_actualizacion=@fecha WHERE codigo=@codigo";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@codigo", p.codigo);
            comando.Parameters.AddWithValue("@nombre", p.nombre);
            comando.Parameters.AddWithValue("@desc", p.descripcion);
            comando.Parameters.AddWithValue("@precio", p.precio_unitario);
            comando.Parameters.AddWithValue("@stock", p.stock);
            comando.Parameters.AddWithValue("@prov", p.proveedor);
            comando.Parameters.AddWithValue("@cat", p.categoria);
            comando.Parameters.AddWithValue("@estado", p.estado);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now);
            

            int filas = comando.ExecuteNonQuery();
            conexion.Close();
            return filas;
        }


        public static int Eliminar(int codigo)
        {
            SqlConnection conexion = Conexion.ObtenerConexion();
            string query = "DELETE FROM productos WHERE codigo = @codigo";

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@codigo", codigo);

            int filas = comando.ExecuteNonQuery();
            conexion.Close();
            return filas;
        }


        public static List<Persona> BuscarPersona(string nombre, int codigo)
        {
            List<Persona> lista = new List<Persona>();
            SqlConnection conexion = Conexion.ObtenerConexion();

            string query = "SELECT * FROM productos WHERE (@codigo = 0 OR codigo = @codigo) AND (@nombre = '' OR nombre LIKE '%' + @nombre + '%')";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(nombre) ? "" : nombre);

            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona p = new Persona();
               p.codigo = reader.GetInt32(0);
                p.nombre = reader.GetString(1);
                p.descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2);
                p.precio_unitario = reader.GetDecimal(3);
                p.stock = reader.GetInt32(4);
                p.proveedor = reader.IsDBNull(5) ? "" : reader.GetString(5);
                p.categoria = reader.GetString(6);
                p.estado = reader.GetString(7);
                p.ultima_actualizacion = reader.GetDateTime(8);

                lista.Add(p);
            }

            conexion.Close();
            return lista;
        }
    }
}