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
    class ManejadorOrdenDeCompra: Interfaz_logica<INV_ENCA_ORDEN >
    {
        private DataSistema _datasistema;
        public ManejadorOrdenDeCompra(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<INV_ENCA_ORDEN> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_ENCA_ORDEN> l = new List<INV_ENCA_ORDEN>();
            l = (from u in _datasistema.ContextoInventario.INV_ENCA_ORDEN
                 select u).ToList();
            return l;
        }
        public List<INV_ENCA_ORDEN> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<INV_ENCA_ORDEN> l = new List<INV_ENCA_ORDEN>();
            l = (from u in _datasistema.ContextoInventario.INV_ENCA_ORDEN
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public V_INV_ENCA_ORDEN consultarVistaPorId(int id)
        {
            _datasistema.conectarInventario();
            V_INV_ENCA_ORDEN l;
            l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_ORDEN
                 where u.ID == id
                 select u).First();
            return l;
        }
        public List<V_INV_ENCA_ORDEN> consultarVistaPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<V_INV_ENCA_ORDEN> l = new List<V_INV_ENCA_ORDEN>();
            l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_ORDEN
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public List<V_INV_ENCA_ORDEN> consultarVistaPorIdEmpresaPeriodo(int idEmpresa, SIS_PERIODO periodo)
        {
            _datasistema.conectarInventario();
            List<V_INV_ENCA_ORDEN> l = new List<V_INV_ENCA_ORDEN>();
            l = (from u in _datasistema.ContextoInventario.V_INV_ENCA_ORDEN
                 where u.ID_EMPRESA == idEmpresa && u.NM_EJERCICIO == periodo.NM_EJERCICIO && u.NM_PERIODO == periodo.NM_PERIODO
                 select u).ToList();
            return l;
        }


        public INV_ENCA_ORDEN insertar(INV_ENCA_ORDEN data)
        {
            _datasistema.conectarInventario();
            INV_ENCA_ORDEN s = data;
            _datasistema.ContextoInventario.INV_ENCA_ORDEN.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_ENCA_ORDEN modificar(INV_ENCA_ORDEN data)
        {
            _datasistema.conectarInventario();
            INV_ENCA_ORDEN s = (from u in _datasistema.ContextoInventario.INV_ENCA_ORDEN
                              where u.ID == data.ID
                              select u).First();
            if (s.CD_ESTA_DOCUMENTO != 'D')
            {
                throw new Exception("La requisicion ya esta actualizada");
            }
            s.DS_NOMBRE_SOLICITANTE = data.DS_NOMBRE_SOLICITANTE;
            s.DS_REFERENCIA = data.DS_REFERENCIA;
            s.ID_TERCERO = data.ID_TERCERO;
            s.FLG_CREDITO = data.FLG_CREDITO;
            s.ID_TIPO_DOCUMENTO_SOLICITADO = data.ID_TIPO_DOCUMENTO;
            s.DS_OBSERVACION = data.DS_OBSERVACION;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_ENCA_ORDEN eliminar(INV_ENCA_ORDEN data)
        {
            _datasistema.conectarInventario();
            INV_ENCA_ORDEN s = (from u in _datasistema.ContextoInventario.INV_ENCA_ORDEN
                              where u.ID == data.ID
                              select u).First();
            if (s.CD_ESTA_DOCUMENTO != 'D')
            {
                throw new Exception("La requisicion ya esta actualizada");
            }
            _datasistema.ContextoInventario.INV_ENCA_ORDEN.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
