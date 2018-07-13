using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContabilidadDB;
using Sistema;
using System.Linq;
using winCont.Utilidades;

namespace winCont.Logica.Contabilidad
{
    class ManejadorPartidaBorrador : Interfaz_logica<CONT_ENCA_PART_BORRADOR >
    {
        private DataSistema _datasistema;
        public ManejadorPartidaBorrador(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<CONT_ENCA_PART_BORRADOR> consultar()
        {
            _datasistema.conectarContabilidad();
            List<CONT_ENCA_PART_BORRADOR> l = new List<CONT_ENCA_PART_BORRADOR>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_ENCA_PART_BORRADOR
                 select u).ToList();
            return l;
        }
        public CONT_ENCA_PART_BORRADOR consultarPorId(int id)
        {
            _datasistema.conectarContabilidad();
            CONT_ENCA_PART_BORRADOR l = (from u in _datasistema.ContextoContabilidad.CONT_ENCA_PART_BORRADOR
                 where u.ID == id
                 select u).First ();
            return l;
        }
        public List<CONT_ENCA_PART_BORRADOR> consultarPorIdEmpresaPorPeriodo(int idEmpresa, SIS_PERIODO periodo)
        {
            _datasistema.conectarContabilidad();
            List<CONT_ENCA_PART_BORRADOR> l = new List<CONT_ENCA_PART_BORRADOR>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_ENCA_PART_BORRADOR
                 where u.ID_EMPRESA == idEmpresa && u.NM_PERIODO ==periodo .NM_PERIODO && u.NM_EJERCICIO ==periodo .NM_EJERCICIO 
                 select u).ToList();
            return l;
        }
        public List<V_CONT_ENCA_PART_BORRADOR> consultarVistaPorIdEmpresaPorPeriodo(int idEmpresa, SIS_PERIODO periodo)
        {
            _datasistema.conectarContabilidad();
            List<V_CONT_ENCA_PART_BORRADOR> l = new List<V_CONT_ENCA_PART_BORRADOR>();
            l = (from u in _datasistema.ContextoContabilidad.V_CONT_ENCA_PART_BORRADOR
                 where u.ID_EMPRESA == idEmpresa && u.NM_PERIODO == periodo.NM_PERIODO && u.NM_EJERCICIO == periodo.NM_EJERCICIO
                 select u).ToList();
            return l;
        }
        public List<V_CONT_ENCA_PART_BORRADOR> consultarVistaPorIdEmpresaPorPeriodo(int idEmpresa, SIS_PERIODO periodo, char cdEstado)
        {
            _datasistema.conectarContabilidad();
            List<V_CONT_ENCA_PART_BORRADOR> l = new List<V_CONT_ENCA_PART_BORRADOR>();
            l = (from u in _datasistema.ContextoContabilidad.V_CONT_ENCA_PART_BORRADOR
                 where u.ID_EMPRESA == idEmpresa && u.NM_PERIODO == periodo.NM_PERIODO && u.NM_EJERCICIO == periodo.NM_EJERCICIO && u.CD_ESTA_PART ==cdEstado 
                 select u).ToList();
            return l;
        }
        public List<V_CONT_ENCA_PART_BORRADOR> consultarVistaPorIdEmpresaPorPeriodoPorEstadoActualizada(int idEmpresa, SIS_PERIODO periodo)
        {
            _datasistema.conectarContabilidad();
            List<V_CONT_ENCA_PART_BORRADOR> l = new List<V_CONT_ENCA_PART_BORRADOR>();
            l = (from u in _datasistema.ContextoContabilidad.V_CONT_ENCA_PART_BORRADOR
                 where u.ID_EMPRESA == idEmpresa && u.NM_PERIODO == periodo.NM_PERIODO && u.NM_EJERCICIO == periodo.NM_EJERCICIO && u.CD_ESTA_PART == 'A' && u.ID_PART_DIA ==null
                 select u).ToList();
            return l;
        }
        public V_CONT_ENCA_PART_BORRADOR consultarVistaPorId(int id)
        {
            _datasistema.conectarContabilidad();
            V_CONT_ENCA_PART_BORRADOR l = (from u in _datasistema.ContextoContabilidad.V_CONT_ENCA_PART_BORRADOR
                 where u.ID == id
                 select u).First();
            return l;
        }
        public List<V_CONT_ULT_IMNPORT> consultarUltimasImportadas(int idEmpresa, int idpartExcl)
        {
            _datasistema.conectarContabilidad();
            List<V_CONT_ULT_IMNPORT> l = new List<V_CONT_ULT_IMNPORT>();
            l = (from u in _datasistema.ContextoContabilidad.V_CONT_ULT_IMNPORT
                 where u.ID_EMPRESA == idEmpresa && u.ID_PART_BORR  != idpartExcl
                 orderby u.FE_IMPORT descending 
                 select u).ToList();
            return l;
        }
        public List<V_CONT_ENCA_PART_BORRADOR> consultarVistaPorIdEmpresaPorPeriodoExcluID(int idEmpresa, SIS_PERIODO periodo,int idpartExcl)
        {
            _datasistema.conectarContabilidad();
            List<V_CONT_ENCA_PART_BORRADOR> l = new List<V_CONT_ENCA_PART_BORRADOR>();
            l = (from u in _datasistema.ContextoContabilidad.V_CONT_ENCA_PART_BORRADOR
                 where u.ID_EMPRESA == idEmpresa && u.NM_PERIODO == periodo.NM_PERIODO && u.NM_EJERCICIO == periodo.NM_EJERCICIO && u.ID !=idpartExcl 
                 select u).ToList();
            return l;
        }

        public CONT_ENCA_PART_BORRADOR insertar(CONT_ENCA_PART_BORRADOR data)
        {
            _datasistema.conectarContabilidad();
            CONT_ENCA_PART_BORRADOR s = data;
            _datasistema.ContextoContabilidad.CONT_ENCA_PART_BORRADOR.InsertOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_ENCA_PART_BORRADOR modificar(CONT_ENCA_PART_BORRADOR data)
        {
            _datasistema.conectarContabilidad();
            CONT_ENCA_PART_BORRADOR s = (from u in _datasistema.ContextoContabilidad.CONT_ENCA_PART_BORRADOR
                                   where u.ID == data.ID
                                   select u).First();
            s.DS_CONCEPTO  = data.DS_CONCEPTO ;
            s.DS_REFERENCIA = data.DS_REFERENCIA;
            s.FE_PARTIDA =data.FE_PARTIDA ;
            s.ID_DIARIO = data.ID_DIARIO ;
            if (s.CD_ESTA_PART == 'D')
            {
                _datasistema.ContextoContabilidad.SubmitChanges();
            }

            
            return s;
        }

        public CONT_ENCA_PART_BORRADOR eliminar(CONT_ENCA_PART_BORRADOR data)
        {
            _datasistema.conectarContabilidad();
            CONT_ENCA_PART_BORRADOR s = (from u in _datasistema.ContextoContabilidad.CONT_ENCA_PART_BORRADOR
                                   where u.ID == data.ID
                                   select u).First();
            _datasistema.ContextoContabilidad.CONT_ENCA_PART_BORRADOR.DeleteOnSubmit(s);
            if (s.CD_ESTA_PART == 'D')
            {
                _datasistema.ContextoContabilidad.SubmitChanges();
            }
            return s;
        }

        public Boolean actualizarPartida(CONT_ENCA_PART_BORRADOR data)
        {
            _datasistema.conectarContabilidad();
            CONT_ENCA_PART_BORRADOR s = (from u in _datasistema.ContextoContabilidad.CONT_ENCA_PART_BORRADOR
                                         where u.ID == data.ID
                                         select u).First();
            if (s.CD_ESTA_PART == 'D')
            {
                V_CONT_DETA_PART_BORR_AUX aux = (from u in _datasistema.ContextoContabilidad.V_CONT_DETA_PART_BORR_AUX where u.ID_PART_BORR == s.ID select u).First();
                if (aux.NM_ABONO != aux.NM_CARGO && aux.NM_ABONO <= 0)
                {
                    throw new Exception("La partida no esta cuadrada");
                }
                if ((from u in _datasistema.ContextoContabilidad.CONT_DETA_PART_BORR where u.ID_PART_BORR == s.ID && u.ID_CUENTA == 0 select 1).Count() > 1) {
                    throw new Exception("Verifique que todas las cuentas esten asignaddas");
                }
                s.CD_ESTA_PART = 'A';
                _datasistema.ContextoContabilidad.SubmitChanges();
            }
            else {
                throw new Exception("Partida ya actualizada");
            }
            return true;

        }
        public void contabilizarPartida(int idEmpresa,SIS_PERIODO periodo) {
            int? error = 0;
            string msj = string.Empty;
            _datasistema.ContextoContabilidad.PR_CONT_PART_BORR(idEmpresa , periodo.NM_PERIODO, periodo.NM_EJERCICIO, ref error, ref msj);
            if (error != 0)
            {
                throw new Exception("Error" + error.ToString() + msj);
                //MetodosForm.mensajeErrorDefault(msj, _datasistema);
            }
        }
        public void descontabilizarPartida(int idEmpresa, SIS_PERIODO periodo)
        {
            int? error = 0;
            string msj = string.Empty;
            _datasistema.ContextoContabilidad.PR_CONT_DESCONT_PART_BORR(idEmpresa, periodo.NM_PERIODO, periodo.NM_EJERCICIO, ref error, ref msj);
            if (error != 0)
            {
                throw new Exception("Error" + error.ToString() + msj);
                //MetodosForm.mensajeErrorDefault(msj, _datasistema);
            }
        }
        public void importarPartida(int partida, int idimpo)
        {
            int? error = 0;
            string msj = string.Empty;
            _datasistema.ContextoContabilidad.PR_CONT_IMPO_PART_BORR(partida, idimpo, ref error, ref msj);
            if (error != 0)
            {
                throw new Exception("Error" + error.ToString() + msj);
                //MetodosForm.mensajeErrorDefault(msj, _datasistema);
            }
        }
    }
}
