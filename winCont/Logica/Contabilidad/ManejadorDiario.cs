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
    class ManejadorDiario:Interfaz_logica<CONT_DIARIO >
    {
        private DataSistema _datasistema;
        public ManejadorDiario(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<CONT_DIARIO> consultar()
        {
            _datasistema.conectarContabilidad();
            List<CONT_DIARIO> l = new List<CONT_DIARIO>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_DIARIO
                 select u).ToList();
            return l;
        }
        public List<CONT_DIARIO> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarContabilidad();
            List<CONT_DIARIO> l = new List<CONT_DIARIO>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_DIARIO
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }

        public CONT_DIARIO insertar(CONT_DIARIO data)
        {
            _datasistema.conectarContabilidad();
            CONT_DIARIO s = data;
            _datasistema.ContextoContabilidad.CONT_DIARIO.InsertOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_DIARIO modificar(CONT_DIARIO data)
        {
            _datasistema.conectarContabilidad();
            CONT_DIARIO s = (from u in _datasistema.ContextoContabilidad.CONT_DIARIO
                             where u.ID == data.ID
                             select u).First();
            s.DS_NOMBRE = data.DS_NOMBRE;
            s.FLG_CONSOL_DIA = data.FLG_CONSOL_DIA;

            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_DIARIO eliminar(CONT_DIARIO data)
        {
            _datasistema.conectarContabilidad();
            CONT_DIARIO s = (from u in _datasistema.ContextoContabilidad.CONT_DIARIO
                             where u.ID == data.ID
                             select u).First();
            _datasistema.ContextoContabilidad.CONT_DIARIO.DeleteOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }
    }
}
