using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;

namespace winCont.Logica.Inventario
{
    class ManejadorDetalleRequerimiento: Interfaz_logica<INV_DETA_REQ >
    {
        private DataSistema _datasistema;
        public ManejadorDetalleRequerimiento(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<INV_DETA_REQ> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_DETA_REQ> l = new List<INV_DETA_REQ>();
            l = (from u in _datasistema.ContextoInventario.INV_DETA_REQ
                 select u).ToList();
            return l;
        }
        public List<INV_DETA_REQ> consultarPorIdEnca(int idReq)
        {
            _datasistema.conectarInventario();
            List<INV_DETA_REQ> l = new List<INV_DETA_REQ>();
            l = (from u in _datasistema.ContextoInventario.INV_DETA_REQ
                 where u.ID_REQ  == idReq
                 select u).ToList();
            return l;
        }
        public List<V_INV_DETA_REQ > consultarVistaPorIdEnca(int idReq)
        {
            _datasistema.conectarInventario();
            List<V_INV_DETA_REQ> l = new List<V_INV_DETA_REQ>();
            l = (from u in _datasistema.ContextoInventario.V_INV_DETA_REQ
                 where u.ID_REQ  == idReq
                 select u).ToList();
            return l;
        }
        public INV_DETA_REQ insertar(INV_DETA_REQ data)
        {
            _datasistema.conectarInventario();
            INV_DETA_REQ s = data;
            _datasistema.ContextoInventario.INV_DETA_REQ.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_DETA_REQ modificar(INV_DETA_REQ data)
        {
            _datasistema.conectarInventario();
            INV_DETA_REQ s = (from u in _datasistema.ContextoInventario.INV_DETA_REQ
                              where u.ID == data.ID
                              select u).First();
           // tupla.ID_ARTICULO = d.ID_ARTICULO;
            s.NM_CANTIDAD = data.NM_CANTIDAD;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_DETA_REQ eliminar(INV_DETA_REQ data)
        {
            _datasistema.conectarInventario();
            INV_DETA_REQ s = (from u in _datasistema.ContextoInventario.INV_DETA_REQ
                              where u.ID == data.ID
                              select u).First();
            _datasistema.ContextoInventario.INV_DETA_REQ.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
