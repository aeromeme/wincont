using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winCont.Utilidades;
using Sistema;
using System.Linq;

namespace winCont.Logica.Configuracion
{
    class ManejadorMunicipio: Interfaz_logica<V_SIS_MUNICIPIO>
    {
         private DataSistema _datasistema;
         public ManejadorMunicipio(DataSistema ds)
        {
            _datasistema = ds;
        }
        public List<V_SIS_MUNICIPIO> consultar()
        {
            _datasistema.conectarSistema();
            List<V_SIS_MUNICIPIO> l = new List<V_SIS_MUNICIPIO>();
            l = (from u in _datasistema.contextoSistema.V_SIS_MUNICIPIO
                 select u).ToList();
            return l;
        }

        public V_SIS_MUNICIPIO insertar(V_SIS_MUNICIPIO data)
        {
            throw new NotImplementedException();
        }

        public V_SIS_MUNICIPIO modificar(V_SIS_MUNICIPIO data)
        {
            throw new NotImplementedException();
        }

        public V_SIS_MUNICIPIO eliminar(V_SIS_MUNICIPIO data)
        {
            throw new NotImplementedException();
        }
    }
}
