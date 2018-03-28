using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR
{
   public class DATOSCHEQUES
    {
        public static List<CHEQUE> MOSTRARCHEQUES()
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from C in db.CHEQUES
                            select C).ToList();
                return Info;
            }
        }
        public static List<CHEQUE>BUSCARELNUMERO(int numerocheque)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from C in db.CHEQUES
                            where C.NUMERO_CHEQUE
                            == numerocheque
                            select C).ToList();
                return Info;
            }
        }
        public static List<CHEQUE> BUSCARPORNUMEROFACT(int numerofactura)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from C in db.CHEQUES
                            where C.NUMERO_FACTURA == numerofactura
                            select C).ToList();
                return Info;
            }
        }
        public static void INSERTARCHEQUE(int numerocheque,int numero_factura,
            decimal valor_cheque, DateTime fecha_cheque)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                db.CHEQUES.Add(new CHEQUE
                {
                    NUMERO_CHEQUE = numerocheque,
                    NUMERO_FACTURA = numero_factura,
                    VALOR_CHEQUE = valor_cheque,
                    FECHA_CHEQUE = fecha_cheque
                });
                db.SaveChanges();
            }
        }
        //Metodo que modifica un cheque
        public static void MODIFICARCHEQUE(
            int numerocheque,
            int numero_factura,
            decimal valor_cheque,
            DateTime fecha_cheque
            )
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var MODIFICAR = (from C in db.CHEQUES
                                 where C.NUMERO_CHEQUE == numerocheque
                                 select C).Single();
                MODIFICAR.NUMERO_CHEQUE = numerocheque;
                MODIFICAR.NUMERO_FACTURA = numero_factura;
                MODIFICAR.VALOR_CHEQUE = valor_cheque;
                MODIFICAR.FECHA_CHEQUE = fecha_cheque;

                db.SaveChanges();
            }
        }
        //este metodo elimina un cheque
        public static void ELIMINARCHEQUE(int numerocheque)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var ELIMINA = (from C in db.CHEQUES
                               where C.NUMERO_CHEQUE == numerocheque
                               select C).Single();
                db.CHEQUES.Remove(ELIMINA);
                db.SaveChanges();
            }
        }
        public static CHEQUE CARGAR(int numerocheque)
        {
            CHEQUE CHEQUES = new CHEQUE();
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from C in db.CHEQUES
                            where C.NUMERO_CHEQUE == numerocheque
                            select C).Single();
                CHEQUES.NUMERO_CHEQUE = Info.NUMERO_CHEQUE;
                CHEQUES.NUMERO_FACTURA = Info.NUMERO_FACTURA;
                CHEQUES.VALOR_CHEQUE = Info.VALOR_CHEQUE;
                CHEQUES.FECHA_CHEQUE = Info.FECHA_CHEQUE;

                return CHEQUES;
            }
        }
    }
}
