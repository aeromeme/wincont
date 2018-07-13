using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContabilidadDB;
using Sistema;
using System.Linq;
using winCont.Utilidades;

namespace winCont.Logica.Contabilidad
{
    class ManejadorDetallePartidaBorrrador: Interfaz_logica<CONT_DETA_PART_BORR>
    {
          private DataSistema _datasistema;
          public ManejadorDetallePartidaBorrrador(DataSistema ds)
        {
            _datasistema = ds;
        }


          public List<CONT_DETA_PART_BORR> consultar()
          {
              _datasistema.conectarContabilidad();
              List<CONT_DETA_PART_BORR> l = new List<CONT_DETA_PART_BORR>();
              l = (from u in _datasistema.ContextoContabilidad.CONT_DETA_PART_BORR
                   select u).ToList();
              return l;
          }
          public List<CONT_DETA_PART_BORR> consultarPorIdEnca(int IdEnca)
          {
              _datasistema.conectarContabilidad();
              List<CONT_DETA_PART_BORR> l = (from u in _datasistema.ContextoContabilidad.CONT_DETA_PART_BORR
                                             where u.ID_PART_BORR == IdEnca
                                     select u).ToList();
              return l;
          }
          public List<V_CONT_DETA_PART_BORR> consultarVistaPorIdEnca(int IdEnca)
          {
              _datasistema.conectarContabilidad();
              List<V_CONT_DETA_PART_BORR> l = (from u in _datasistema.ContextoContabilidad.V_CONT_DETA_PART_BORR
                                             where u.ID_PART_BORR == IdEnca
                                             select u).ToList();
              return l;
          }
          public V_CONT_DETA_PART_BORR_AUX consultarVistaAuxPorIdEnca(int IdEnca)
          {
              _datasistema.conectarContabilidad();
              V_CONT_DETA_PART_BORR_AUX l = (from u in _datasistema.ContextoContabilidad.V_CONT_DETA_PART_BORR_AUX
                                               where u.ID_PART_BORR == IdEnca
                                               select u).First ();
              return l;
          }

          public CONT_DETA_PART_BORR insertar(CONT_DETA_PART_BORR data)
          {
              _datasistema.conectarContabilidad();
              CONT_DETA_PART_BORR s = data;
              _datasistema.ContextoContabilidad.CONT_DETA_PART_BORR.InsertOnSubmit(s);
              _datasistema.ContextoContabilidad.SubmitChanges();
              return s;
          }

          public CONT_DETA_PART_BORR modificar(CONT_DETA_PART_BORR data)
          {
              _datasistema.conectarContabilidad();
              CONT_DETA_PART_BORR s = (from u in _datasistema.ContextoContabilidad.CONT_DETA_PART_BORR
                               where u.ID == data.ID
                               select u).First();
              s.DS_CONCEPTO = data.DS_CONCEPTO;
              s.ID_CUENTA = data.ID_CUENTA;
              s.ID_CENTRO_COSTO = data.ID_CENTRO_COSTO;
              s.NM_ABONO = data.NM_ABONO;
              s.NM_CARGO = data.NM_CARGO;

              _datasistema.ContextoContabilidad.SubmitChanges();
              return s;
          }

          public CONT_DETA_PART_BORR eliminar(CONT_DETA_PART_BORR data)
          {
              _datasistema.conectarContabilidad();
              CONT_DETA_PART_BORR s = (from u in _datasistema.ContextoContabilidad.CONT_DETA_PART_BORR
                               where u.ID == data.ID
                               select u).First();
              _datasistema.ContextoContabilidad.CONT_DETA_PART_BORR.DeleteOnSubmit(s);
              _datasistema.ContextoContabilidad.SubmitChanges();
              return s;
          }
    }
}
