using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR
{
   public class DATOSESTADOSDECUENTAS
    {
        public static List<estado_de_cuentas> MOSTRARESTADO()
        {
            //Instancia del modelo de la db
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                //usamos LINQ para que nos muestre todas las facturas que hay
                var Info = (from E in db.estado_de_cuentas
                            select E).ToList();
                return Info;
            }
        }
        public static List<estado_de_cuentas> BUSCARPORNUMEROFACTURA(int numerofactura)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from E in db.estado_de_cuentas
                            where E. BALANCE== numerofactura
                            select E).ToList();
                return Info;
            }
        }
        public static List<estado_de_cuentas> BUSCARPORCODIGO(int codigo)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from E in db.estado_de_cuentas
                            where E.PAGOS ==codigo
                            select E).ToList();
                return Info;
            }
        }
    }
}
