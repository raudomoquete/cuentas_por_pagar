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
    public partial class FESTADODECUENTAS : Form
    {
        public FESTADODECUENTAS()
        {
            InitializeComponent();
        }

        private void FESTADODECUENTAS_Load(object sender, EventArgs e)
        {
            DGVESTADOSDCTAS.DataSource = DATOSESTADOSDECUENTAS.MOSTRARESTADO();
        }

        private void TXTCODIGODELPROV_TextChanged(object sender, EventArgs e)
        {
           DGVESTADOSDCTAS.DataSource = DATOSESTADOSDECUENTAS.BUSCARPORCODIGO(int.Parse(TXTCODIGODELPROV.Text));
        }

        private void TXTNUMFACT_TextChanged(object sender, EventArgs e)
        {
            DGVESTADOSDCTAS.DataSource = DATOSESTADOSDECUENTAS.BUSCARPORNUMEROFACTURA(int.Parse(TXTNUMFACT.Text));
        }

        private void BTNVERTODOS_Click(object sender, EventArgs e)
        {
            DGVESTADOSDCTAS.DataSource = DATOSESTADOSDECUENTAS.MOSTRARESTADO();
        }
    }
}
