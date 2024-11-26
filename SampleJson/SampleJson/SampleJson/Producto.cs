using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleJson
{
    public class Producto
    {
        public string NombreProducto { get; set; }
        public string Categoria {  get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, string categoria, double precio)
        {
            NombreProducto = nombre;
            Categoria = categoria;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{NombreProducto}";
        }
    }
}
