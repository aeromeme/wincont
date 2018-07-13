using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using System.Linq;
using InventarioDB;
using winCont.Clases.Metodoscompartidos;
using Sistema;
using winCont.Clases.Reportes;
using winCont.Reportes.Inventario;
using DevExpress.XtraEditors;

namespace winCont.Formularios.Inventario
{
    public partial class frm_ordencompra : winCont.Formularios.MasterFormTab,Interfaz_forms 
    {
        public List<V_INV_ENCA_ORDEN  > lista;
        public List<V_INV_ARTICULO> lista_articulos;
        public frm_ordencompra()
        {
            InitializeComponent();
        }
        public frm_ordencompra(DataSistema ds):base(ds)
        {
            InitializeComponent();
        }

        public void llenarcombo() {
            _datasistema.conectarSistema();
            UIID_TIPO_DOCUMENTO.Properties .DataSource  = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO where u.ID_EMPRESA == _datasistema.empresa.ID && u.CD_TIPO_DOCUMENTO =="ORD" select u).ToList();
            UIID_UBICACION_SOLI.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_UBICACION where u.ID_EMPRESA ==_datasistema.empresa.ID && u.CD_TIPO_UBICACION =='D' select u).ToList();
            UICD_ESTA_DOCUMENTO.Properties.DataSource = MetodosForm.listaEstadoOrdenCompra ();
            lista_articulos = (from u in _datasistema.ContextoInventario.V_INV_ARTICULO where u.ID_EMPRESA == _datasistema.empresa.ID select u).ToList();
            UIGID_ARTICULO.DataSource = lista_articulos;
            UIID_TERCERO.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_TERCERO where u.FLG_PROVEEDOR == 'S' && u.ID_EMPRESA == _datasistema.empresa.ID select u).ToList();
            UIID_TIPO_DOCUMENTO_SOLICITADO.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO where u.ID_EMPRESA == _datasistema.empresa.ID && (u.CD_TIPO_DOCUMENTO == "FAC" || u.CD_TIPO_DOCUMENTO =="CRE" || u.CD_TIPO_DOCUMENTO =="REC") select u).ToList();
            
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarInventario();
                lista = (from u in _datasistema.ContextoInventario.V_INV_ENCA_ORDEN where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_PERIODO == _datasistema.periodo.NM_PERIODO && u.NM_EJERCICIO == _datasistema.periodo.NM_EJERCICIO select u
                    ).ToList();
                llenarcombo();
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                if (lista.Count == 0)
                {
                    nuevo();
                }
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void nuevo()
        {
            UIID.Text = "";
            UIID_UBICACION_SOLI.EditValue = null;
            UIID_TIPO_DOCUMENTO.EditValue = null;
            UICD_SERIE.Text = "";
            UICD_NUMERO.Text = "";
            UIDS_REFERENCIA.Text = "";
            UIFE_FECHA.DateTime =DateTime.Now;
            UICD_ESTA_DOCUMENTO.EditValue ='D';
            UIID_TERCERO.EditValue = null;
            UIFLG_CREDITO.Checked = false;
            UIDS_OBSERVACION.Text = "";
            UIID_TIPO_DOCUMENTO_SOLICITADO.EditValue = null;
        }

        public void guardar()
        {
            if (!validar())
            {
                return;
            }
            if (UIID.Text == "")
            {  
                try
                {
                    SIS_TALONARIO t = SistemasMT.ObtenerTalonario(_datasistema ,(int)UIID_TIPO_DOCUMENTO .EditValue ,(int)UIID_UBICACION_SOLI .EditValue );
                    UICD_NUMERO.EditValue = t.NM_ACTUAL;
                    UICD_SERIE.Text = t.CD_SERIE;

                    INV_ENCA_ORDEN m = new INV_ENCA_ORDEN { ID = 0, CD_SERIE = UICD_SERIE.Text, CD_NUMERO = int.Parse(UICD_NUMERO.Text.ToString()), ID_UBICACION_SOLI = int.Parse(UIID_UBICACION_SOLI.EditValue.ToString()), ID_TIPO_DOCUMENTO = int.Parse(UIID_TIPO_DOCUMENTO.EditValue.ToString()), FE_FECHA = UIFE_FECHA.DateTime, DS_NOMBRE_SOLICITANTE = UIDS_NOMBRE_SOLICITANTE.Text, CD_ESTA_DOCUMENTO = char.Parse("D"), DS_REFERENCIA = UIDS_REFERENCIA.Text, NM_EJERCICIO = _datasistema.periodo.NM_EJERCICIO, NM_PERIODO = _datasistema.periodo.NM_PERIODO, ID_EMPRESA = _datasistema.empresa.ID,ID_TERCERO =(int)UIID_TERCERO .EditValue,FLG_CREDITO =(char) UIFLG_CREDITO .EditValue, ID_TIPO_DOCUMENTO_SOLICITADO =(int)UIID_TIPO_DOCUMENTO_SOLICITADO .EditValue,DS_OBSERVACION =UIDS_OBSERVACION .Text    };
                    _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoInventario.INV_ENCA_ORDEN.InsertOnSubmit(m);
                    _datasistema.ContextoInventario.SubmitChanges();
                    consultar();
                    MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
                }
                catch (Exception e)
                {

                    MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
                }
            }
            else {
                try
                {
                    INV_ENCA_ORDEN m = (from u in _datasistema.ContextoInventario.INV_ENCA_ORDEN
                                      where u.ID == int.Parse(UIID.Text)
                                      select u).First();

                    if (m.CD_ESTA_DOCUMENTO != 'D') {
                        return;
                    }
                    m.DS_NOMBRE_SOLICITANTE  = UIDS_NOMBRE_SOLICITANTE .Text ;
                    m.DS_REFERENCIA = UIDS_REFERENCIA.Text;
                    m.ID_TERCERO = (int)UIID_TERCERO.EditValue;
                    m.FLG_CREDITO = (char)UIFLG_CREDITO.EditValue;
                    m.ID_TIPO_DOCUMENTO_SOLICITADO = (int)UIID_TIPO_DOCUMENTO_SOLICITADO.EditValue;
                    m.DS_OBSERVACION = UIDS_OBSERVACION.Text;

                    _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoInventario.SubmitChanges();
                    consultar();
                    MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
                }
                catch (Exception e)
                {

                    MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
                }
            }
        
        }

        public void eliminar()
        {
            try
            {
                INV_ENCA_ORDEN m = (from u in _datasistema.ContextoInventario.INV_ENCA_ORDEN
                                where u.ID == int.Parse(UIID.Text)
                                select u).First();

                if (m.CD_ESTA_DOCUMENTO != 'D') {
                    return;
                }
                _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoInventario.INV_ENCA_ORDEN.DeleteOnSubmit(m);
                _datasistema.ContextoInventario.SubmitChanges();
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
                V_INV_ENCA_ORDEN  enca = (from u in _datasistema.ContextoInventario.V_INV_ENCA_ORDEN 
                                                  where u.ID == (int)UIID.EditValue
                                                  select u).First();
                List<V_INV_DETA_ORDEN > detas = (from u in _datasistema.ContextoInventario.V_INV_DETA_ORDEN 
                                                     where u.ID_ORDEN   == (int)UIID.EditValue
                                                     select u).ToList();
                cOrdenCompra data = new cOrdenCompra(enca, detas);

                rpt_ordencompra rpt = new rpt_ordencompra();
                List<cOrdenCompra> prpdata = new List<cOrdenCompra>();
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
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
            UIID_UBICACION_SOLI.DataBindings.Add("EditValue", lista, "ID_UBICACION_SOLI", false, DataSourceUpdateMode.Never);
            UIID_TIPO_DOCUMENTO.DataBindings.Add("EditValue", lista, "ID_TIPO_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UICD_SERIE.DataBindings.Add("EditValue", lista, "CD_SERIE", false, DataSourceUpdateMode.Never);
            UICD_NUMERO.DataBindings.Add("EditValue", lista, "CD_NUMERO", false, DataSourceUpdateMode.Never);
            UIDS_REFERENCIA.DataBindings.Add("EditValue", lista, "DS_REFERENCIA", false, DataSourceUpdateMode.Never);
            UIFE_FECHA.DataBindings.Add("EditValue", lista, "FE_FECHA", false, DataSourceUpdateMode.Never);
            UICD_ESTA_DOCUMENTO.DataBindings.Add("EditValue", lista, "CD_ESTA_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UIDS_NOMBRE_SOLICITANTE.DataBindings.Add("EditValue", lista, "DS_NOMBRE_SOLICITANTE", false, DataSourceUpdateMode.Never);
            UIID_TERCERO.DataBindings.Add("EditValue", lista, "ID_TERCERO", false, DataSourceUpdateMode.Never);
            UIFLG_CREDITO.DataBindings.Add("EditValue", lista, "FLG_CREDITO", false, DataSourceUpdateMode.Never);
            UIID_TIPO_DOCUMENTO_SOLICITADO .DataBindings.Add("EditValue", lista, "ID_TIPO_DOCUMENTO_SOLICITADO", false, DataSourceUpdateMode.Never);
            UIDS_OBSERVACION .DataBindings.Add("EditValue", lista, "DS_OBSERVACION", false, DataSourceUpdateMode.Never);

        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIID_UBICACION_SOLI.DataBindings.Clear();
            UIID_TIPO_DOCUMENTO.DataBindings.Clear();
            UICD_SERIE.DataBindings.Clear();
            UICD_NUMERO.DataBindings.Clear();
            UIDS_REFERENCIA.DataBindings.Clear();
            UIFE_FECHA.DataBindings.Clear();
            UICD_ESTA_DOCUMENTO.DataBindings.Clear();
            UIDS_NOMBRE_SOLICITANTE.DataBindings.Clear();
            UIID_TERCERO.DataBindings.Clear();
            UIFLG_CREDITO.DataBindings.Clear();
            UIID_TIPO_DOCUMENTO_SOLICITADO.DataBindings.Clear();
            UIDS_OBSERVACION.DataBindings.Clear();
        }
        public override void refrescar()
        {
            consultar();
        }

        public bool validar()
        {
            try
            {

                if (UIID_UBICACION_SOLI.EditValue == null) {
                    throw new Exception("Elija un solicitante");
                }
                if (UIID_TIPO_DOCUMENTO.EditValue == null) {
                    throw new Exception("Elija un documento");
                }
                if (UIID_TERCERO.EditValue == null) {
                    throw new Exception("Elija un proveedor");
                }
                if (UIID_TIPO_DOCUMENTO_SOLICITADO .EditValue == null) {
                    throw new Exception("Elija una documento solicitado");
                }
            }
            catch (Exception ex)
            {
                MetodosForm.mensajeErrorDefault(ex.Message,_datasistema );
                return false;
            }
            return true;
        }

        public override void enlazar_aux()
        {
            desenlazar();
            enlazar();
        }

        #region detalle
        System.ComponentModel.BindingList<V_INV_DETA_ORDEN   > lista_deta;
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
                _datasistema.conectarInventario();
                lista_deta = new System.ComponentModel.BindingList<V_INV_DETA_ORDEN>((from u in _datasistema.ContextoInventario.V_INV_DETA_ORDEN where u.ID_ORDEN  == int.Parse(UIID.Text) select u
                    ).ToList());

                lista_deta.AddingNew += list_AddinDeta;

                UIGRIDCONTROL_DETA.DataSource = lista_deta;


            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void insertardetalle(INV_DETA_ORDEN d)
        {
            try
            {
                _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoInventario.INV_DETA_ORDEN.InsertOnSubmit(d);
                _datasistema.ContextoInventario.SubmitChanges();
                int? error = 0;
                string msj = String.Empty;
                _datasistema.ContextoInventario.PR_INV_ACTU_DETA_ORDE_COMP(d.ID_ORDEN, _datasistema.empresa.ID, ref error , ref msj);
                if (error != 0) {
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

        public void modificardetalle(INV_DETA_ORDEN d)
        {
            try
            {
                INV_DETA_ORDEN tupla = (from u in _datasistema.ContextoInventario.INV_DETA_ORDEN 
                                             where u.ID == d.ID
                                             select u).First();
                tupla.ID_ARTICULO  = d.ID_ARTICULO ;
                tupla.NM_CANTIDAD = d.NM_CANTIDAD;
                tupla.NM_PRECIO = d.NM_PRECIO;
                _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoInventario.SubmitChanges();
                int? error = 0;
                string msj = String.Empty;
                _datasistema.ContextoInventario.PR_INV_ACTU_DETA_ORDE_COMP(tupla.ID_ORDEN, _datasistema.empresa.ID, ref error, ref msj);
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

        public void eliminardetalle(INV_DETA_ORDEN d)
        {

            try
            {
                INV_DETA_ORDEN tupla = (from u in _datasistema.ContextoInventario.INV_DETA_ORDEN 
                                             where u.ID == d.ID
                                             select u).First();
                _datasistema.ContextoInventario.INV_DETA_ORDEN.DeleteOnSubmit(tupla);
                _datasistema.ContextoInventario.SubmitChanges();
                int? error = 0;
                string msj = String.Empty;
                _datasistema.ContextoInventario.PR_INV_ACTU_DETA_ORDE_COMP(tupla.ID_ORDEN, _datasistema.empresa.ID, ref error, ref msj);
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
            e.NewObject = new V_INV_DETA_ORDEN();
        }


        private void UIGRIDVIEW_DETA_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID", 0);
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID_ORDEN", UIID.EditValue);
        }

        private void UIGRIDVIEW_DETA_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            V_INV_DETA_ORDEN v = (V_INV_DETA_ORDEN)e.Row;
            INV_DETA_ORDEN  d = new INV_DETA_ORDEN  { ID = v.ID, ID_ARTICULO = v.ID_ARTICULO, NM_CANTIDAD = v.NM_CANTIDAD, ID_ORDEN = v.ID_ORDEN ,NM_PRECIO =v.NM_PRECIO  };
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
            V_INV_DETA_ORDEN d = (V_INV_DETA_ORDEN)e.Row;
            if (d.ID_ARTICULO  == 0)
            {
                flgvalid = false;
                msjerror = "Seleccione un articulo";
                UIGRIDVIEW_DETA.SetColumnError(colID_ARTICULO , msjerror);
            }
            if (d.NM_CANTIDAD <= 0)
            {
                flgvalid = false;
                msjerror = "Digite una cantidad correcta";
                UIGRIDVIEW_DETA.SetColumnError(colNM_CANTIDAD , msjerror);
            }
            if (d.NM_PRECIO  <= 0)
            {
                flgvalid = false;
                msjerror = "Digite un precio correcta";
                UIGRIDVIEW_DETA.SetColumnError(colNM_PRECIO , msjerror);
            }
            e.Valid = flgvalid;
        }

        private void UIGRIDVIEW_DETA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && UIGRIDVIEW_DETA.FocusedRowHandle >= 0)
            {
                if (MetodosForm.preguntar(3))
                {
                    INV_DETA_ORDEN d = new INV_DETA_ORDEN()
                    {
                        ID = (int)UIGRIDVIEW_DETA.GetFocusedRowCellValue("ID")
                    };
                    eliminardetalle(d);
                }
            }
        }

        #endregion

        private void UIID_EditValueChanged(object sender, EventArgs e)
        {
            consultardetalle();
        }

        private void UICD_ESTA_DOCUMENTO_EditValueChanged(object sender, EventArgs e)
        {
            if (char.Parse(UICD_ESTA_DOCUMENTO.EditValue.ToString()) == 'D')
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

        private void UIGID_ARTICULO_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter(); 
        }

        private void uirbn_actualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                _datasistema.conectarInventario();
                INV_ENCA_ORDEN p = (from u in _datasistema.ContextoInventario.INV_ENCA_ORDEN where u.ID == int.Parse(UIID.Text) select u).First();

                if (p.CD_ESTA_DOCUMENTO == 'D')
                {

                   

                    if (MetodosForm.preguntar("¿Quiere actualizar la orden?"))
                    {
                        p.CD_ESTA_DOCUMENTO = 'A';
                        _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                        _datasistema.ContextoInventario.SubmitChanges();
                        consultar();
                        MetodosForm.seleccionarFila(uigridview, "ID", p.ID);
                    }

                }

            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }


    }
}
