using GonzalezJoseBiblioClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GonzalezJoseFormKwikEMart
{
    public partial class RealizarCompraForm : Form
    {
        private double sumatoriaTotal = 0;
        private bool botonCliente = false;
        private bool botonVendedor = false;
        private bool botonAgregar = false;

        public RealizarCompraForm()
        {
            InitializeComponent();
        }

        private void FinalizarCompraBtn_Click(object sender, EventArgs e)
        {
            if (botonAgregar == true)
            {

                string fileCompras = Path.Combine(Environment.CurrentDirectory, "Some\\Compras.txt");
                string lineaNueva = "Precio Total: " + PrecioTotalLbl.Text + "\n";
                sumatoriaTotal = 0;
                File.AppendAllText(fileCompras, lineaNueva);                
                Form graciasForm = new GraciasForm();
                graciasForm.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Por favor ingrese al menos un producto antes confirmar la compra.");
            }

        }

        private void RealizarCompraForm_Load(object sender, EventArgs e)
        {
            List<Producto> listaProductos = CargaGeneral.CargarProductos();
            DGVProductos.DataSource = listaProductos;
            DGVProductos.Columns[0].HeaderText = "Id del Producto";
            DGVProductos.Columns[1].HeaderText = "Nombre del Producto";
            DGVProductos.Columns[2].HeaderText = "Cantidad del Producto";
            DGVProductos.Columns[3].HeaderText = "Precio del Producto";
            DGVProductos.Columns[4].HeaderText = "Estado del Producto";
        }

        private void VerificarDniClienteBtn_Click(object sender, EventArgs e)
        {
            if (DniClienteVerificarTxt.Text != null)
            {
                botonCliente = true;
                List<Cliente> clienteVerificar = CargaGeneral.VerificarCliente(
                                                    int.Parse(DniClienteVerificarTxt.Text));
                NombreClienteLbl.Text = clienteVerificar[0].GetNombre();
                ApellidoClienteLbl.Text = clienteVerificar[0].GetApellido();
                DniClienteLbl.Text = clienteVerificar[0].GetDni().ToString();
                string fileCompras = Path.Combine(Environment.CurrentDirectory, "Some\\Compras.txt");
                List<Cliente> clienteCompra = CargaGeneral.VerificarCliente(int.Parse(DniClienteVerificarTxt.Text));
                string inicioCompra = "Cliente," + clienteCompra[0].GetNombre() + ","
                                    + clienteCompra[0].GetApellido() + "\n";
                File.AppendAllText(fileCompras, inicioCompra);
            } else {
                MessageBox.Show("Ingrese un Dni.");
            }
        }

        private void VerificarDniVendedorBtn_Click(object sender, EventArgs e)
        {
            if (DniVendedorVerificarTxt.Text != null)
            {
                botonVendedor = true;
                List<Vendedor> vendedorVerificar = CargaGeneral.VerificarVendedor(
                                        int.Parse(DniVendedorVerificarTxt.Text));
                NombreVendedorLbl.Text = vendedorVerificar[0].GetNombre();
                ApellidoVendedorLbl.Text = vendedorVerificar[0].GetApellido();
                DniVendedorLbl.Text = vendedorVerificar[0].GetDni().ToString();
                string fileCompras = Path.Combine(Environment.CurrentDirectory, "Some\\Compras.txt");
                List<Vendedor> vendedorCompra = CargaGeneral.VerificarVendedor
                                                (int.Parse(DniVendedorVerificarTxt.Text));
                string inicioCompra = "Vendedor," + vendedorCompra[0].GetNombre() + ","
                                    + vendedorCompra[0].GetApellido() + ",Fecha," + DateTime.Now.ToString() + "\n";
                File.AppendAllText(fileCompras, inicioCompra);
            } else
            {
                MessageBox.Show("Ingrese un Dni.");
            }
        }

        private void AgregarProductosCompraBtn_Click(object sender, EventArgs e)
        {
            if (botonCliente == true && botonVendedor == true)
            {
                botonAgregar = true;
                List<Producto> listaProductos = CargaGeneral.CargarProductos();
                DGVProductos.DataSource = listaProductos;
                DGVProductos.Columns[0].HeaderText = "Id del Producto";
                DGVProductos.Columns[1].HeaderText = "Nombre del Producto";
                DGVProductos.Columns[2].HeaderText = "Cantidad del Producto";
                DGVProductos.Columns[3].HeaderText = "Precio del Producto";
                DGVProductos.Columns[4].HeaderText = "Estado del Producto";
                List<Producto> listaProductosAgregadosCompra = CargaGeneral.AgregarProductoALaCompra
                                                        (int.Parse(IdProductoAgregarCompraTxt.Text));
                DataGridViewProductosDeLaCompra.DataSource = listaProductosAgregadosCompra;
                sumatoriaTotal += listaProductosAgregadosCompra[0].GetPrecioProducto();
                if (ApellidoClienteLbl.Text == "Simpson")
                {
                    sumatoriaTotal *= 0.87;
                }
                PrecioTotalLbl.Text = sumatoriaTotal.ToString();
            } else
            {
                MessageBox.Show("Por favor ingrese un cliente y un vendedor antes de agregar productos.");
            }
            DataGridViewProductosDeLaCompra.Columns[0].HeaderText = "Id del Producto";
            DataGridViewProductosDeLaCompra.Columns[1].HeaderText = "Nombre del Producto";
            DataGridViewProductosDeLaCompra.Columns[2].HeaderText = "Cantidad del Producto";
            DataGridViewProductosDeLaCompra.Columns[3].HeaderText = "Precio del Producto";
            DataGridViewProductosDeLaCompra.Columns[4].HeaderText = "Estado del Producto";

        }
    }
}
