using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using VentasDB;
using InventarioDB;
using Sistema;
using winCont.Clases.Metodoscompartidos;
using System.Linq;
using DevExpress.XtraEditors;
using winCont.Reportes.Ventas;
using winCont.Clases.Reportes.Ventas;
using winCont.Logica.Ventas;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Ventas
{
    public partial class frm_pedidos : winCont.Formularios.MasterFormTab, Interfaz_forms 
    {
        List<V_FAC_PEDIDO > lista;
        ManejadorPedido manejadorData;
        ManejadorTercero manejadorTercero;
        ManejadorDocumento manejadorDocumento;
        ManejadorDetallePedido manejadorDataDetalle;
        
        public List<V_FAC_DETA_LISTA_PRECIO> lista_articulos;
        public frm_pedidos()
        {
            InitializeComponent();
        }
        public frm_pedidos(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorPedido(ds);
            manejadorTercero = new ManejadorTercero(ds);
            manejadorDocumento = new ManejadorDocumento(ds);
            manejadorDataDetalle = new ManejadorDetallePedido(ds);
        }
        public void llenarcombo()
        {
            _datasistema.conectarSistema();

            UICD_ESTADO.Properties.DataSource = MetodosForm.listaEstadoCompraVenta();
            UIID_TIPO_DOCUMENTO.Properties.DataSource = manejadorDocumento.consultarPorEmpresaYTipo(_datasistema.empresa.ID, "PED");
            UIID_TERCERO.Properties.DataSource = manejadorTercero.consultarCLientesPorEmpresa(_datasistema.empresa.ID);
            UIID_VENDEDOR.Properties.DataSource = (from u in _datasistema.ContextoVentas.FAC_VENDEDOR where u.ID_EMPRESA == _datasistema.empresa.ID select u).ToList();
            UIID_TIENDA .Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_UBICACION where u.ID_EMPRESA == _datasistema.empresa.ID && u.CD_TIPO_UBICACION == 'T' select u).ToList();
          
        }
        public void consultar()
        {
            try
            {
                lista = manejadorData.consultarPorIdEmpresaPorPeriodo(_datasistema.empresa.ID, _datasistema.periodo);
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                if (lista.Count() == 0)
                {
                    nuevo();
                }
                llenarcombo();
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void nuevo()
        {
            desenlazar();
            UIID.Text = "";
            UIID_TERCERO.EditValue = null;
            UIID_TIPO_DOCUMENTO.EditValue = null;
            UIID_TIENDA.EditValue = null;
            UIID_VENDEDOR.EditValue = null;
            UIDS_NOMBRE_CLIENTE.Text = "";
            UIDS_DIR_ENTREGA.Text = "";
            UICD_NUMERO.EditValue = null;
            UICD_SERIE.Text = "";
            UICD_ESTADO.EditValue = 'D';
            UIFE_FECHA.EditValue = DateTime.Now;

        }

        public void guardar()
        {
            if (!validar())
            {
                return;
            }

            FAC_PEDIDO m = new FAC_PEDIDO
            {
                ID = 0,
                ID_EMPRESA = _datasistema.empresa.ID,
                NM_EJERCICIO = _datasistema.periodo.NM_EJERCICIO,
                NM_PERIODO = _datasistema.periodo.NM_PERIODO,
                ID_TERCERO = (int)UIID_TERCERO.EditValue,
                DS_NOMBRE_CLIENTE = UIDS_NOMBRE_CLIENTE.Text,
                DS_DIR_ENTREGA = UIDS_DIR_ENTREGA.Text,
                ID_VENDEDOR = (int)UIID_VENDEDOR.EditValue,
                ID_TIENDA = (int)UIID_TIENDA.EditValue,
                FE_FECHA = UIFE_FECHA.DateTime,
                ID_TIPO_DOCUMENTO = (int)UIID_TIPO_DOCUMENTO.EditValue,
                CD_SERIE = "",
                CD_NUMERO = 0,
                NM_GRAVADO = 0,
                NM_EXENTO = 0,
                NM_IVA = 0,
                NM_PERCEPCION = 0,
                NM_RETENCION = 0,
                NM_TOTAL = 0,
                CD_ESTADO = 'D'
            };
            if (UIID.Text == "")
            {
                try
                {
                    SIS_TALONARIO t = SistemasMT.ObtenerTalonario(_datasistema, (int)UIID_TIPO_DOCUMENTO.EditValue, (int)UIID_TIENDA.EditValue);
                    m.CD_NUMERO  = t.NM_ACTUAL;
                    m.CD_SERIE  = t.CD_SERIE;   
                    m=manejadorData.insertar(m);
                    consultar();
                    MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
                }
                catch (Exception e)
                {

                    MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
                }
            }

            else
            {
                try
                {
                    m.ID = int.Parse(UIID.Text);
                    m.CD_SERIE = UICD_SERIE.Text;
                    m.CD_NUMERO = (int)UICD_NUMERO.EditValue;
                    manejadorData.modificar(m);
                    consultar();
                    MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
                    }

                catch
                    (Exception e)
                {

                    MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
                }
            }
        }

        public void eliminar()
        {
            try
            {
                FAC_PEDIDO m = new FAC_PEDIDO {
               ID =int.Parse(UIID.Text)
                };
                manejadorData.eliminar(m);
                consultar();
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void imprimir()
        {
            try
            {
                //V_FAC_PEDIDO enca = (from u in _datasistema.ContextoVentas.V_FAC_PEDIDO 
                                         //where u.ID == (int)UIID.EditValue
                                         //select u).First();
                V_FAC_PEDIDO enca = manejadorData.consultarVistaPorId(int.Parse(UIID.Text));
                //List<V_FAC_DETA_PEDIDO> detas = (from u in _datasistema.ContextoVentas .V_FAC_DETA_PEDIDO
                //                                where u.ID_PEDIDO  == (int)UIID.EditValue
                //                                select u).ToList();

                List<V_FAC_DETA_PEDIDO> detas = manejadorDataDetalle.consultarVistaPorIdEnca(int.Parse(UIID.Text));
                cPedido data = new cPedido(enca, detas);

                rpt_pedido rpt = new rpt_pedido();
                List<cPedido> prpdata = new List<cPedido>();
                prpdata.Add(data);
                rpt.DataSource = prpdata;
                //rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        public void cerrar()
        {
            this.Close();
        }

        public void enlazar()
        {
            UIID_TERCERO.DataBindings.Add("EditValue", lista, "ID_TERCERO", false, DataSourceUpdateMode.Never);
            UIID_TIENDA.DataBindings.Add("EditValue", lista, "ID_TIENDA", false, DataSourceUpdateMode.Never);
            UIID_TIPO_DOCUMENTO.DataBindings.Add("EditValue", lista, "ID_TIPO_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UIID_VENDEDOR.DataBindings.Add("EditValue", lista, "ID_VENDEDOR", false, DataSourceUpdateMode.Never);
            UIDS_NOMBRE_CLIENTE.DataBindings.Add("EditValue", lista, "DS_NOMBRE_CLIENTE", false, DataSourceUpdateMode.Never);
            UIDS_DIR_ENTREGA.DataBindings.Add("EditValue", lista, "DS_DIR_ENTREGA", false, DataSourceUpdateMode.Never);
            UICD_NUMERO.DataBindings.Add("EditValue", lista, "CD_NUMERO", false, DataSourceUpdateMode.Never);
            UICD_SERIE.DataBindings.Add("EditValue", lista, "CD_SERIE", false, DataSourceUpdateMode.Never);
            UICD_ESTADO.DataBindings.Add("EditValue", lista, "CD_ESTADO", false, DataSourceUpdateMode.Never);
            UIFE_FECHA.DataBindings.Add("EditValue", lista, "FE_FECHA", false, DataSourceUpdateMode.Never);
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {

            UIID_TERCERO.DataBindings.Clear();
            UIID_TIENDA.DataBindings.Clear();
            UIID_TIPO_DOCUMENTO.DataBindings.Clear();
            UIID_VENDEDOR.DataBindings.Clear();
            UIDS_NOMBRE_CLIENTE.DataBindings.Clear();
            UIDS_DIR_ENTREGA.DataBindings.Clear();
            UICD_NUMERO.DataBindings.Clear();
            UICD_SERIE.DataBindings.Clear();
            UICD_ESTADO.DataBindings.Clear();
            UIFE_FECHA.DataBindings.Clear();
            UIID.DataBindings.Clear();
        }

        public bool validar()
        {
            try
            {

                if (UIID_TIENDA.EditValue == null)
                {
                    throw new Exception("Elija una tienda");
                }
                if (UIID_TIPO_DOCUMENTO.EditValue == null)
                {
                    throw new Exception("Elija un documento");
                }
                if (UIID_TERCERO.EditValue == null)
                {
                    throw new Exception("Elija un cliente");
                }
                if (UIID_VENDEDOR .EditValue == null)
                {
                    throw new Exception("Elija un vendedor");
                }
   
            }
            catch (Exception ex)
            {
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                return false;
            }
            return true;
        }
        public override void refrescar()
        {
            consultar();
        }

        public override void enlazar_aux()
        {
            desenlazar();
            enlazar();
        }

        private void UIID_TERCERO_EditValueChanged(object sender, EventArgs e)
        {
            if (UIID.Text == "" && UIID_TERCERO .EditValue!=null)
            {
                _datasistema.conectarSistema();
                SIS_TERCERO clie = (from u in _datasistema.contextoSistema.SIS_TERCERO where u.ID == int.Parse(UIID_TERCERO.EditValue.ToString()) select u).First();
                UIDS_DIR_ENTREGA.Text = clie.DS_DIRECCION;
                UIDS_NOMBRE_CLIENTE.Text = clie.DS_NOMBRE;

                lista_articulos = (from u in _datasistema.ContextoVentas.V_FAC_DETA_LISTA_PRECIO where u.ID_LISTA == clie.ID_LISTA_PRECIO  select u).ToList();
                UIGID_ARTICULO.DataSource = lista_articulos;
            }
            
        }


        #region detalle
        System.ComponentModel.BindingList<V_FAC_DETA_PEDIDO > lista_deta;
        public void consultardetalle()
        {
            try
            {
                if (UIID.Text == "")
                {
                    UIGRIDCONTROL_DETA.DataSource = null;
                    UIGRIDVIEW_DETA.OptionsBehavior.Editable = false;
                    UIGRIDVIEW_DETA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    return;
                }
                _datasistema.conectarVentas();
                lista_deta = new System.ComponentModel.BindingList<V_FAC_DETA_PEDIDO>((manejadorDataDetalle .consultarVistaPorIdEnca (int.Parse (UIID.Text) )));

                lista_deta.AddingNew += list_AddinDeta;

                UIGRIDCONTROL_DETA.DataSource = lista_deta;


            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void insertardetalle(FAC_DETA_PEDIDO  d)
        {
            try
            {
                //_datasistema.ContextoVentas .Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoVentas.FAC_DETA_PEDIDO .InsertOnSubmit(d);
                //_datasistema.ContextoVentas.SubmitChanges();
                manejadorDataDetalle.insertar(d);
                int? error = 0;
                string msj = String.Empty;
                _datasistema.ContextoVentas .PR_VEN_ACTU_DETA_PEDIDO(d.ID_PEDIDO , _datasistema.empresa.ID, ref error, ref msj);
                if (error != 0)
                {
                    MetodosForm.mensajeErrorDefault(msj, _datasistema);
                }

                consultardetalle();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }

        }

        public void modificardetalle(FAC_DETA_PEDIDO d)
        {
            try
            {
                //FAC_DETA_PEDIDO tupla = (from u in _datasistema.ContextoVentas.FAC_DETA_PEDIDO
                //                        where u.ID == d.ID
                //                        select u).First();
                //tupla.ID_ARTICULO = d.ID_ARTICULO;
                //tupla.NM_CANTIDAD = d.NM_CANTIDAD;
                //tupla.NM_PRECIO = d.NM_PRECIO;
                //_datasistema.ContextoVentas.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoVentas.SubmitChanges();
                manejadorDataDetalle.modificar(d);
                int? error = 0;
                string msj = String.Empty;
                _datasistema.ContextoVentas.PR_VEN_ACTU_DETA_PEDIDO (d.ID_PEDIDO, _datasistema.empresa.ID, ref error, ref msj);
                if (error != 0)
                {
                    MetodosForm.mensajeErrorDefault(msj, _datasistema);
                }
                consultardetalle();


            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }
        }

        public void eliminardetalle(FAC_DETA_PEDIDO d)
        {

            try
            {
                //FAC_DETA_PEDIDO tupla = (from u in _datasistema.ContextoVentas.FAC_DETA_PEDIDO
                //                        where u.ID == d.ID
                //                        select u).First();
                //_datasistema.ContextoVentas.FAC_DETA_PEDIDO.DeleteOnSubmit(tupla);
                //_datasistema.ContextoVentas.SubmitChanges();
                manejadorDataDetalle.eliminar(d);
                int? error = 0;
                string msj = String.Empty;
                _datasistema.ContextoVentas.PR_VEN_ACTU_DETA_PEDIDO(d.ID_PEDIDO, _datasistema.empresa.ID, ref error, ref msj);
                if (error != 0)
                {
                    MetodosForm.mensajeErrorDefault(msj, _datasistema);
                }

                consultardetalle();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }
        }

        private void list_AddinDeta(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new V_FAC_DETA_PEDIDO ();
        }


        private void UIGRIDVIEW_DETA_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID", 0);
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID_PEDIDO", UIID.EditValue);
        }

        private void UIGRIDVIEW_DETA_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            V_FAC_DETA_PEDIDO v = (V_FAC_DETA_PEDIDO)e.Row;
            FAC_DETA_PEDIDO  d = new FAC_DETA_PEDIDO  { ID = v.ID, ID_ARTICULO = v.ID_ARTICULO, NM_CANTIDAD = v.NM_CANTIDAD, ID_PEDIDO  = v.ID_PEDIDO , NM_PRECIO = v.NM_PRECIO };
            if (d.ID == 0)
            {
                insertardetalle(d);
            }
            else
            {
                modificardetalle(d);
            }

        }

        private void UIGRIDVIEW_DETA_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool flgvalid = true;
            string msjerror = "";
            V_FAC_DETA_PEDIDO d = (V_FAC_DETA_PEDIDO)e.Row;
            if (d.ID_ARTICULO == 0)
            {
                flgvalid = false;
                msjerror = "Seleccione un articulo";
                UIGRIDVIEW_DETA.SetColumnError(colID_ARTICULO, msjerror);
            }
            if (d.NM_CANTIDAD <= 0)
            {
                flgvalid = false;
                msjerror = "Digite una cantidad correcta";
                UIGRIDVIEW_DETA.SetColumnError(colNM_CANTIDAD, msjerror);
            }
            if (d.NM_PRECIO <= 0)
            {
                flgvalid = false;
                msjerror = "Digite un precio correcta";
                UIGRIDVIEW_DETA.SetColumnError(colNM_PRECIO, msjerror);
            }
            e.Valid = flgvalid;
        }

        private void UIGRIDVIEW_DETA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && UIGRIDVIEW_DETA.FocusedRowHandle >= 0)
            {
                if (MetodosForm.preguntar(3))
                {
                    FAC_DETA_PEDIDO  d = new FAC_DETA_PEDIDO ()
                    {
                        ID = (int)UIGRIDVIEW_DETA.GetFocusedRowCellValue("ID"),
                        ID_PEDIDO = (int)UIGRIDVIEW_DETA.GetFocusedRowCellValue("ID_PEDIDO")
                    };
                    eliminardetalle(d);
                }
            }
        }

        #endregion

        private void UICD_ESTADO_EditValueChanged(object sender, EventArgs e)
        {
            if (char.Parse(UICD_ESTADO .EditValue.ToString()) == 'D')
            {
                UIGRIDVIEW_DETA.OptionsBehavior.Editable = true;
                UIGRIDVIEW_DETA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;

            }
            else
            {
                UIGRIDVIEW_DETA.OptionsBehavior.Editable = false;
                UIGRIDVIEW_DETA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
        }

        private void UIID_EditValueChanged(object sender, EventArgs e)
        {
            consultardetalle();
        }

        private void UIGID_ARTICULO_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter(); 
        }

        private void UIGRIDVIEW_DETA_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name .Equals( colID_ARTICULO.Name)) { 
              
                FAC_DETA_LISTA_PRECIO precio = (from u in _datasistema .ContextoVentas .FAC_DETA_LISTA_PRECIO where u.ID_ARTICULO  ==int.Parse (e.Value.ToString()) select u).First();
                UIGRIDVIEW_DETA.SetRowCellValue(e.RowHandle, colNM_PRECIO, precio.NM_PRECIO);
            }
        }
    }
}
