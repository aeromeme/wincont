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
    class ManejadorPerfil : Interfaz_logica<SIS_PERFIL >
    {
        private DataSistema _datasistema;
        public ManejadorPerfil(DataSistema ds)
        {
            _datasistema = ds;
        }


        public List<SIS_PERFIL> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_PERFIL> l = new List<SIS_PERFIL>();
            l = (from u in _datasistema.contextoSistema.SIS_PERFIL
                 select u).ToList();
            return l;
        }

        public SIS_PERFIL insertar(SIS_PERFIL data)
        {
           
            _datasistema.conectarSistema();
            SIS_PERFIL s = data;
            _datasistema.contextoSistema.SIS_PERFIL.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_PERFIL modificar(SIS_PERFIL data)
        {
            _datasistema.conectarSistema();
            SIS_PERFIL s = (from u in _datasistema.contextoSistema.SIS_PERFIL
                          where u.ID == data.ID
                          select u).First();
            s.DS_PERFIL = data.DS_PERFIL;

            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_PERFIL eliminar(SIS_PERFIL data)
        {
            _datasistema.conectarSistema();
            SIS_PERFIL s = (from u in _datasistema.contextoSistema.SIS_PERFIL
                              where u.ID == data.ID
                              select u).First();
            _datasistema.contextoSistema.SIS_PERFIL.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
    }
}
