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
    class ManejadorForm : Interfaz_logica<SIS_FORM >
    {
        private DataSistema _datasistema;
        public List<SIS_FORM> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_FORM> l = new List<SIS_FORM>();
            l = (from u in _datasistema.contextoSistema.SIS_FORM
                 select u).ToList();
            return l;
        }
        public List<V_SIS_FORM> consultarVista()
        {
            _datasistema.conectarSistema();
            List<V_SIS_FORM> l = new List<V_SIS_FORM>();
            l = (from u in _datasistema.contextoSistema.V_SIS_FORM
                 select u).ToList();
            return l;
        }

        public List<SIS_FORM> consultarSinMenu() {
            _datasistema.conectarSistema();
            List<SIS_FORM> l = new List<SIS_FORM>();
            l= (from u in _datasistema.contextoSistema.SIS_FORM
                where (from y in _datasistema.contextoSistema.SIS_OPC_MENU
                    where y.ID_FORM == u.ID
                    select y).Count() == 0
                select u).ToList();             
            return l;

        }

        public SIS_FORM insertar(SIS_FORM data)
        {
            _datasistema.conectarSistema();
            SIS_FORM s = data;
            _datasistema.contextoSistema.SIS_FORM.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_FORM modificar(SIS_FORM data)
        {
            _datasistema.conectarSistema();
            SIS_FORM s = (from u in _datasistema.contextoSistema.SIS_FORM
                            where u.ID == data.ID
                            select u).First();
            s.CD_FORM  = data.CD_FORM ;
            s.CD_MODO_INTERFAZ  = data.CD_MODO_INTERFAZ ;
            s.DS_ALT_NOMBRE = data.DS_ALT_NOMBRE;
            s.DS_NOMBRE = data.DS_NOMBRE;
            s.DS_TOOLTIP = data.DS_TOOLTIP;
            s.FLG_REQ_EMPRESA = data.FLG_REQ_EMPRESA;
            s.FLG_REQ_PERIODO = data.FLG_REQ_PERIODO;
            s.ID_MODULO = data.ID_MODULO;

            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_FORM eliminar(SIS_FORM data)
        {
            _datasistema.conectarSistema();
            SIS_FORM s = (from u in _datasistema.contextoSistema.SIS_FORM
                            where u.ID == data.ID
                            select u).First();
            _datasistema.contextoSistema.SIS_FORM.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
        public ManejadorForm(DataSistema ds)
        {
            _datasistema = ds;
        }
    }
}
