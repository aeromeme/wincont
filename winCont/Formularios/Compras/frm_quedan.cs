using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComprasDB;
using winCont.Utilidades;
using Sistema;
using System.Linq;
using winCont.Clases.Metodoscompartidos;
using winCont.Clases.Reportes;
using winCont.Reportes.Compras ;


namespace winCont.Formularios.Compras
{
    public partial class frm_quedan : winCont.Formularios.MasterFormTab,Interfaz_forms
    {
        public List<V_COMP_QUEDAN > lista;
        public frm_quedan()
        {
            InitializeComponent();
        }
        public frm_quedan(DataSistema ds):base(ds)
        {
            InitializeComponent();
        }

        public void llenarcombo()
        {
            _datasistema.conectarSistema();
            UIID_TIPO_DOCUMENTO.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO where u.ID_EMPRESA == _datasistema.empresa.ID && u.CD_TIPO_DOCUMENTO == "QUE" select u).ToList();
            UIID_UBICACION_DEPT.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_UBICACION where u.ID_EMPRESA == _datasistema.empresa.ID && u.CD_TIPO_UBICACION == 'D' select u).ToList();
            UICD_ESTADO.Properties.DataSource = MetodosForm.listaEstadoQuedan();
            UIID_TERCERO.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_TERCERO where u.FLG_PROVEEDOR == 'S' && u.ID_EMPRESA == _datasistema.empresa.ID select u).ToList();
        }
        public void consultar()
        {
            try
            {
                _datasistema.conectarCompras();
                _datasistema.conectarSistema();
                lista = (from u in _datasistema.ContextoCompras.V_COMP_QUEDAN where u.ID_EMPRESA == _datasistema.empresa.ID select u
                    ).ToList();
                llenarcombo();
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                if (lista.Count() == 0)
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
            desenlazar();
            UIID.Text = "";
            UIFE_FECHA.DateTime = DateTime.Now;
            UIID_TERCERO.EditValue = null;
            UIID_UBICACION_DEPT.EditValue = null;
            UIID_TIPO_DOCUMENTO.EditValue = null;
            UICD_SERIE.Text = "";
            UICD_NUMERO.Text = "";
            UICD_ESTADO.EditValue = 'D';
        }

        public void guardar()
        {
            if (UIID_TIPO_DOCUMENTO.EditValue == null)
            {
                return;
            }
            if (UIID_UBICACION_DEPT.EditValue == null)
            {
                return;
            }
            if (UIID_TERCERO.EditValue == null)
            {
                return;
            }
            if (UIID.Text == "")
            {
                try
                {
                    SIS_TALONARIO t = SistemasMT.ObtenerTalonario(_datasistema, (int)UIID_TIPO_DOCUMENTO.EditValue, (int)UIID_UBICACION_DEPT.EditValue);
                    UICD_NUMERO.EditValue = t.NM_ACTUAL;
                    UICD_SERIE.Text = t.CD_SERIE;

                    COMP_QUEDAN m = new COMP_QUEDAN { ID = 0, CD_SERIE = UICD_SERIE.Text, CD_NUMERO = int.Parse(UICD_NUMERO.Text.ToString()), ID_UBICACION_DEPT = int.Parse(UIID_UBICACION_DEPT.EditValue.ToString()), ID_TIPO_DOCUMENTO = int.Parse(UIID_TIPO_DOCUMENTO.EditValue.ToString()), FE_FECHA = DateTime.Now , CD_ESTADO = char.Parse("D"), NM_EJERCICIO = _datasistema.periodo.NM_EJERCICIO, NM_PERIODO = _datasistema.periodo.NM_PERIODO, ID_EMPRESA = _datasistema.empresa.ID, ID_TERCERO = (int)UIID_TERCERO.EditValue };
                    _datasistema.ContextoCompras.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoCompras.COMP_QUEDAN.InsertOnSubmit(m);
                    _datasistema.ContextoCompras.SubmitChanges();
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
                    COMP_QUEDAN m = (from u in _datasistema.ContextoCompras.COMP_QUEDAN
                                        where u.ID == int.Parse(UIID.Text)
                                        select u).First();

                    if (m.CD_ESTADO != 'D')
                    {
                        return;
                    }
                   
                    _datasistema.ContextoCompras.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoCompras.SubmitChanges();
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
                COMP_QUEDAN m = (from u in _datasistema.ContextoCompras.COMP_QUEDAN
                                    where u.ID == int.Parse(UIID.Text)
                                    select u).First();

                if (m.CD_ESTADO != 'D')
                {
                    return;
                }
                _datasistema.ContextoCompras.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoCompras.COMP_QUEDAN.DeleteOnSubmit(m);
                _datasistema.ContextoCompras.SubmitChanges();
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
                V_COMP_QUEDAN  enca = (from u in _datasistema.ContextoCompras .V_COMP_QUEDAN 
                                        where u.ID == (int)UIID.EditValue
                                        select u).First();
                List<V_COMP_DETA_QUEDAN> detas = (from u in _datasistema.ContextoCompras.V_COMP_DETA_QUEDAN 
                                               where u.ID_QUEDAN  == (int)UIID.EditValue
                                               select u).ToList();
                cQuedan data = new cQuedan(enca, detas);

                rpt_quedan rpt = new rpt_quedan();
                List<cQuedan> prpdata = new List<cQuedan>();
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
            UIFE_FECHA.DataBindings.Add("EditValue", lista, "FE_FECHA", false, DataSourceUpdateMode.Never);
            UIID_TERCERO.DataBindings.Add("EditValue", lista, "ID_TERCERO", false, DataSourceUpdateMode.Never);
            UIID_UBICACION_DEPT.DataBindings.Add("EditValue", lista, "ID_UBICACION_DEPT", false, DataSourceUpdateMode.Never);
            UIID_TIPO_DOCUMENTO.DataBindings.Add("EditValue", lista, "ID_TIPO_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UICD_SERIE.DataBindings.Add("EditValue", lista, "CD_SERIE", false, DataSourceUpdateMode.Never);
            UICD_NUMERO.DataBindings.Add("EditValue", lista, "CD_NUMERO", false, DataSourceUpdateMode.Never);
            UICD_ESTADO.DataBindings.Add("EditValue", lista, "CD_ESTADO", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIFE_FECHA.DataBindings.Clear();
            UIID_TERCERO.DataBindings.Clear();
            UIID_UBICACION_DEPT.DataBindings.Clear();
            UIID_TIPO_DOCUMENTO.DataBindings.Clear();
            UICD_SERIE.DataBindings.Clear();
            UICD_NUMERO.DataBindings.Clear();
            UICD_ESTADO.DataBindings.Clear();
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

        System.ComponentModel.BindingList<V_COMP_DETA_QUEDAN > lista_deta;
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
                _datasistema.conectarCompras ();
                lista_deta = new System.ComponentModel.BindingList<V_COMP_DETA_QUEDAN>((from u in _datasistema.ContextoCompras.V_COMP_DETA_QUEDAN where u.ID_QUEDAN == int.Parse(UIID.Text) select u
                    ).ToList());

                lista_deta.AddingNew += list_AddinDeta;

                UIGRIDCONTROL_DETA.DataSource = lista_deta;


            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void insertardetalle(COMP_DETA_QUEDAN  d)
        {
            try
            {
                _datasistema.ContextoCompras.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoCompras.COMP_DETA_QUEDAN.InsertOnSubmit(d);
                _datasistema.ContextoCompras.SubmitChanges();

                consultardetalle();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }

        }


        public void eliminardetalle(COMP_DETA_QUEDAN d)
        {

            try
            {
                COMP_DETA_QUEDAN tupla = (from u in _datasistema.ContextoCompras.COMP_DETA_QUEDAN
                                        where u.ID == d.ID
                                        select u).First();
                _datasistema.ContextoCompras.COMP_DETA_QUEDAN.DeleteOnSubmit(tupla);
                _datasistema.ContextoCompras.SubmitChanges();
               
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
            e.NewObject = new V_COMP_DETA_QUEDAN ();
        }
        #endregion

        private void uirbn_sel_comp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (uigridview.FocusedRowHandle < 0)
                {
                    return;
                }

                V_COMP_QUEDAN tupla = (V_COMP_QUEDAN)uigridview.GetFocusedRow();
                frm_sel_comp f = new frm_sel_comp(_datasistema, tupla, this);
                f.ShowDialog();

            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        private void uirbn_actualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (uigridview.FocusedRowHandle < 0)
                {
                    return;
                }
                _datasistema.conectarCompras ();
                V_COMP_QUEDAN p = (from u in _datasistema.ContextoCompras.V_COMP_QUEDAN where u.ID == int.Parse(UIID.Text) select u).First();
                if (p.CD_ESTADO == 'D')
                {
                    if (MetodosForm.preguntar("¿Quiere actualizar el quedan"))
                    {
                        p.CD_ESTADO  = 'A';
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

        private void UIID_EditValueChanged(object sender, EventArgs e)
        {
            consultardetalle();
        }
    }
}
