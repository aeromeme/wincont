using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;

namespace winCont.Logica.Inventario
{
    class ManejadorFamilia : Interfaz_logica<INV_FAMILIA >
    {
         private DataSistema _datasistema;
         public ManejadorFamilia(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<INV_FAMILIA> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_FAMILIA> l = new List<INV_FAMILIA>();
            l = (from u in _datasistema.ContextoInventario.INV_FAMILIA
                 select u).ToList();
            return l;
        }
        public List<INV_FAMILIA> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<INV_FAMILIA> l = new List<INV_FAMILIA>();
            l = (from u in _datasistema.ContextoInventario.INV_FAMILIA
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }

        public INV_FAMILIA insertar(INV_FAMILIA data)
        {
            _datasistema.conectarInventario();
            INV_FAMILIA s = data;
            _datasistema.ContextoInventario.INV_FAMILIA.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_FAMILIA modificar(INV_FAMILIA data)
        {
            _datasistema.conectarInventario();
            INV_FAMILIA s = (from u in _datasistema.ContextoInventario.INV_FAMILIA
                           where u.ID == data.ID
                           select u).First();
            s.DS_FAMILIA = data.DS_FAMILIA;
            s.CD_LINEA = data.CD_LINEA;
            s.FLG_SERVICIO = data.FLG_SERVICIO;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_FAMILIA eliminar(INV_FAMILIA data)
        {
            _datasistema.conectarInventario();
            INV_FAMILIA s = (from u in _datasistema.ContextoInventario.INV_FAMILIA
                           where u.ID == data.ID
                           select u).First();
            _datasistema.ContextoInventario.INV_FAMILIA.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
