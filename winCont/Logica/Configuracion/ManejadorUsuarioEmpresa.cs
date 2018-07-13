using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema;
using winCont.Utilidades;
using System.Linq;

namespace winCont.Logica.Configuracion
{
    class ManejadorUsuarioEmpresa:Interfaz_logica<SIS_USER_EMPRESA>
    {
         private DataSistema _datasistema;
         public ManejadorUsuarioEmpresa(DataSistema ds)
        {
            _datasistema = ds;
        }

         public List<SIS_USER_EMPRESA> consultar()
         {
             _datasistema.conectarSistema();
             List<SIS_USER_EMPRESA> l = new List<SIS_USER_EMPRESA>();
             l = (from u in _datasistema.contextoSistema.SIS_USER_EMPRESA
                  select u).ToList();
             return l;
         }

         public List<V_SIS_USER_EMPRESA> consultarVistaPorUsuario(int idUsuario) {
             _datasistema.conectarSistema();
             List<V_SIS_USER_EMPRESA> l = new List<V_SIS_USER_EMPRESA>();
             l = (from u in _datasistema.contextoSistema.V_SIS_USER_EMPRESA
                  where u.ID_USER ==idUsuario  select u).ToList();
             return l;
         }

         public SIS_USER_EMPRESA insertar(SIS_USER_EMPRESA data)
         {
             _datasistema.conectarSistema();

             if ((from u in _datasistema.contextoSistema.SIS_USER_EMPRESA where u.ID_EMPRESA == data.ID_EMPRESA && u.ID_USER ==data.ID_USER  select u).ToList().Count() > 0)
             {
                 throw new Exception("Ya existe la empresa");
             }

             SIS_USER_EMPRESA s = data;
             _datasistema.contextoSistema.SIS_USER_EMPRESA.InsertOnSubmit(s);
             _datasistema.contextoSistema.SubmitChanges();
             return s;
         }

         public SIS_USER_EMPRESA modificar(SIS_USER_EMPRESA data)
         {
             throw new NotImplementedException();
         }

         public SIS_USER_EMPRESA eliminar(SIS_USER_EMPRESA data)
         {
             _datasistema.conectarSistema();
             SIS_USER_EMPRESA s = (from u in _datasistema.contextoSistema.SIS_USER_EMPRESA
                                where u.ID == data.ID
                                select u).First();
             _datasistema.contextoSistema.SIS_USER_EMPRESA.DeleteOnSubmit(s);
             _datasistema.contextoSistema.SubmitChanges();
             return s;
         }
    }
}
