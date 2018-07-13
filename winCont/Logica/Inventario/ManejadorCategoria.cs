using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;

namespace winCont.Logica.Inventario
{
    class ManejadorCategoria: Interfaz_logica<INV_CATEGORIA >
    {
         private DataSistema _datasistema;
         public ManejadorCategoria(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<INV_CATEGORIA> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_CATEGORIA> l = new List<INV_CATEGORIA>();
            l = (from u in _datasistema.ContextoInventario.INV_CATEGORIA
                 select u).ToList();
            return l;
        }
        public List<INV_CATEGORIA> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<INV_CATEGORIA> l = new List<INV_CATEGORIA>();
            l = (from u in _datasistema.ContextoInventario.INV_CATEGORIA
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public List<V_INV_CATEGORIA> consultarVistaPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<V_INV_CATEGORIA> l = new List<V_INV_CATEGORIA>();
            l = (from u in _datasistema.ContextoInventario.V_INV_CATEGORIA
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public List<INV_CATEGORIA> consultarPorIdEmpresaPorGrupo(int idEmpresa,int idGrupo)
        {
            _datasistema.conectarInventario();
            List<INV_CATEGORIA> l = new List<INV_CATEGORIA>();
            l = (from u in _datasistema.ContextoInventario.INV_CATEGORIA
                 where u.ID_EMPRESA == idEmpresa && u.ID_GRUPO ==idGrupo 
                 select u).ToList();
            return l;
        }
        public List<V_INV_CATEGORIA> consultarVistaPorIdEmpresaPorGrupoPorFamilia(int idEmpresa, int idGrupo,int idFamilia)
        {
            _datasistema.conectarInventario();
            List<V_INV_CATEGORIA> l = new List<V_INV_CATEGORIA>();
            l = (from u in _datasistema.ContextoInventario.V_INV_CATEGORIA
                 where u.ID_EMPRESA == idEmpresa && u.ID_GRUPO == idGrupo && u.ID_FAMILIA ==idFamilia
                 select u).ToList();
            return l;
        }



        public INV_CATEGORIA insertar(INV_CATEGORIA data)
        {
            _datasistema.conectarInventario();
            INV_CATEGORIA s = data;
            _datasistema.ContextoInventario.INV_CATEGORIA.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_CATEGORIA modificar(INV_CATEGORIA data)
        {
            _datasistema.conectarInventario();
            INV_CATEGORIA s = (from u in _datasistema.ContextoInventario.INV_CATEGORIA
                             where u.ID == data.ID
                             select u).First();
            s.DS_CATEGORIA = data.DS_CATEGORIA;
            s.CD_LINEA  = data.CD_LINEA;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_CATEGORIA eliminar(INV_CATEGORIA data)
        {
            _datasistema.conectarInventario();
            INV_CATEGORIA s = (from u in _datasistema.ContextoInventario.INV_CATEGORIA
                             where u.ID == data.ID
                             select u).First();
            _datasistema.ContextoInventario.INV_CATEGORIA.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
