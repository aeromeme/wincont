using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using System.Linq;
using Sistema;
using ComprasDB;
using InventarioDB;

namespace winCont.Formularios.Compras
{
    public partial class frm_compras : winCont.Formularios.MasterFormTab, Interfaz_forms
    {
        List<V_COMP_COMPRA> lista;
        public frm_compras()
        {
            InitializeComponent();
        }
        public frm_compras(DataSistema ds) : base(ds) 
        {
            InitializeComponent();
        }
        public void llenarcombo()
        {
            _datasistema.conectarSistema();
           
            UICD_ESTADO.Properties.DataSource = MetodosForm.listaEstadoCompraVenta  ();
            UIID_TIPO_DOCUMENTO.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_DOCUMENTO where u.ID_EMPRESA == _datasistema.empresa.ID && (u.CD_TIPO_DOCUMENTO == "FAC" || u.CD_TIPO_DOCUMENTO == "CRE" || u.CD_TIPO_DOCUMENTO == "REC") select u).ToList();
            UIID_TERCERO.Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_TERCERO where u.FLG_PROVEEDOR == 'S' && u.ID_EMPRESA ==_datasistema .empresa .ID  select u).ToList();
           
        }
        public void consultar()
        {
            try
            {
                _datasistema.conectarCompras();
                _datasistema.conectarSistema();
                lista = (from u in _datasistema.ContextoCompras .V_COMP_COMPRA  where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_EJERCICIO ==_datasistema.periodo .NM_EJERCICIO && u.NM_PERIODO ==_datasistema .periodo .NM_PERIODO  select u
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
            UIID_TERCERO.EditValue = null;
            UIFLG_CREDITO.Checked = false;
            UIFE_FECHA.DateTime  = DateTime.Now;
            UIFE_VENCIMIENTO.DateTime = DateTime.Now;
            UIFE_RECEPCION.DateTime = DateTime.Now;
            UIID_TIPO_DOCUMENTO.EditValue = null;
            UICD_SERIE.Text = "";
            UICD_NUMERO.Text = "";
            UINM_GRAVADO.EditValue = 0;
            UINM_EXENTO .EditValue =0;
            UINM_SUJETO_A_RENTA.EditValue = 0;
            UINM_IVA.EditValue = 0;
            UINM_RETENCION .EditValue=0;
            UINM_RENTA.EditValue = 0;
            UINM_TOTAL.EditValue = 0;
            UICD_ESTADO.EditValue = 'D';

        }

        public void guardar()
        {
             if (UIID_TIPO_DOCUMENTO.EditValue == null)
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
                    COMP_COMPRA m = new COMP_COMPRA
                    {
                        ID = 0,
                        NM_EJERCICIO=(int) _datasistema .periodo.NM_EJERCICIO,
                        NM_PERIODO = (int)_datasistema.periodo.NM_PERIODO,
                        ID_EMPRESA = _datasistema.empresa.ID,
                        ID_TERCERO = (int) UIID_TERCERO .EditValue ,
                        FLG_CREDITO =(char) UIFLG_CREDITO .EditValue ,
                        FE_FECHA=UIFE_FECHA .DateTime ,
                        FE_VENCIMIENTO =UIFE_VENCIMIENTO .DateTime,
                        FE_RECEPCION =UIFE_RECEPCION .DateTime ,
                        ID_TIPO_DOCUMENTO =(int)UIID_TIPO_DOCUMENTO .EditValue ,
                        CD_SERIE =UICD_SERIE .Text ,
                        CD_NUMERO =int.Parse (UICD_NUMERO .EditValue.ToString() ),
                        NM_GRAVADO = decimal.Parse (UINM_GRAVADO.EditValue.ToString() ),
                        NM_EXENTO = decimal.Parse(UINM_EXENTO.EditValue.ToString ()),
                        NM_SUJETO_A_RENTA=decimal.Parse (UINM_SUJETO_A_RENTA .EditValue.ToString ()) ,
                        CD_ESTADO ='D'
                    };
                    
                    _datasistema.ContextoCompras.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoCompras.COMP_COMPRA.InsertOnSubmit(m);
                    _datasistema.ContextoCompras.SubmitChanges();
                     int? error = 0;
                     string msj = String.Empty;
                     _datasistema.ContextoCompras.PR_COMP_ACTU_COMP(m.ID, m.ID_EMPRESA, ref error,ref msj);
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
                    COMP_COMPRA m = (from u in _datasistema.ContextoCompras.COMP_COMPRA
                                        where u.ID == int.Parse(UIID.Text)
                                        select u).First();

                    if (m.CD_ESTADO != 'D') {
                        return;
                    }

                    {
                        m.FLG_CREDITO =(char) UIFLG_CREDITO .EditValue ;
                        m.FE_FECHA=UIFE_FECHA .DateTime ;
                        m.FE_VENCIMIENTO =UIFE_VENCIMIENTO .DateTime;
                        m.FE_RECEPCION = UIFE_RECEPCION.DateTime;
                        m.ID_TIPO_DOCUMENTO =(int)UIID_TIPO_DOCUMENTO .EditValue ;
                        m.CD_SERIE =UICD_SERIE .Text ;
                        m.CD_NUMERO =int.Parse (UICD_NUMERO .EditValue.ToString() );
                        m.NM_GRAVADO = decimal.Parse (UINM_GRAVADO.EditValue.ToString ());
                        m.NM_EXENTO = decimal.Parse (UINM_EXENTO.EditValue.ToString ());
                        m.NM_SUJETO_A_RENTA = decimal.Parse (UINM_SUJETO_A_RENTA.EditValue.ToString ());
                        _datasistema.ContextoCompras.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                        _datasistema.ContextoCompras.SubmitChanges();
                        int? error = 0;
                        string msj = String.Empty;
                        _datasistema.ContextoCompras.PR_COMP_ACTU_COMP(m.ID, m.ID_EMPRESA, ref error, ref msj);
                        consultar();
                        MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
                    }

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
                COMP_COMPRA m = (from u in _datasistema.ContextoCompras.COMP_COMPRA
                                    where u.ID == int.Parse(UIID.Text)
                                    select u).First();

                if (m.CD_ESTADO != 'D') {
                    return;
                }
                if(m.ID_INGRESO !=0){
                    int idingr = m.ID_INGRESO.Value ;
                    _datasistema.conectarInventario();
                    INV_ENCA_INGR ing = (from u in _datasistema.ContextoInventario.INV_ENCA_INGR
                                         where u.ID == idingr 
                                         select u).First();
                    ing.ID_COMPRA = 0;
                    _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoInventario.SubmitChanges();

                }

                _datasistema.ContextoCompras.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoCompras.COMP_COMPRA.DeleteOnSubmit(m);
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
            
        }

        public void cerrar()
        {
            this.Close();
        }

        public void enlazar()
        {
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
            UIID_TERCERO.DataBindings.Add("EditValue", lista, "ID_TERCERO", false, DataSourceUpdateMode.Never);
            UIFLG_CREDITO.DataBindings.Add("EditValue", lista, "FLG_CREDITO", false, DataSourceUpdateMode.Never);
            UIFE_FECHA.DataBindings.Add("EditValue", lista, "FE_FECHA", false, DataSourceUpdateMode.Never);
            UIFE_VENCIMIENTO.DataBindings.Add("EditValue", lista, "FE_VENCIMIENTO", false, DataSourceUpdateMode.Never);
            UIID_TIPO_DOCUMENTO.DataBindings.Add("EditValue", lista, "ID_TIPO_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UICD_SERIE.DataBindings.Add("EditValue", lista, "CD_SERIE", false, DataSourceUpdateMode.Never);
            UICD_NUMERO.DataBindings.Add("EditValue", lista, "CD_NUMERO", false, DataSourceUpdateMode.Never);
            UINM_GRAVADO.DataBindings.Add("EditValue", lista, "NM_GRAVADO", false, DataSourceUpdateMode.Never);
            UINM_EXENTO.DataBindings.Add("EditValue", lista, "NM_EXENTO", false, DataSourceUpdateMode.Never);
            UINM_SUJETO_A_RENTA.DataBindings.Add("EditValue",lista,"NM_SUJETO_A_RENTA",false,DataSourceUpdateMode.Never );
            UINM_IVA.DataBindings .Add("EditValue",lista,"NM_IVA",false,DataSourceUpdateMode.Never );
            UINM_RETENCION.DataBindings .Add("EditValue",lista,"NM_RETENCION",false,DataSourceUpdateMode.Never );
            UINM_RENTA.DataBindings .Add("EditValue",lista,"NM_RENTA",false,DataSourceUpdateMode.Never );
            UINM_TOTAL.DataBindings .Add("EditValue",lista,"NM_TOTAL",false,DataSourceUpdateMode.Never );
            UICD_ESTADO.DataBindings .Add("EditValue",lista,"CD_ESTADO",false,DataSourceUpdateMode.Never );
            UIFE_RECEPCION.DataBindings.Add("EditValue", lista, "FE_RECEPCION", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIID_TERCERO.DataBindings .Clear();
            UIFLG_CREDITO.DataBindings.Clear(); ;
            UIFE_FECHA.DataBindings.Clear();
            UIFE_VENCIMIENTO.DataBindings.Clear();
            UIID_TIPO_DOCUMENTO.DataBindings.Clear();
            UICD_SERIE.DataBindings.Clear();
            UICD_NUMERO.DataBindings.Clear();
            UINM_GRAVADO.DataBindings.Clear();
            UINM_EXENTO.DataBindings.Clear();
            UINM_SUJETO_A_RENTA.DataBindings.Clear();
            UINM_IVA.DataBindings.Clear();
            UINM_RETENCION.DataBindings.Clear();
            UINM_RENTA.DataBindings.Clear();
            UINM_TOTAL.DataBindings.Clear();
            UICD_ESTADO.DataBindings.Clear();
            UIFE_RECEPCION.DataBindings.Clear();
        }

        public bool validar()
        {
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

        private void uirbn_actualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                COMP_COMPRA p = (from u in _datasistema.ContextoCompras .COMP_COMPRA where u.ID == int.Parse(UIID.Text) select u).First();

                if (p.CD_ESTADO == 'D')
                {

                   

                    if (MetodosForm.preguntar("¿Quiere actualizar la compra?"))
                    {
                        int? error = 0;
                        string msj = string.Empty;
                        p.CD_ESTADO  = 'A';
                        _datasistema.ContextoCompras.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                        _datasistema.ContextoCompras.SubmitChanges();
                        _datasistema.ContextoCompras.PR_CONT_GENE_CONT_COMP(p.ID, ref error, ref msj);
                        if (error != 0)
                        {
                            MetodosForm.mensajeErrorDefault(msj, _datasistema);
                        }
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

        private void uirbn_btn_import_ingr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                form_sel_ingr_comp f = new form_sel_ingr_comp (_datasistema ,this);
                f.ShowDialog();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(_datasistema );
            }
        }

        private void uirbn_btn_rev_ingr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                 COMP_COMPRA m = (from u in _datasistema.ContextoCompras.COMP_COMPRA
                                    where u.ID == int.Parse(UIID.Text)
                                    select u).First();
                 if (m.ID_INGRESO == 0) {
                     return;
                 }
                frm_consultar_ingr_comp f = new frm_consultar_ingr_comp(_datasistema);
                f.idingr = m.ID_INGRESO.Value ;
                f.consultar();
                f.ShowDialog();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(_datasistema);
            }
        }
    }
}
