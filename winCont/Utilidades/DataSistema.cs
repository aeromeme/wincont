using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContabilidadContext;
using SistemaContext;
using Sistema;
using ContabilidadDB;
using InventarioContext;
using InventarioDB;
using VentasContext;
using ComprasContext;

namespace winCont.Utilidades
{
    public class DataSistema
    {
       
        public String nomUsuario { get; set; }
        public String nomSistema { get; set; }
        public String verSistema { get; set; }
        public SIS_USER usuario{get;set;} 
        public SIS_EMPRESAS empresa { get; set; }
        public SIS_PERIODO periodo { get; set; }

        public String nombreOpcion { get; set; }
        public String nombreVentana { get; set; }
        public String cadenaConexion { get; set; }
        public marco_principal mainForm { get; set; }
        public int modoInterfaz { get; set; }      

        #region sistema
        public SistemaDataContext contextoSistema { get; set; }
        public bool conectarSistema()
        {
            contextoSistema = new SistemaDataContext(cadenaConexion);
            return true;
        }
        #endregion

        #region contabilidad
        public ContabilidadDataContext ContextoContabilidad { get; set; }
        public bool conectarContabilidad()
        {
           ContextoContabilidad = new ContabilidadDataContext(cadenaConexion);
            return true;
        }
        #endregion

        #region inventario
        public InventarioDataContext ContextoInventario { get; set; }
        public bool conectarInventario()
        {
            ContextoInventario = new InventarioDataContext(cadenaConexion);
            return true;
        }
        #endregion

        #region ventas
        public VentasDataContext ContextoVentas { get; set; }
        public bool conectarVentas()
        {
            ContextoVentas = new VentasDataContext(cadenaConexion);
            return true;
        }
        #endregion

        #region compras
        public ComprasDataContext ContextoCompras { get; set; }
        public bool conectarCompras()
        {
            ContextoCompras = new ComprasDataContext(cadenaConexion);
            return true;
        }
        #endregion



        public DataSistema()
        {
            cadenaConexion = Preferencias.obtenercadenaConexion();
        }
        
    }
}
