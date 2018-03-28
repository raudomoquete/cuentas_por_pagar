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
    public partial class FPROVEEDORES : Form
    {
        FAGREGARPROV FAP = new FAGREGARPROV();       
        
        public FPROVEEDORES()
        {
            InitializeComponent();
        }
        private void FAGREGARPROV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSPROVEEDORES.MOSTRARDATOS();
        }
        private void FMODIFICAPROV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSPROVEEDORES.MOSTRARDATOS();
        }
        private void FPROVEEDORES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
        }

        private void FPROVEEDORES_Load(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();

            //OCULTAMOS LA COLUMNA FACTURAS PARA QUE NO APAREZCA EN EL DATAGRID VIEW
            DGVPROVEEDORES.Columns["FACTURAS"].Visible = false;
        }
        private void TXTCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORCODIGO(TXTCODIGO.Text);
        }

        private void TXTNOMBRE_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORNOMBRES(TXTNOMBRE.Text);
        }

        private void TXTAPELLIDOS_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORAPELLIDOS(TXTAPELLIDOS.Text);
        }

        private void TXTDIRECCION_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORDIRECCION(TXTDIRECCION.Text);
        }

        private void TXTCIUDAD_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORDIRECCION(TXTCIUDAD.Text);
        }

        private void BTNAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARPROV FAP = new FAGREGARPROV();
            /*ABRIMOS EL FORMULARIO Y ACTUALIZAMOS DATAGRID VIEW DGVPROVEEDORES
             * DESPUES DE CERRARLO*/
            FAP.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FPROVEEDORES_FormClosed);
            FAP.Show();
        }

        public void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            FMODIFICAPROV FMP = new FMODIFICAPROV();
            DataGridViewRow FILA = DGVPROVEEDORES.CurrentRow;
            string CODIGO = Convert.ToString(FILA.Cells[0].Value);
            
            
            FMP.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FPROVEEDORES_FormClosed);
            FMP.Show();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "DESEA ELIMINAR EL PROVEEDOR?", "BORRAR PROVEEDOR?", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVPROVEEDORES.CurrentRow;
                string codigo = Convert.ToString(FILA.Cells[0].Value);
                DATOSPROVEEDORES.ELIMINARPROVEEDOR(codigo);

                MessageBox.Show("SE HA BORRADO EL PROVEEDOR" + "" + TXTNOMBRE.Text + "" +
                    TXTAPELLIDOS.Text, "Registro Eliminado ");
                DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
                
            }
        }
    }
}
