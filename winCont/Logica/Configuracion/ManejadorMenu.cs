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
    class ManejadorMenu : Interfaz_logica<SIS_MENU>
    {
        private DataSistema _datasistema;

        public List<SIS_MENU> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_MENU> l = new List<SIS_MENU>();
            l = (from u in _datasistema.contextoSistema.SIS_MENU
                 select u).ToList();
            return l;
        }

        public SIS_MENU insertar(SIS_MENU data)
        {
            _datasistema.conectarSistema();
            SIS_MENU s = data;
            _datasistema.contextoSistema.SIS_MENU.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_MENU modificar(SIS_MENU data)
        {
            _datasistema.conectarSistema();
            SIS_MENU s = (from u in _datasistema.contextoSistema.SIS_MENU
                            where u.ID == data.ID
                            select u).First();
            s.DS_MENU = data.DS_MENU;

            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_MENU eliminar(SIS_MENU data)
        {
            _datasistema.conectarSistema();
            SIS_MENU s = (from u in _datasistema.contextoSistema.SIS_MENU
                            where u.ID == data.ID
                            select u).First();
            _datasistema.contextoSistema.SIS_MENU.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
        public ManejadorMenu (DataSistema ds){
            _datasistema = ds;
        }
    }
}
