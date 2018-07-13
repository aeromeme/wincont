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
    class ManejadorFormaPago : Interfaz_logica<SIS_FORMA_PAGO>
    {
        private DataSistema _datasistema;
        public ManejadorFormaPago(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<SIS_FORMA_PAGO> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_FORMA_PAGO> l = new List<SIS_FORMA_PAGO>();
            l = (from u in _datasistema.contextoSistema.SIS_FORMA_PAGO
                 select u).ToList();
            return l;
        }
        public List<SIS_FORMA_PAGO> consultarPorIdEmpresa(int idEmpresa)
        {
            _datasistema.conectarSistema();
            List<SIS_FORMA_PAGO> l = new List<SIS_FORMA_PAGO>();
            l = (from u in _datasistema.contextoSistema.SIS_FORMA_PAGO
                where u.ID_EMPRESA ==idEmpresa  select u).ToList();
            return l;
        }

        public SIS_FORMA_PAGO insertar(SIS_FORMA_PAGO data)
        {
            _datasistema.conectarSistema();
            SIS_FORMA_PAGO s = data;
            _datasistema.contextoSistema.SIS_FORMA_PAGO.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_FORMA_PAGO modificar(SIS_FORMA_PAGO data)
        {
            _datasistema.conectarSistema();
            SIS_FORMA_PAGO s = (from u in _datasistema.contextoSistema.SIS_FORMA_PAGO
                            where u.ID == data.ID
                            select u).First();
            s.DS_FORMA_PAGO  = data.DS_FORMA_PAGO;
            s.FLG_CREDITO = data.FLG_CREDITO;
            s.NM_DIAS_PLAZO = data.NM_DIAS_PLAZO;

            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_FORMA_PAGO eliminar(SIS_FORMA_PAGO data)
        {
            _datasistema.conectarSistema();
            SIS_FORMA_PAGO s = (from u in _datasistema.contextoSistema.SIS_FORMA_PAGO
                            where u.ID == data.ID
                            select u).First();
            _datasistema.contextoSistema.SIS_FORMA_PAGO.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
    }
}
