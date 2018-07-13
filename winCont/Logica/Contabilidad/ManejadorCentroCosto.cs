using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContabilidadDB;
using System.Linq;
using winCont.Utilidades;

namespace winCont.Logica.Contabilidad
{
    class ManejadorCentroCosto : Interfaz_logica<CONT_CENTRO_COSTO>
    {
         private DataSistema _datasistema;
         public ManejadorCentroCosto(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<CONT_CENTRO_COSTO> consultar()
        {
            _datasistema.conectarContabilidad();
            List<CONT_CENTRO_COSTO> l = new List<CONT_CENTRO_COSTO>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_CENTRO_COSTO
                 select u).ToList();
            return l;
        }
        public List<CONT_CENTRO_COSTO> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarContabilidad();
            List<CONT_CENTRO_COSTO> l = new List<CONT_CENTRO_COSTO>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_CENTRO_COSTO
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }

        public CONT_CENTRO_COSTO insertar(CONT_CENTRO_COSTO data)
        {
            _datasistema.conectarContabilidad();
            CONT_CENTRO_COSTO s = data;
            _datasistema.ContextoContabilidad.CONT_CENTRO_COSTO.InsertOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_CENTRO_COSTO modificar(CONT_CENTRO_COSTO data)
        {
            _datasistema.conectarContabilidad();
            CONT_CENTRO_COSTO s = (from u in _datasistema.ContextoContabilidad.CONT_CENTRO_COSTO
                             where u.ID == data.ID
                             select u).First();
            s.DS_NOMBRE = data.DS_NOMBRE;

            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_CENTRO_COSTO eliminar(CONT_CENTRO_COSTO data)
        {
            _datasistema.conectarContabilidad();
            CONT_CENTRO_COSTO s = (from u in _datasistema.ContextoContabilidad.CONT_CENTRO_COSTO
                             where u.ID == data.ID
                             select u).First();
            _datasistema.ContextoContabilidad.CONT_CENTRO_COSTO.DeleteOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }
    }
}
