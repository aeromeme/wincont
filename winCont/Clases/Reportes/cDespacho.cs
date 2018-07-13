using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioDB;

namespace winCont.Clases.Reportes
{
    class cDespacho
    {
         public V_INV_ENCA_DESP   encabezado{get;set;}
        public List<V_INV_DETA_DESP  > detalle { get; set; }

        public cDespacho(V_INV_ENCA_DESP _enca, List<V_INV_DETA_DESP> _deta)
        {
            encabezado = _enca;
            detalle = _deta;
        }
    }
}
