using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema;
using winCont.Utilidades;
using System.Linq;

namespace winCont.Logica.Configuracion
{
    class ManejadorOpcionMenu : Interfaz_logica<SIS_OPC_MENU>
    {
        private DataSistema _datasistema;
        public ManejadorOpcionMenu(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<SIS_OPC_MENU> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_OPC_MENU> l = new List<SIS_OPC_MENU>();
            l = (from u in _datasistema.contextoSistema.SIS_OPC_MENU
                 select u).ToList();
            return l;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="idmenu">Por menu</param>
        /// <returns></returns>
        public List<V_SIS_OPC_MENU> consultarVistaPorIDMenu(int  idmenu)
        {
            _datasistema.conectarSistema();
            List<V_SIS_OPC_MENU> l = new List<V_SIS_OPC_MENU>();
            l = (from u in _datasistema.contextoSistema.V_SIS_OPC_MENU
                 where u.ID_MENU ==idmenu  select u).ToList();
            return l;
        }
        public List<V_SIS_OPC_MENU> consultarVistaSinPerfil(int idPerfil)
        { 
           _datasistema.conectarSistema();
            List<V_SIS_OPC_MENU> l = new List<V_SIS_OPC_MENU>();
            l = (from u in _datasistema.contextoSistema.V_SIS_OPC_MENU
                 where (from y in _datasistema.contextoSistema.V_SIS_PERFIL_OPC_MENU
                        where y.ID_OPC_MENU == u.ID && y.ID_PERFIL == idPerfil 
                        select y).Count() == 0
                 select u).ToList();
            return l;
        }

        public SIS_OPC_MENU insertar(SIS_OPC_MENU data)
        {
            _datasistema.conectarSistema();
            SIS_OPC_MENU s = data;
            _datasistema.contextoSistema.SIS_OPC_MENU.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_OPC_MENU modificar(SIS_OPC_MENU data)
        {
            throw new NotImplementedException();
        }

        public SIS_OPC_MENU eliminar(SIS_OPC_MENU data)
        {
            _datasistema.conectarSistema();
            SIS_OPC_MENU s = (from u in _datasistema.contextoSistema.SIS_OPC_MENU
                          where u.ID == data.ID
                          select u).First();
            _datasistema.contextoSistema.SIS_OPC_MENU.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
    }
}
