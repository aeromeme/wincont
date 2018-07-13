using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComprasDB;

namespace winCont.Clases.Reportes
{
    class cQuedan
    {
         public V_COMP_QUEDAN    encabezado{get;set;}
        public List<V_COMP_DETA_QUEDAN   > detalle { get; set; }

        public cQuedan(V_COMP_QUEDAN _enca, List<V_COMP_DETA_QUEDAN> _deta)
        {
            encabezado = _enca;
            detalle = _deta;
        }
    }
}
