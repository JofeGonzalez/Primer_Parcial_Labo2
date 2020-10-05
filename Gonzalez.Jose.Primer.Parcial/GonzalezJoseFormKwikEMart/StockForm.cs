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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }

        private void GeneralStockBtn_Click(object sender, EventArgs e)
        {
            Form gralStockForm = new GralStockForm();
            gralStockForm.Show();
        }

        private void MenosDe10StockBtn_Click(object sender, EventArgs e)
        {
            Form productosEscasosForm = new ProductosEscasosForm();
            productosEscasosForm.Show();
        }

        private void AgregarNuevoProductoBtn_Click(object sender, EventArgs e)
        {
            Form nuevoProductoForm = new NuevoProductoForm();
            nuevoProductoForm.Show();
        }

        private void ModificarProductoBtn_Click(object sender, EventArgs e)
        {
            Form modificarProductoForm = new ModificarProductoForm();
            modificarProductoForm.Show();
        }
    }
}
