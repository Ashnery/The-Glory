using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheGlory
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadenaConexion = "Data Source=DESKTOP-AS2EP0Q;Initial Catalog=CafeteriaDB;Integrated Security=true;TrustServerCertificate=True;";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}

