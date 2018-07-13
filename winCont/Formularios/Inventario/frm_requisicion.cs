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
    public partial class frm_requisicion : winCont.Formularios.MasterFormTab,Interfaz_forms 
    {
        public List<V_INV_ENCA_REQ > lista;
        public List<V_INV_ARTICULO> lista_articulos;

        ManejadorArticulo manejadorArticulos;
        ManejadorRequerimiento manejadorRequerimiento;
        ManejadorDocumento manejadorDocumento;
        ManejadorUbicacion manejadorUbicacion;
        ManejadorDetalleRequerimiento manejadorDetalleRequirimiento;
       
        public frm_requisicion()
        {
            InitializeComponent();
        }
        public frm_requisicion(DataSistema ds):base(ds)
        {
            InitializeComponent();
             manejadorArticulos= new ManejadorArticulo(ds);
             manejadorRequerimiento= new ManejadorRequerimiento(ds);
             manejadorDocumento= new ManejadorDocumento(ds);
             manejadorUbicacion= new ManejadorUbicacion(ds);
             manejadorDetalleRequirimiento= new ManejadorDetalleRequerimiento(ds);
        }

        public void llenarcombo() {
            _datasistema.conectarSistema();
            //UIID_TIPO_DOCUMENTO.Properties .DataSource  = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO where u.ID_EMPRESA == _datasistema.empresa.ID && u.CD_TIPO_DOCUMENTO =="REQ" select u).ToList();
            UIID_TIPO_DOCUMENTO.Properties.DataSource = manejadorDocumento.consultarPorEmpresaYTipo(_datasistema.empresa.ID, "REQ");
            //UIID_UBICACION_SOLI.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_UBICACION where u.ID_EMPRESA ==_datasistema.empresa.ID && u.CD_TIPO_UBICACION =='D' select u).ToList();
            UIID_UBICACION_SOLI.Properties.DataSource = manejadorUbicacion.consultarPorIdEmpresaYTipo(_datasistema.empresa.ID,'D');
           
            UICD_ESTA_DOCUMENTO.Properties.DataSource = MetodosForm.listaEstadoRequisicion();
            
            //lista_articulos = (from u in _datasistema.ContextoInventario.V_INV_ARTICULO where u.ID_EMPRESA == _datasistema.empresa.ID && u.FLG_INVENTARIABLE =='S' select u).ToList();

            lista_articulos = manejadorArticulos.consultarVistaPorIdEmpresaInventariable(_datasistema.empresa.ID, 'S');

            UIGID_ARTICULO.DataSource = lista_articulos;
        }

        public void consultar()
        {
            try
            {
                //_datasistema.conectarInventario();
                //lista = (from u in _datasistema.ContextoInventario.V_INV_ENCA_REQ where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_PERIODO ==_datasistema .periodo .NM_PERIODO && u.NM_EJERCICIO ==_datasistema .periodo .NM_EJERCICIO  select u
                //    ).ToList();
                lista = manejadorRequerimiento.consultarVistaPorIdEmpresaPeriodo(_datasistema.empresa.ID, _datasistema.periodo);
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
            UICD_ESTA_DOCUMENTO.EditValue =' ';
        }

        public void guardar()
        {
            if (!validar())
            {
                return;
            }
            try
                {
            INV_ENCA_REQ m = new INV_ENCA_REQ { ID = 0, CD_SERIE ="", CD_NUMERO = 0, ID_UBICACION_SOLI = int.Parse(UIID_UBICACION_SOLI.EditValue.ToString()), ID_TIPO_DOCUMENTO = int.Parse(UIID_TIPO_DOCUMENTO.EditValue.ToString()), FE_FECHA = UIFE_FECHA.DateTime, DS_NOMBRE_SOLICITANTE = UIDS_NOMBRE_SOLICITANTE.Text, CD_ESTA_DOCUMENTO = char.Parse("D"), DS_REFERENCIA = UIDS_REFERENCIA.Text, NM_EJERCICIO = _datasistema.periodo.NM_EJERCICIO, NM_PERIODO = _datasistema.periodo.NM_PERIODO, ID_EMPRESA = _datasistema.empresa.ID };
            if (UIID.Text == "")
            {  
                SIS_TALONARIO t = SistemasMT.ObtenerTalonario(_datasistema ,(int)UIID_TIPO_DOCUMENTO .EditValue ,(int)UIID_UBICACION_SOLI .EditValue );
                UICD_NUMERO.EditValue = t.NM_ACTUAL;
                UICD_SERIE.Text = t.CD_SERIE; 
                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.INV_ENCA_REQ.InsertOnSubmit(m);
                //_datasistema.ContextoInventario.SubmitChanges();
                m=manejadorRequerimiento.insertar(m);
                consultar();
                MetodosForm.seleccionarFila(uigridview, "ID", m.ID);   
            }
            else {
            
                //INV_ENCA_REQ m = (from u in _datasistema.ContextoInventario.INV_ENCA_REQ
                //                  where u.ID == int.Parse(UIID.Text)
                //                  select u).First();
                //if (m.CD_ESTA_DOCUMENTO != 'D')
                //{
                //    return;
                //}
                //m.DS_NOMBRE_SOLICITANTE  = UIDS_NOMBRE_SOLICITANTE .Text ;
                //m.DS_REFERENCIA = UIDS_REFERENCIA.Text;
                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.SubmitChanges();
                m.ID = int.Parse(UIID.Text);
                m.CD_NUMERO = int.Parse(UICD_NUMERO.Text.ToString());
                m.CD_SERIE = UICD_SERIE.Text;
                manejadorRequerimiento.modificar(m);
                consultar();
                MetodosForm.seleccionarFila(uigridview, "ID", m.ID);      
            }
                }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        
        }

        public void eliminar()
        {
            try
            {
                INV_ENCA_REQ m = new INV_ENCA_REQ { ID = 0, CD_SERIE = UICD_SERIE.Text, CD_NUMERO = int.Parse(UICD_NUMERO.Text.ToString()), ID_UBICACION_SOLI = int.Parse(UIID_UBICACION_SOLI.EditValue.ToString()), ID_TIPO_DOCUMENTO = int.Parse(UIID_TIPO_DOCUMENTO.EditValue.ToString()), FE_FECHA = UIFE_FECHA.DateTime, DS_NOMBRE_SOLICITANTE = UIDS_NOMBRE_SOLICITANTE.Text, CD_ESTA_DOCUMENTO = char.Parse("D"), DS_REFERENCIA = UIDS_REFERENCIA.Text, NM_EJERCICIO = _datasistema.periodo.NM_EJERCICIO, NM_PERIODO = _datasistema.periodo.NM_PERIODO, ID_EMPRESA = _datasistema.empresa.ID };
                //INV_ENCA_REQ m = (from u in _datasistema.ContextoInventario.INV_ENCA_REQ
                //                where u.ID == int.Parse(UIID.Text)
                //                select u).First();
                if (m.CD_ESTA_DOCUMENTO != 'D') {
                    return;
                }
                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.INV_ENCA_REQ.DeleteOnSubmit(m);
                //_datasistema.ContextoInventario.SubmitChanges();
                manejadorRequerimiento.eliminar(m);
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
                //V_INV_ENCA_REQ enca = (from u in _datasistema.ContextoInventario.V_INV_ENCA_REQ 
                //                                  where u.ID == (int)UIID.EditValue
                //                                  select u).First();
                V_INV_ENCA_REQ enca = manejadorRequerimiento.consultarVistaPorId(int.Parse(UIID.Text)); 

                //List<V_INV_DETA_REQ> detas = (from u in _datasistema.ContextoInventario.V_INV_DETA_REQ
                //                                     where u.ID_REQ  == (int)UIID.EditValue
                //                                     select u).ToList();
                List<V_INV_DETA_REQ> detas = manejadorDetalleRequirimiento.consultarVistaPorIdEnca(int.Parse(UIID.Text));
                cRequisicion data = new cRequisicion(enca, detas);

                rpt_requisicion rpt = new rpt_requisicion();
                List<cRequisicion> prpdata = new List<cRequisicion>();
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
        }
        public override void refrescar()
        {
            consultar();
        }

        public bool validar()
        {
            try
            {

                if (UIID_UBICACION_SOLI.EditValue == null)
                {
                    throw new Exception("Elija quien solicita");
                }
                if (UIID_TIPO_DOCUMENTO.EditValue == null)
                {
                    throw new Exception("Elija un documento");
                }
                
            }
            catch (Exception ex)
            {
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
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
        System.ComponentModel.BindingList<V_INV_DETA_REQ  > lista_deta;
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
                lista_deta = new System.ComponentModel.BindingList<V_INV_DETA_REQ>((from u in _datasistema.ContextoInventario .V_INV_DETA_REQ where u.ID_REQ  == int.Parse(UIID.Text) select u
                    ).ToList());

                lista_deta.AddingNew += list_AddinDeta;

                UIGRIDCONTROL_DETA.DataSource = lista_deta;


            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void insertardetalle(INV_DETA_REQ  d)
        {
            try
            {
                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.INV_DETA_REQ .InsertOnSubmit(d);
                //_datasistema.ContextoInventario.SubmitChanges();
                manejadorDetalleRequirimiento.insertar(d);
                consultardetalle();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }

        }

        public void modificardetalle(INV_DETA_REQ  d)
        {
            try
            {
                //INV_DETA_REQ tupla = (from u in _datasistema.ContextoInventario.INV_DETA_REQ 
                //                             where u.ID == d.ID
                //                             select u).First();
                //tupla.ID_ARTICULO  = d.ID_ARTICULO ;
                //tupla.NM_CANTIDAD = d.NM_CANTIDAD;
                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.SubmitChanges();
                manejadorDetalleRequirimiento.modificar(d);
                consultardetalle();

            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }
        }

        public void eliminardetalle(INV_DETA_REQ  d)
        {

            try
            {
                //INV_DETA_REQ tupla = (from u in _datasistema.ContextoInventario.INV_DETA_REQ 
                //                             where u.ID == d.ID
                //                             select u).First();
                //_datasistema.ContextoInventario.INV_DETA_REQ .DeleteOnSubmit(tupla);
                //_datasistema.ContextoInventario.SubmitChanges();
                manejadorDetalleRequirimiento.eliminar(d);
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
            e.NewObject = new V_INV_DETA_REQ();
        }


        private void UIGRIDVIEW_DETA_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID", 0);
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID_REQ", UIID.EditValue);
        }

        private void UIGRIDVIEW_DETA_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            V_INV_DETA_REQ v = (V_INV_DETA_REQ)e.Row;
            INV_DETA_REQ d = new INV_DETA_REQ { ID = v.ID, ID_ARTICULO = v.ID_ARTICULO, NM_CANTIDAD = v.NM_CANTIDAD, ID_REQ = v.ID_REQ };
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
            V_INV_DETA_REQ d = (V_INV_DETA_REQ)e.Row;
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
                    INV_DETA_REQ d = new INV_DETA_REQ()
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
                INV_ENCA_REQ p = (from u in _datasistema.ContextoInventario .INV_ENCA_REQ where u.ID == int.Parse(UIID.Text) select u).First();

                if (p.CD_ESTA_DOCUMENTO == 'D')
                {

                   

                    if (MetodosForm.preguntar("¿Quiere actualizar la requisicion?"))
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
