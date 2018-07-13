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
    class ManejadorUbicacion: Interfaz_logica<SIS_UBICACION >
    {
         private DataSistema _datasistema;
         public ManejadorUbicacion(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<SIS_UBICACION> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_UBICACION> l = new List<SIS_UBICACION>();
            l = (from u in _datasistema.contextoSistema.SIS_UBICACION
                 select u).ToList();
            return l;
        }
        public List<SIS_UBICACION> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarSistema();
            List<SIS_UBICACION> l = new List<SIS_UBICACION>();
            l = (from u in _datasistema.contextoSistema.SIS_UBICACION
                 where u.ID_EMPRESA ==idEmpresa  select u).ToList();
            return l;
        }
        public List<SIS_UBICACION> consultarPorIdEmpresaYTipo(int idEmpresa, char tipo)
        {
            _datasistema.conectarSistema();
            List<SIS_UBICACION> l = new List<SIS_UBICACION>();
            l = (from u in _datasistema.contextoSistema.SIS_UBICACION
                 where u.ID_EMPRESA == idEmpresa && u.CD_TIPO_UBICACION ==tipo
                 select u).ToList();
            return l;
        }

        public SIS_UBICACION insertar(SIS_UBICACION data)
        {
            _datasistema.conectarSistema();
            SIS_UBICACION s = data;
            _datasistema.contextoSistema.SIS_UBICACION.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_UBICACION modificar(SIS_UBICACION data)
        {
            _datasistema.conectarSistema();
            SIS_UBICACION s = (from u in _datasistema.contextoSistema.SIS_UBICACION
                               where u.ID == data.ID
                               select u).First();

            s.CD_TIPO_UBICACION = data.CD_TIPO_UBICACION;
            s.DS_UBICACION = data.DS_UBICACION;


            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_UBICACION eliminar(SIS_UBICACION data)
        {
            _datasistema.conectarSistema();
            SIS_UBICACION s = (from u in _datasistema.contextoSistema.SIS_UBICACION
                               where u.ID == data.ID
                               select u).First();
            _datasistema.contextoSistema.SIS_UBICACION.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
    }
}
