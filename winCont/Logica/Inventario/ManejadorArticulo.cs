using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;

namespace winCont.Logica.Inventario
{
    class ManejadorArticulo : Interfaz_logica<INV_ARTICULO >
    {
         private DataSistema _datasistema;
         public ManejadorArticulo(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<INV_ARTICULO> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_ARTICULO> l = new List<INV_ARTICULO>();
            l = (from u in _datasistema.ContextoInventario.INV_ARTICULO
                 select u).ToList();
            return l;
        }
        public List<INV_ARTICULO> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<INV_ARTICULO> l = new List<INV_ARTICULO>();
            l = (from u in _datasistema.ContextoInventario.INV_ARTICULO
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public List<V_INV_ARTICULO> consultarVistaPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<V_INV_ARTICULO> l = new List<V_INV_ARTICULO>();
            l = (from u in _datasistema.ContextoInventario.V_INV_ARTICULO
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public List<V_INV_ARTICULO> consultarVistaPorIdEmpresaInventariable(int idEmpresa, char flgInventariable)
        {
            _datasistema.conectarInventario();
            List<V_INV_ARTICULO> l = new List<V_INV_ARTICULO>();
            l = (from u in _datasistema.ContextoInventario.V_INV_ARTICULO
                 where u.ID_EMPRESA == idEmpresa && u.FLG_INVENTARIABLE  == flgInventariable 
                 select u).ToList();
            return l;
        }

        public INV_ARTICULO insertar(INV_ARTICULO data)
        {
            _datasistema.conectarInventario();
            INV_ARTICULO s = data;
            _datasistema.ContextoInventario.INV_ARTICULO.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_ARTICULO modificar(INV_ARTICULO data)
        {
            _datasistema.conectarInventario();
            INV_ARTICULO s = (from u in _datasistema.ContextoInventario.INV_ARTICULO
                            where u.ID == data.ID
                            select u).First();
            s.ID_UNI_MED = data.ID_UNI_MED;
            s.ID_CATE_ARTI = data.ID_CATE_ARTI;
            s.CD_BARRA = data.CD_BARRA;
            s.CD_CLAVE = data.CD_CLAVE;
            s.DS_NOMBRE = data.DS_NOMBRE;
            s.DS_NOMBRE_ALTER = data.DS_NOMBRE_ALTER;
            s.DS_REFERENCIA = data.DS_REFERENCIA;
            s.FLG_EXEN_IMPU =data.FLG_EXEN_IMPU ;
            s.FLG_VERI_EXIS_VENT =data.FLG_VERI_EXIS_VENT ;
            s.NM_CANT_MAX =data.NM_CANT_MAX  ;
            s.NM_CANT_MIN = data.NM_CANT_MIN ;
            s.FLG_INVENTARIABLE = data.FLG_INVENTARIABLE;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_ARTICULO eliminar(INV_ARTICULO data)
        {
            _datasistema.conectarInventario();
            INV_ARTICULO s = (from u in _datasistema.ContextoInventario.INV_ARTICULO
                            where u.ID == data.ID
                            select u).First();
            _datasistema.ContextoInventario.INV_ARTICULO.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
