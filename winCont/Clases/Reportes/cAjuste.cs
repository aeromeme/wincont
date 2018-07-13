using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioDB;

namespace winCont.Clases.Reportes
{
    class cAjuste
    {
         public V_INV_ENCA_AJUS   encabezado{get;set;}
        public List<V_INV_DETA_AJUS  > detalle { get; set; }

        public cAjuste(V_INV_ENCA_AJUS _enca, List<V_INV_DETA_AJUS> _deta)
        {
            encabezado = _enca;
            detalle = _deta;
        }
    }
}
