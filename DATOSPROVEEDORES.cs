using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR
{
    public class DATOSPROVEEDORES
    {
        public static List<PROVEEDORE> MOSTRARDATOS()
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from P in db.PROVEEDORES
                            select P).ToList();
                return Info;
            }
        } 
        public static List<PROVEEDORE> BUSCARPORCODIGO(string codigo)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from P in db.PROVEEDORES
                            where P.CODIGO.StartsWith(codigo)
                            select P).ToList();
                return Info;
            }
        }
        public static List<PROVEEDORE> BUSCARPORNOMBRES(string nombres)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from P in db.PROVEEDORES
                            where P.NOMBRES.StartsWith(nombres)
                            select P).ToList();
                return Info;
            }
        }
        public static List<PROVEEDORE> BUSCARPORAPELLIDOS(string apellidos)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from P in db.PROVEEDORES
                            where P.APELLIDOS.StartsWith(apellidos)
                            select P).ToList();
                return Info;
            }
        }
        public static List<PROVEEDORE> BUSCARPORDIRECCION(string direccion)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from P in db.PROVEEDORES
                            where P.DIRECCION.StartsWith(direccion)
                            select P).ToList();
                return Info;
            }
        }
        public static List<PROVEEDORE> BUSCARCIUDAD(string ciudad)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var Info = (from P in db.PROVEEDORES
                            where P.CIUDAD.StartsWith(ciudad)
                            select P).ToList();
                return Info;
            }
        }
        //ESTE METODO AÑADE UN NUEVO REGISTRO
       public static void INSERTARPROVEEDOR(string codigo, string nombres,
          string apellidos, string direccion, string ciudad, string telefono)
        {
            try
            {
                using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
                {
                    db.PROVEEDORES.Add(new PROVEEDORE
                    {
                        CODIGO = codigo,
                        NOMBRES = nombres,
                        APELLIDOS = apellidos,
                        DIRECCION = direccion,
                        CIUDAD = ciudad,
                        TELEFONO = telefono
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }
        public static void MODIFICARPROVEEDOR (string codigo, string nombres,
            string apellidos, string direccion, string ciudad, string telefono)
        {
            try
            {
                PROVEEDORE proveedores = new PROVEEDORE();
                using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
                {
                var MODIFICAR = (from P in db.PROVEEDORES
                               where P.CODIGO == codigo
                               select P).FirstOrDefault();
                MODIFICAR.CODIGO = codigo;
                MODIFICAR.NOMBRES = nombres;
                MODIFICAR.APELLIDOS = apellidos;
                MODIFICAR.DIRECCION = direccion;
                MODIFICAR.CIUDAD = ciudad;
                MODIFICAR.TELEFONO = telefono;

                db.SaveChanges();
            }                
            }
            catch (Exception error)
            {

                throw new Exception (error.Message);
            }
        }   
      /*  public static PROVEEDORE CARGAR(string codigo)
        {
            try
            {
                PROVEEDORE proveedores = new PROVEEDORE();
                using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
                {
                    var Info = (from P in db.PROVEEDORES
                                where P.CODIGO == codigo
                                select P).Single();
                    proveedores.CODIGO = Info.CODIGO;
                    proveedores.NOMBRES = Info.NOMBRES;
                    proveedores.APELLIDOS = Info.APELLIDOS;
                    proveedores.DIRECCION = Info.DIRECCION;
                    proveedores.CIUDAD = Info.CIUDAD;
                    proveedores.TELEFONO = Info.TELEFONO;
                    return proveedores;
                }
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }                    
        }*/
        public static void ELIMINARPROVEEDOR(string codigo)
        {
            using (SCXPRAUDOEntities db = new SCXPRAUDOEntities())
            {
                var ELIMINA = (from P in db.PROVEEDORES
                               where P.CODIGO == codigo
                               select P).Single();
                db.PROVEEDORES.Remove(ELIMINA);
                db.SaveChanges();
            }
        }
    }
}
