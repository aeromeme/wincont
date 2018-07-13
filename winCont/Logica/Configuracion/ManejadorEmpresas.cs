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
    class ManejadorEmpresas : Interfaz_logica<SIS_EMPRESAS > 
    {
        private DataSistema _datasistema;

        public List<SIS_EMPRESAS> consultar()
        {
            _datasistema.conectarSistema();
            List <SIS_EMPRESAS > l = new List<SIS_EMPRESAS> ();
            l = (from u in _datasistema.contextoSistema.SIS_EMPRESAS
                 select u).ToList();
            return l;
        }
        public SIS_EMPRESAS consultarPorIdEmpresa(int id)
        {
            _datasistema.conectarSistema();
            SIS_EMPRESAS s =(from u in _datasistema.contextoSistema.SIS_EMPRESAS
                 where u.ID==id select u).First() ;
            return s;
        }
        public List<SIS_EMPRESAS> consultarVistaPorIdUsuarioConsiderUsuEmpr(int idUsuario) {
            _datasistema.conectarSistema();
            List<SIS_EMPRESAS> l = new List<SIS_EMPRESAS>();
            l = (from u in _datasistema.contextoSistema.SIS_EMPRESAS
                 where !(from e in _datasistema.contextoSistema.SIS_USER_EMPRESA
                         where e.ID_USER == idUsuario
                         select e.ID_EMPRESA).ToList().Contains(u.ID)
                 select u).ToList();
            return l;
            
        }

        public SIS_EMPRESAS insertar(SIS_EMPRESAS data)
        {
            _datasistema.conectarSistema();
            SIS_EMPRESAS s= data;
            _datasistema.contextoSistema .SIS_EMPRESAS .InsertOnSubmit (s);
            _datasistema.contextoSistema .SubmitChanges ();
            return s;
        }

        public SIS_EMPRESAS modificar(SIS_EMPRESAS data)
        {
            _datasistema.conectarSistema();
            SIS_EMPRESAS s = (from u in _datasistema.contextoSistema.SIS_EMPRESAS
                              where u.ID==data.ID  select u).First();
            s.DS_EMPRESA = data.DS_EMPRESA ;
            s.DS_RAZON_SOCIAL = data.DS_RAZON_SOCIAL ;
            s.CD_TIPO_CONTRIBUYENTE = data.CD_TIPO_CONTRIBUYENTE ;
            s.DS_DIRECCION =data.DS_DIRECCION ;
            s.DS_NIT = data.DS_NIT ;
            s.DS_NRF = data.DS_NRF ;
            s.DS_CONTACTO_1 = data.DS_CONTACTO_1 ;
            s.DS_CONTACTO_2 = data.DS_CONTACTO_2 ;
            s.DS_TELEFONO_1 = data.DS_TELEFONO_1 ;
            s.DS_TELEFONO_2 = data.DS_TELEFONO_2 ;
            s.DS_CORREO_E = data.DS_CORREO_E;
            s.DS_GERENTE = data.DS_GERENTE ;
            s.DS_CONTADOR = data.DS_CONTADOR ;
            s.DS_AUDITOR = data.DS_AUDITOR ;

            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_EMPRESAS eliminar(SIS_EMPRESAS data)
        {
            _datasistema.conectarSistema();
            SIS_EMPRESAS s = (from u in _datasistema.contextoSistema.SIS_EMPRESAS
                              where u.ID == data.ID
                              select u).First();
            _datasistema.contextoSistema.SIS_EMPRESAS.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public ManejadorEmpresas(DataSistema ds) {
            _datasistema = ds;
        }

    }
}
