using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;

namespace winCont.Logica.Inventario
{
    class ManejadorDetalleAjuste: Interfaz_logica<INV_DETA_AJUS>
    {
        private DataSistema _datasistema;
        public ManejadorDetalleAjuste(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<INV_DETA_AJUS> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_DETA_AJUS> l = new List<INV_DETA_AJUS>();
            l = (from u in _datasistema.ContextoInventario.INV_DETA_AJUS
                 select u).ToList();
            return l;
        }
        public List<INV_DETA_AJUS> consultarPorIdEnca(int idAjus)
        {
            _datasistema.conectarInventario();
            List<INV_DETA_AJUS> l = new List<INV_DETA_AJUS>();
            l = (from u in _datasistema.ContextoInventario.INV_DETA_AJUS
                 where u.ID_AJUS == idAjus
                 select u).ToList();
            return l;
        }
        public List<V_INV_DETA_AJUS> consultarVistaPorIdEnca(int idAjus)
        {
            _datasistema.conectarInventario();
            List<V_INV_DETA_AJUS> l = new List<V_INV_DETA_AJUS>();
            l = (from u in _datasistema.ContextoInventario.V_INV_DETA_AJUS
                 where u.ID_AJUS == idAjus
                 select u).ToList();
            return l;
        }

        public INV_DETA_AJUS insertar(INV_DETA_AJUS data)
        {
             _datasistema.conectarInventario();
             INV_DETA_AJUS s = data;
             _datasistema.ContextoInventario.INV_DETA_AJUS.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        
        }

        public INV_DETA_AJUS modificar(INV_DETA_AJUS data)
        {
            _datasistema.conectarInventario();
            INV_DETA_AJUS s = (from u in _datasistema.ContextoInventario.INV_DETA_AJUS
                               where u.ID == data.ID
                               select u).First();
            // tupla.ID_ARTICULO = d.ID_ARTICULO;
            s.NM_CANTIDAD = data.NM_CANTIDAD;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_DETA_AJUS eliminar(INV_DETA_AJUS data)
        {
            _datasistema.conectarInventario();
            INV_DETA_AJUS s = (from u in _datasistema.ContextoInventario.INV_DETA_AJUS
                               where u.ID == data.ID
                               select u).First();
            _datasistema.ContextoInventario.INV_DETA_AJUS.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
