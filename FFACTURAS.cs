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
    
    public partial class FFACTURAS : Form
    {
        FAGREGARFACT faf = new FAGREGARFACT();
        
        public FFACTURAS()
        {
            InitializeComponent();           
        }
        private void FAGREGARFACT_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSFACTURAS.MOSTRARDATOS();
        }
        private void FMODIFICARFACT_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSFACTURAS.MOSTRARDATOS();
        }
        private void FFACTURAS_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVFACTURAS.DataSource = DATOSFACTURAS.MOSTRARDATOS();
        }

        private void FFACTURAS_Load(object sender, EventArgs e)
        {
            DGVFACTURAS.DataSource = DATOSFACTURAS.MOSTRARDATOS();

            //Ocultamos las columnas proveedores y cheques 
            DGVFACTURAS.Columns["PROVEEDORE"].Visible = false;
            DGVFACTURAS.Columns["CHEQUES"].Visible = false;
        }

        private void TXTNFACTURA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVFACTURAS.DataSource = DATOSFACTURAS.BUSCARPORELNUMERO
                    (Convert.ToUInt16(TXTNFACTURA.Text));
            }
            catch
            {
                MessageBox.Show("DEBE INTRODUCIR VALORES NUMERICOS");
                TXTNFACTURA.Focus();
            }
        }

        private void TXTCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVFACTURAS.DataSource = DATOSFACTURAS.BUSCARPORCODIGO(TXTCODIGO.Text);
        }         

        private void TXTNFACTURA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTCODIGO.Focus();
            }
        }
        private void BTNAGR_Click(object sender, EventArgs e)
        {
            FAGREGARFACT faf = new FAGREGARFACT();

            faf.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FFACTURAS_FormClosed);
            faf.Show();
        }

        private void BTNMODIF_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DGVFACTURAS.CurrentRow;
            int numerofactura = Convert.ToInt16(Fila.Cells[0].Value);
            FMODIFICARFACT fmf = new FMODIFICARFACT();

            fmf.Show();
            fmf.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FFACTURAS_FormClosed);
            
        }

        private void BTNELIMN_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "DESEA ELIMINAR ESTA FACTURA? ", "ADVERTENCIA!", MessageBoxButtons.YesNo);
            if(respuesta == DialogResult.Yes)
            {
                DataGridViewRow Fila = DGVFACTURAS.CurrentRow;
                int numerofactura = Convert.ToUInt16(Fila.Cells[0].Value);
                DATOSFACTURAS.ELIMINARFACTURA(numerofactura);
                MessageBox.Show(
                    "SE HA BORRADO LA FACTURA" + " " + TXTNFACTURA, "REGISTRO ELIMINADO ");
                DGVFACTURAS.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
            }
        }
    }
}
