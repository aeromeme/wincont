using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCont.Utilidades
{
    interface  Interfaz_logica<O>
    {
        List<O> consultar();
        O insertar(O data);
        O modificar(O data);
        O eliminar(O data);
    }
}
