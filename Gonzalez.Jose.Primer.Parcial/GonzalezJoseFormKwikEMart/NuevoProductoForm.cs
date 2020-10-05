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
    public partial class NuevoProductoForm : Form
    {
        public NuevoProductoForm()
        {
            InitializeComponent();
        }

        private void AgregarNuevoProductoBtn_Click(object sender, EventArgs e)
        {
            if (NuevoProductoCantidadTxt.Text != null && 
                NuevoProductoNombreTxt.Text != null && NuevoProductoPrecioTxt.Text != null) {
                CargaGeneral.AgregarNuevoProducto(NuevoProductoNombreTxt.Text,
                                                 int.Parse(NuevoProductoCantidadTxt.Text),
                                                 double.Parse(NuevoProductoPrecioTxt.Text));
                MessageBox.Show("Producto agregado.");
            } else
            {
                MessageBox.Show("Por favor llene los campos necesarios.");
            }
            this.Close();
        }
    }
}
