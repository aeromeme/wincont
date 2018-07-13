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
    class ManejadorOpcionesPerfil : Interfaz_logica<SIS_PERFIL_OPC_MENU >
    {
        private DataSistema _datasistema;
        public ManejadorOpcionesPerfil(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<SIS_PERFIL_OPC_MENU> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_PERFIL_OPC_MENU> l = new List<SIS_PERFIL_OPC_MENU>();
            l = (from u in _datasistema.contextoSistema.SIS_PERFIL_OPC_MENU
                 select u).ToList();
            return l;
        }
        public List<V_SIS_PERFIL_OPC_MENU> consultarVistaPorIDPerfil(int idPerfil)
        {
            _datasistema.conectarSistema();
            List<V_SIS_PERFIL_OPC_MENU> l = new List<V_SIS_PERFIL_OPC_MENU>();
            l = (from u in _datasistema.contextoSistema.V_SIS_PERFIL_OPC_MENU
                 where u.ID_PERFIL ==idPerfil  select u).ToList();
            return l;
        }

        public SIS_PERFIL_OPC_MENU insertar(SIS_PERFIL_OPC_MENU data)
        {
            _datasistema.conectarSistema();
            SIS_PERFIL_OPC_MENU s = data;
            _datasistema.contextoSistema.SIS_PERFIL_OPC_MENU.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_PERFIL_OPC_MENU modificar(SIS_PERFIL_OPC_MENU data)
        {
            throw new NotImplementedException();
        }

        public SIS_PERFIL_OPC_MENU eliminar(SIS_PERFIL_OPC_MENU data)
        {
            _datasistema.conectarSistema();
            SIS_PERFIL_OPC_MENU s = (from u in _datasistema.contextoSistema.SIS_PERFIL_OPC_MENU
                          where u.ID == data.ID
                          select u).First();
            _datasistema.contextoSistema.SIS_PERFIL_OPC_MENU.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
    }
}
