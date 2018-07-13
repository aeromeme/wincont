using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using Sistema;
using System.Linq;

namespace winCont.Logica.Configuracion
{
    class ManejadorPeriodo: Interfaz_logica<SIS_PERIODO>
    {
        private DataSistema _datasistema;
        public ManejadorPeriodo(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<SIS_PERIODO> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_PERIODO> l = new List<SIS_PERIODO>();
            l = (from u in _datasistema.contextoSistema.SIS_PERIODO
                 select u).ToList();
            return l;
        }
        public SIS_PERIODO consultarPorID(int idPeriodo)
        {
            _datasistema.conectarSistema();
            SIS_PERIODO l;
            l = (from u in _datasistema.contextoSistema.SIS_PERIODO
                where u.ID==idPeriodo select u).First ();
            return l;
        }

        public List<V_SIS_PERIODO> consultarVistaPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarSistema();
            List<V_SIS_PERIODO> l = new List<V_SIS_PERIODO>();
            l = (from u in _datasistema.contextoSistema.V_SIS_PERIODO
                 where u.ID_EMPRESA ==idEmpresa orderby u.NM_EJERCICIO descending  ,u.NM_PERIODO descending   select u).ToList();
            return l;
        }

        public SIS_PERIODO insertar(SIS_PERIODO data)
        {
            _datasistema.conectarSistema();
            SIS_PERIODO s = data;
            _datasistema.contextoSistema.SIS_PERIODO.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_PERIODO modificar(SIS_PERIODO data)
        {
            throw new NotImplementedException();
        }

        public SIS_PERIODO eliminar(SIS_PERIODO data)
        {
            throw new NotImplementedException();
        }

        public SIS_PERIODO insertarSiguientePeriodo()
        {
            int periodo, ejercicio;
            if ((from u in _datasistema.contextoSistema.SIS_PERIODO select u).Count() > 0)
            {
                ejercicio = int.Parse((from u in _datasistema.contextoSistema.SIS_PERIODO where u.ID_EMPRESA == _datasistema.empresa.ID select u.NM_EJERCICIO).Max().ToString());
                periodo = int.Parse((from u in _datasistema.contextoSistema.SIS_PERIODO where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_EJERCICIO == ejercicio select u.NM_PERIODO).Max().ToString());
            }
            else
            {
                ejercicio = DateTime.Today.Year;
                periodo = 1;
            }

            if (periodo == 12)
            {
                ejercicio += 1;
                periodo = 1;
            }
            else
            {
                periodo += 1;
            }
            SIS_PERIODO tupla = new SIS_PERIODO { ID_EMPRESA = _datasistema.empresa.ID, NM_EJERCICIO = ejercicio, NM_PERIODO = periodo, CD_ESTADO = 'D' };
            tupla = insertar(tupla);
            return tupla;
        }
    }
}
