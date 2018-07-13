using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using Sistema;
using System.Linq;
using winCont.Clases;
using ContabilidadDB;
using VentasDB;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_tercero : winCont.Formularios.MasterFormTab,Interfaz_forms
    {
        private List<V_SIS_TERCERO> lista;
        ManejadorTercero manejadorData;
        ManejadorMunicipio manejadorMunicipio;
        public frm_tercero()
        {
            InitializeComponent();
        }
        public frm_tercero(DataSistema ds):base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorTercero(ds);
            manejadorMunicipio = new ManejadorMunicipio(ds);
        }

        private void llenarcombos() {

            List<clsGenericaPares> listaContrib = MetodosForm.listaDeTipodeContribuyentes();
            List<clsGenericaPares> listaPersonas = MetodosForm.listaDeTipodePersonas();
            List<V_CONT_CUENTA > listaCuentas= (from u in _datasistema .ContextoContabilidad .V_CONT_CUENTA
                                                    where u.ID_EMPRESA ==_datasistema .empresa .ID && u.FLG_DETALLE=='S' select u).ToList();

            List<V_SIS_MUNICIPIO> listaMuni = manejadorMunicipio.consultar();

            UIID_CUENTAXCOBRAR.Properties.DataSource = listaCuentas;
            UIID_CUENTAXPAGAR.Properties.DataSource = listaCuentas;

            UICD_TIPO_CONTRIBUYENTE.Properties.DataSource = listaContrib;
            UICD_TIPO_PERSONA.Properties.DataSource = listaPersonas;

            UIID_MUNICIPIO.Properties.DataSource = listaMuni;

            _datasistema.conectarVentas();

            List<FAC_CANAL> listaCanales = (from u in _datasistema .ContextoVentas .FAC_CANAL select u).ToList ();
            List<FAC_VENDEDOR> listaVendedores=(from u in _datasistema.ContextoVentas .FAC_VENDEDOR select u).ToList ();
            List<FAC_LISTA_PRECIO> listaPrecios = (from u in _datasistema.ContextoVentas.FAC_LISTA_PRECIO select u).ToList();

            UIID_CANAL.Properties.DataSource = listaCanales;
            UIID_VENDEDOR.Properties.DataSource = listaVendedores;
            UIID_LISTA_PRECIO.Properties.DataSource = listaPrecios;

            UICD_ESTADO.Properties.DataSource = MetodosForm.listaEstadosTercero();

            int aux= uitabcontrol_opcion.SelectedTabPageIndex ;
            foreach (DevExpress .XtraLayout .LayoutGroup  item in uitabcontrol_opcion .TabPages ){
                uitabcontrol_opcion.SelectedTabPage = item;
            }
            uitabcontrol_opcion.SelectedTabPageIndex = aux;

        }


        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                _datasistema.conectarContabilidad();
                lista = manejadorData.consultarVistaPorEmpresa(_datasistema.empresa.ID);
                llenarcombos();
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                refrescarUI();
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
            UIID.Text="";
            UIDS_NOMBRE.Text="";
            UIDS_RZN_COMER.Text="";
            UIDS_NM_NIT.Text="";
            UIDS_NM_DUI.Text="";
            UIDS_NM_RF.Text="";
            UICD_TIPO_CONTRIBUYENTE.EditValue=null;
            UIID_MUNICIPIO.EditValue=null;
            UIDS_DIRECCION.Text="";
            UIDS_NM_TELEFONO.Text = "";
            UIDS_CORREO_E.Text = "";
            UIDS_CONTACTO.Text = "";
            UIDS_REFERENCIA.Text = "";
            UIFLG_CLIENTE.Checked = false;
            UIFLG_PROVEEDOR.Checked = false;
            UIID_CUENTAXCOBRAR.EditValue = null;
            UIID_CUENTAXPAGAR.EditValue = null;
            UIFLG_CREDITO_CLIENTE.Checked = false;
            UIFLG_CREDITO_PROVEEDOR.Checked = false;
            UICD_TIPO_PERSONA.EditValue = null;
            UIID_LISTA_PRECIO.EditValue = null;
            UINM_CREDITO_CLIENTE.EditValue = 0;
            UINM_CREDITO_PROVEEDOR.EditValue = 0;
            UINM_DIAS_CREDITO_CLIENTE.EditValue = 0;
            UINM_DIAS_CREDITO_PROVEEDOR.EditValue = 0;
            UIID_CANAL.EditValue = null;
            UINM_SALDO_CLIENTE.EditValue = 0;
            UINM_SALDO_PROVEEDOR.EditValue = 0;
            UIFLG_PROVEEDOR_EXENTO_IVA.Checked = false;
            UIFLG_CLIENTE.Checked = false;
            UIID_VENDEDOR.EditValue = null;
            UICD_ESTADO.EditValue = 'A';

        }

        public void guardar()
        {
             try
                {

                    if (!validar()) { return; };
                    int cxc = 0;
                    int cxp = 0;
                    if (UIID_CUENTAXCOBRAR.EditValue != null)
                    {
                        cxc = (int)UIID_CUENTAXCOBRAR.EditValue;
                    }

                    if (UIID_CUENTAXPAGAR.EditValue != null)
                    {
                        cxp = (int)UIID_CUENTAXPAGAR.EditValue;
                    }
                    SIS_TERCERO m = new SIS_TERCERO
                    {
                        ID = 0,
                        ID_EMPRESA = _datasistema.empresa.ID,
                        DS_NOMBRE = UIDS_NOMBRE.Text,
                        DS_RZN_COMER = UIDS_RZN_COMER.Text,
                        DS_NM_NIT = UIDS_NM_NIT.Text,
                        DS_NM_DUI = UIDS_NM_DUI.Text,
                        DS_NM_RF = UIDS_NM_RF.Text,
                        CD_TIPO_CONTRIBUYENTE = char.Parse(UICD_TIPO_CONTRIBUYENTE.EditValue.ToString()),
                        ID_MUNICIPIO = int.Parse(UIID_MUNICIPIO.EditValue.ToString()),
                        DS_DIRECCION = UIDS_DIRECCION.Text,
                        DS_NM_TELEFONO = UIDS_NM_TELEFONO.Text,
                        DS_CORREO_E = UIDS_CORREO_E.Text,
                        DS_CONTACTO = UIDS_CONTACTO.Text,
                        DS_REFERENCIA = UIDS_REFERENCIA.Text,
                        FLG_CLIENTE = char.Parse(UIFLG_CLIENTE.EditValue.ToString()),
                        FLG_PROVEEDOR = char.Parse(UIFLG_PROVEEDOR.EditValue.ToString()),
                        ID_CUENTAXCOBRAR = cxc,
                        ID_CUENTAXPAGAR = cxp,
                        FLG_CREDITO_CLIENTE = char.Parse(UIFLG_CREDITO_CLIENTE.EditValue.ToString()),
                        FLG_CREDITO_PROVEEDOR = char.Parse(UIFLG_CREDITO_PROVEEDOR.EditValue.ToString()),
                        CD_TIPO_PERSONA = char.Parse(UICD_TIPO_PERSONA.EditValue.ToString()),
                        ID_LISTA_PRECIO = int.Parse(UIID_LISTA_PRECIO.EditValue.ToString()),
                        NM_CREDITO_CLIENTE = decimal.Parse(UINM_CREDITO_CLIENTE.EditValue.ToString()),
                        NM_CREDITO_PROVEEDOR = decimal.Parse(UINM_CREDITO_PROVEEDOR.EditValue.ToString()),
                        NM_DIAS_CREDITO_CLIENTE = int.Parse(UINM_DIAS_CREDITO_CLIENTE.EditValue.ToString()),
                        NM_DIAS_CREDITO_PROVEEDOR = int.Parse(UINM_DIAS_CREDITO_PROVEEDOR.EditValue.ToString()),
                        ID_CANAL = int.Parse(UIID_CANAL.EditValue.ToString()),
                        NM_SALDO_CLIENTE = decimal.Parse(UINM_SALDO_CLIENTE.EditValue.ToString()),
                        NM_SALDO_PROVEEDOR = decimal.Parse(UINM_SALDO_PROVEEDOR.EditValue.ToString()),
                        FLG_CLIENTE_EXENTO_IVA = char.Parse(UIFLG_CLIENTE_EXENTO_IVA.EditValue.ToString()),
                        FLG_PROVEEDOR_EXENTO_IVA = char.Parse(UIFLG_PROVEEDOR_EXENTO_IVA.EditValue.ToString()),
                        ID_VENDEDOR = int.Parse(UIID_VENDEDOR.EditValue.ToString()),
                        CD_ESTADO = char.Parse(UICD_ESTADO.EditValue.ToString())
                    };
                    if (UIID.Text == "")
                    {
                        m=manejadorData.insertar(m);
                    }
                    else
                    {
                        m.ID = int.Parse(UIID.Text);
                        manejadorData.modificar(m);

                    }
                    consultar();
                    MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
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
                SIS_TERCERO m = new SIS_TERCERO { ID = int.Parse(UIID.Text) };
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
          
        }

        public void cerrar()
        {
            this.Close();
        }

        public void enlazar()
        {
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
            UIDS_NOMBRE.DataBindings.Add("EditValue", lista, "DS_NOMBRE", false, DataSourceUpdateMode.Never);
            UIDS_RZN_COMER .DataBindings.Add("EditValue", lista, "DS_RZN_COMER", false, DataSourceUpdateMode.Never);
            UIDS_NM_NIT .DataBindings.Add("EditValue", lista, "DS_NM_NIT", false, DataSourceUpdateMode.Never);
            UIDS_NM_DUI .DataBindings.Add("EditValue", lista, "DS_NM_DUI", false, DataSourceUpdateMode.Never);
            UIDS_NM_RF .DataBindings.Add("EditValue", lista, "DS_NM_RF", false, DataSourceUpdateMode.Never);
            UICD_TIPO_CONTRIBUYENTE .DataBindings.Add("EditValue", lista, "CD_TIPO_CONTRIBUYENTE", false, DataSourceUpdateMode.Never);
            UIID_MUNICIPIO .DataBindings.Add("EditValue", lista, "ID_MUNICIPIO", false, DataSourceUpdateMode.Never);
            UIDS_DIRECCION .DataBindings.Add("EditValue", lista, "DS_DIRECCION", false, DataSourceUpdateMode.Never);
            UIDS_NM_TELEFONO .DataBindings.Add("EditValue", lista, "DS_NM_TELEFONO", false, DataSourceUpdateMode.Never);
            UIDS_CORREO_E.DataBindings.Add("EditValue", lista, "DS_CORREO_E", false, DataSourceUpdateMode.Never);
            UIDS_CONTACTO .DataBindings.Add("EditValue", lista, "DS_CONTACTO", false, DataSourceUpdateMode.Never);
            UIDS_REFERENCIA.DataBindings.Add("EditValue", lista, "DS_REFERENCIA", false, DataSourceUpdateMode.Never);
            UIFLG_CLIENTE .DataBindings.Add("EditValue", lista, "FLG_CLIENTE", false, DataSourceUpdateMode.Never);
            UIFLG_PROVEEDOR .DataBindings.Add("EditValue", lista, "FLG_PROVEEDOR", false, DataSourceUpdateMode.Never);
            UIID_CUENTAXCOBRAR .DataBindings.Add("EditValue", lista, "ID_CUENTAXCOBRAR", false, DataSourceUpdateMode.Never);
            UIID_CUENTAXPAGAR .DataBindings.Add("EditValue", lista, "ID_CUENTAXPAGAR", false, DataSourceUpdateMode.Never);
            UIFLG_CREDITO_CLIENTE .DataBindings.Add("EditValue", lista, "FLG_CREDITO_CLIENTE", false, DataSourceUpdateMode.Never);
            UIFLG_CREDITO_PROVEEDOR.DataBindings.Add("EditValue", lista, "FLG_CREDITO_PROVEEDOR", false, DataSourceUpdateMode.Never);
            UICD_TIPO_PERSONA .DataBindings.Add("EditValue", lista, "CD_TIPO_PERSONA", false, DataSourceUpdateMode.Never);
            
            UIID_LISTA_PRECIO.DataBindings.Add("EditValue", lista, "ID_LISTA_PRECIO", false, DataSourceUpdateMode.Never);
            UINM_CREDITO_CLIENTE.DataBindings.Add("EditValue", lista, "NM_CREDITO_CLIENTE", false, DataSourceUpdateMode.Never);
            UINM_CREDITO_PROVEEDOR.DataBindings.Add("EditValue", lista, "NM_CREDITO_PROVEEDOR", false, DataSourceUpdateMode.Never);
            UINM_DIAS_CREDITO_CLIENTE.DataBindings.Add("EditValue", lista, "NM_DIAS_CREDITO_CLIENTE", false, DataSourceUpdateMode.Never);
            UINM_DIAS_CREDITO_PROVEEDOR.DataBindings.Add("EditValue", lista, "NM_DIAS_CREDITO_PROVEEDOR", false, DataSourceUpdateMode.Never);
            UIID_CANAL.DataBindings.Add("EditValue", lista, "ID_CANAL", false, DataSourceUpdateMode.Never);
            UINM_SALDO_CLIENTE.DataBindings.Add("EditValue", lista, "NM_SALDO_CLIENTE", false, DataSourceUpdateMode.Never);
            UINM_SALDO_PROVEEDOR.DataBindings.Add("EditValue", lista, "NM_SALDO_PROVEEDOR", false, DataSourceUpdateMode.Never);
            UIFLG_PROVEEDOR_EXENTO_IVA.DataBindings.Add("EditValue", lista, "FLG_PROVEEDOR_EXENTO_IVA", false, DataSourceUpdateMode.Never);
            UIFLG_CLIENTE_EXENTO_IVA.DataBindings.Add("EditValue", lista, "FLG_CLIENTE_EXENTO_IVA", false, DataSourceUpdateMode.Never);
            UIID_VENDEDOR.DataBindings.Add("EditValue", lista, "ID_VENDEDOR", false, DataSourceUpdateMode.Never);
            UICD_ESTADO.DataBindings.Add("EditValue", lista, "CD_ESTADO", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_NOMBRE.DataBindings.Clear();
            UIDS_RZN_COMER.DataBindings.Clear();
            UIDS_NM_NIT.DataBindings.Clear();
            UIDS_NM_DUI.DataBindings.Clear();
            UIDS_NM_RF.DataBindings.Clear();
            UICD_TIPO_CONTRIBUYENTE.DataBindings .Clear();
            UIID_MUNICIPIO.DataBindings.Clear();
            UIDS_DIRECCION.DataBindings.Clear();
            UIDS_NM_TELEFONO.DataBindings.Clear();
            UIDS_CORREO_E.DataBindings.Clear();
            UIDS_CONTACTO.DataBindings.Clear();
            UIDS_REFERENCIA.DataBindings.Clear();
            UIFLG_CLIENTE.DataBindings.Clear();
            UIFLG_PROVEEDOR.DataBindings.Clear();
            UIID_CUENTAXCOBRAR.DataBindings.Clear();
            UIID_CUENTAXPAGAR.DataBindings.Clear();
            UIFLG_CREDITO_CLIENTE.DataBindings.Clear();
            UIFLG_CREDITO_PROVEEDOR.DataBindings.Clear();
            UICD_TIPO_PERSONA.DataBindings.Clear();
            UIID_LISTA_PRECIO.DataBindings.Clear();
            UINM_CREDITO_CLIENTE.DataBindings.Clear();
            UINM_CREDITO_PROVEEDOR.DataBindings.Clear();
            UINM_DIAS_CREDITO_CLIENTE.DataBindings.Clear();
            UINM_DIAS_CREDITO_PROVEEDOR.DataBindings.Clear();
            UIID_CANAL.DataBindings.Clear();
            UINM_SALDO_CLIENTE.DataBindings.Clear();
            UINM_SALDO_PROVEEDOR.DataBindings.Clear();
            UIFLG_PROVEEDOR_EXENTO_IVA.DataBindings.Clear();
            UIFLG_CLIENTE_EXENTO_IVA.DataBindings.Clear();
            UIFLG_CLIENTE.DataBindings.Clear();
            UIID_VENDEDOR.DataBindings.Clear();
            UICD_ESTADO.DataBindings.Clear();
        }
        public override void refrescar()
        {
            consultar();
        }

        public bool validar()
        {
            if (UIID_MUNICIPIO.EditValue == null)
            {
                MetodosForm.mensajeErrorDefault("Seleccione un municipio", _datasistema);
                return false;
            }
            if (UICD_TIPO_PERSONA.EditValue == null)
            {
                MetodosForm.mensajeErrorDefault("Seleccione un tipo de persona", _datasistema);
                return false;
            }
            if (UICD_TIPO_CONTRIBUYENTE.EditValue == null)
            {
                MetodosForm.mensajeErrorDefault("Seleccione un tipo de contribuyente", _datasistema);
                return false;
            }
            if (char.Parse(UIFLG_CLIENTE.EditValue.ToString()) == 'S')
            {
                if (UIID_VENDEDOR.EditValue == null)
                {
                    MetodosForm.mensajeErrorDefault("Seleccione un tipo de contribuyente", _datasistema);
                    return false;
                }
                if (UIID_CANAL.EditValue == null)
                {
                    MetodosForm.mensajeErrorDefault("Seleccione un tipo de contribuyente", _datasistema);
                    return false;
                }
                if (UIID_LISTA_PRECIO.EditValue == null)
                {
                    MetodosForm.mensajeErrorDefault("Seleccione un tipo de contribuyente", _datasistema);
                    return false;
                }
            }
            return true;
        }

        public override void enlazar_aux()
        {
            desenlazar();
            enlazar();
        }

        private void UIFLG_CLIENTE_CheckedChanged(object sender, EventArgs e)
        {
            refrescarUI();
        }

        private void UIFLG_PROVEEDOR_CheckedChanged(object sender, EventArgs e)
        {
            refrescarUI();
        }

        public void refrescarUI() {
            if (UIFLG_PROVEEDOR.Checked)
            {
                uipnl_proveedor.Enabled = true;
            }
            else
            {
                uipnl_proveedor.Enabled = false;
            }
            if (UIFLG_CLIENTE.Checked)
            {
                uipnl_cliente.Enabled = true;
            }
            else
            {
                uipnl_cliente.Enabled = false;
            }
        }
    }
}
