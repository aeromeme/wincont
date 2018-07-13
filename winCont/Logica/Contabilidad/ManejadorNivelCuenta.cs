using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContabilidadDB;
using System.Linq;
using winCont.Utilidades;

namespace winCont.Logica.Contabilidad
{
    class ManejadorNivelCuenta : Interfaz_logica<CONT_NIVEL_CUENTA >
    {
         private DataSistema _datasistema;
         public ManejadorNivelCuenta(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<CONT_NIVEL_CUENTA> consultar()
        {
            _datasistema.conectarContabilidad();
            List<CONT_NIVEL_CUENTA> l = new List<CONT_NIVEL_CUENTA>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA
                 select u).ToList();
            return l;
        }
        public List<CONT_NIVEL_CUENTA> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarContabilidad();
            List<CONT_NIVEL_CUENTA> l = new List<CONT_NIVEL_CUENTA>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public int consultarMaxNivelPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarContabilidad();
           
            int l = int.Parse((from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA where u.ID_EMPRESA == idEmpresa select u.NM_NIVEL).Max().ToString());
            return l;
        }
        public List<CONT_NIVEL_CUENTA> consultarPorNivel(int idEmpresa,int nmNivel)
        {
            _datasistema.conectarContabilidad();
            List<CONT_NIVEL_CUENTA> l = new List<CONT_NIVEL_CUENTA>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA
                 where u.NM_NIVEL  > nmNivel && u.ID_EMPRESA == idEmpresa 
                 select u).ToList();
            return l;
        }
        public CONT_NIVEL_CUENTA consultarPorIdNivel(int idEmpresa, int nmNivel)
        {
            _datasistema.conectarContabilidad();
            CONT_NIVEL_CUENTA l =  (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA
                 where u.NM_NIVEL == nmNivel && u.ID_EMPRESA == idEmpresa 
                 select u).First ();
            return l;
        }
        public CONT_NIVEL_CUENTA consultarSiguienteNivel(int nmNivel)
        {
            _datasistema.conectarContabilidad();
            CONT_NIVEL_CUENTA l = new CONT_NIVEL_CUENTA();
            l = (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA
                 where u.NM_NIVEL ==nmNivel +1
                 select u).First();
            return l;
        }
        public CONT_NIVEL_CUENTA consultarPorId(int id)
        {
            _datasistema.conectarContabilidad();
            CONT_NIVEL_CUENTA l = new CONT_NIVEL_CUENTA();
            l = (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA
                 where u.ID == id
                 select u).First();
            return l;
        }
        

        public CONT_NIVEL_CUENTA insertar(CONT_NIVEL_CUENTA data)
        {
            _datasistema.conectarContabilidad();
            CONT_NIVEL_CUENTA s = data;
            if ((from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA select u.NM_CANT_CARACTERES).Max() > s.NM_CANT_CARACTERES)
            {
                throw new Exception("Cantidad de caracteres invalido");
            }
            _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA.InsertOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_NIVEL_CUENTA modificar(CONT_NIVEL_CUENTA data)
        {
            _datasistema.conectarContabilidad();
            CONT_NIVEL_CUENTA s = (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA
                                   where u.ID == data.ID
                                   select u).First();
            s.NM_CANT_CARACTERES  = data.NM_CANT_CARACTERES ;
            s.NM_NIVEL = data.NM_NIVEL;

            if ((from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA where u.NM_NIVEL < s.NM_NIVEL select u.NM_CANT_CARACTERES).Max() > s.NM_CANT_CARACTERES)
            {
                throw new Exception("Cantidad de caracteres invalido");
            }

            if ((from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA where u.NM_NIVEL > s.NM_NIVEL select u.NM_CANT_CARACTERES).Max() < s.NM_CANT_CARACTERES)
            {
                throw new Exception("Cantidad de caracteres invalido");
            }
            if ((from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                 where u.ID_NIVEL == s.ID
                 select u).Count() > 0)
            {
                throw new Exception("Cuentas registradas a este nivel, no se puede modificar");
            }


            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_NIVEL_CUENTA eliminar(CONT_NIVEL_CUENTA data)
        {
            _datasistema.conectarContabilidad();
            CONT_NIVEL_CUENTA s = (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA
                                   where u.ID == data.ID
                                   select u).First();

            if ((from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA where u.NM_NIVEL > s.NM_NIVEL select u).Count() > 0)
            {
                throw new Exception("Hay niveles superiores, no se puede borrar");
            }
            if ((from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                 where u.ID_NIVEL == s.ID
                 select u).Count() > 0)
            {
                throw new Exception("Cuentas registradas a este nivel, no se puede eliminar");
            }
            _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA.DeleteOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }
    }
}
