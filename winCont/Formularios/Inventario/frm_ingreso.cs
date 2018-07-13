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
    public partial class frm_ingreso : winCont.Formularios.MasterFormTab,Interfaz_forms 
    {
        public List<V_INV_ENCA_INGR > lista;
        public List<V_INV_ARTICULO> lista_articulos;
        public frm_ingreso()
        {
            InitializeComponent();
        }
        public frm_ingreso(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
        }

        public void llenarcombo() {
            _datasistema.conectarSistema();
            UIID_TIPO_DOCUMENTO.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO where u.ID_EMPRESA == _datasistema.empresa.ID && u.CD_TIPO_DOCUMENTO == "ING" select u).ToList();
            UIID_UBICACION_INGR.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_UBICACION where u.ID_EMPRESA ==_datasistema.empresa.ID && u.CD_TIPO_UBICACION =='B' select u).ToList();
            UICD_ESTA_DOCUMENTO.Properties.DataSource = MetodosForm.listaEstadoIngreso();
            //lista_articulos = (from u in _datasistema.ContextoInventario.V_INV_ARTICULO where u.ID_EMPRESA == _datasistema.empresa.ID select u).ToList();
            //UIGID_ARTICULO.DataSource = lista_articulos;
            UIID_TIPO_DOCUMENTO_PROV.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO where u.ID_EMPRESA == _datasistema.empresa.ID && (u.CD_TIPO_DOCUMENTO == "FAC" || u.CD_TIPO_DOCUMENTO =="CRE" || u.CD_TIPO_DOCUMENTO =="REC") select u).ToList();
            UIID_TERCERO.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_TERCERO where u.FLG_PROVEEDOR == 'S' && u.ID_EMPRESA ==_datasistema .empresa .ID select u).ToList();
           
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarInventario();
                lista = (from u in _datasistema.ContextoInventario.V_INV_ENCA_INGR  where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_PERIODO ==_datasistema .periodo .NM_PERIODO && u.NM_EJERCICIO ==_datasistema .periodo .NM_EJERCICIO  select u
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
            UIID_UBICACION_INGR.EditValue = null;
            UIID_TIPO_DOCUMENTO.EditValue = null;
            UICD_SERIE.Text = "";
            UICD_NUMERO.Text = "";
            UIDS_REFERENCIA.Text = "";
            UIFE_FECHA.DateTime =DateTime.Now;
            UICD_ESTA_DOCUMENTO.EditValue =' ';
            UIID_TERCERO.EditValue = null;
            UIID_TIPO_DOCUMENTO_PROV.EditValue = null;
            UICD_NUMERO_PROV.Text = "";
            UICD_SERIE_PROV.Text = "";
            UIFLG_CREDITO.Checked = false;
        }

        public void guardar()
        {
            if (!validar()) {
                return;
            }
            if (UIID.Text == "")
            {  
                try
                {
                    SIS_TALONARIO t = SistemasMT.ObtenerTalonario(_datasistema ,(int)UIID_TIPO_DOCUMENTO .EditValue ,(int)UIID_UBICACION_INGR .EditValue );
                    UICD_NUMERO.EditValue = t.NM_ACTUAL;
                    UICD_SERIE.Text = t.CD_SERIE;

                    INV_ENCA_INGR m = new INV_ENCA_INGR { ID = 0, CD_SERIE = UICD_SERIE.Text, CD_NUMERO = int.Parse(UICD_NUMERO.Text.ToString()), ID_UBICACION_INGR = int.Parse(UIID_UBICACION_INGR.EditValue.ToString()), ID_TIPO_DOCUMENTO = int.Parse(UIID_TIPO_DOCUMENTO.EditValue.ToString()), FE_FECHA = UIFE_FECHA.DateTime, DS_NOMBRE_RECEPCIONISTA = UIDS_NOMBRE_RECEPCIONISTA.Text, CD_ESTA_DOCUMENTO = char.Parse("D"), DS_REFERENCIA = UIDS_REFERENCIA.Text, NM_EJERCICIO = _datasistema.periodo.NM_EJERCICIO, NM_PERIODO = _datasistema.periodo.NM_PERIODO, ID_EMPRESA = _datasistema.empresa.ID,ID_TERCERO =(int)UIID_TERCERO .EditValue ,ID_TIPO_DOCUMENTO_PROV =(int)UIID_TIPO_DOCUMENTO_PROV .EditValue ,CD_SERIE_PROV =UICD_SERIE_PROV .Text ,CD_NUMERO_PROV =int.Parse (UICD_NUMERO_PROV .Text),FLG_CREDITO  =(char)UIFLG_CREDITO  .EditValue  };
                    _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoInventario.INV_ENCA_INGR.InsertOnSubmit(m);
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
                    INV_ENCA_INGR m = (from u in _datasistema.ContextoInventario.INV_ENCA_INGR
                                      where u.ID == int.Parse(UIID.Text)
                                      select u).First();
                    if (m.CD_ESTA_DOCUMENTO != 'D')
                    {
                        return;
                    }
                    m.DS_NOMBRE_RECEPCIONISTA   = UIDS_NOMBRE_RECEPCIONISTA .Text ;
                    m.DS_REFERENCIA = UIDS_REFERENCIA.Text;
                    m.ID_TIPO_DOCUMENTO_PROV = (int)UIID_TIPO_DOCUMENTO_PROV.EditValue;
                    m.ID_TERCERO = (int)UIID_TERCERO.EditValue;
                    m.CD_SERIE_PROV = UICD_SERIE_PROV.Text;
                    m.CD_NUMERO_PROV = int.Parse(UICD_NUMERO_PROV.Text);
                    m.FLG_CREDITO = (char)UIFLG_CREDITO.EditValue;

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
                INV_ENCA_INGR m = (from u in _datasistema.ContextoInventario.INV_ENCA_INGR
                                where u.ID == int.Parse(UIID.Text)
                                select u).First();

                if (m.CD_ESTA_DOCUMENTO != 'D') {
                    return;
                }
                _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoInventario.INV_ENCA_INGR.DeleteOnSubmit(m);
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
                V_INV_ENCA_INGR enca = (from u in _datasistema.ContextoInventario.V_INV_ENCA_INGR 
                                                  where u.ID == (int)UIID.EditValue
                                                  select u).First();
                List<V_INV_DETA_INGR> detas = (from u in _datasistema.ContextoInventario.V_INV_DETA_INGR
                                                     where u.ID_INGR    == (int)UIID.EditValue
                                                     select u).ToList();
                cIngreso data = new cIngreso(enca, detas);

                rpt_ingreso rpt = new rpt_ingreso();
                List<cIngreso> prpdata = new List<cIngreso>();
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
            UIID_UBICACION_INGR.DataBindings.Add("EditValue", lista, "ID_UBICACION_INGR", false, DataSourceUpdateMode.Never);
            UIID_TIPO_DOCUMENTO.DataBindings.Add("EditValue", lista, "ID_TIPO_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UICD_SERIE.DataBindings.Add("EditValue", lista, "CD_SERIE", false, DataSourceUpdateMode.Never);
            UICD_NUMERO.DataBindings.Add("EditValue", lista, "CD_NUMERO", false, DataSourceUpdateMode.Never);
            UIDS_REFERENCIA.DataBindings.Add("EditValue", lista, "DS_REFERENCIA", false, DataSourceUpdateMode.Never);
            UIFE_FECHA.DataBindings.Add("EditValue", lista, "FE_FECHA", false, DataSourceUpdateMode.Never);
            UICD_ESTA_DOCUMENTO.DataBindings.Add("EditValue", lista, "CD_ESTA_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UIDS_NOMBRE_RECEPCIONISTA.DataBindings.Add("EditValue", lista, "DS_NOMBRE_RECEPCIONISTA", false, DataSourceUpdateMode.Never);
            UIID_TERCERO.DataBindings.Add("EditValue", lista, "ID_TERCERO", false, DataSourceUpdateMode.Never);
            UIID_TIPO_DOCUMENTO_PROV.DataBindings.Add("EditValue", lista, "ID_TIPO_DOCUMENTO_PROV", false, DataSourceUpdateMode.Never);
            UICD_NUMERO_PROV.DataBindings.Add("EditValue", lista, "CD_NUMERO_PROV", false, DataSourceUpdateMode.Never);
            UICD_SERIE_PROV.DataBindings.Add("EditValue", lista, "CD_SERIE_PROV", false, DataSourceUpdateMode.Never);
            UIFLG_CREDITO.DataBindings.Add("EditValue", lista, "FLG_CREDITO", false, DataSourceUpdateMode.Never);

        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIID_UBICACION_INGR.DataBindings.Clear();
            UIID_TIPO_DOCUMENTO.DataBindings.Clear();
            UICD_SERIE.DataBindings.Clear();
            UICD_NUMERO.DataBindings.Clear();
            UIDS_REFERENCIA.DataBindings.Clear();
            UIFE_FECHA.DataBindings.Clear();
            UICD_ESTA_DOCUMENTO.DataBindings.Clear();
            UIDS_NOMBRE_RECEPCIONISTA.DataBindings.Clear();
            UIID_TERCERO.DataBindings.Clear();
            UIID_TIPO_DOCUMENTO_PROV.DataBindings.Clear();
            UICD_NUMERO_PROV.DataBindings.Clear();
            UICD_SERIE_PROV.DataBindings.Clear();
            UIFLG_CREDITO.DataBindings.Clear();
        }
        public override void refrescar()
        {
            consultar();
        }

        public bool validar()
        {
            try
            {

                if (UIID_UBICACION_INGR.EditValue == null)
                {
                    throw new Exception("Elija donde ingresara");
                }
                if (UIID_TIPO_DOCUMENTO.EditValue == null)
                {
                    throw new Exception("Elija un documento");
                }
                if (UIID_TERCERO.EditValue == null)
                {
                    throw new Exception("Elija un proveedor");
                }
                if (UIID_TIPO_DOCUMENTO_PROV.EditValue == null) {
                    throw new Exception("Elija un documento del proveedor");
                }
                if(UICD_NUMERO_PROV.Text == ""){
                    throw new Exception("Digite numero del documento");
                };
                if(UICD_SERIE_PROV.Text ==""){
                    throw new Exception("Digite serie del documento");
                };
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
        System.ComponentModel.BindingList<V_INV_DETA_INGR  > lista_deta;
        public void consultardetalle()
        {
            try
            {
                if (UIID.Text == "")
                {
                    UIGRIDCONTROL_DETA.DataSource = null;
                    UIGRIDVIEW_DETA.OptionsBehavior.Editable = false;
                    return;
                }
                _datasistema.conectarInventario();
                lista_deta = new System.ComponentModel.BindingList<V_INV_DETA_INGR>((from u in _datasistema.ContextoInventario.V_INV_DETA_INGR where u.ID_INGR == int.Parse(UIID.Text) select u
                    ).ToList());

                lista_deta.AddingNew += list_AddinDeta;

                UIGRIDCONTROL_DETA.DataSource = lista_deta;


            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void insertardetalle(INV_DETA_INGR   d)
        {
            try
            {
                _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoInventario.INV_DETA_INGR .InsertOnSubmit(d);
                _datasistema.ContextoInventario.SubmitChanges();
                int? error=0;
                string msj=String.Empty ;
                _datasistema .ContextoInventario .PR_INV_ACTU_DETA_INGR (d.ID_INGR ,_datasistema .empresa .ID,ref error,ref msj);
                consultardetalle();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }

        }

        public void modificardetalle(INV_DETA_INGR  d)
        {
            try
            {
                INV_DETA_INGR tupla = (from u in _datasistema.ContextoInventario.INV_DETA_INGR 
                                             where u.ID == d.ID
                                             select u).First();
                //tupla.ID_ARTICULO  = d.ID_ARTICULO ;
                tupla.NM_CANTIDAD = d.NM_CANTIDAD;
               // tupla.NM_PRECIO = d.NM_PRECIO;
                _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoInventario.SubmitChanges();
                int? error = 0;
                string msj = String.Empty;
                _datasistema.ContextoInventario.PR_INV_ACTU_DETA_INGR(d.ID_INGR , _datasistema.empresa.ID, ref error, ref msj);
                consultardetalle();

            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                consultardetalle();
            }
        }

        public void eliminardetalle(INV_DETA_INGR  d)
        {

            try
            {
                INV_DETA_INGR tupla = (from u in _datasistema.ContextoInventario.INV_DETA_INGR 
                                             where u.ID == d.ID
                                             select u).First();
                _datasistema.ContextoInventario.INV_DETA_INGR.DeleteOnSubmit(tupla);
                _datasistema.ContextoInventario.SubmitChanges();
                int? error = 0;
                string msj = String.Empty;
                _datasistema.ContextoInventario.PR_INV_ACTU_DETA_INGR(d.ID, _datasistema.empresa.ID, ref error, ref msj);
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
            e.NewObject = new V_INV_DETA_INGR  ();
        }

        private void UIGRIDVIEW_DETA_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            V_INV_DETA_INGR v = (V_INV_DETA_INGR)e.Row;
            INV_DETA_INGR d = new INV_DETA_INGR  { ID = v.ID, ID_ARTICULO = v.ID_ARTICULO, NM_CANTIDAD = v.NM_CANTIDAD, ID_INGR  = v.ID_INGR ,ID_DETA_ORDEN=v.ID_DETA_ORDEN,NM_PRECIO =v.NM_PRECIO  };

             modificardetalle(d);
        }

        private void UIGRIDVIEW_DETA_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool flgvalid = true;
            string msjerror = "";
            V_INV_DETA_INGR d = (V_INV_DETA_INGR)e.Row;
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
                    INV_DETA_INGR d = new INV_DETA_INGR()
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
            }
            else
            {
                UIGRIDVIEW_DETA.OptionsBehavior.Editable = false;
            }
        }

        private void UIGID_ARTICULO_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter(); 
        }

        private void uirbn_despachar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (uigridview.FocusedRowHandle < 0) {
                    return;
                }
                _datasistema.conectarInventario();
                INV_ENCA_INGR   p = (from u in _datasistema.ContextoInventario .INV_ENCA_INGR  where u.ID == int.Parse(UIID.Text) select u).First();
                if (p.CD_ESTA_DOCUMENTO == 'D')
                {
                    if (MetodosForm.preguntar("¿Quiere efectuar el ingreso?"))
                    {
                        
                        foreach (var item in lista_deta)
                        {
                            INV_ARTICULO art = (from u in _datasistema.ContextoInventario.INV_ARTICULO where u.ID == item.ID_ARTICULO select u).First();
                            if( item.FLG_INGR !='S'){
                                 int? error = 0;
                            string msj = string.Empty;

                            if (art.FLG_INVENTARIABLE == 'S') {
                                _datasistema.ContextoInventario.PR_INV_PROC_INGRESO(_datasistema.empresa.ID, p.ID_UBICACION_INGR, p.NM_EJERCICIO, p.NM_PERIODO, item.ID_ARTICULO, item.NM_CANTIDAD, item.NM_PRECIO, p.ID, p.ID_TIPO_DOCUMENTO, p.CD_SERIE + p.CD_NUMERO.ToString(), ref error, ref msj);
                            }
                            
                            if (error == 0) {
                                INV_DETA_INGR d = (from u in _datasistema.ContextoInventario.INV_DETA_INGR
                                                   where u.ID == item.ID
                                                   select u).First();
                                INV_DETA_ORDEN  r = (from u in _datasistema.ContextoInventario.INV_DETA_ORDEN 
                                                  where u.ID == item.ID_DETA_ORDEN
                                                  select u).First();
                                d.FLG_INGR = 'S';
                                r.NM_CANT_RECIBIDA   = r.NM_CANT_RECIBIDA + item.NM_CANTIDAD;
                                _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                                _datasistema.ContextoInventario.SubmitChanges();

                            }
                           
                            }
                        }

                        if ((from u in _datasistema.ContextoInventario.INV_DETA_INGR
                             where u.ID_INGR  == p.ID && u.FLG_INGR != 'S'
                             select u).Count() > 0) {
                                 MetodosForm.mensajeErrorDefault("Hay productos que no se ingresaron", _datasistema);
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

        private void uirbn_sel_reque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (uigridview.FocusedRowHandle < 0)
                {
                    return;
                }

                V_INV_ENCA_INGR tupla = (V_INV_ENCA_INGR)uigridview.GetFocusedRow();
                frm_sel_ord f = new frm_sel_ord(_datasistema, tupla, this);
                f.ShowDialog();

            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }


    }
}
