using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GonzalezJoseBiblioClases;

namespace GonzalezJoseFormKwikEMart
{
    public partial class ModificarProductoForm : Form
    {
        public ModificarProductoForm()
        {
            InitializeComponent();
        }

        private void ModificarProductoForm_Load(object sender, EventArgs e)
        {
            List<Producto> listaProductosGral = CargaGeneral.CargarProductos();
            DataGridViewProductosModificar.DataSource = listaProductosGral;
            DataGridViewProductosModificar.Columns[0].HeaderText = "Id del Producto";
            DataGridViewProductosModificar.Columns[1].HeaderText = "Nombre del Producto";
            DataGridViewProductosModificar.Columns[2].HeaderText = "Cantidad del Producto";
            DataGridViewProductosModificar.Columns[3].HeaderText = "Precio del Producto";
            DataGridViewProductosModificar.Columns[4].HeaderText = "Estado del Producto";
        }

        private void ModificarProductoBtn_Click(object sender, EventArgs e)
        {
            if (ModificarProductoIdTxt.Text != null && ModificarProductoCantidadTxt.Text != null && ModificarProductoPrecioTxt.Text != null)
            {
                CargaGeneral.ModificarProductoExistente(int.Parse(ModificarProductoIdTxt.Text),
                                                        int.Parse(ModificarProductoCantidadTxt.Text),
                                                        double.Parse(ModificarProductoPrecioTxt.Text));
                MessageBox.Show("Producto Modificado.");
            }
            else
            {
                MessageBox.Show("Por favor llene los campos necesarios.");
            }
            List<Producto> listaClientesExistentes = CargaGeneral.CargarProductos();
            DataGridViewProductosModificar.DataSource = listaClientesExistentes;
            DataGridViewProductosModificar.Columns[0].HeaderText = "Id del Producto";
            DataGridViewProductosModificar.Columns[1].HeaderText = "Nombre del Producto";
            DataGridViewProductosModificar.Columns[2].HeaderText = "Cantidad del Producto";
            DataGridViewProductosModificar.Columns[3].HeaderText = "Precio del Producto";
            DataGridViewProductosModificar.Columns[4].HeaderText = "Estado del Producto"; ;
        }
    }
}
