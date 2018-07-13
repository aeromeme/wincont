using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComprasDB;
using System.Linq;
using Sistema;
using winCont.Utilidades;

namespace winCont.Logica.Compras
{
    class ManejadorCompra: Interfaz_logica<COMP_COMPRA >
    {
        private DataSistema _datasistema;
        public ManejadorCompra(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<COMP_COMPRA> consultar()
        {
            _datasistema.conectarVentas();
            List<COMP_COMPRA> l = new List<COMP_COMPRA>();
            l = (from u in _datasistema.ContextoCompras.COMP_COMPRA
                 select u).ToList();

            return l;
        }

        public COMP_COMPRA insertar(COMP_COMPRA data)
        {
            throw new NotImplementedException();
        }

        public COMP_COMPRA modificar(COMP_COMPRA data)
        {
            throw new NotImplementedException();
        }

        public COMP_COMPRA eliminar(COMP_COMPRA data)
        {
            throw new NotImplementedException();
        }
    }
}
