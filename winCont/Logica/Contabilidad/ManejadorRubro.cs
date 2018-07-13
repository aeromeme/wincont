using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using System.Linq;
using ContabilidadDB;

namespace winCont.Logica.Contabilidad
{
    class ManejadorRubro: Interfaz_logica<CONT_RUBROS>
    {
        private DataSistema _datasistema;
        public ManejadorRubro(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<CONT_RUBROS> consultar()
        {
            _datasistema.conectarContabilidad();
            List<CONT_RUBROS> l = new List<CONT_RUBROS>();
            l = (from u in _datasistema.ContextoContabilidad .CONT_RUBROS
                 select u).ToList();
            return l;
        }
        public List<CONT_RUBROS> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarContabilidad();
            List<CONT_RUBROS> l = new List<CONT_RUBROS>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_RUBROS
                 where u.ID_EMPRESA ==idEmpresa  select u).ToList();
            return l;
        }

        public CONT_RUBROS insertar(CONT_RUBROS data)
        {
            _datasistema.conectarContabilidad();
            CONT_RUBROS s = data;
            _datasistema.ContextoContabilidad.CONT_RUBROS.InsertOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_RUBROS modificar(CONT_RUBROS data)
        {
            _datasistema.conectarContabilidad();
            CONT_RUBROS s = (from u in _datasistema.ContextoContabilidad.CONT_RUBROS
                          where u.ID == data.ID
                          select u).First();
            s.DS_RUBRO  = data.DS_RUBRO;
            s.CD_RUBRO_BASE = data.CD_RUBRO_BASE;

            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_RUBROS eliminar(CONT_RUBROS data)
        {
            _datasistema.conectarContabilidad();
            CONT_RUBROS s = (from u in _datasistema.ContextoContabilidad.CONT_RUBROS
                          where u.ID == data.ID
                          select u).First();
            _datasistema.ContextoContabilidad.CONT_RUBROS.DeleteOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }
    }
}
