using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GonzalezJoseBiblioClases;
using System.IO;

namespace GonzalezJoseFormKwikEMart
{
    public partial class GralStockForm : Form
    {
        public List<Producto> listaModificada;
        public GralStockForm()
        {
            InitializeComponent();
        }

        private void GralStockForm_Load(object sender, EventArgs e)
        {           
            List<Producto> listaProductosGral = CargaGeneral.CargarProductos();

            DGVGralStock.DataSource = listaProductosGral;            
            DGVGralStock.Columns[0].HeaderText = "Id del Producto";
            DGVGralStock.Columns[1].HeaderText = "Nombre del Producto";
            DGVGralStock.Columns[2].HeaderText = "Cantidad del Producto";
            DGVGralStock.Columns[3].HeaderText = "Precio del Producto";            
            DGVGralStock.Columns[4].HeaderText = "Estado del Producto";            
        }
    }
}
