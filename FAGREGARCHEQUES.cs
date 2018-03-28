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
    public partial class FAGREGARCHEQUES : Form
    {
        public FAGREGARCHEQUES()
        {
            InitializeComponent();
        }

        private void BTNAGREGA_Click(object sender, EventArgs e)
        {
            DATOSCHEQUES.INSERTARCHEQUE(

                Convert.ToInt16(TXTNUMCHEC.Text),                
                Convert.ToInt16(TXTNUMFACT.Text),
                Convert.ToDecimal(TXTVALCHEC.Text),
                Convert.ToDateTime(TXTFCHECQ.Text));

            MessageBox.Show("EL CHEQUE SE AGREGO SATISFACTORIAMENTE", "AGREGADO");
            Close();
        }
    }
}
