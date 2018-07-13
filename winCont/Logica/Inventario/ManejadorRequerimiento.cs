using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;
using Sistema;

namespace winCont.Logica.Inventario
{
    class ManejadorRequerimiento : Interfaz_logica<INV_ENCA_REQ >
    {
        private DataSistema _datasistema;
        public ManejadorRequerimiento(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<INV_ENCA_REQ> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_ENCA_REQ> l = new List<INV_ENCA_REQ>();
            l = (from u in _datasistema.ContextoInventario.INV_ENCA_REQ
                 select u).ToList();
            return l;
        }
        public List<INV_ENCA_REQ> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<INV_ENCA_REQ> l = new List<INV_ENCA_REQ>();
            l = (from u in _datasistema.ContextoInventario.INV_ENCA_REQ
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public V_INV_ENCA_REQ consultarVistaPorId(int id)
        {
            _datasistema.conectarInventario();
            V_INV_ENCA_REQ l;
            l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_REQ
                 where u.ID == id
                 select u).First ();
            return l;
        }
        public List<V_INV_ENCA_REQ> consultarVistaPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<V_INV_ENCA_REQ> l = new List<V_INV_ENCA_REQ>();
            l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_REQ
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public List<V_INV_ENCA_REQ> consultarVistaPorIdEmpresaPeriodo(int idEmpresa, SIS_PERIODO periodo)
        {
            _datasistema.conectarInventario();
            List<V_INV_ENCA_REQ> l = new List<V_INV_ENCA_REQ>();
            l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_REQ
                 where u.ID_EMPRESA == idEmpresa && u.NM_EJERCICIO == periodo .NM_EJERCICIO && u.NM_PERIODO ==periodo .NM_PERIODO 
                 select u).ToList();
            return l;
        }

        public INV_ENCA_REQ insertar(INV_ENCA_REQ data)
        {
            _datasistema.conectarInventario();
            INV_ENCA_REQ s = data;
            _datasistema.ContextoInventario.INV_ENCA_REQ.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_ENCA_REQ modificar(INV_ENCA_REQ data)
        {
            _datasistema.conectarInventario();
            INV_ENCA_REQ s = (from u in _datasistema.ContextoInventario.INV_ENCA_REQ
                              where u.ID == data.ID
                              select u).First();
            if (s.CD_ESTA_DOCUMENTO != 'D')
            {
                throw new Exception("La requisicion ya esta actualizada");
            }
            s.DS_NOMBRE_SOLICITANTE = data.DS_NOMBRE_SOLICITANTE ;
            s.DS_REFERENCIA = data.DS_REFERENCIA ;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_ENCA_REQ eliminar(INV_ENCA_REQ data)
        {
            _datasistema.conectarInventario();
            INV_ENCA_REQ s = (from u in _datasistema.ContextoInventario.INV_ENCA_REQ
                              where u.ID == data.ID
                              select u).First();
            if (s.CD_ESTA_DOCUMENTO != 'D')
            {
                throw new Exception("La requisicion ya esta actualizada");
            }
            _datasistema.ContextoInventario.INV_ENCA_REQ.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
