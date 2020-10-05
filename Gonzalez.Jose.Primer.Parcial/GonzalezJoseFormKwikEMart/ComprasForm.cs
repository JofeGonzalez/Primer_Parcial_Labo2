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

namespace GonzalezJoseFormKwikEMart
{
    public partial class ComprasForm : Form
    {
        public ComprasForm()
        {
            InitializeComponent();
        }

        private void ComprasForm_Load(object sender, EventArgs e)
        {
            List<Cliente> listaClientesExistentes = CargaGeneral.CargarClientes();
            DGVClientes.DataSource = listaClientesExistentes;      
            DGVClientes.Columns[0].HeaderText = "Direccion";
            DGVClientes.Columns[2].HeaderText = "Apellido";
            DGVClientes.Columns[3].HeaderText = "Dni";
            DGVClientes.Columns[1].HeaderText = "Nombre";                       
        }

        private void AgregarNuevoClienteBtn_Click(object sender, EventArgs e)
        {
            if (NuevoClienteApellidoTxt.Text != null && NuevoClienteNombreTxt.Text != null
                && NuevoClienteDniTxt.Text != null && NuevoClienteDireccionTxt.Text != null) {
                CargaGeneral.AgregarNuevoCliente(NuevoClienteNombreTxt.Text,
                                                 NuevoClienteApellidoTxt.Text,
                                                 int.Parse(NuevoClienteDniTxt.Text),
                                                 NuevoClienteDireccionTxt.Text);
                MessageBox.Show("Cliente Agregado.");
            } else
            {
                MessageBox.Show("Por favor llene los campos necesarios.");
            }
            List<Cliente> listaClientesExistentes = CargaGeneral.CargarClientes();
            DGVClientes.DataSource = listaClientesExistentes;
            DGVClientes.Columns[0].HeaderText = "Direccion";
            DGVClientes.Columns[2].HeaderText = "Apellido";
            DGVClientes.Columns[3].HeaderText = "Dni";
            DGVClientes.Columns[1].HeaderText = "Nombre";
        }

        private void RealizarCompraBtn_Click(object sender, EventArgs e)
        {
            Form realizarCompraForm = new RealizarCompraForm();
            realizarCompraForm.Show();
        }
    }
}
