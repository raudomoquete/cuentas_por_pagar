using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTAS_POR_PAGAR
{
    public partial class FRESTADO : Form
    {
        public FRESTADO()
        {
            InitializeComponent();
        }

        private void FRESTADO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SCXPRAUDODataSet.estado_de_cuentas' table. You can move, or remove it, as needed.
            this.estado_de_cuentasTableAdapter.Fill(this.SCXPRAUDODataSet.estado_de_cuentas);

            this.reportViewer1.RefreshReport();
        }
    }
}
