using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContabilidadDB;
using winCont.Utilidades;
using winCont.Clases ;
using winCont.Logica.Contabilidad;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_rubros : winCont.Formularios.MasterFormTab, Interfaz_forms
    {
        List<CONT_RUBROS> lista;
        List<clsGenericaPares> lista_rubros_bases;
        ManejadorRubro manejadorData;
        public frm_rubros()
        {
            InitializeComponent();
        }

        public frm_rubros(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorRubro(ds);
        }

        public void llenarcombos() {
            lista_rubros_bases = MetodosForm.listaDeRubrosContablesBases();
            UICD_RUBRO_BASE.Properties.DataSource = lista_rubros_bases;
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarContabilidad();
                lista = manejadorData.consultarPorIdEmpresa(_datasistema.empresa.ID);
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
            desenlazar();
            UIID.Text = "";
            UIDS_RUBRO.Text = "";
            UICD_RUBRO_BASE.EditValue = null;
        }

        public void guardar()
        {
            try
                {
                CONT_RUBROS m = new CONT_RUBROS { ID = 0, DS_RUBRO = UIDS_RUBRO.Text, ID_EMPRESA = _datasistema.empresa.ID, CD_RUBRO_BASE = UICD_RUBRO_BASE.EditValue.ToString() };
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
                CONT_RUBROS m = new CONT_RUBROS { ID = int.Parse(UIID.Text) };
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
            throw new NotImplementedException();
        }

        public void cerrar()
        {
            this.Close();
        }

        public void enlazar()
        {
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
            UIDS_RUBRO.DataBindings.Add("EditValue", lista, "DS_RUBRO", false, DataSourceUpdateMode.Never);
            UICD_RUBRO_BASE.DataBindings.Add("EditValue", lista, "CD_RUBRO_BASE", false, DataSourceUpdateMode.Never);
        
        }

        public bool validar()
        {
            return true;
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_RUBRO.DataBindings.Clear();
            UICD_RUBRO_BASE.DataBindings.Clear();
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
    }
}
