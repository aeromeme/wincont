using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasDB;
using System.Linq;
using Sistema;
using winCont.Utilidades;

namespace winCont.Logica.Ventas
{
    class ManejadorDetallePedido : Interfaz_logica<FAC_DETA_PEDIDO>
    {
        private DataSistema _datasistema;
        public ManejadorDetallePedido(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<FAC_DETA_PEDIDO> consultar()
        {
            _datasistema.conectarVentas();
            List<FAC_DETA_PEDIDO> l = new List<FAC_DETA_PEDIDO>();
            l = (from u in _datasistema.ContextoVentas.FAC_DETA_PEDIDO
                 select u).ToList();
            return l;
        }

        public List<FAC_DETA_PEDIDO> consultarPorIdEnca(int IdEnca)
        {
            _datasistema.conectarVentas();
            List<FAC_DETA_PEDIDO> l = (from u in _datasistema.ContextoVentas.FAC_DETA_PEDIDO
                                           where u.ID_PEDIDO == IdEnca
                                           select u).ToList();
            return l;
        }
        public List<V_FAC_DETA_PEDIDO > consultarVistaPorIdEnca(int IdEnca)
        {
            _datasistema.conectarVentas();
            List<V_FAC_DETA_PEDIDO> l = (from u in _datasistema.ContextoVentas.V_FAC_DETA_PEDIDO
                                         where u.ID_PEDIDO == IdEnca
                                             select u).ToList();
            return l;
        }

        public FAC_DETA_PEDIDO insertar(FAC_DETA_PEDIDO data)
        {
            _datasistema.conectarVentas();
            FAC_DETA_PEDIDO s = data;
            _datasistema.ContextoVentas.FAC_DETA_PEDIDO.InsertOnSubmit(s);
            _datasistema.ContextoVentas.SubmitChanges();
            return s;
        }

        public FAC_DETA_PEDIDO modificar(FAC_DETA_PEDIDO data)
        {
            _datasistema.conectarVentas();
            FAC_DETA_PEDIDO s = (from u in _datasistema.ContextoVentas.FAC_DETA_PEDIDO
                                     where u.ID == data.ID
                                     select u).First();
            s.ID_ARTICULO = data.ID_ARTICULO;
            s.NM_CANTIDAD = data.NM_CANTIDAD;
            s.NM_PRECIO = data.NM_PRECIO;

            _datasistema.ContextoVentas.SubmitChanges();
            return s;
        }

        public FAC_DETA_PEDIDO eliminar(FAC_DETA_PEDIDO data)
        {
            _datasistema.conectarContabilidad();
            FAC_DETA_PEDIDO s = (from u in _datasistema.ContextoVentas.FAC_DETA_PEDIDO
                                     where u.ID == data.ID
                                     select u).First();
            _datasistema.ContextoVentas.FAC_DETA_PEDIDO.DeleteOnSubmit(s);
            _datasistema.ContextoVentas.SubmitChanges();
            return s;
        }
    }
}
