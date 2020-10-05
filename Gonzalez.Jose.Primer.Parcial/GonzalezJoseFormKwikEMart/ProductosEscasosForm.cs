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
    public partial class ProductosEscasosForm : Form
    {
        public ProductosEscasosForm()
        {
            InitializeComponent();
        }

        private void ProductosEscasosForm_Load(object sender, EventArgs e)
        {            
            List<Producto> listaProductosGral = CargaGeneral.CargarProductos();
            List<Producto> listaProductosEscasos = new List<Producto>();

            for (int i = 0; i < listaProductosGral.Count; i++)
            {
                if (listaProductosGral[i].GetCantidadProducto() < 10)
                {
                    listaProductosEscasos.Add(listaProductosGral[i]);
                }
            }

            DGVGralStock.DataSource = listaProductosEscasos;
            DGVGralStock.Columns[0].HeaderText = "Id del Producto";
            DGVGralStock.Columns[1].HeaderText = "Nombre del Producto";
            DGVGralStock.Columns[2].HeaderText = "Cantidad del Producto";
            DGVGralStock.Columns[3].HeaderText = "Precio del Producto";
        }
    }
}
