using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace winCont.Clases
{
    class clsGenericaPares
    {
        public dynamic id {get;set;}
        public string descripcion { get; set; }

        public clsGenericaPares(dynamic pid, string pdescripcion)
        {
            id = pid;
            descripcion = pdescripcion;
        }


    }
}
