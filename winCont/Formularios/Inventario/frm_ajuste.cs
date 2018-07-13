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
using winCont.Utilidades;
using winCont.Logica.Inventario;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Inventario
{
    public partial class frm_ajuste : winCont.Formularios.MasterFormTab,Interfaz_forms 
    {
        public List<V_INV_ENCA_AJUS > lista;
        public List<V_INV_ARTICULO> lista_articulos;
        public SIS_DOCUMENTO doc;

        ManejadorArticulo manejadorArticulos;
        ManejadorRequerimiento manejadorRequerimiento;
        ManejadorAjuste manejadorAjuste;
        ManejadorDocumento manejadorDocumento;
        ManejadorUbicacion manejadorUbicacion;
        ManejadorDetalleAjuste manejadorDetalleAjuste;

        public frm_ajuste()
        {
            InitializeComponent();
        }
        public frm_ajuste(DataSistema ds):base(ds)
        {
            InitializeComponent();
        }

        public void llenarcombo() {
            _datasistema.conectarSistema();
            //UIID_TIPO_DOCUMENTO.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO where u.ID_EMPRESA == _datasistema.empresa.ID && (u.CD_TIPO_DOCUMENTO == "AJS" || u.CD_TIPO_DOCUMENTO == "AJE" || u.CD_TIPO_DOCUMENTO == "PRO") select u).ToList();
            UIID_TIPO_DOCUMENTO.Properties.DataSource = manejadorDocumento.consultarPorEmpresaYTipoAjuste(_datasistema.empresa.ID);

            //UIID_UBICACION_BODEGA.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_UBICACION where u.ID_EMPRESA ==_datasistema.empresa.ID && u.CD_TIPO_UBICACION =='B' select u).ToList();
            UIID_UBICACION_BODEGA.Properties.DataSource = manejadorUbicacion.consultarPorIdEmpresaYTipo(_datasistema.empresa.ID, 'B');

            UICD_ESTA_DOCUMENTO.Properties.DataSource = MetodosForm.listaEstadoRequisicion();

            //lista_articulos = (from u in _datasistema.ContextoInventario.V_INV_ARTICULO where u.ID_EMPRESA == _datasistema.empresa.ID && u.FLG_INVENTARIABLE =='S' select u).ToList();
            lista_articulos = manejadorArticulos.consultarVistaPorIdEmpresaInventariable(_datasistema.empresa.ID, 'S');

            UIGID_ARTICULO.DataSource = lista_articulos;
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarInventario();
                //lista = (from u in _datasistema.ContextoInventario.V_INV_ENCA_AJUS where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_PERIODO ==_datasistema .periodo .NM_PERIODO && u.NM_EJERCICIO ==_datasistema .periodo .NM_EJERCICIO  select u
                //    ).ToList();
                lista = manejadorAjuste.consultarVistaPorIdEmpresaPeriodo(_datasistema.empresa.ID, _datasistema.periodo);
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
            UIID_UBICACION_BODEGA.EditValue = null;
            UIID_TIPO_DOCUMENTO.EditValue = null;
            UICD_SERIE.Text = "";
            UICD_NUMERO.Text = "";
            UIDS_REFERENCIA.Text = "";
            UIFE_FECHA.DateTime =DateTime.Now;
            UICD_ESTA_DOCUMENTO.EditValue =' ';
        }

        public void guardar()
        {
            if (UIID_TIPO_DOCUMENTO.EditValue == null)
            {
                return;
            }
            if (UIID_UBICACION_BODEGA.EditValue == null)
            {
                return;
            }
            INV_ENCA_AJUS m = new INV_ENCA_AJUS { ID = 0, CD_SERIE = UICD_SERIE.Text, CD_NUMERO = int.Parse(UICD_NUMERO.Text.ToString()), ID_UBICACION_BODEGA = int.Parse(UIID_UBICACION_BODEGA.EditValue.ToString()), ID_TIPO_DOCUMENTO = int.Parse(UIID_TIPO_DOCUMENTO.EditValue.ToString()), FE_FECHA = UIFE_FECHA.DateTime, DS_NOMBRE_PROCESADOR = UIDS_NOMBRE_PROCESADOR.Text, CD_ESTA_DOCUMENTO = char.Parse("D"), DS_REFERENCIA = UIDS_REFERENCIA.Text, NM_EJERCICIO = _datasistema.periodo.NM_EJERCICIO, NM_PERIODO = _datasistema.periodo.NM_PERIODO, ID_EMPRESA = _datasistema.empresa.ID };
            if (UIID.Text == "")
            {  
                try
                {
                    SIS_TALONARIO t = SistemasMT.ObtenerTalonario(_datasistema ,(int)UIID_TIPO_DOCUMENTO .EditValue ,(int)UIID_UBICACION_BODEGA .EditValue );
                    UICD_NUMERO.EditValue = t.NM_ACTUAL;
                    UICD_SERIE.Text = t.CD_SERIE;

                    m=manejadorAjuste.insertar(m);
                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.INV_ENCA_AJUS.InsertOnSubmit(m);
                    //_datasistema.ContextoInventario.SubmitChanges();
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
                    //INV_ENCA_AJUS m = (from u in _datasistema.ContextoInventario.INV_ENCA_AJUS
                    //                  where u.ID == int.Parse(UIID.Text)
                    //                  select u).First();
                    m.ID = int.Parse(UIID.Text);
                    //if (m.CD_ESTA_DOCUMENTO != 'D')
                    //{
                    //    return;
                    //}
                    m.DS_NOMBRE_PROCESADOR  = UIDS_NOMBRE_PROCESADOR .Text ;
                    m.DS_REFERENCIA = UIDS_REFERENCIA.Text;
                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    manejadorAjuste.modificar(m);
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
                INV_ENCA_AJUS m = new INV_ENCA_AJUS { ID = int.Parse (UIID.Text ), NM_EJERCICIO = _datasistema.periodo.NM_EJERCICIO, NM_PERIODO = _datasistema.periodo.NM_PERIODO, ID_EMPRESA = _datasistema.empresa.ID };
                //INV_ENCA_AJUS m = (from u in _datasistema.ContextoInventario.INV_ENCA_AJUS
                //                where u.ID == int.Parse(UIID.Text)
                //                select u).First();

                //if (m.CD_ESTA_DOCUMENTO != 'D') {
                //    return;
                //}
                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.INV_ENCA_AJUS.DeleteOnSubmit(m);
                //_datasistema.ContextoInventario.SubmitChanges();
                manejadorAjuste.eliminar(m);
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
                //V_INV_ENCA_AJUS enca = (from u in _datasistema.ContextoInventario.V_INV_ENCA_AJUS
                //                       where u.ID == (int)UIID.EditValue
                //                       select u).First();

                V_INV_ENCA_AJUS enca = manejadorAjuste.consultarVistaPorId(int.Parse(UIID.Text));
                //List<V_INV_DETA_AJUS> detas = (from u in _datasistema.ContextoInventario.V_INV_DETA_AJUS
                //                              where u.ID_AJUS == (int)UIID.EditValue
                //                              select u).ToList();
                List<V_INV_DETA_AJUS> detas = manejadorDetalleAjuste .consultarVistaPorIdEnca (int.Parse (UIID.Text ));
                cAjuste data = new cAjuste(enca, detas);

                rpt_ajuste rpt = new rpt_ajuste();
                List<cAjuste> prpdata = new List<cAjuste>();
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
            UIID_UBICACION_BODEGA.DataBindings.Add("EditValue", lista, "ID_UBICACION_BODEGA", false, DataSourceUpdateMode.Never);
            UIID_TIPO_DOCUMENTO.DataBindings.Add("EditValue", lista, "ID_TIPO_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UICD_SERIE.DataBindings.Add("EditValue", lista, "CD_SERIE", false, DataSourceUpdateMode.Never);
            UICD_NUMERO.DataBindings.Add("EditValue", lista, "CD_NUMERO", false, DataSourceUpdateMode.Never);
            UIDS_REFERENCIA.DataBindings.Add("EditValue", lista, "DS_REFERENCIA", false, DataSourceUpdateMode.Never);
            UIFE_FECHA.DataBindings.Add("EditValue", lista, "FE_FECHA", false, DataSourceUpdateMode.Never);
            UICD_ESTA_DOCUMENTO.DataBindings.Add("EditValue", lista, "CD_ESTA_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UIDS_NOMBRE_PROCESADOR.DataBindings.Add("EditValue", lista, "DS_NOMBRE_PROCESADOR", false, DataSourceUpdateMode.Never);

        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIID_UBICACION_BODEGA.DataBindings.Clear();
            UIID_TIPO_DOCUMENTO.DataBindings.Clear();
            UICD_SERIE.DataBindings.Clear();
            UICD_NUMERO.DataBindings.Clear();
            UIDS_REFERENCIA.DataBindings.Clear();
            UIFE_FECHA.DataBindings.Clear();
            UICD_ESTA_DOCUMENTO.DataBindings.Clear();
            UIDS_NOMBRE_PROCESADOR.DataBindings.Clear();
        }
        public override void refrescar()
        {
            consultar();
        }

        public bool validar()
        {
            return true;
        }

        public override void enlazar_aux()
        {
            desenlazar();
            enlazar();
        }

        #region detalle
        System.ComponentModel.BindingList<V_INV_DETA_AJUS  > lista_deta;
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
                //lista_deta = new System.ComponentModel.BindingList<V_INV_DETA_AJUS>((from u in _datasistema.ContextoInventario .V_INV_DETA_AJUS where u.ID_AJUS  == int.Parse(UIID.Text) select u
                //    ).ToList());

                lista_deta = new System.ComponentModel.BindingList<V_INV_DETA_AJUS>(manejadorDetalleAjuste .consultarVistaPorIdEnca (int.Parse (UIID.Text )));

                lista_deta.AddingNew += list_AddinDeta;

                UIGRIDCONTROL_DETA.DataSource = lista_deta;


            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void insertardetalle(INV_DETA_AJUS  d)
        {
            try
            {
                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.INV_DETA_AJUS.InsertOnSubmit(d);
                //_datasistema.ContextoInventario.SubmitChanges();
                manejadorDetalleAjuste.insertar(d);
                consultardetalle();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }

        }

        public void modificardetalle(INV_DETA_AJUS  d)
        {
            try
            {
                //INV_DETA_AJUS tupla = (from u in _datasistema.ContextoInventario.INV_DETA_AJUS 
                //                             where u.ID == d.ID
                //                             select u).First();
                //tupla.ID_ARTICULO  = d.ID_ARTICULO ;
                //tupla.NM_CANTIDAD = d.NM_CANTIDAD;
                //tupla.NM_PRECIO = d.NM_PRECIO;
                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.SubmitChanges();
                manejadorDetalleAjuste.modificar(d);
                consultardetalle();

            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }
        }

        public void eliminardetalle(INV_DETA_AJUS   d)
        {

            try
            {
                //INV_DETA_AJUS tupla = (from u in _datasistema.ContextoInventario.INV_DETA_AJUS 
                //                             where u.ID == d.ID
                //                             select u).First();
                //_datasistema.ContextoInventario.INV_DETA_AJUS.DeleteOnSubmit(tupla);
                //_datasistema.ContextoInventario.SubmitChanges();

                manejadorDetalleAjuste.eliminar(d);

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
            e.NewObject = new V_INV_DETA_AJUS();
        }


        private void UIGRIDVIEW_DETA_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID", 0);
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID_AJUS", UIID.EditValue);
        }

        private void UIGRIDVIEW_DETA_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            V_INV_DETA_AJUS v = (V_INV_DETA_AJUS)e.Row;
            INV_DETA_AJUS d = new INV_DETA_AJUS { ID = v.ID, ID_ARTICULO = v.ID_ARTICULO, NM_CANTIDAD = v.NM_CANTIDAD, ID_AJUS = v.ID_AJUS,NM_PRECIO =v.NM_PRECIO  };
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
            V_INV_DETA_AJUS d = (V_INV_DETA_AJUS)e.Row;
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
            e.Valid = flgvalid;
        }

        private void UIGRIDVIEW_DETA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && UIGRIDVIEW_DETA.FocusedRowHandle >= 0)
            {
                if (MetodosForm.preguntar(3))
                {
                    INV_DETA_AJUS d = new INV_DETA_AJUS()
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

            if (doc.CD_TIPO_DOCUMENTO == "AJS")
            {
                procesarSalida();
            }
            else
            {
                procesarEntrada();
            }
        }

        private void UIID_TIPO_DOCUMENTO_EditValueChanged(object sender, EventArgs e)
        {
            if (uigridview.FocusedRowHandle < 0)
            {
                return;
            }
            V_INV_ENCA_AJUS v = (V_INV_ENCA_AJUS)uigridview.GetFocusedRow();

            doc=(from u in _datasistema .contextoSistema.SIS_DOCUMENTO where u.ID ==v.ID_TIPO_DOCUMENTO  select u).First ();

            if (doc.CD_TIPO_DOCUMENTO == "AJS")
            {
                colNM_PRECIO.Visible = false;
            }
            else {
                colNM_PRECIO.Visible = true;
            }
       
        }

        public void procesarSalida() {
            try
            {
                if (uigridview.FocusedRowHandle < 0)
                {
                    return;
                }
                _datasistema.conectarInventario();
                INV_ENCA_AJUS p = (from u in _datasistema.ContextoInventario.INV_ENCA_AJUS where u.ID == int.Parse(UIID.Text) select u).First();
                if (p.CD_ESTA_DOCUMENTO == 'D')
                {
                    if (MetodosForm.preguntar("¿Quiere efectuar la salida?"))
                    {

                        foreach (var item in lista_deta)
                        {
                            try
                            {
                                INV_ARTICULO art = (from u in _datasistema.ContextoInventario.INV_ARTICULO where u.ID == item.ID_ARTICULO select u).First();
                                if ((from u in _datasistema.ContextoInventario.INV_EXISTENCIA
                                     where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_EJERCICIO == _datasistema.periodo.NM_EJERCICIO && u.NM_PERIODO == _datasistema.periodo.NM_PERIODO && u.ID_BODEGA == p.ID_UBICACION_BODEGA  && u.ID_ARTICULO == item.ID_ARTICULO 
                                     select u).Count() <= 0 && art.FLG_INVENTARIABLE =='S')
                                {
                                    MetodosForm.mensajeInfo("Revisar", "No hay existencias del " + item.DS_NOMBRE + " para despacharlo", _datasistema);
                                    return;
                                }

                                INV_EXISTENCIA exist = (from u in _datasistema.ContextoInventario.INV_EXISTENCIA
                                                        where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_EJERCICIO == _datasistema.periodo.NM_EJERCICIO && u.NM_PERIODO == _datasistema.periodo.NM_PERIODO && u.ID_BODEGA == p.ID_UBICACION_BODEGA  && u.ID_ARTICULO == item.ID_ARTICULO 
                                                        select u).First();
                                if (exist.NM_CANT_ACTUAL < item.NM_CANTIDAD && art.FLG_INVENTARIABLE =='S')
                                {
                                    MetodosForm.mensajeInfo("Revisar", "No hay suficiente existencia del " + item.DS_NOMBRE + " para despacharlo", _datasistema);
                                    return;
                                }
                                //INV_DETA_AJUS req = (from u in _datasistema.ContextoInventario.INV_DETA_AJUS
                                //                    where u.ID == item.ID_DETA_AJUS
                                //                    select u).First();
                                //if (item.NM_CANTIDAD > req.NM_CANTIDAD - req.NM_CANT_DESP && item.FLG_DESP != 'S')
                                //{
                                //    MetodosForm.mensajeInfo("Revisar", "El articulo " + item.DS_NOMBRE + " solo tiene pendiente de despachar " + (req.NM_CANTIDAD - req.NM_CANT_DESP).ToString(), _datasistema);
                                //    return;
                                //}

                            }
                            catch (Exception except)
                            {

                                MetodosForm.mensajeErrorDefault(except.Message, _datasistema);
                                return;
                            }


                        }

                        foreach (var item in lista_deta)
                        {
                            if (item.FLG_PROC != 'S')
                            {
                                INV_ARTICULO art = (from u in _datasistema.ContextoInventario.INV_ARTICULO where u.ID == item.ID_ARTICULO select u).First();
                                int? error = 0;
                                string msj = string.Empty;
                                if (art.FLG_INVENTARIABLE == 'S') {
                                    _datasistema.ContextoInventario.PR_INV_PROC_DESPACHO(_datasistema.empresa.ID, p.ID_UBICACION_BODEGA, p.NM_EJERCICIO, p.NM_PERIODO, item.ID_ARTICULO, item.NM_CANTIDAD, p.ID, p.ID_TIPO_DOCUMENTO, p.CD_SERIE + p.CD_NUMERO.ToString(), ref error, ref msj);
                                }
                                
                                if (error == 0)
                                {
                                    INV_DETA_AJUS d = (from u in _datasistema.ContextoInventario.INV_DETA_AJUS
                                                       where u.ID == item.ID
                                                       select u).First();
                                    d.FLG_PROC = 'S';
                                    _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                                    _datasistema.ContextoInventario.SubmitChanges();

                                }

                            }
                        }

                        if ((from u in _datasistema.ContextoInventario.INV_DETA_AJUS
                             where u.ID_AJUS == p.ID && u.FLG_PROC != 'S'
                             select u).Count() > 0)
                        {
                            MetodosForm.mensajeErrorDefault("Hay productos que no salieron", _datasistema);
                            return;
                        }
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

        public void procesarEntrada() {
            try
            {
                if (uigridview.FocusedRowHandle < 0)
                {
                    return;
                }
                _datasistema.conectarInventario();
                INV_ENCA_AJUS p = (from u in _datasistema.ContextoInventario.INV_ENCA_AJUS where u.ID == int.Parse(UIID.Text) select u).First();
                if (p.CD_ESTA_DOCUMENTO == 'D')
                {
                    if (MetodosForm.preguntar("¿Quiere efectuar la entrada?"))
                    {

                        foreach (var item in lista_deta)
                        {
                            if (item.FLG_PROC != 'S')
                            {
                                INV_ARTICULO art = (from u in _datasistema.ContextoInventario.INV_ARTICULO where u.ID == item.ID_ARTICULO select u).First();
                                int? error = 0;
                                string msj = string.Empty;
                                if (art.FLG_INVENTARIABLE == 'S') {
                                    _datasistema.ContextoInventario.PR_INV_PROC_INGRESO(_datasistema.empresa.ID, p.ID_UBICACION_BODEGA, p.NM_EJERCICIO, p.NM_PERIODO, item.ID_ARTICULO, item.NM_CANTIDAD, item.NM_PRECIO, p.ID, p.ID_TIPO_DOCUMENTO, p.CD_SERIE + p.CD_NUMERO.ToString(), ref error, ref msj);
                                }
                               
                                if (error == 0)
                                {
                                    INV_DETA_AJUS d = (from u in _datasistema.ContextoInventario.INV_DETA_AJUS
                                                       where u.ID == item.ID
                                                       select u).First();
                                    //INV_DETA_ORDEN r = (from u in _datasistema.ContextoInventario.INV_DETA_ORDEN
                                    //                    where u.ID == item.ID_DETA_ORDEN
                                    //                    select u).First();
                                    d.FLG_PROC = 'S';
                                    //r.NM_CANT_RECIBIDA = r.NM_CANT_RECIBIDA + item.NM_CANTIDAD;
                                    _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                                    _datasistema.ContextoInventario.SubmitChanges();

                                }

                            }
                        }

                        if ((from u in _datasistema.ContextoInventario.INV_DETA_AJUS
                             where u.ID_AJUS == p.ID && u.FLG_PROC != 'S'
                             select u).Count() > 0)
                        {
                            MetodosForm.mensajeErrorDefault("Hay productos que no entraron", _datasistema);
                            return;
                        }
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
