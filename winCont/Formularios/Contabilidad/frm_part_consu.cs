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


namespace winCont.Formularios.Contabilidad
{
    public partial class frm_part_consu : winCont.Formularios.MasterFormTab,Interfaz_forms

    {
        List<V_CONT_ENCA_PART_DIARIO> lista;
        List<clsGenericaPares> lista_estados;

        public frm_part_consu()
        {
            InitializeComponent();
        }

        public frm_part_consu(DataSistema ds) : base(ds)
        {
            InitializeComponent();
        }

        public void llenarCombos()
        {

            lista_estados = MetodosForm.listaEstadosPartidaBorrador();
            UICD_ESTA_PART.Properties.DataSource = lista_estados;
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarContabilidad();
                lista = (from u in _datasistema.ContextoContabilidad.V_CONT_ENCA_PART_DIARIO where u.ID_EMPRESA == _datasistema.empresa.ID && u.NM_EJERCICIO == _datasistema.periodo.NM_EJERCICIO && u.NM_PERIODO == _datasistema.periodo.NM_PERIODO select u
                    ).ToList();
                UIID.Text = "";
                llenarCombos();
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                //if (lista.Count() == 0)
                //{
                //    nuevo();
                //}
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void nuevo()
        {
            
        }

        public void guardar()
        {
            
        }

        public void eliminar()
        {
            
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
            UIFE_PARTIDA.DataBindings.Add("EditValue", lista, "FE_PARTIDA", false, DataSourceUpdateMode.Never);
            UIID_DIARIO.DataBindings.Add("EditValue", lista, "ID_DIARIO", false, DataSourceUpdateMode.Never);
            UIDS_CONCEPTO.DataBindings.Add("EditValue", lista, "DS_CONCEPTO", false, DataSourceUpdateMode.Never);
            UIDS_REFERENCIA.DataBindings.Add("EditValue", lista, "DS_REFERENCIA", false, DataSourceUpdateMode.Never);
            UICD_ESTA_PART.DataBindings.Add("EditValue", lista, "CD_ESTA_PART", false, DataSourceUpdateMode.Never);
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar(){
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

        public override void enlazar_aux()
        {
            desenlazar();
            enlazar();
        }
    }
}
