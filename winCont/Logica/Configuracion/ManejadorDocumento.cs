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
    class ManejadorDocumento : Interfaz_logica<SIS_DOCUMENTO >
    {
        private DataSistema _datasistema;
        public ManejadorDocumento(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<SIS_DOCUMENTO> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_DOCUMENTO> l = new List<SIS_DOCUMENTO>();
            l = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO
                 select u).ToList();
            return l;
        }
        public List<SIS_DOCUMENTO> consultarPorEmpresa(int IdEmpresa)
        {
            _datasistema.conectarSistema();
            List<SIS_DOCUMENTO> l = new List<SIS_DOCUMENTO>();
            l = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO
                 where u.ID_EMPRESA ==IdEmpresa  select u).ToList();
            return l;
        }
        public List<SIS_DOCUMENTO> consultarPorEmpresaYTipo(int IdEmpresa, string tipo)
        {
            _datasistema.conectarSistema();
            List<SIS_DOCUMENTO> l = new List<SIS_DOCUMENTO>();
            l = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO
                 where u.ID_EMPRESA == IdEmpresa && u.CD_TIPO_DOCUMENTO ==tipo
                 select u).ToList();
            return l;
        }
        public List<SIS_DOCUMENTO> consultarPorEmpresaYTipoAjuste(int IdEmpresa)
        {
            _datasistema.conectarSistema();
            List<SIS_DOCUMENTO> l = new List<SIS_DOCUMENTO>();
            l = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO
                 where u.ID_EMPRESA == IdEmpresa && (u.CD_TIPO_DOCUMENTO == "AJS" || u.CD_TIPO_DOCUMENTO == "AJE" || u.CD_TIPO_DOCUMENTO == "PRO") 
                 select u).ToList();
            return l;
        }

        public SIS_DOCUMENTO insertar(SIS_DOCUMENTO data)
        {
            _datasistema.conectarSistema();
            SIS_DOCUMENTO s = data;
            _datasistema.contextoSistema.SIS_DOCUMENTO.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_DOCUMENTO modificar(SIS_DOCUMENTO data)
        {
            _datasistema.conectarSistema();
            SIS_DOCUMENTO s = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO
                          where u.ID == data.ID
                          select u).First();
            s.DS_DOCUMENTO = data.DS_DOCUMENTO ;
            s.CD_TIPO_DOCUMENTO = data.CD_TIPO_DOCUMENTO;

            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_DOCUMENTO eliminar(SIS_DOCUMENTO data)
        {
            _datasistema.conectarSistema();
            SIS_DOCUMENTO s = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO
                          where u.ID == data.ID
                          select u).First();
            _datasistema.contextoSistema.SIS_DOCUMENTO.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
    }
}
