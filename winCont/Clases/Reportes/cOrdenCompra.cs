using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioDB;

namespace winCont.Clases.Reportes
{
    class cOrdenCompra
    {
         public V_INV_ENCA_ORDEN    encabezado{get;set;}
        public List<V_INV_DETA_ORDEN  > detalle { get; set; }

        public cOrdenCompra(V_INV_ENCA_ORDEN _enca, List<V_INV_DETA_ORDEN> _deta)
        {
            encabezado = _enca;
            detalle = _deta;
        }
    }
}
