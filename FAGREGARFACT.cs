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
    public partial class FAGREGARFACT : Form
    {
        public FAGREGARFACT()
        {
            InitializeComponent();
        }

        private void TXTNUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTCOD.Focus();
            }
        }

        private void TXTCOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTVALFACT.Focus();
            }
        }

        private void TXTVALFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTFECHAFACT.Focus();
            }
        }

        private void TXTFECHAFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTFECHVENC.Focus();
            }
        }

        private void TXTFECHVENC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                BTNAGREGAR.Focus();
            }
        }

        private void BTNAGREGAR_Click(object sender, EventArgs e)
        {
            DATOSFACTURAS.INSERTARFACTURA(
                Convert.ToInt16(TXTNUM.Text),
                TXTCOD.Text,
                Convert.ToDecimal(TXTVALFACT.Text),
                Convert.ToDateTime(TXTFECHAFACT.Text),
                Convert.ToDateTime(TXTFECHVENC.Text));

            MessageBox.Show("LA FACTURA SE AGREGO SATISFACTORIAMENTE", "AGREGADA");
            Close();
        }
    }
}
