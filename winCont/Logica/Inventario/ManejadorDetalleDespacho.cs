using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;

namespace winCont.Logica.Inventario
{
    class ManejadorDetalleDespacho : Interfaz_logica<INV_DETA_DESP>
    {
        private DataSistema _datasistema;
        public ManejadorDetalleDespacho(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<INV_DETA_DESP> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_DETA_DESP> l = new List<INV_DETA_DESP>();
            l = (from u in _datasistema.ContextoInventario.INV_DETA_DESP
                 select u).ToList();
            return l;
        }
        public List<INV_DETA_DESP> consultarPorIdEnca(int idDesp)
        {
            _datasistema.conectarInventario();
            List<INV_DETA_DESP> l = new List<INV_DETA_DESP>();
            l = (from u in _datasistema.ContextoInventario.INV_DETA_DESP
                 where u.ID_DESP == idDesp
                 select u).ToList();
            return l;
        }
        public List<V_INV_DETA_DESP> consultarVistaPorIdEnca(int idDesp)
        {
            _datasistema.conectarInventario();
            List<V_INV_DETA_DESP> l = new List<V_INV_DETA_DESP>();
            l = (from u in _datasistema.ContextoInventario.V_INV_DETA_DESP
                 where u.ID_DESP == idDesp
                 select u).ToList();
            return l;
        }

        public INV_DETA_DESP insertar(INV_DETA_DESP data)
        {
            _datasistema.conectarInventario();
            INV_DETA_DESP s = data;
            _datasistema.ContextoInventario.INV_DETA_DESP.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_DETA_DESP modificar(INV_DETA_DESP data)
        {
            _datasistema.conectarInventario();
            INV_DETA_DESP s = (from u in _datasistema.ContextoInventario.INV_DETA_DESP
                              where u.ID == data.ID
                              select u).First();
            // tupla.ID_ARTICULO = d.ID_ARTICULO;
            s.NM_CANTIDAD = data.NM_CANTIDAD;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_DETA_DESP eliminar(INV_DETA_DESP data)
        {
            _datasistema.conectarInventario();
            INV_DETA_DESP s = (from u in _datasistema.ContextoInventario.INV_DETA_DESP
                              where u.ID == data.ID
                              select u).First();
            _datasistema.ContextoInventario.INV_DETA_DESP.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
