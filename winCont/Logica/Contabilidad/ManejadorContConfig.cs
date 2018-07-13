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
    class ManejadorContConfig : Interfaz_logica<CONT_CONFIG>
    {
        private DataSistema _datasistema;
        public ManejadorContConfig(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<CONT_CONFIG> consultar()
        {
            throw new NotImplementedException();
        }
        public List<CONT_CONFIG> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarContabilidad();
            List<CONT_CONFIG> l = new List<CONT_CONFIG>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_CONFIG
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }

        public CONT_CONFIG insertar(CONT_CONFIG data)
        {
            _datasistema.conectarContabilidad();
            CONT_CONFIG s = data;
            _datasistema.ContextoContabilidad.CONT_CONFIG.InsertOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_CONFIG modificar(CONT_CONFIG data)
        {
            _datasistema.conectarContabilidad();
            CONT_CONFIG s = (from u in _datasistema.ContextoContabilidad.CONT_CONFIG
                             where u.ID_EMPRESA  == data.ID_EMPRESA 
                             select u).First();
            s.DS_NOMBRE_CONTADOR = data.DS_NOMBRE_CONTADOR;
            s.FLG_USA_CENTRO_COSTO = data.FLG_USA_CENTRO_COSTO;
            s.ID_NIVEL_MAYOR = data.ID_NIVEL_MAYOR; 

            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_CONFIG eliminar(CONT_CONFIG data)
        {
            throw new NotImplementedException();
        }
    }
}
