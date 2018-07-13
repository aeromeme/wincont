using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema;
using winCont.Utilidades;

namespace winCont.Clases.Metodoscompartidos
{
    class SistemasMT
    {
        public static SIS_TALONARIO ObtenerTalonario(DataSistema ds,int _documento,int _ubicacion) {
            SIS_TALONARIO r= new SIS_TALONARIO();
            ds.conectarSistema();

             int? error=0;
             string msj=string.Empty ;
             int? numero = 0;
             string serie = string.Empty;
             int? documento = 0;
             int? ubicacion = 0;
             documento = _documento;
             ubicacion = _ubicacion;
             ds.contextoSistema.PR_SIS_SERVIR_NUME_TALONARIO(ds.empresa.ID, documento, ubicacion,ref serie, ref numero, ref error, ref msj);
             r.CD_SERIE = serie;
             r.NM_ACTUAL = numero;
             if (error > 0) {
                 throw new Exception("Error: "+msj);
             }
            return r;
        }
    }
}
