using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventarioDB;
using winCont.Utilidades;
using System.Linq;
using winCont.Logica.Inventario;

namespace winCont.Formularios.Inventario
{
    public partial class frm_arti : winCont.Formularios.MasterFormTab,Interfaz_forms 
    {
        public List<V_INV_ARTICULO > lista;
        public List<V_INV_CATEGORIA> lista_cate;
        public List<INV_UNIMED> lista_unimed;


        ManejadorUnidadDeMedida manejadorUniMed;
        ManejadorCategoria manejadorCate;
        ManejadorArticulo manejadorArticulo;
        public frm_arti()
        {
            InitializeComponent();
        }
        public frm_arti(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
            manejadorUniMed = new ManejadorUnidadDeMedida(ds);
            manejadorCate = new ManejadorCategoria(ds);
            manejadorArticulo = new ManejadorArticulo(ds);
        }
        public void llenarcombo() {
           // lista_cate = (from u in _datasistema.ContextoInventario.V_INV_CATEGORIA  where u.ID_EMPRESA == _datasistema.empresa.ID select u).ToList();
            lista_cate = manejadorCate.consultarVistaPorIdEmpresa(_datasistema.empresa.ID);
            UIID_CATE_ARTI.Properties.DataSource = lista_cate  ;

            //lista_unimed = (from u in _datasistema.ContextoInventario.INV_UNIMED where u.ID_EMPRESA == _datasistema.empresa.ID select u).ToList();
            lista_unimed = manejadorUniMed.consultarPorIdEmpresa(_datasistema.empresa.ID);
            UIID_UNI_MED.Properties.DataSource = lista_unimed;
            
        }

        public void consultar()
        {
            try
            {
                //_datasistema.conectarInventario();
                //lista = (from u in _datasistema.ContextoInventario.V_INV_ARTICULO where u.ID_EMPRESA == _datasistema.empresa.ID select u
                //    ).ToList();
                lista = manejadorArticulo.consultarVistaPorIdEmpresa(_datasistema.empresa.ID);
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
            desenlazar();
            UIID.Text = "";
            UIDS_NOMBRE.Text = "";
            UIDS_NOMBRE_ALTER.Text = "";
            UIDS_REFERENCIA.Text = "";
            UINM_CANT_MAX.EditValue = 0.0;
            UINM_CANT_MIN.EditValue = 0.0;
            UIID_UNI_MED.EditValue = null;
            UIID_CATE_ARTI.EditValue = null;
            UIFLG_VERI_EXIS_VENT.Checked = false;
            UICD_BARRA.Text = "";
            UIFLG_EXEN_IMPU.Checked = false;
            UIFLG_INVENTARIABLE.Checked = false;
            UICD_CLAVE.Text = "";
        }

        public void guardar()
        {
            INV_ARTICULO m = new INV_ARTICULO { ID = 0, ID_UNI_MED = int.Parse(UIID_UNI_MED.EditValue.ToString()), ID_CATE_ARTI = int.Parse(UIID_CATE_ARTI.EditValue.ToString()), CD_BARRA = UICD_BARRA.Text, DS_NOMBRE = UIDS_NOMBRE.Text, DS_NOMBRE_ALTER = UIDS_NOMBRE_ALTER.Text, DS_REFERENCIA = UIDS_REFERENCIA.Text, FLG_EXEN_IMPU = char.Parse(UIFLG_EXEN_IMPU.EditValue.ToString()), FLG_VERI_EXIS_VENT = char.Parse(UIFLG_VERI_EXIS_VENT.EditValue.ToString()), NM_CANT_MAX = decimal.Parse(UINM_CANT_MAX.EditValue.ToString()), NM_CANT_MIN = decimal.Parse(UINM_CANT_MIN.EditValue.ToString()), ID_EMPRESA = _datasistema.empresa.ID, FLG_INVENTARIABLE = char.Parse(UIFLG_INVENTARIABLE.EditValue.ToString()), CD_CLAVE = UICD_CLAVE.Text };
            if (UIID.Text == "")
            {
                try
                {
                   
                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.INV_ARTICULO.InsertOnSubmit(m);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    m= manejadorArticulo.insertar(m);
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
                    //INV_ARTICULO m = (from u in _datasistema.ContextoInventario.INV_ARTICULO
                    //                where u.ID == int.Parse(UIID.Text)
                    //                select u).First();
                    //m.ID_UNI_MED = (int)UIID_UNI_MED.EditValue;
                    //m.ID_CATE_ARTI =(int)UIID_CATE_ARTI .EditValue ;
                    //m.CD_BARRA =UICD_BARRA .Text;
                    //m.CD_CLAVE = UICD_CLAVE.Text;
                    //m.DS_NOMBRE=UIDS_NOMBRE.Text ;
                    //m.DS_NOMBRE_ALTER =UIDS_NOMBRE_ALTER.Text;
                    //m.DS_REFERENCIA =UIDS_REFERENCIA .Text;
                    //m.FLG_EXEN_IMPU =(char)UIFLG_EXEN_IMPU .EditValue;
                    //m.FLG_VERI_EXIS_VENT =(char)UIFLG_VERI_EXIS_VENT .EditValue;
                    //m.NM_CANT_MAX =(decimal)UINM_CANT_MAX .EditValue ;
                    //m.NM_CANT_MIN = (decimal)UINM_CANT_MIN.EditValue;
                    //m.FLG_INVENTARIABLE = char.Parse(UIFLG_INVENTARIABLE.EditValue.ToString());
                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.SubmitChanges();

                    m.ID = int.Parse(UIID.Text);
                    manejadorArticulo.modificar(m);
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
                INV_ARTICULO m = new INV_ARTICULO { ID = int.Parse(UIID.Text), ID_EMPRESA =_datasistema.empresa .ID  };
                //INV_ARTICULO m = (from u in _datasistema.ContextoInventario.INV_ARTICULO
                //                where u.ID == int.Parse(UIID.Text)
                //                select u).First();

                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.INV_ARTICULO.DeleteOnSubmit(m);
                //_datasistema.ContextoInventario.SubmitChanges();
                manejadorArticulo.eliminar(m);
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
            UIDS_NOMBRE.DataBindings.Add("EditValue", lista, "DS_NOMBRE", false, DataSourceUpdateMode.Never);
            UIDS_NOMBRE_ALTER.DataBindings.Add("EditValue", lista, "DS_NOMBRE_ALTER", false, DataSourceUpdateMode.Never);
            UIDS_REFERENCIA.DataBindings.Add("EditValue", lista, "DS_REFERENCIA", false, DataSourceUpdateMode.Never);
            UINM_CANT_MAX.DataBindings.Add("EditValue", lista, "NM_CANT_MAX", false, DataSourceUpdateMode.Never);
            UINM_CANT_MIN.DataBindings.Add("EditValue", lista, "NM_CANT_MIN", false, DataSourceUpdateMode.Never);
            UIID_UNI_MED.DataBindings.Add("EditValue", lista, "ID_UNI_MED", false, DataSourceUpdateMode.Never);
            UIID_CATE_ARTI.DataBindings.Add("EditValue", lista, "ID_CATE_ARTI", false, DataSourceUpdateMode.Never);
            UIFLG_VERI_EXIS_VENT.DataBindings.Add("EditValue", lista, "FLG_VERI_EXIS_VENT", false, DataSourceUpdateMode.Never);
            UICD_BARRA .DataBindings .Add("EditValue",lista,"CD_BARRA",false, DataSourceUpdateMode.Never );
            UIFLG_EXEN_IMPU .DataBindings .Add("EditValue",lista,"FLG_EXEN_IMPU",false,DataSourceUpdateMode.Never );
            UIFLG_INVENTARIABLE.DataBindings.Add("EditValue", lista, "FLG_INVENTARIABLE", false, DataSourceUpdateMode.Never);
            UICD_CLAVE.DataBindings.Add("EditValue", lista, "CD_CLAVE", false, DataSourceUpdateMode.Never);

        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_NOMBRE.DataBindings.Clear();
            UIDS_NOMBRE_ALTER.DataBindings.Clear();
            UIDS_REFERENCIA.DataBindings.Clear();
            UINM_CANT_MAX.DataBindings.Clear();
            UINM_CANT_MIN.DataBindings.Clear();
            UIID_UNI_MED.DataBindings.Clear();
            UIID_CATE_ARTI.DataBindings.Clear();
            UIFLG_VERI_EXIS_VENT.DataBindings.Clear();
            UICD_BARRA.DataBindings.Clear();
            UIFLG_EXEN_IMPU.DataBindings.Clear();
            UIFLG_INVENTARIABLE.DataBindings.Clear();
            UICD_CLAVE.DataBindings.Clear();
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
        public bool validar()
        {
            return true;
        }
    }
}
