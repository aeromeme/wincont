using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;

namespace winCont.Logica.Inventario
{
    class ManejadorUnidadDeMedida : Interfaz_logica<INV_UNIMED>
    {
         private DataSistema _datasistema;
         public ManejadorUnidadDeMedida(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<INV_UNIMED> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_UNIMED> l = new List<INV_UNIMED>();
            l = (from u in _datasistema.ContextoInventario.INV_UNIMED
                 select u).ToList();
            return l;
        }
        public List<INV_UNIMED> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<INV_UNIMED> l = new List<INV_UNIMED>();
            l = (from u in _datasistema.ContextoInventario.INV_UNIMED
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }

        public INV_UNIMED insertar(INV_UNIMED data)
        {
            _datasistema.conectarInventario();
            INV_UNIMED s = data;
            _datasistema.ContextoInventario.INV_UNIMED.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_UNIMED modificar(INV_UNIMED data)
        {
            _datasistema.conectarInventario();
            INV_UNIMED s = (from u in _datasistema.ContextoInventario.INV_UNIMED
                               where u.ID == data.ID
                               select u).First();
            s.DS_UNIMED = data.DS_UNIMED;
            s.DS_SIMBOLO = data.DS_SIMBOLO;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_UNIMED eliminar(INV_UNIMED data)
        {
            _datasistema.conectarInventario();
            INV_UNIMED s = (from u in _datasistema.ContextoInventario.INV_UNIMED
                               where u.ID == data.ID
                               select u).First();
            _datasistema.ContextoInventario.INV_UNIMED.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
