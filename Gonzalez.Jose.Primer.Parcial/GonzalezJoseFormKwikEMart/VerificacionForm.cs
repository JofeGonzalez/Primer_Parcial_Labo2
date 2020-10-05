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
    public partial class VerificacionForm : Form
    {
        public VerificacionForm()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            List<Vendedor> logInVendedor =
                           CargaGeneral.VerificarVendedor(int.Parse(DniEmpleadoVerificar.Text));
            if (DniEmpleadoVerificar.Text != null)
            {
                NombreVendedorLbl.Text = logInVendedor[0].GetNombre();
                ApellidoVendedorLbl.Text = logInVendedor[0].GetApellido();
                if (logInVendedor != null)
                {
                    Form formPrincipal = new FormPrincipal();
                    formPrincipal.Show();
                }
            }
            else
            {
                MessageBox.Show("Ingrese el dni de un vendedor existente.");
            }
        }
    }
}
