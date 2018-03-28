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
    public partial class FMODIFICAPROV : Form
    {       
        DATOSPROVEEDORES datosProveedores = new DATOSPROVEEDORES();
        
        public FMODIFICAPROV()
        {
            InitializeComponent();            
        }

        public void FMODIFICAPROV_Load(object sender, EventArgs e)
        {
            DATOSPROVEEDORES datosProveedores = new DATOSPROVEEDORES();
        }
        

        private void BTNACTUALIZA_Click(object sender, EventArgs e)
        {
            //Invocamos el metodo MODIFICARPROVEEDOR
            DATOSPROVEEDORES.MODIFICARPROVEEDOR(
                  TXTCODIGO.Text,
                  TXTNOMBRES.Text,
                   TXTAPELLIDOS.Text,
                   TXTDIRECCION.Text,
                   TXTCIUDAD.Text,
                   TXTTELEFONO.Text
                   );
            MessageBox.Show("EL REGISTRO SE MODIFICO EXITOSAMENTE ");           
            Close();
        }
    }
}
