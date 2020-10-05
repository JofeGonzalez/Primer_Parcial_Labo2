using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezJoseBiblioClases
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public int cantidadDeProducto { get; set; }
        public double precioProducto { get; set; }
        public string estadoProducto { get; set; }

        public Producto() 
        {
            this.idProducto = 0;
            this.nombreProducto = null;
            this.cantidadDeProducto = 0;
            this.precioProducto = 0;
            this.estadoProducto = null;
        }
        public Producto(int id, string nombre, int cantidad, double precio)
        {
            this.idProducto = id;
            this.nombreProducto = nombre;
            this.cantidadDeProducto = cantidad;
            this.precioProducto = precio;
            this.estadoProducto = "activo";
        }
        public  void SetNombreProducto(string nombre)
        {
            this.nombreProducto = nombre;
        }

        public string GetNombreProducto()
        {
            return nombreProducto;
        }

        public void SetCantidadProducto(int cantidad)
        {
            this.cantidadDeProducto = cantidad;
        }

        public int GetCantidadProducto()
        {
            return cantidadDeProducto;
        }

        public void SetPrecioProducto(double precio)
        {
            this.precioProducto = precio;
        }
        
        public double GetPrecioProducto()
        {
            return precioProducto;
        }
        public static int SetIdProducto(int id)
        {
            int ID = id + 1;
            return ID;
        }
        public int GetIdProducto()
        {
            return this.idProducto;
        }
    }
}
