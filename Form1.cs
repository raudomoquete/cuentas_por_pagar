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
    public partial class FINICIO : Form
    {
        string USUARIO, CLAVE;
        public FINICIO()
        {
            InitializeComponent();
            
        }

        private void BTNENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow FILA = DGVUSUARIOS.CurrentRow;
                string US = Convert.ToString(FILA.Cells[0].Value);
                string CL = Convert.ToString(FILA.Cells[1].Value);

                if(TXTUSUARIO.Text == US & TXTCLAVE.Text == CL)
                {
                    FMENUPRIN FP = new FMENUPRIN();
                    FP.Show();
                }
                else
                {
                    MessageBox.Show("DEBE ESCRIBIR NOMBRE Y CONTRASEÑA VALIDOS");
                }
            }
            catch
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INVALIDOS");
            }
        }

        private void TXTUSUARIO_TextChanged(object sender, EventArgs e)
        {
            DGVUSUARIOS.DataSource = DATOSUSUARIOS.BuscarporUsuario(TXTUSUARIO.Text);
        }

        private void TXTCLAVE_TextChanged(object sender, EventArgs e)
        {
            DGVUSUARIOS.DataSource = DATOSUSUARIOS.BuscarporUsuario(TXTCLAVE.Text);
        }

        private void FINICIO_Load(object sender, EventArgs e)
        {
            //PARA MOSTRAR LOS DATOS DE LOS USUARIOS
            DGVUSUARIOS.DataSource = DATOSUSUARIOS.MOSTRAR();
            //Para ocultar la clave
            DGVUSUARIOS.Columns[1].Visible = false;
            //Disfrazar los caracteres de la clave
            TXTCLAVE.PasswordChar = '*';
        }       
    }
}
