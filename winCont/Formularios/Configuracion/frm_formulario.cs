using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema;
using winCont.Utilidades;
using System.Linq;
using winCont.Clases;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_formulario : winCont.Formularios.MasterFormTab, Interfaz_forms
    {
        List<V_SIS_FORM> lista;
        List<SIS_MODULO> lista_mod;
        List<clsGenericaPares> lista_interfaz;
        ManejadorForm manejadorData;
        ManejadorModulo manejadorModulo;
        public frm_formulario()
        {
            InitializeComponent();
        }
        public frm_formulario(DataSistema ds) : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorForm(ds);
            manejadorModulo = new ManejadorModulo(ds);
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                lista = manejadorData.consultarVista();
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                if (lista.Count() == 0)
                {
                    nuevo();
                }

                lista_mod = manejadorModulo.consultar();
                UIID_MODULO.Properties.DataSource = lista_mod;

                lista_interfaz = MetodosForm.listaDeModosDeInterfaz();
                UICD_MODO_INTERFAZ.Properties.DataSource = lista_interfaz;


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
            UICD_FORM.Text = "";
            UIDS_NOMBRE.Text = "";
            UIDS_ALT_NOMBRE.Text = "";
            UIDS_TOOLTIP.Text = "";
            UIID_MODULO.EditValue = null;
            UICD_MODO_INTERFAZ.EditValue = null;
            UIFLG_REQ_EMPRESA.Checked = false;
            UIFLG_REQ_PERIODO .Checked =false;
        }

        public void guardar()
        {
             try
                {
                SIS_FORM m = new SIS_FORM { 
                    ID = 0, 
                    CD_FORM = UICD_FORM.Text, 
                    DS_NOMBRE = UIDS_NOMBRE.Text, 
                    DS_ALT_NOMBRE = UIDS_ALT_NOMBRE.Text, 
                    DS_TOOLTIP = UIDS_TOOLTIP.Text, 
                    ID_MODULO = int.Parse(UIID_MODULO.EditValue.ToString()), 
                    CD_MODO_INTERFAZ = int.Parse(UICD_MODO_INTERFAZ.EditValue.ToString()), 
                    FLG_REQ_EMPRESA = char.Parse(UIFLG_REQ_EMPRESA.EditValue.ToString()), 
                    FLG_REQ_PERIODO = char.Parse(UIFLG_REQ_PERIODO.EditValue.ToString()) 
                };
                if (UIID.Text == "")
                {
                   m= manejadorData.insertar(m);
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
                SIS_FORM m = new SIS_FORM { ID = int.Parse (UIID.Text ) };
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
            UICD_FORM.DataBindings.Add("EditValue", lista, "CD_FORM", false, DataSourceUpdateMode.Never);
            UIDS_ALT_NOMBRE.DataBindings.Add("EditValue", lista, "DS_ALT_NOMBRE", false, DataSourceUpdateMode.Never);
            UIDS_TOOLTIP.DataBindings.Add("EditValue", lista, "DS_TOOLTIP", false, DataSourceUpdateMode.Never);
            UIID_MODULO.DataBindings.Add("EditValue", lista, "ID_MODULO", false, DataSourceUpdateMode.Never);
            UICD_MODO_INTERFAZ.DataBindings.Add("EditValue", lista, "CD_MODO_INTERFAZ", false, DataSourceUpdateMode.Never);
            UIFLG_REQ_EMPRESA.DataBindings.Add("EditValue", lista, "FLG_REQ_EMPRESA", false, DataSourceUpdateMode.Never);
            UIFLG_REQ_PERIODO.DataBindings.Add("EditValue", lista, "FLG_REQ_PERIODO", false, DataSourceUpdateMode.Never);

        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear ();
            UIDS_NOMBRE.DataBindings.Clear();
            UICD_FORM.DataBindings.Clear();
            UIDS_ALT_NOMBRE.DataBindings.Clear();
            UIDS_TOOLTIP.DataBindings.Clear();
            UIID_MODULO.DataBindings.Clear();
            UICD_MODO_INTERFAZ.DataBindings.Clear();
            UIFLG_REQ_EMPRESA.DataBindings.Clear();
            UIFLG_REQ_PERIODO.DataBindings.Clear();
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
