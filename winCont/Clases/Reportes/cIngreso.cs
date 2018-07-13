using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioDB;

namespace winCont.Clases.Reportes
{
    class cIngreso
    {
         public V_INV_ENCA_INGR   encabezado{get;set;}
        public List<V_INV_DETA_INGR  > detalle { get; set; }

        public cIngreso(V_INV_ENCA_INGR _enca, List<V_INV_DETA_INGR> _deta)
        {
            encabezado = _enca;
            detalle = _deta;
        }
    }
}
