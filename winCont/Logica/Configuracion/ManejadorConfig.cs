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
    class ManejadorConfig : Interfaz_logica<SIS_CONFIG>
    {
        private DataSistema _datasistema;
        public ManejadorConfig(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<SIS_CONFIG> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_CONFIG> l = new List<SIS_CONFIG>();
            l = (from u in _datasistema.contextoSistema.SIS_CONFIG
                 select u).ToList();
            return l;
        }

        public SIS_CONFIG insertar(SIS_CONFIG data)
        {
            _datasistema.conectarSistema();
            SIS_CONFIG s = data;
            _datasistema.contextoSistema.SIS_CONFIG.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_CONFIG modificar(SIS_CONFIG data)
        {
            _datasistema.conectarSistema();
            SIS_CONFIG s = (from u in _datasistema.contextoSistema.SIS_CONFIG
                               where u.ID == data.ID
                               select u).First();
            s.NM_PORC_IVA = data.NM_PORC_IVA ;
            s.NM_PORC_RENTA = data.NM_PORC_RENTA ;
            s.NM_PORC_RETENCION = data.NM_PORC_RETENCION ;
            s.NM_MONTO_SOBRE_RETENCION = data.NM_MONTO_SOBRE_RETENCION ;

            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_CONFIG eliminar(SIS_CONFIG data)
        {
            _datasistema.conectarSistema();
            SIS_CONFIG s = (from u in _datasistema.contextoSistema.SIS_CONFIG
                               where u.ID == data.ID
                               select u).First();
            _datasistema.contextoSistema.SIS_CONFIG.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
    }
}
