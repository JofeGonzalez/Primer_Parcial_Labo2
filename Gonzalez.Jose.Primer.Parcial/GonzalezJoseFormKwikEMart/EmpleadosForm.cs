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
    public partial class EmpleadosForm : Form
    {
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private void ConfirmarVendedorBtn_Click(object sender, EventArgs e)
        {
            if (DniVendedorTxt.Text != null) 
            {
                List<Vendedor> vendedorCompras = 
                                CargaGeneral.NumeroDeVentasPorEmpleado(int.Parse(DniVendedorTxt.Text));
                DGVEmpleados.DataSource = vendedorCompras;
                DGVEmpleados.Columns[0].HeaderText = "Fecha de la Venta";
                DGVEmpleados.Columns[1].HeaderText = "Nombre Vendedor";
                DGVEmpleados.Columns[2].HeaderText = "Apellido Vendedor";
                DGVEmpleados.Columns[3].HeaderText = "Dni Vendedor";
            } else
            {
                MessageBox.Show("Por Favor ingrese un dni.");
            }
        }
    }
}
