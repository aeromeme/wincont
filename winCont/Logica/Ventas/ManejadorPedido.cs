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
    class ManejadorPedido: Interfaz_logica<FAC_PEDIDO>
    {
        private DataSistema _datasistema;
        public ManejadorPedido(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<FAC_PEDIDO> consultar()
        {
            _datasistema.conectarVentas();
            List<FAC_PEDIDO> l = new List<FAC_PEDIDO>();
            l = (from u in _datasistema.ContextoVentas.FAC_PEDIDO
                 select u).ToList();
            return l;
        }

        public List<V_FAC_PEDIDO > consultarPorIdEmpresaPorPeriodo(int idEmpresa, SIS_PERIODO periodo)
        {
            _datasistema.conectarVentas();
            List<V_FAC_PEDIDO> l = new List<V_FAC_PEDIDO>();
            l = (from u in _datasistema.ContextoVentas.V_FAC_PEDIDO
                 where u.ID_EMPRESA == idEmpresa && u.NM_PERIODO == periodo.NM_PERIODO && u.NM_EJERCICIO == periodo.NM_EJERCICIO
                 select u).ToList();
            return l;
        }
        public V_FAC_PEDIDO consultarVistaPorId(int id)
        {
            _datasistema.conectarVentas();
            V_FAC_PEDIDO l = (from u in _datasistema.ContextoVentas.V_FAC_PEDIDO
                 where u.ID==id 
                 select u).First();
            return l;
        }

        public FAC_PEDIDO insertar(FAC_PEDIDO data)
        {
            _datasistema.conectarVentas();
            FAC_PEDIDO s = data;
            _datasistema.ContextoVentas.FAC_PEDIDO.InsertOnSubmit(s);
            _datasistema.ContextoVentas.SubmitChanges();
            return s;
        }

        public FAC_PEDIDO modificar(FAC_PEDIDO data)
        {
            _datasistema.conectarVentas();
            FAC_PEDIDO s = (from u in _datasistema.ContextoVentas.FAC_PEDIDO
                             where u.ID == data.ID
                             select u).First();
            s.DS_NOMBRE_CLIENTE = data.DS_NOMBRE_CLIENTE;
            s.DS_DIR_ENTREGA = data.DS_DIR_ENTREGA;
            s.ID_VENDEDOR = data.ID_VENDEDOR;


            _datasistema.ContextoVentas.SubmitChanges();
            return s;
        }

        public FAC_PEDIDO eliminar(FAC_PEDIDO data)
        {
            _datasistema.conectarVentas();
            FAC_PEDIDO s = (from u in _datasistema.ContextoVentas.FAC_PEDIDO
                             where u.ID == data.ID
                             select u).First();
            if (s.CD_ESTADO != 'D')
            {
                throw new Exception("El pedido ya se actualizo");
            }
            _datasistema.ContextoVentas.FAC_PEDIDO.DeleteOnSubmit(s);
            _datasistema.ContextoVentas.SubmitChanges();
            return s;
        }
    }
}
