using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasDB;

namespace winCont.Clases.Reportes.Ventas
{
    class cPedido
    {
        public V_FAC_PEDIDO     encabezado{get;set;}
        public List<V_FAC_DETA_PEDIDO   > detalle { get; set; }

        public cPedido(V_FAC_PEDIDO  _enca, List<V_FAC_DETA_PEDIDO > _deta)
        {
            encabezado = _enca;
            detalle = _deta;
        }
    }
}
