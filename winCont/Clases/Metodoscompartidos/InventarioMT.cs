using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioDB;
using winCont.Utilidades;

namespace winCont.Clases.Metodoscompartidos
{
    class InventarioMT
    {
        public static bool  procesarDespacho(DataSistema ds,int _idBodega, int _idArticulo , decimal _nmCantidad,int _idDocuOriginal,int _idTipoDocumento, String _dsReferencia)
        {
            
            ds.conectarInventario ();

            int? error = 0;
            string msj = string.Empty;

            ds.ContextoInventario .PR_INV_PROC_DESPACHO(ds.empresa.ID, _idBodega ,ds.periodo .NM_EJERCICIO ,ds.periodo .NM_PERIODO ,_idArticulo, _nmCantidad  ,_idDocuOriginal  , _idTipoDocumento,_dsReferencia, ref error, ref msj);

            if (error > 0)
            {
                throw new Exception("Error: " + msj);
            }
            return true;
        }
        public static bool procesarIngreso(DataSistema ds, int _idBodega, int _idArticulo, decimal _nmCantidad, decimal _nmPrecio, int _idDocuOriginal, int _idTipoDocumento, String _dsReferencia)
        {
            ds.conectarInventario();

            int? error = 0;
            string msj = string.Empty;

            ds.ContextoInventario.PR_INV_PROC_INGRESO(ds.empresa.ID, _idBodega, ds.periodo.NM_EJERCICIO, ds.periodo.NM_PERIODO, _idArticulo, _nmCantidad, _nmPrecio, _idDocuOriginal, _idTipoDocumento, _dsReferencia, ref error, ref msj);

            if (error > 0)
            {
                throw new Exception("Error: " + msj);
            }
            return true;
        }
    }
}
