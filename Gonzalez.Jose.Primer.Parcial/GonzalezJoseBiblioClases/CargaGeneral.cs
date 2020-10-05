using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezJoseBiblioClases
{
    public class CargaGeneral
    {
        static void Main(string[] args)
        {
        }
        /// <CargarPrdocutos>
        /// Carga los productos de un archivo de texto.         
        /// <returns> Retorna una lista para poder mostrar o modificar.
        public static List<Producto> CargarProductos()
        {
            string fileProductos = Path.Combine(Environment.CurrentDirectory, "Some\\Productos.txt");
            List<Producto> productos = new List<Producto>();
            List<string> lineas = File.ReadAllLines(fileProductos).ToList();

            foreach (var linea in lineas)
            {
                string[] entries = linea.Split(',');
                Producto nuevoProducto = new Producto();
                nuevoProducto.SetNombreProducto(entries[0]);
                nuevoProducto.SetCantidadProducto(int.Parse(entries[1]));
                nuevoProducto.SetPrecioProducto(double.Parse(entries[2]));
                nuevoProducto.idProducto = Producto.SetIdProducto(productos.Count);
                //Retorna una lista para poder mostrar o modificar.
                if (nuevoProducto.GetCantidadProducto() > 0)
                {
                    nuevoProducto.estadoProducto = "activo";               
                }
                else
                {
                    nuevoProducto.estadoProducto = "agotado";
                }
                productos.Add(nuevoProducto);
            }
            return productos;
        }
        /// <Cargar Clientes>
        /// Carga los clientes de un archivo de texto.
        /// <returns> Retorna una lista para poder mosrar o modificar.
        public static List<Cliente> CargarClientes()
        {
            string fileClientes = Path.Combine(Environment.CurrentDirectory, "Some\\Clientes.txt");
            List<Cliente> clientes = new List<Cliente>();
            List<string> lineas = File.ReadAllLines(fileClientes).ToList();

            foreach (var linea in lineas)
            {
                string[] entries = linea.Split(',');
                string nombre = entries[0];
                string apellido = entries[1];
                int dni = int.Parse(entries[2]);
                string direccion = entries[3];
                Cliente nuevoCliente = new Cliente(nombre, apellido, dni, direccion);
                clientes.Add(nuevoCliente);
            }
            return clientes;
        }
        /// <AgregarNuevoProducto>
        /// Permite agregar un nuevo productos al archivo de texto Productos.txt
        /// <param name="nombre"> Nombre del producto a agregar.
        /// <param name="cantidad"> Cantidad del producto a agregar.
        /// <param name="precio"> Precio del producto a agregar.
        public static void AgregarNuevoProducto(string nombre, int cantidad, double precio)
        {
            string fileProductos = Path.Combine(Environment.CurrentDirectory, "Some\\Productos.txt");
            string linea = "\n" + nombre + "," + cantidad + "," + precio;
            File.AppendAllText(fileProductos, linea);
        }
        /// <AgregarNuevoCliente>
        /// Permite agregar un nuevo cliente al archivo de texto Clientes.txt
        /// <param name="nombre"> Nombre del cliente a agregar.
        /// <param name="apellido"> Apellido del cliente a agregar.
        /// <param name="dni"> Dni del cliente a agregar.
        /// <param name="direccion"> Direccion del cliente a agregar.
        public static void AgregarNuevoCliente(string nombre, string apellido, int dni, string direccion)
        {
            string fileClientes = Path.Combine(Environment.CurrentDirectory, "Some\\Clientes.txt");
            string linea = "\n" + nombre + "," + apellido + "," + dni + "," + direccion;
            File.AppendAllText(fileClientes, linea);
        }
        /// <ModificarProductoExistente>
        /// Permite modifcar un producto en el archivo Productos.txt
        /// <param name="id"> Id del producto que se quiere modificar.
        /// <param name="cantidad"> Nueva cantidad de producto a modificar.
        /// <param name="precio"> Nuevo precio del prodcuto a modificar.
        /// <returns> Retorna una lista para poder mostrar o modificar.
        public static List<Producto> ModificarProductoExistente(int id, int cantidad, double precio)
        {

            string fileProductos = Path.Combine(Environment.CurrentDirectory, "Some\\Productos.txt");
            List<Producto> productos = new List<Producto>();
            List<string> lineas = File.ReadAllLines(fileProductos).ToList();
            File.Delete(fileProductos);
            foreach (var linea in lineas)
            {
                string[] entries = linea.Split(',');
                Producto nuevoProducto = new Producto();
                nuevoProducto.idProducto = Producto.SetIdProducto(productos.Count);
                if (nuevoProducto.idProducto == id)
                {
                    nuevoProducto.SetNombreProducto(entries[0]);
                    nuevoProducto.SetCantidadProducto(cantidad);
                    nuevoProducto.SetPrecioProducto(precio);
                    //Si el producto tiene 0 en cantidad pasa a estado agotado
                    if (nuevoProducto.GetCantidadProducto() > 0)
                    {
                        nuevoProducto.estadoProducto = "activo";
                    }
                    else
                    {
                        nuevoProducto.estadoProducto = "agotado";
                    }
                }
                else
                {
                    nuevoProducto.SetNombreProducto(entries[0]);
                    nuevoProducto.SetCantidadProducto(int.Parse(entries[1]));
                    nuevoProducto.SetPrecioProducto(double.Parse(entries[2]));
                    if (nuevoProducto.GetCantidadProducto() > 0)
                    {
                        nuevoProducto.estadoProducto = "activo";
                    }
                    else
                    {
                        nuevoProducto.estadoProducto = "agotado";
                    }
                }
                productos.Add(nuevoProducto);
                string lineaNueva = nuevoProducto.GetNombreProducto() + ","
                             + nuevoProducto.GetCantidadProducto() + ","
                             + nuevoProducto.GetPrecioProducto() + "\n";
                File.AppendAllText(fileProductos, lineaNueva);
            }
            return productos;
        }
        /// <VerificarCliente>
        /// Permite verificar que un cliente exista en el archivo Clientes.txt
        /// <param name="dni"> Dni del cliente a verificar.
        /// <returns> Retorna una Lista para mostrar por pantalla.
        public static List<Cliente> VerificarCliente(int dni)
        {
            string fileClientes = Path.Combine(Environment.CurrentDirectory, "Some\\Clientes.txt");
            List<Cliente> clientes = new List<Cliente>();
            List<string> lineas = File.ReadAllLines(fileClientes).ToList();

            foreach (var linea in lineas)
            {
                string[] entries = linea.Split(',');
                if (dni == (int.Parse(entries[2])))
                {
                    string nombre = entries[0];
                    string apellido = entries[1];
                    string direccion = entries[3];
                    Cliente nuevoCliente = new Cliente(nombre, apellido, dni, direccion);
                    clientes.Add(nuevoCliente);
                }
            }
            return clientes;
        }
        /// <VerificarVendedor>
        /// Permite verificar que un cliente existe en el archivo Vendedores.txt        
        /// <param name="dni"> Dni del vendedor a verificar.
        /// <returns> Retorna una lista para mostrar por pantalla
        public static List<Vendedor> VerificarVendedor(int dni)
        {
            string fileVendedores = Path.Combine(Environment.CurrentDirectory, "Some\\Vendedores.txt");
            List<Vendedor> vendedores = new List<Vendedor>();
            List<string> lineas = File.ReadAllLines(fileVendedores).ToList();

            foreach (var linea in lineas)
            {
                string[] entries = linea.Split(',');
                if (dni == (int.Parse(entries[2])))
                {
                    string nombre = entries[0];
                    string apellido = entries[1];
                    string turno = entries[3];
                    double sueldo = double.Parse(entries[4]);
                    Vendedor nuevoVendedor = new Vendedor(nombre, apellido, dni, turno, sueldo);
                    vendedores.Add(nuevoVendedor);
                }
            }
            return vendedores;
        }
        /// <AgregarProductoALaCompra>
        /// Permite agregar un producto a la lista de compra de un cliente, reduciendo
        /// el numero del mismo en el stock al mismo tiempo.
        /// <param name="id"> Id del producto agregado a la compra del cliente.
        /// <returns> Retorna una lista para mostrar por pantalla.
        public static List<Producto> AgregarProductoALaCompra(int id)
        {
            int contador = 0;
            string lineaNuevaCompra = null;
            string fileProductos = Path.Combine(Environment.CurrentDirectory, "Some\\Productos.txt");
            string fileCompras = Path.Combine(Environment.CurrentDirectory, "Some\\Compras.txt");
            List<Producto> productos = new List<Producto>();
            List<Producto> productosAgregados = new List<Producto>();
            List<string> lineas = File.ReadAllLines(fileProductos).ToList();
            File.Delete(fileProductos);
            foreach (var linea in lineas)
            {
                string[] entries = linea.Split(',');
                Producto nuevoProducto = new Producto();
                Producto nuevoProductoAgregado = new Producto();
                nuevoProducto.idProducto = Producto.SetIdProducto(productos.Count);
                if (nuevoProducto.idProducto == id)
                {
                    contador++;
                    nuevoProducto.SetNombreProducto(entries[0]);
                    if (nuevoProducto.estadoProducto != "agotado")
                    {
                        nuevoProducto.SetCantidadProducto(int.Parse(entries[1]) - 1);
                    }
                    else
                    {
                        nuevoProducto.SetNombreProducto("Producto Agotado");
                        nuevoProducto.SetCantidadProducto(0);
                        nuevoProducto.SetPrecioProducto(0);
                    }
                    nuevoProducto.SetPrecioProducto(double.Parse(entries[2]));
                    //Si el producto tiene 0 en cantidad pasa a estado agotado
                    if (nuevoProducto.GetCantidadProducto() > 0)
                    {
                        nuevoProducto.estadoProducto = "activo";
                    }
                    else
                    {
                        nuevoProducto.estadoProducto = "agotado";
                    }
                    nuevoProductoAgregado.idProducto = nuevoProducto.idProducto;
                    nuevoProductoAgregado.SetNombreProducto(nuevoProducto.GetNombreProducto());
                    nuevoProductoAgregado.SetCantidadProducto(contador);
                    nuevoProductoAgregado.SetPrecioProducto(nuevoProducto.GetPrecioProducto());
                    nuevoProductoAgregado.estadoProducto = nuevoProducto.estadoProducto;
                    productosAgregados.Add(nuevoProductoAgregado);
                }
                else
                {
                    nuevoProducto.SetNombreProducto(entries[0]);
                    nuevoProducto.SetCantidadProducto(int.Parse(entries[1]));
                    nuevoProducto.SetPrecioProducto(double.Parse(entries[2]));
                    if (nuevoProducto.GetCantidadProducto() > 0)
                    {
                        nuevoProducto.estadoProducto = "activo";
                    }
                    else
                    {
                        nuevoProducto.estadoProducto = "agotado";
                    }
                }
                productos.Add(nuevoProducto);
                string lineaNueva = nuevoProducto.GetNombreProducto() + ","
                             + nuevoProducto.GetCantidadProducto() + ","
                             + nuevoProducto.GetPrecioProducto() + "\n";
                File.AppendAllText(fileProductos, lineaNueva);
            }
            for (int i = 0; i < productosAgregados.Count; i++)
            {
                lineaNuevaCompra = productosAgregados[i].GetNombreProducto() + "," +
                                   productosAgregados[i].GetCantidadProducto() + "," +
                                   productosAgregados[i].GetPrecioProducto() + "\n";
            }
            File.AppendAllText(fileCompras, lineaNuevaCompra);
            return productosAgregados;
        }
        /// <NumeroDeVentasPorEmpleado>        
        /// Permite conocer el numero de ventas que ha realizado cada empleado.
        /// <param name="id"> Id del empleado del cual se quiere conocer el numero de ventas.
        /// <returns> retorna un contador entero con el numero de ventas.
        public static List<Vendedor> NumeroDeVentasPorEmpleado(int id)
        {
            string fileCompras = Path.Combine(Environment.CurrentDirectory, "Some\\Compras.txt");
            List<Vendedor> vendedorLista = VerificarVendedor(id);
            List<Vendedor> listaVendedorRetorno = new List<Vendedor>();    
            List<string> lineas = File.ReadAllLines(fileCompras).ToList();
            foreach (var linea in lineas)
            {
                string[] entries = linea.Split(',');
                if (linea.StartsWith("Vendedor,"))
                {
                    if (entries[1] == vendedorLista[0].GetNombre() && 
                        entries[2] == vendedorLista[0].GetApellido())
                    {
                        Vendedor retornoVendedor = new Vendedor(vendedorLista[0].GetNombre(), 
                                                  vendedorLista[0].GetApellido(), vendedorLista[0].GetDni(),
                                                  entries[4], vendedorLista[0].GetSueldo());
                        listaVendedorRetorno.Add(retornoVendedor);
                    }
                }
            }
                return listaVendedorRetorno;
        }
    }
}

