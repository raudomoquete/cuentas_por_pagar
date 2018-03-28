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
    public partial class FCHEQUES : Form
    {
        public FCHEQUES()
        {
            InitializeComponent();
        }
        private void FCHEQUES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVFCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
        }
        private void FAGREGARCHEQUES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSCHEQUES.MOSTRARCHEQUES();
        }
        private void FMODIFICARCHEQUES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSCHEQUES.MOSTRARCHEQUES();
        }

        private void TXTNCHEQ_TextChanged(object sender, EventArgs e)
        {
           // DGVFCHEQUES.DataSource = DATOSCHEQUES.BUSCARELNUMERO(TXTNCHEQ.Text);
        }

        private void BTNELIMINA_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "DESEA ELIMINAR ESTE CHEQUE? ", "BORRAR CHEQUE? ", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVFCHEQUES.CurrentRow;
                int numerocheque = Convert.ToUInt16(FILA.Cells[0].Value);
                DATOSCHEQUES.ELIMINARCHEQUE(numerocheque);
                MessageBox.Show(
                    "SE HA BORRADO EL CHEQUE " + " " + TXTNCHEQ, "REGISTRO ELIMINADO ");
                DGVFCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
            }
        }

        private void BTNAGREGA_Click(object sender, EventArgs e)
        {
            FAGREGARCHEQUES FAC = new FAGREGARCHEQUES();            
            FAC.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FCHEQUES_FormClosed);
            FAC.Show();
        }

        private void BTNMODIFICA_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DGVFCHEQUES.CurrentRow;
            int numerocheque = Convert.ToUInt16(Fila.Cells[0].Value);
            FMODIFICARCHEQUES fmc = new FMODIFICARCHEQUES();
            fmc.Show();
            fmc.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FCHEQUES_FormClosed);


        }

        private void FCHEQUES_Load(object sender, EventArgs e)
        {
            DGVFCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
            DGVFCHEQUES.Columns["FACTURAS"].Visible = false;
        }
    }
}
