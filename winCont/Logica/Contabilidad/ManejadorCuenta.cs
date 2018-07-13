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
    class ManejadorCuenta : Interfaz_logica<CONT_CUENTA>
    {
         private DataSistema _datasistema;
         public ManejadorCuenta(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<CONT_CUENTA> consultar()
        {
           _datasistema.conectarContabilidad();
            List<CONT_CUENTA> l = new List<CONT_CUENTA>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                 select u).ToList();
            return l;
        }
        public CONT_CUENTA consultarPorId(int ID)
        {
            _datasistema.conectarContabilidad();
            CONT_CUENTA l = new CONT_CUENTA();
            l = (from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                 where u.ID ==ID 
                 select u).First();
            return l;
        }
        public List<CONT_CUENTA> consultarPorIdPadre(int IdPadre)
        {
            _datasistema.conectarContabilidad();
            List<CONT_CUENTA> l = (from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                 where u.ID_CUENTA_PADRE  == IdPadre
                                   select u).ToList();
            return l;
        }
        public List<CONT_CUENTA> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarContabilidad();
            List<CONT_CUENTA> l = new List<CONT_CUENTA>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }
        public List<CONT_CUENTA> consultarPorIdEmpresaPorTipo(int idEmpresa, char flgDetalle)
        {
            _datasistema.conectarContabilidad();
            List<CONT_CUENTA> l = new List<CONT_CUENTA>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                 where u.ID_EMPRESA == idEmpresa && u.FLG_DETALLE ==flgDetalle 
                 select u).ToList();
            return l;
        }
        public List<CONT_CUENTA> consultarPorIdEmpresaPorRubro(int idEmpresa, int idRubro)
        {
            _datasistema.conectarContabilidad();
            List<CONT_CUENTA> l = new List<CONT_CUENTA>();
            l = (from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                 where u.ID_EMPRESA == idEmpresa && u.ID_RUBRO == idRubro 
                 select u).ToList();
            return l;
        }
        public List<V_CONT_CUENTA> consultarVistaPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarContabilidad();
            List<V_CONT_CUENTA> l = new List<V_CONT_CUENTA>();
            l = (from u in _datasistema.ContextoContabilidad.V_CONT_CUENTA
                 where u.ID_EMPRESA == idEmpresa
                 select u).ToList();
            return l;
        }

        public CONT_CUENTA insertar(CONT_CUENTA data)
        {
            _datasistema.conectarContabilidad();
            CONT_CUENTA s = data;


            if (s.CD_CUENTA .Length != (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_NIVEL == s.ID_NIVEL  select u.NM_CANT_CARACTERES).First())
            {
                throw new Exception("Numero de caracteres invalido para la cuenta");
            }

            CONT_CUENTA Cuentapadre = this.consultarPorId(s.ID_CUENTA_PADRE.Value );

            if (!s.CD_CUENTA.StartsWith(Cuentapadre.CD_CUENTA))
            {
                throw new Exception("Numero de cuenta invalido, revice la cuenta padre");
            }

            _datasistema.ContextoContabilidad.CONT_CUENTA.InsertOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

        public CONT_CUENTA modificar(CONT_CUENTA data)
        {
            _datasistema.conectarContabilidad();
            CONT_CUENTA s = (from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                                   where u.ID == data.ID
                                   select u).First();


            if (data.ID_CUENTA_PADRE != 0)
            {
                CONT_CUENTA Cuentapadre = this.consultarPorId(s.ID_CUENTA_PADRE.Value);
                if (!data.CD_CUENTA .StartsWith(Cuentapadre.CD_CUENTA))
                {
                    throw new Exception ("la cuenta es invalida, revice la cuenta padre");
                }
            }

            if (s.CD_CUENTA != data.CD_CUENTA  && this.consultarPorIdPadre (s.ID ).Count() > 0)
            {
                throw new Exception ("No se puede cambiar la cuenta debido a que tiene detalles");
            }
            s.CD_CUENTA = data.CD_CUENTA;

            s.CD_TIPO_SALDO = data.CD_TIPO_SALDO;
            //debe de verificar si no tiene movimientos

            if (s.FLG_DETALLE == 'N' && data.FLG_DETALLE  == 'S' & this.consultarPorIdPadre (s.ID ).Count() > 0) // si la cuenta cambia de general a detalle
            {
                //flgdetalle no cambia.
                //falta validar que la cuenta de detalle que cambia a general no tenga movimientos.
            // si la cuenta cambia de general a detalle//flgdetalle no cambia.//falta validar que la cuenta de detalle que cambia a general no tenga movimientos.
            }else
            // si la cuenta cambia de general a detalleelse
            {
                s.FLG_DETALLE = data.FLG_DETALLE ;
            }
            s.DS_CUENTA = data.DS_CUENTA;

            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }

    
        public CONT_CUENTA eliminar(CONT_CUENTA data)
        {
            _datasistema.conectarContabilidad();
            CONT_CUENTA s = (from u in _datasistema.ContextoContabilidad.CONT_CUENTA
                                   where u.ID == data.ID
                                   select u).First();

            if (this.consultarPorIdPadre (s.ID).Count() > 0)
            {
                throw new Exception("La cuenta tiene subcuentas, no se puede eliminar");
            }
            _datasistema.ContextoContabilidad.CONT_CUENTA.DeleteOnSubmit(s);
            _datasistema.ContextoContabilidad.SubmitChanges();
            return s;
        }
    }
}
