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
    public partial class FRCHEQUES : Form
    {
        public FRCHEQUES()
        {
            InitializeComponent();
        }

        private void FRCHEQUES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SCXPRAUDODataSet.CHEQUES' table. You can move, or remove it, as needed.
            this.CHEQUESTableAdapter.Fill(this.SCXPRAUDODataSet.CHEQUES);

            this.reportViewer1.RefreshReport();
        }
    }
}
