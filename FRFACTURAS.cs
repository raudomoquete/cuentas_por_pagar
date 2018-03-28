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
    public partial class FRFACTURAS : Form
    {
        public FRFACTURAS()
        {
            InitializeComponent();
        }

        private void FRFACTURAS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SCXPRAUDODataSet.FACTURAS' table. You can move, or remove it, as needed.
            this.FACTURASTableAdapter.Fill(this.SCXPRAUDODataSet.FACTURAS);

            this.reportViewer1.RefreshReport();
        }
    }
}
