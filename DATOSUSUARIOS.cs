using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR
{
   public class DATOSUSUARIOS
    {
        SCXPRAUDOEntities db = new SCXPRAUDOEntities();
           public static List<USUARIO> MOSTRAR()
        {
            try
            {
                SCXPRAUDOEntities db = new SCXPRAUDOEntities();
                var Info = (from u in db.USUARIOS select u).ToList();
                return Info;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
           
            } 
        public static List<USUARIO> BuscarporUsuario(string usuario)
        {
            try
            {
                SCXPRAUDOEntities db = new SCXPRAUDOEntities();
                var Info = (from u in db.USUARIOS
                            where u.USUARIO1 == usuario
                            select u).ToList();
                return Info;
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }
        public static List<USUARIO> BuscarporClave(string clave)
        {
            try
            {
                SCXPRAUDOEntities db = new SCXPRAUDOEntities();
                var Info = (from u in db.USUARIOS
                            where u.CLAVE == clave
                            select u).ToList();
                return Info;
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }
        }
        
}
