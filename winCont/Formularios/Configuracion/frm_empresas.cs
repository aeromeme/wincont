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
    public partial class frm_empresas : winCont.Formularios.MasterFormTab, Interfaz_forms
    {
        List<SIS_EMPRESAS> lista;
        List<clsGenericaPares> lista_tipCont;
        ManejadorEmpresas manejadorData;
        public frm_empresas()
        {
            InitializeComponent();
        }
        public frm_empresas(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorEmpresas(ds);

        }

        public void consultar()
        {
            try
            {

                lista = manejadorData.consultar();
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                lista_tipCont = MetodosForm.listaDeTipodeContribuyentes();
                UICD_TIPO_CONTRIBUCION.Properties.DataSource = lista_tipCont;
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
            UIDS_EMPRESA.Text = "";
            UIDS_RAZON_SOCIAL.Text = "";
            UICD_TIPO_CONTRIBUCION.EditValue = null;
            UIDS_DIRECCION.Text = "";
            UIDS_NIT.Text = "";
            UIDS_NRF.Text = "";
            UIDS_CONTACTO_1.Text = "";
            UIDS_CONTACTO_2.Text = "";
            UIDS_TELEFONO_1.Text = "";
            UIDS_TELEFONO_2.Text = "";
            UIDS_CORREO_E.Text = "";
            UIDS_GERENTE.Text = "";
            UIDS_CONTADOR.Text = "";
            UIDS_AUDITOR.Text = "";


        }

        public void guardar()
        {
            try
            {

                SIS_EMPRESAS m = new SIS_EMPRESAS
                {
                    ID = 0,
                    DS_EMPRESA = UIDS_EMPRESA.Text,
                    DS_RAZON_SOCIAL = UIDS_RAZON_SOCIAL.Text,
                    CD_TIPO_CONTRIBUYENTE = (string)UICD_TIPO_CONTRIBUCION.EditValue,
                    DS_DIRECCION = UIDS_DIRECCION.Text,
                    DS_NIT = UIDS_NIT.Text,
                    DS_NRF = UIDS_NRF.Text,
                    DS_CONTACTO_1 = UIDS_CONTACTO_1.Text,
                    DS_CONTACTO_2 = UIDS_CONTACTO_2.Text,
                    DS_TELEFONO_1 = UIDS_TELEFONO_1.Text,
                    DS_TELEFONO_2 = UIDS_TELEFONO_2.Text,
                    DS_CORREO_E = UIDS_CORREO_E.Text,
                    DS_GERENTE = UIDS_GERENTE.Text,
                    DS_CONTADOR = UIDS_CONTADOR.Text,
                    DS_AUDITOR = UIDS_AUDITOR.Text
                };

                if (UIID.Text == "")
                {
                    m = manejadorData.insertar(m);
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
                SIS_EMPRESAS m = new SIS_EMPRESAS { ID = int.Parse(UIID.Text) };
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
            UIDS_EMPRESA.DataBindings.Add("EditValue", lista, "DS_EMPRESA", false, DataSourceUpdateMode.Never);
            UIDS_RAZON_SOCIAL.DataBindings.Add("EditValue", lista, "DS_RAZON_SOCIAL", false, DataSourceUpdateMode.Never);
            UICD_TIPO_CONTRIBUCION.DataBindings.Add("EditValue", lista, "CD_TIPO_CONTRIBUYENTE", false, DataSourceUpdateMode.Never);
            UIDS_DIRECCION.DataBindings.Add("EditValue", lista, "DS_DIRECCION", false, DataSourceUpdateMode.Never);
            UIDS_NIT.DataBindings.Add("EditValue", lista, "DS_NIT", false, DataSourceUpdateMode.Never);
            UIDS_NRF.DataBindings.Add("EditValue", lista, "DS_NRF", false, DataSourceUpdateMode.Never);
            UIDS_CONTACTO_1.DataBindings.Add("EditValue", lista, "DS_CONTACTO_1", false, DataSourceUpdateMode.Never);
            UIDS_CONTACTO_2.DataBindings.Add("EditValue", lista, "DS_CONTACTO_2", false, DataSourceUpdateMode.Never);
            UIDS_TELEFONO_1.DataBindings.Add("EditValue", lista, "DS_TELEFONO_1", false, DataSourceUpdateMode.Never);
            UIDS_TELEFONO_2.DataBindings.Add("EditValue", lista, "DS_TELEFONO_2", false, DataSourceUpdateMode.Never);
            UIDS_CORREO_E.DataBindings.Add("EditValue", lista, "DS_CORREO_E", false, DataSourceUpdateMode.Never);
            UIDS_GERENTE.DataBindings.Add("EditValue", lista, "DS_GERENTE", false, DataSourceUpdateMode.Never);
            UIDS_CONTADOR.DataBindings.Add("EditValue", lista, "DS_CONTADOR", false, DataSourceUpdateMode.Never);
            UIDS_AUDITOR.DataBindings.Add("EditValue", lista, "DS_AUDITOR", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_EMPRESA.DataBindings.Clear();
            UIDS_RAZON_SOCIAL.DataBindings.Clear();
            UICD_TIPO_CONTRIBUCION.DataBindings.Clear();
            UIDS_DIRECCION.DataBindings.Clear();
            UIDS_NIT.DataBindings.Clear();
            UIDS_NRF.DataBindings.Clear();
            UIDS_CONTACTO_1.DataBindings.Clear();
            UIDS_CONTACTO_2.DataBindings.Clear();
            UIDS_TELEFONO_1.DataBindings.Clear();
            UIDS_TELEFONO_2.DataBindings.Clear();
            UIDS_CORREO_E.DataBindings.Clear();
            UIDS_GERENTE.DataBindings.Clear();
            UIDS_CONTADOR.DataBindings.Clear();
            UIDS_AUDITOR.DataBindings.Clear();
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
