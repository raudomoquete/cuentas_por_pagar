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
    public partial class FMENUPRIN : Form
    {
        public FMENUPRIN()
        {
            InitializeComponent();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPROVEEDORES FP = new FPROVEEDORES();
            FP.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FFACTURAS ff = new FFACTURAS();
            ff.Show();
        }

        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FCHEQUES FQ = new FCHEQUES();
            FQ.Show();
        }

        private void estadoDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FESTADODECUENTAS fe = new FESTADODECUENTAS();
            fe.Show();
        }

        private void reporteDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRPROVEEDORES RP = new FRPROVEEDORES();
            RP.Show();
        }

        private void reporteDeEstadoDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRESTADO RE = new FRESTADO();
            RE.Show();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRCHEQUES RC = new FRCHEQUES();
            RC.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRFACTURAS rf = new FRFACTURAS();
            rf.Show();
        }
    }
}
