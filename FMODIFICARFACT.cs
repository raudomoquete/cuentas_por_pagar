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
    public partial class FMODIFICARFACT : Form
    {
      //  private int numero;
        public FMODIFICARFACT()
        {
            InitializeComponent();
           // numero = numerofactura;
        }      

        private void FMODIFICARFACT_Load(object sender, EventArgs e)
        {
            DATOSFACTURAS datosFACTURAS = new DATOSFACTURAS();
           /* FACTURA fact = DATOSFACTURAS.CARGAR(numero);
            numero = fact.NUMERO_FACTURA;
            TXTCODIGO.Text = fact.CODIGO;
            TXTVALFACT.Text = Convert.ToString(fact.VALOR_FACTURA);
            TXTFECHAFACT.Text = Convert.ToString(fact.FECHA_FACTURA);
            TXTFECHAVENC.Text = Convert.ToString(fact.FECHA_VENCIMIENTO);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DATOSFACTURAS.MODIFICARFACTURA(

                Convert.ToInt16(TXTNUMEROF.Text),
                TXTCODIGO.Text,
                Convert.ToDecimal(TXTVALFACT.Text),
                Convert.ToDateTime(TXTFECHAFACT.Text),
                Convert.ToDateTime(TXTFECHAVENC.Text));
            MessageBox.Show("LA FACTURA SE MODIFICO SATISFACTORIAMENTE");
            Close();
        }
    }
}
