using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR
{
   public class DATOSFACTURAS
    {  
        public static List<FACTURA> MOSTRARDATOS()
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from F in db.FACTURAS
                            select F).ToList();
                return Info;
            }
        }
        //ESTE METODO BUSCA UNA FACTURA POR EL NUMERO
        public static List<FACTURA>BUSCARPORELNUMERO(int numerofactura)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                //Usamos LINQ para buscar la factura
                var Info = (from F in db.FACTURAS
                            where F.NUMERO_FACTURA == numerofactura
                            select F).ToList();
                return Info;
            }
        }
        //aqui buscamos la factura por el codigo
        public static List<FACTURA>BUSCARPORCODIGO(string codigo)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from F in db.FACTURAS
                            where F.CODIGO == codigo
                            select F).ToList();
                return Info;
            }
        }
        public static void INSERTARFACTURA(int numerofactura, string codigoproveedor, decimal valorfactura,
            DateTime fechafactura, DateTime fechavencimiento)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                //Insertamos un objeto asignando los valores de los parametros
                //a los campos de la tabla

                db.FACTURAS.Add(new FACTURA
                {
                    NUMERO_FACTURA = numerofactura,
                    CODIGO = codigoproveedor,
                    VALOR_FACTURA = valorfactura,
                    FECHA_FACTURA = fechafactura,
                    FECHA_VENCIMIENTO = fechavencimiento,

                });
                db.SaveChanges();
            }
        } 
        public static void MODIFICARFACTURA(int numerofactura, string codigoproveedor,
            decimal valorfactura, DateTime fechafactura, DateTime fechavencimiento)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var MODIFICAR = (from F in db.FACTURAS
                                 where F.NUMERO_FACTURA == numerofactura
                                 select F).Single();
                MODIFICAR.NUMERO_FACTURA = numerofactura;
                MODIFICAR.CODIGO = codigoproveedor;
                MODIFICAR.VALOR_FACTURA = valorfactura;
                MODIFICAR.FECHA_FACTURA = fechafactura;
                MODIFICAR.FECHA_VENCIMIENTO = fechavencimiento;
                db.SaveChanges();
            }
        }
        //Metodo que elimina una factura
        public static void ELIMINARFACTURA (int numerofactura)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var ELIMINA = (from F in db.FACTURAS
                               where F.NUMERO_FACTURA == numerofactura
                               select F).Single();
                db.FACTURAS.Remove(ELIMINA);
                db.SaveChanges();
            }
        }
       /* public static FACTURA CARGAR(int numerofactura)
        {
            FACTURA facturas = new FACTURA();
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from F in db.FACTURAS
                            where F.NUMERO_FACTURA == numerofactura
                            select F).FirstOrDefault();
                facturas.NUMERO_FACTURA = Info.NUMERO_FACTURA;
                facturas.CODIGO = Info.CODIGO;
                facturas.VALOR_FACTURA = Info.VALOR_FACTURA;
                facturas.FECHA_FACTURA = Info.FECHA_FACTURA;
                facturas.FECHA_VENCIMIENTO = Info.FECHA_VENCIMIENTO;

                return facturas;
            }
        }*/

    }
}
