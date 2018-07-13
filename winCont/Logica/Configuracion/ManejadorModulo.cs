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
    class ManejadorModulo :Interfaz_logica <SIS_MODULO>
    {
        private DataSistema _datasistema;

        public List<SIS_MODULO> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_MODULO > l = new List<SIS_MODULO>();
            l = (from u in _datasistema.contextoSistema.SIS_MODULO
                 select u).ToList();
            return l;
        }

        public SIS_MODULO insertar(SIS_MODULO data)
        {
            _datasistema.conectarSistema();
            SIS_MODULO s = data;
            _datasistema.contextoSistema.SIS_MODULO.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_MODULO modificar(SIS_MODULO data)
        {
            _datasistema.conectarSistema();
            SIS_MODULO s = (from u in _datasistema.contextoSistema.SIS_MODULO
                              where u.ID == data.ID
                              select u).First();
            s.DS_MODULO  = data.DS_MODULO;
            s.CD_IMAGEN_ICO  = data.CD_IMAGEN_ICO;

            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_MODULO eliminar(SIS_MODULO data)
        {
            _datasistema.conectarSistema();
            SIS_MODULO s = (from u in _datasistema.contextoSistema.SIS_MODULO
                              where u.ID == data.ID
                              select u).First();
            _datasistema.contextoSistema.SIS_MODULO.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
        public ManejadorModulo (DataSistema ds){
            _datasistema = ds;
        }

    }
}
