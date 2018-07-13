using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using InventarioDB;

namespace winCont.Logica.Inventario
{
    class ManejadorGrupo : Interfaz_logica<INV_GRUPO>
    {
         private DataSistema _datasistema;
         public ManejadorGrupo(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<INV_GRUPO> consultar()
        {
            _datasistema.conectarInventario();
            List<INV_GRUPO> l = new List<INV_GRUPO>();
            l = (from u in _datasistema.ContextoInventario.INV_GRUPO
                 select u).ToList();
            return l;
        }
        public List<INV_GRUPO> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarInventario();
            List<INV_GRUPO> l = new List<INV_GRUPO>();
            l = (from u in _datasistema.ContextoInventario.INV_GRUPO
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public List<INV_GRUPO> consultarPorIdEmpresayIdFamilia(int idEmpresa, int idFamilia)
        {
            _datasistema.conectarInventario();
            List<INV_GRUPO> l = new List<INV_GRUPO>();
            l = (from u in _datasistema.ContextoInventario.INV_GRUPO
                 where u.ID_EMPRESA == idEmpresa && u.ID_FAMILIA ==idFamilia
                 select u).ToList();
            return l;
        }


        public INV_GRUPO insertar(INV_GRUPO data)
        {
            _datasistema.conectarInventario();
            INV_GRUPO s = data;
            _datasistema.ContextoInventario.INV_GRUPO.InsertOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_GRUPO modificar(INV_GRUPO data)
        {
            _datasistema.conectarInventario();
            INV_GRUPO s = (from u in _datasistema.ContextoInventario.INV_GRUPO
                               where u.ID == data.ID
                               select u).First();
            s.DS_GRUPO = data.DS_GRUPO;
            s.CD_LINEA  = data.CD_LINEA;

            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }

        public INV_GRUPO eliminar(INV_GRUPO data)
        {
            _datasistema.conectarInventario();
            INV_GRUPO s = (from u in _datasistema.ContextoInventario.INV_GRUPO
                               where u.ID == data.ID
                               select u).First();
            _datasistema.ContextoInventario.INV_GRUPO.DeleteOnSubmit(s);
            _datasistema.ContextoInventario.SubmitChanges();
            return s;
        }
    }
}
