using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioDB;

namespace winCont.Clases.Reportes
{
    class cRequisicion
    {
         public V_INV_ENCA_REQ   encabezado{get;set;}
        public List<V_INV_DETA_REQ  > detalle { get; set; }

        public cRequisicion(V_INV_ENCA_REQ _enca, List<V_INV_DETA_REQ> _deta)
        {
            encabezado = _enca;
            detalle = _deta;
        }
    }
}
