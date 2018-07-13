using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using ContabilidadDB;
using System.Linq;
using winCont.Clases ;
using winCont.Clases.Reportes;
using winCont.Reportes.Contabilidad;
using DevExpress.XtraEditors;
using winCont.Logica.Contabilidad;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_part_borr : winCont.Formularios.MasterFormTab,Interfaz_forms
    {
        List<V_CONT_ENCA_PART_BORRADOR> lista;
        List<CONT_DIARIO> lista_diarios;
        List<clsGenericaPares> lista_estados;
        List<CONT_CUENTA> lista_cuentas;
        ManejadorPartidaBorrador manejadorData;
        ManejadorDiario manejadorDiario;
        ManejadorCuenta manejadorCuenta;
        ManejadorDetallePartidaBorrrador manejadorDetallePartidaBorrador;
        

        public frm_part_borr()
        {
            InitializeComponent();
        }

        public frm_part_borr(DataSistema ds):base(ds) {
            InitializeComponent();
            manejadorData = new ManejadorPartidaBorrador(ds);
            manejadorDiario = new ManejadorDiario(ds);
            manejadorCuenta = new ManejadorCuenta(ds);
            manejadorDetallePartidaBorrador = new ManejadorDetallePartidaBorrrador(ds);
        }

        public void llenarcombos() {
            lista_diarios = manejadorDiario .consultarPorIdEmpresa (_datasistema .empresa .ID);
            UIID_DIARIO.Properties.DataSource = lista_diarios;
            
            lista_estados = MetodosForm.listaEstadosPartidaBorrador();
            UICD_ESTA_PART.Properties.DataSource = lista_estados;

            lista_cuentas = manejadorCuenta .consultarPorIdEmpresaPorTipo (_datasistema .empresa .ID,'S');
            UIG_ID_CUENTA.DataSource = lista_cuentas;

        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarContabilidad();
                lista = manejadorData.consultarVistaPorIdEmpresaPorPeriodo(_datasistema.empresa.ID, _datasistema.periodo);
                UIID.Text = "";
                llenarcombos();
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
            UIID.Text = "";
            UIFE_PARTIDA.DateTime = DateTime.Now;
            UIID_DIARIO.EditValue =null;
            UIDS_CONCEPTO.Text = "";
            UIDS_REFERENCIA.Text = "";
            UICD_ESTA_PART.EditValue = ' ';
        }

        public void guardar()
        {
            try
            {
                if (!validar()) {
                    return;
                }
              

                    CONT_ENCA_PART_BORRADOR p = new CONT_ENCA_PART_BORRADOR { ID = 0, FE_PARTIDA = UIFE_PARTIDA.DateTime, ID_DIARIO = int.Parse(UIID_DIARIO.EditValue.ToString()), NM_EJERCICIO = int.Parse(_datasistema.periodo.NM_EJERCICIO.ToString()), NM_PERIODO = int.Parse(_datasistema.periodo.NM_PERIODO.ToString()), DS_CONCEPTO = UIDS_CONCEPTO.Text, DS_REFERENCIA = UIDS_REFERENCIA.Text, CD_ESTA_PART = 'D', ID_PART_DIA = 0, ID_EMPRESA = _datasistema.empresa.ID };
                    if (UIID.Text == "")
                    {
                        p = manejadorData.insertar(p);
                    }
                    else
                    {

                        p.ID = int.Parse(UIID.Text);
                        manejadorData.modificar(p);

                    }
                    consultar();
                    MetodosForm.seleccionarFila(uigridview, "ID", p.ID);

            }
            catch (Exception ex)
            {
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        public void eliminar()
        {
            try
            {
                CONT_ENCA_PART_BORRADOR p = new CONT_ENCA_PART_BORRADOR { ID = int.Parse(UIID.Text) };
                 manejadorData.eliminar(p);
                 consultar();
            }
            catch (Exception ex)
            {
               MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        public void imprimir()
        {
            try
            {
                V_CONT_ENCA_PART_BORRADOR enca = manejadorData .consultarVistaPorId (int.Parse (UIID.Text ));
                List<V_CONT_DETA_PART_BORR > detas=manejadorDetallePartidaBorrador .consultarVistaPorIdEnca (int.Parse (UIID.Text ));
                cPartidaBorrador data = new cPartidaBorrador(enca, detas);

                rpt_part_borr rpt = new rpt_part_borr();
                List<cPartidaBorrador > prpdata= new List<cPartidaBorrador>();
                prpdata.Add(data);
                rpt.DataSource =  prpdata;
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
           
            UIFE_PARTIDA.DataBindings.Add("EditValue", lista, "FE_PARTIDA", false, DataSourceUpdateMode.Never);
            UIID_DIARIO .DataBindings .Add("EditValue",lista,"ID_DIARIO",false ,DataSourceUpdateMode.Never );
            UIDS_CONCEPTO.DataBindings.Add("EditValue", lista, "DS_CONCEPTO", false, DataSourceUpdateMode.Never);
            UIDS_REFERENCIA.DataBindings.Add("EditValue", lista, "DS_REFERENCIA", false, DataSourceUpdateMode.Never);
            UICD_ESTA_PART.DataBindings.Add("EditValue", lista, "CD_ESTA_PART", false, DataSourceUpdateMode.Never);
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
           
            UIFE_PARTIDA.DataBindings.Clear();
            UIID_DIARIO.DataBindings.Clear();
            UIDS_CONCEPTO.DataBindings.Clear();
            UIDS_REFERENCIA.DataBindings.Clear();
            UICD_ESTA_PART.DataBindings.Clear();
            UIID.DataBindings.Clear();
        }

        public override void refrescar()
        {
            consultar();
        }

        public bool validar()
        {
            if (UIID_DIARIO.EditValue == null)
            {
                MetodosForm.mensajeErrorDefault("Seleccione el tipo de diario", _datasistema);
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
        System.ComponentModel.BindingList<CONT_DETA_PART_BORR> lista_deta;
        public void consultardetalle(){
            try
            {
                if (UIID.Text == "") {
                    UIGRIDCONTROL_DETA.DataSource = null;
                    UIGRIDVIEW_DETA.OptionsBehavior.Editable = false;
                    UIGRIDVIEW_DETA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                    return;
                }
                lista_deta =  new System.ComponentModel.BindingList<CONT_DETA_PART_BORR >(manejadorDetallePartidaBorrador .consultarPorIdEnca (int.Parse (UIID.Text) ));

                     lista_deta.AddingNew  += list_AddinDeta;

                UIGRIDCONTROL_DETA.DataSource = lista_deta;

                
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void insertardetalle(CONT_DETA_PART_BORR d) {
            try
            {
                manejadorDetallePartidaBorrador.insertar(d);
                consultardetalle();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }
           
        }

        public void modificardetalle(CONT_DETA_PART_BORR d) {
            try
            {
                manejadorDetallePartidaBorrador.modificar(d);
                consultardetalle();
              
            }
            catch (Exception ex)
            {
                
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }
        }

        public void eliminardetalle(CONT_DETA_PART_BORR d) {

            try
            {
                manejadorDetallePartidaBorrador.eliminar(d);
                 _datasistema.ContextoContabilidad.SubmitChanges();

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
         e.NewObject = new CONT_DETA_PART_BORR ();
        }

        private void UIGRIDVIEW_DETA_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID", 0);
            UIGRIDVIEW_DETA.SetFocusedRowCellValue("ID_PART_BORR",UIID .EditValue);
        }

        private void UIGRIDVIEW_DETA_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            CONT_DETA_PART_BORR d = (CONT_DETA_PART_BORR) e.Row ;
            if (d.NM_ABONO == null)
            {
                d.NM_ABONO = 0;
            }
            if (d.NM_CARGO == null)
            {
                d.NM_CARGO = 0;
            }
            if (d.ID == 0)
            {
                insertardetalle(d);
            }
            else {
                modificardetalle(d);  
            }
        }

        private void UIGRIDVIEW_DETA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && UIGRIDVIEW_DETA.FocusedRowHandle >= 0) {
                if (MetodosForm.preguntar(3)) {
                    CONT_DETA_PART_BORR d = new CONT_DETA_PART_BORR()
                    {
                        ID = (int)UIGRIDVIEW_DETA.GetFocusedRowCellValue("ID")
                    };
                    eliminardetalle(d);
                }
            }
        }

        private void UIGRIDVIEW_DETA_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool flgvalid=true;
            string msjerror="";
            CONT_DETA_PART_BORR d = (CONT_DETA_PART_BORR)e.Row;
            if (d.ID_CUENTA == 0) {
                flgvalid = false;
                msjerror = "Seleccione una cuenta";
                UIGRIDVIEW_DETA.SetColumnError(colID_CUENTA, msjerror);
            }
            if (d.NM_CARGO > 0 && d.NM_ABONO > 0) {
                flgvalid = false;
                msjerror = "Solo puede hacer un movimiento";
                UIGRIDVIEW_DETA.SetColumnError(colNM_CARGO, msjerror);
            }
            e.Valid = flgvalid;
        }

        #endregion

        private void UIID_EditValueChanged(object sender, EventArgs e)
        {
            consultardetalle();
        }

        private void UICD_ESTA_PART_EditValueChanged(object sender, EventArgs e)
        {
            if (char.Parse(UICD_ESTA_PART.EditValue.ToString()) == 'D')
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

        private void uirbn_actualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                CONT_ENCA_PART_BORRADOR p = new CONT_ENCA_PART_BORRADOR { ID = int.Parse(UIID.Text) };
                    if (MetodosForm.preguntar("¿Quiere actualizar la partida?"))
                    {
                        manejadorData.actualizarPartida(p); 
                        consultar();
                        MetodosForm.seleccionarFila(uigridview, "ID", p.ID);
                    }
            }
            catch (Exception ex)
            {
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        private void uirbn_importar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UIID.Text != "" && (char)UICD_ESTA_PART.EditValue == 'D') {
                frm_impo_part_borr f = new frm_impo_part_borr(_datasistema, int.Parse(UIID.Text));
                f.ShowDialog();
                consultardetalle();
            }
        }

        private void UIG_ID_CUENTA_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter(); 
        }

    }
}
