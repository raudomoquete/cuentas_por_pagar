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
    public partial class FAGREGARPROV : Form
    {
        DATOSPROVEEDORES datosProveedores = new DATOSPROVEEDORES();
        public FAGREGARPROV()
        {
            InitializeComponent();
        }

        private void TXTCODIGO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTNOMBRE.Focus();
            }
        }

        private void TXTNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTAPELLIDOS.Focus();
            }
        }

        private void TXTAPELLIDOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTDIRECCION.Focus();
            }
        }

        private void TXTDIRECCION_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTCIUDAD.Focus();
            }
        }

        private void TXTCIUDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTTELEFONO.Focus();
            }
        }

        private void TXTTELEFONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BTNAGREGAR.Focus();
            }
        }
        public void FAGREGARPROV_Load(object sender, EventArgs e)
        {
            DATOSPROVEEDORES datosProveedores = new DATOSPROVEEDORES();
        }

        private void BTNAGREGAR_Click(object sender, EventArgs e)
        {
            DATOSPROVEEDORES.INSERTARPROVEEDOR(
                TXTCODIGO.Text,
                TXTNOMBRE.Text,
                TXTAPELLIDOS.Text,
                TXTDIRECCION.Text,
                TXTCIUDAD.Text,
                TXTTELEFONO.Text
                );
            MessageBox.Show("EL PROVEEDOR " + " " + TXTNOMBRE.Text + " " + TXTAPELLIDOS.Text + " " + "HA SIDO AGREGADO");
            this.Close();
        }

        private void FAGREGARPROV_Load_1(object sender, EventArgs e)
        {

        }       
    }
}
