using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContabilidadDB;

namespace winCont.Clases.Reportes
{
    class cPartidaBorrador
    {
        public V_CONT_ENCA_PART_BORRADOR encabezado{get;set;}
        public List<V_CONT_DETA_PART_BORR> detalle { get; set; }

        public cPartidaBorrador(V_CONT_ENCA_PART_BORRADOR _enca, List<V_CONT_DETA_PART_BORR> _deta) {
            encabezado = _enca;
            detalle = _deta;
        }

    }
}
