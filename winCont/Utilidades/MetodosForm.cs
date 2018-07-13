using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows .Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraBars.Alerter;
using winCont.Clases;
using System.Drawing ;

namespace winCont.Utilidades
{
    class MetodosForm
    {
        #region Mensajes
        public static void mensajeErrorDefault(DataSistema ds){
            AlertInfo info = new AlertInfo("Error", "Disculpa el inconveniente notifica al desarrollador de este problema",winCont.Properties .Resources .high_priority_48 );
            ds.mainForm.uialertasistema .Show(ds.mainForm , info);
        }
        public static void mensajeErrorDefault(string txt, DataSistema ds)
        {
            AlertInfo info = new AlertInfo("Error", txt, winCont.Properties.Resources.high_priority_48);
            ds.mainForm.uialertasistema .Show(ds.mainForm , info);
        }
        public static void mensajeErrorDefault(string titulo, string txt, DataSistema ds)
        {
            AlertInfo info = new AlertInfo(titulo, txt, winCont.Properties.Resources.high_priority_48);
            ds.mainForm.uialertasistema .Show(ds.mainForm , info);
       }
        public static void mensajeInfo(string titulo, string txt, DataSistema ds)
        {
            AlertInfo info = new AlertInfo(titulo, txt, winCont.Properties.Resources.info_48);
            ds.mainForm.uialertasistema.Show(ds.mainForm, info);
        }
       public static bool preguntar(string titulo, string preg){
        if (MessageBox .Show (preg,titulo,MessageBoxButtons .YesNo ,MessageBoxIcon.Question )==DialogResult .Yes ){
            return true;
        }else{
            return false;
        }
       }
       
        public static bool preguntar(string preg){
        if (MessageBox .Show (preg,"Pregunta",MessageBoxButtons .YesNo ,MessageBoxIcon.Question )==DialogResult .Yes ){
            return true;
        }else{
            return false;
        }
        
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="tipo">1: insertar, 2: modificar, 3 eliminar</param>
        /// <returns></returns>
        public static bool preguntar(int tipo){
            string preg="";
            if (tipo==1) {
                preg="¿Esta seguro de insertar el registro?";
            }else if (tipo==2){
                preg="¿Esta seguro de guardar el registro?";
            }else if (tipo==3){
                preg="¿Esta seguro de eliminar el registro?";
            }
             if (MessageBox .Show (preg,"Pregunta",MessageBoxButtons .YesNo ,MessageBoxIcon.Question )==DialogResult .Yes ){
                return true;
            }else{
                return false;
            }
        }
        #endregion

        #region datagrid 
        public static void seleccionarFila(DevExpress .XtraGrid .Views.Grid .GridView vista, string columna, object valor){
        try 
	    {	        
		    int RowHandle=0;
            GridColumn col =vista.Columns[columna];
            while (true){
                RowHandle =vista .LocateByValue(RowHandle ,col,valor);
                if (RowHandle == GridControl.InvalidRowHandle)
                {
                    break;
                }else{
                    vista.FocusedRowHandle = RowHandle;
                    break;
                }
                RowHandle += 1;
            }

	    }
	    catch (Exception)
	    {
		
		    
	    }
        
        }
#endregion

        #region listas
        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave entera</returns>
        public static List<clsImagen> listaDeImagenesModulo() {
            List<clsImagen> lista = new List<clsImagen>();
            lista.Add(new clsImagen (1,"Configuracion",winCont .Properties .Resources .settings_24  ));
            lista.Add(new clsImagen(2, "Contabilidad", winCont.Properties.Resources.bussines));
            lista.Add(new clsImagen(3, "Dinero", winCont.Properties.Resources.money ));
            lista.Add(new clsImagen(4, "Negocios", winCont.Properties.Resources.bussines));
            lista.Add(new clsImagen(5, "Compras", winCont.Properties.Resources.shopbasket ));
            lista.Add(new clsImagen(6, "Ventas", winCont.Properties.Resources.shop_24 ));
            lista.Add(new clsImagen(7, "Bancos", winCont.Properties.Resources.bank));
            lista.Add(new clsImagen(8, "Inventarios", winCont.Properties.Resources.products));
            lista.Add(new clsImagen(9, "IVA", winCont.Properties.Resources.leyes_finanza));
            lista.Add(new clsImagen(10, "Caja Chica", winCont.Properties.Resources.billetera));

            return lista ;


        }
        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave entera</returns>
        public static List<clsGenericaPares> listaDeModosDeInterfaz() { 
            List<clsGenericaPares > lista=new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares(0, "normal"));
            lista.Add(new clsGenericaPares(1, "No mostrar parametros generales ni boton imprimir"));
            lista.Add(new clsGenericaPares(2, "Solo mostrar consultar y cerrar"));
            lista.Add(new clsGenericaPares(3, "Solo mostrar consultar y cerrar mas parametros generales"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaDeTipodeContribuyentes()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares("G", "Grande"));
            lista.Add(new clsGenericaPares("M", "Mediano"));
            lista.Add(new clsGenericaPares("P", "Pequeño"));
            lista.Add(new clsGenericaPares("N", "No es contribuyente"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaDeTipodePersonas()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares("N", "Natural"));
            lista.Add(new clsGenericaPares("J", "Juridica"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaDeRubrosContablesBases()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares("ACT", "Activo"));
            lista.Add(new clsGenericaPares("PAS", "Pasivo"));
            lista.Add(new clsGenericaPares("CAP", "Capital"));
            lista.Add(new clsGenericaPares("ING", "Ingresos"));
            lista.Add(new clsGenericaPares("GAS", "Gastos"));
            lista.Add(new clsGenericaPares("COS", "Costos"));
            lista.Add(new clsGenericaPares("LIQ", "Liquidadora"));
            return lista;
        }
        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave int</returns>
        public static List<clsGenericaPares> listaDeMeses()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares(1, "Enero"));
            lista.Add(new clsGenericaPares(2, "Febrero"));
            lista.Add(new clsGenericaPares(3, "Marzo"));
            lista.Add(new clsGenericaPares(4, "Abril"));
            lista.Add(new clsGenericaPares(5, "Mayo"));
            lista.Add(new clsGenericaPares(6, "Junio"));
            lista.Add(new clsGenericaPares(7, "Julio"));
            lista.Add(new clsGenericaPares(8, "Agosto"));
            lista.Add(new clsGenericaPares(9, "Septiembre"));
            lista.Add(new clsGenericaPares(10, "Octubre"));
            lista.Add(new clsGenericaPares(11, "Noviembre"));
            lista.Add(new clsGenericaPares(12, "Diciembre"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaSaldos()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('A', "Acreedor"));
            lista.Add(new clsGenericaPares('D', "Deudor"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaEstadosPartidaBorrador()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('D', "Digitada"));
            lista.Add(new clsGenericaPares('A', "Actualizada"));
            lista.Add(new clsGenericaPares('C', "Contabilizada"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaTipoDocumentos()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares("ORD", "Orden de compra [Compra]"));
            lista.Add(new clsGenericaPares("ING", "Ingreso de mercaderia [Compra]"));
            lista.Add(new clsGenericaPares("REQ", "Requision [Consumo interno]"));
            lista.Add(new clsGenericaPares("DES", "Despacho [Consumo interno]"));
            lista.Add(new clsGenericaPares("FAC", "Factura [Ventas o compras]"));
            lista.Add(new clsGenericaPares("CRE", "Credito fiscal [Ventas o compras]"));
            lista.Add(new clsGenericaPares("NAB", "Nota de abono [Ventas o compras]"));
            lista.Add(new clsGenericaPares("NDE", "Nota de debito [Ventas o compras]"));
            lista.Add(new clsGenericaPares("NCR", "Nota de credito [Ventas o compras]"));
            lista.Add(new clsGenericaPares("CHE", "Cheques [Bancos]"));
            lista.Add(new clsGenericaPares("REM", "Remesas [Bancos]"));
            lista.Add(new clsGenericaPares("TRA", "Transferencia [Bancos]"));
            lista.Add(new clsGenericaPares("VAL", "Vales [Caja Chica]"));
            lista.Add(new clsGenericaPares("REC", "Recibo comercial [Ventas o compra]"));
            lista.Add(new clsGenericaPares("QUE", "Quedan [compra]"));
            lista.Add(new clsGenericaPares("CRE", "Comprobante retencion [compra]"));
            lista.Add(new clsGenericaPares("NRE", "Nota de remision [compra]"));
            lista.Add(new clsGenericaPares("DSE", "Documento sujeto excluido [compra]"));
            lista.Add(new clsGenericaPares("IMP", "Importacion [compra]"));
            lista.Add(new clsGenericaPares("EXP", "Factura exportacion [compra]"));
            lista.Add(new clsGenericaPares("PRO", "Produccion [inventario]"));
            lista.Add(new clsGenericaPares("AJS", "Ajuste salida [inventario]"));
            lista.Add(new clsGenericaPares("AJE", "Ajuste entrada [inventario]"));
            lista.Add(new clsGenericaPares("PED", "Pedidos"));
            return lista;
        }
        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaTipoUbicacion()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('T', "Tienda"));
            lista.Add(new clsGenericaPares('D', "Departamento"));
            lista.Add(new clsGenericaPares('B', "Bodega"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaEstadoTalonario()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('D', "Digitado"));
            lista.Add(new clsGenericaPares('U', "En Uso"));
            lista.Add(new clsGenericaPares('T', "Terminado"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaEstadoRequisicion()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('D', "Digitada"));
            lista.Add(new clsGenericaPares('A', "Actualizada"));
            lista.Add(new clsGenericaPares('F', "Despachada"));
            lista.Add(new clsGenericaPares('N', "Anulada"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaEstadoOrdenCompra()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('D', "Digitada"));
            lista.Add(new clsGenericaPares('A', "Actualizada"));
            lista.Add(new clsGenericaPares('R', "Recibida"));
            lista.Add(new clsGenericaPares('N', "Anulada"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaEstadoDespacho()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('D', "Digitado"));
            lista.Add(new clsGenericaPares('A', "Actualizado"));
            lista.Add(new clsGenericaPares('C', "Contabilizado"));
            lista.Add(new clsGenericaPares('N', "Anulado"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaEstadoIngreso()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('D', "Digitado"));
            lista.Add(new clsGenericaPares('A', "Actualizado"));
            lista.Add(new clsGenericaPares('R', "Recibida"));
            lista.Add(new clsGenericaPares('C', "Contabilizado"));
            lista.Add(new clsGenericaPares('N', "Anulado"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaEstadoCompraVenta()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('D', "Digitada"));
            lista.Add(new clsGenericaPares('A', "Actualizada"));
            lista.Add(new clsGenericaPares('C', "Contabilizada"));
            lista.Add(new clsGenericaPares('N', "Anulada"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave char</returns>
        public static List<clsGenericaPares> listaEstadoQuedan()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('D', "Digitado"));
            lista.Add(new clsGenericaPares('A', "Actualizado"));
            lista.Add(new clsGenericaPares('N', "Anulado"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave entera</returns>
        public static List<clsGenericaPares> listaNivelesContabilidad()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('D', "Default"));
            lista.Add(new clsGenericaPares('F', "Familia"));
            lista.Add(new clsGenericaPares('G', "Grupo"));
            lista.Add(new clsGenericaPares('C', "Categoria"));
            return lista;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>arreglo con llave entera</returns>
        public static List<clsGenericaPares> listaEstadosTercero()
        {
            List<clsGenericaPares> lista = new List<clsGenericaPares>();
            lista.Add(new clsGenericaPares('A', "Activo"));
            lista.Add(new clsGenericaPares('S', "Suspendido"));
            return lista;
        }

        #endregion

        #region Funciones especiales
        public static DataSistema obtenerCopy(DataSistema ds) {
            DataSistema copy = new DataSistema();
            copy.cadenaConexion = ds.cadenaConexion;
            copy.nomSistema = ds.nomSistema;
            copy.nomUsuario = ds.nomUsuario;
            copy.usuario = ds.usuario;
            copy.verSistema = ds.verSistema;
            copy.mainForm = ds.mainForm;
            copy.empresa = ds.empresa;
            copy.periodo = ds.periodo;
            return copy;
        }
        public static Image encontrarImagen(int id, List<clsImagen > lista){ 
            foreach (clsImagen  item in lista)
	        {
		         if (item.id ==id){
                    return item.imagen ;
                 }
	        }
            return winCont .Properties.Resources .settings_24;
        }
        public static string encontrarMes(int id) {
            foreach (clsGenericaPares  item in listaDeMeses ())
            {
                if (item.id == id)
                {
                    return item.descripcion;
                }
            }
            return "n/e";
        }

        #endregion

    }
}
