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
    class ManejadorTalonario : Interfaz_logica<SIS_TALONARIO>
    {
         private DataSistema _datasistema;
         public ManejadorTalonario(DataSistema ds)
        {
            _datasistema = ds;
        }

         public List<SIS_TALONARIO> consultar()
         {
             _datasistema.conectarSistema();
             List<SIS_TALONARIO> l = new List<SIS_TALONARIO>();
             l = (from u in _datasistema.contextoSistema.SIS_TALONARIO
                  select u).ToList();
             return l;
         }
         public List<V_SIS_TALONARIO> consultarVistaPorEmpresa(int idempresa)
         {
             _datasistema.conectarSistema();
             List<V_SIS_TALONARIO> l = new List<V_SIS_TALONARIO>();
             l = (from u in _datasistema.contextoSistema.V_SIS_TALONARIO
                  where u.ID_EMPRESA ==idempresa select u).ToList();
             return l;
         }

         public SIS_TALONARIO insertar(SIS_TALONARIO data)
         {
             _datasistema.conectarSistema();
             SIS_TALONARIO s = data;
             _datasistema.contextoSistema.SIS_TALONARIO.InsertOnSubmit(s);
             _datasistema.contextoSistema.SubmitChanges();
             return s;
         }

         public SIS_TALONARIO modificar(SIS_TALONARIO data)
         {
             _datasistema.conectarSistema();
             SIS_TALONARIO s = (from u in _datasistema.contextoSistema.SIS_TALONARIO
                                where u.ID == data.ID
                                select u).First();
             if (s.CD_ESTADO == char.Parse("A"))
             {
                 s.NM_FINAL = data.NM_FINAL;
             }
             else if (s.CD_ESTADO == char.Parse("D"))
             {
                 s.CD_SERIE = data.CD_SERIE;
                 s.NM_ACTUAL = data.NM_ACTUAL;
                 s.NM_INICIAL = data.NM_INICIAL;
                 s.NM_FINAL = data.NM_FINAL;
             }

             _datasistema.contextoSistema.SubmitChanges();
             return s;
         }

         public SIS_TALONARIO eliminar(SIS_TALONARIO data)
         {
             _datasistema.conectarSistema();
             SIS_TALONARIO s = (from u in _datasistema.contextoSistema.SIS_TALONARIO
                                where u.ID == data.ID
                                select u).First();
             _datasistema.contextoSistema.SIS_TALONARIO.DeleteOnSubmit(s);
             _datasistema.contextoSistema.SubmitChanges();
             return s;
         }
    }
}
