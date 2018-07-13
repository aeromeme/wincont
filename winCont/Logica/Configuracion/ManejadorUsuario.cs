using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema;
using System.Linq;
using winCont.Utilidades;

namespace winCont.Logica.Configuracion
{
    class ManejadorUsuario: Interfaz_logica<SIS_USER >
    {
         private DataSistema _datasistema;
         public ManejadorUsuario(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<SIS_USER> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_USER> l = new List<SIS_USER>();
            l = (from u in _datasistema.contextoSistema.SIS_USER
                 select u).ToList();
            return l;
        }
        public bool autenticar(String dsuser,String dspassword)
        {
            _datasistema.conectarSistema();

            if ((from u in _datasistema.contextoSistema.SIS_USER
                 where u.CD_LOGIN ==dsuser && u.CD_PASSWORD ==dspassword  select u).Count() == 1)
            {
                return true;
            }
            else {
                return false;
            }
            
        }
        public SIS_USER consultar(String dsuser, String dspassword)
        {
            _datasistema.conectarSistema();
            SIS_USER l=(from u in _datasistema.contextoSistema.SIS_USER
                 where u.CD_LOGIN == dsuser && u.CD_PASSWORD == dspassword
                 select u).First();
            return l;
        }

        public SIS_USER insertar(SIS_USER data)
        {
            _datasistema.conectarSistema();
            SIS_USER s = data;
            _datasistema.contextoSistema.SIS_USER.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_USER modificar(SIS_USER data)
        {
            _datasistema.conectarSistema();
            SIS_USER s = (from u in _datasistema.contextoSistema.SIS_USER
                               where u.ID == data.ID
                               select u).First();

            s.CD_LOGIN = data.CD_LOGIN;
            s.CD_PASSWORD = data.CD_PASSWORD;
            s.DS_NOMBRE_USUARIO = data.DS_NOMBRE_USUARIO;
            s.ID_PERFIL = data.ID_PERFIL;


            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_USER eliminar(SIS_USER data)
        {
            _datasistema.conectarSistema();
            SIS_USER s = (from u in _datasistema.contextoSistema.SIS_USER
                             where u.ID == data.ID
                             select u).First();
            _datasistema.contextoSistema.SIS_USER.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
    }
}
