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
    class ManejadorTercero: Interfaz_logica<SIS_TERCERO>
    {
         private DataSistema _datasistema;
         public ManejadorTercero(DataSistema ds)
        {
            _datasistema = ds;
        }

        public List<SIS_TERCERO> consultar()
        {
            _datasistema.conectarSistema();
            List<SIS_TERCERO> l = new List<SIS_TERCERO>();
            l = (from u in _datasistema.contextoSistema.SIS_TERCERO
                 select u).ToList();
            return l;
        }
        public List<SIS_TERCERO> consultarPorEmpresa(int idEmpresa)
        {
            _datasistema.conectarSistema();
            List<SIS_TERCERO> l = new List<SIS_TERCERO>();
            l = (from u in _datasistema.contextoSistema.SIS_TERCERO
                 where u.ID_EMPRESA ==idEmpresa  select u).ToList();
            return l;
        }

        public List<SIS_TERCERO> consultarCLientesPorEmpresa(int idEmpresa)
        {
            _datasistema.conectarSistema();
            List<SIS_TERCERO> l = new List<SIS_TERCERO>();
            l = (from u in _datasistema.contextoSistema.SIS_TERCERO
                 where u.FLG_CLIENTE == 'S' &&  u.ID_EMPRESA == idEmpresa 
                 select u).ToList();
            return l;
        }
        public List<V_SIS_TERCERO> consultarVistaPorEmpresa(int idEmpresa)
        {
            _datasistema.conectarSistema();
            List<V_SIS_TERCERO> l = new List<V_SIS_TERCERO>();
            l = (from u in _datasistema.contextoSistema.V_SIS_TERCERO
                 where u.ID_EMPRESA ==idEmpresa  select u).ToList();
            return l;
        }

        public SIS_TERCERO insertar(SIS_TERCERO data)
        {
            _datasistema.conectarSistema();
            SIS_TERCERO s = data;
            _datasistema.contextoSistema.SIS_TERCERO.InsertOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_TERCERO modificar(SIS_TERCERO data)
        {
            _datasistema.conectarSistema();
            SIS_TERCERO s = (from u in _datasistema.contextoSistema.SIS_TERCERO
                               where u.ID == data.ID
                               select u).First();
            s.DS_NOMBRE = data.DS_NOMBRE ;
            s.DS_RZN_COMER = data.DS_RZN_COMER ;
            s.DS_NM_NIT = data.DS_NM_NIT ;
            s.DS_NM_DUI = data.DS_NM_DUI ;
            s.DS_NM_RF = data.DS_NM_RF ;
            s.CD_TIPO_CONTRIBUYENTE = data.CD_TIPO_CONTRIBUYENTE ;
            s.ID_MUNICIPIO = data.ID_MUNICIPIO ;
            s.DS_DIRECCION = data.DS_DIRECCION ;
            s.DS_NM_TELEFONO = data.DS_NM_TELEFONO ;
            s.DS_CORREO_E = data.DS_CORREO_E ;
            s.DS_CONTACTO = data.DS_CONTACTO ;
            s.DS_REFERENCIA =data.DS_REFERENCIA ;
            s.FLG_CLIENTE = data.FLG_CLIENTE ;
            s.FLG_PROVEEDOR = data.FLG_PROVEEDOR ;
            s.ID_CUENTAXCOBRAR = data.ID_CUENTAXCOBRAR ;
            s.ID_CUENTAXPAGAR = data.ID_CUENTAXPAGAR ;
            s.FLG_CREDITO_CLIENTE = data.FLG_CREDITO_CLIENTE ;
            s.FLG_CREDITO_PROVEEDOR = data.FLG_CREDITO_PROVEEDOR ;
            s.CD_TIPO_PERSONA =data.CD_TIPO_PERSONA ;
            if (data.FLG_CLIENTE  == 'S')
            {
                s.ID_LISTA_PRECIO = data.ID_LISTA_PRECIO ;
                s.ID_CANAL = data.ID_CANAL ;
                s.ID_VENDEDOR = data.ID_VENDEDOR ;
            }

            s.NM_CREDITO_CLIENTE = data.NM_CREDITO_CLIENTE ;
            s.NM_CREDITO_PROVEEDOR = data.NM_CREDITO_PROVEEDOR ;
            s.NM_DIAS_CREDITO_CLIENTE = data.NM_DIAS_CREDITO_CLIENTE ;
            s.NM_DIAS_CREDITO_PROVEEDOR = data.NM_DIAS_CREDITO_PROVEEDOR ;

            s.NM_SALDO_CLIENTE = data.NM_SALDO_CLIENTE ;
            s.NM_SALDO_PROVEEDOR = data.NM_SALDO_PROVEEDOR ;

            s.FLG_CLIENTE_EXENTO_IVA = data.FLG_CLIENTE ;
            s.FLG_PROVEEDOR_EXENTO_IVA = data.FLG_PROVEEDOR_EXENTO_IVA ;

            s.CD_ESTADO = data.CD_ESTADO ;


            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }

        public SIS_TERCERO eliminar(SIS_TERCERO data)
        {
            _datasistema.conectarSistema();
            SIS_TERCERO s = (from u in _datasistema.contextoSistema.SIS_TERCERO
                               where u.ID == data.ID
                               select u).First();
            _datasistema.contextoSistema.SIS_TERCERO.DeleteOnSubmit(s);
            _datasistema.contextoSistema.SubmitChanges();
            return s;
        }
    }
}
