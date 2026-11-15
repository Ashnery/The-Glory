using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TheGlory
{
    public class Persona
    {
        public Persona() { }

        public int codigo { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }
        public decimal precio_unitario { get; set; }
        public int stock { get; set; }
        public string? proveedor { get; set; }
        public string? categoria { get; set; }
        public string? estado { get; set; }
        public DateTime ultima_actualizacion { get; set; }

    }
}