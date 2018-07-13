using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContabilidadDB;

namespace winCont.Clases.Reportes
{
    class cPartidaDiario
    {
         public V_CONT_ENCA_PART_DIARIO  encabezado{get;set;}
        public List<V_CONT_DETA_PART_DIARIO > detalle { get; set; }

        public cPartidaDiario(V_CONT_ENCA_PART_DIARIO _enca, List<V_CONT_DETA_PART_DIARIO> _deta)
        {
            encabezado = _enca;
            detalle = _deta;
        }
    }
}
