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
using Microsoft.Win32;

namespace GonzalezJoseFormKwikEMart
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            Form stockForm = new StockForm();
            stockForm.Show();
        }

        private void CompraBtn_Click(object sender, EventArgs e)
        {
            Form comprasForm = new ComprasForm();
            comprasForm.Show();
        }

        private void EmpleadosBtn_Click(object sender, EventArgs e)
        {
            Form empleadosForm = new EmpleadosForm();
            empleadosForm.Show();
        }
    }
}
