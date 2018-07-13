using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing ;

namespace winCont.Clases
{
    class clsImagen
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Image imagen { get;set;}
        public clsImagen(int pid,string pnombre, Image pimagen) {
            id = pid;
            nombre = pnombre;
            imagen = pimagen;
        }
    }
}
