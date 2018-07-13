using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ContabilidadDB;
using winCont.Utilidades ;
using System.Linq;
using winCont.Logica.Contabilidad;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_diario : winCont.Formularios.MasterFormTab,Interfaz_forms 
    {
        List<CONT_DIARIO > lista;
        ManejadorDiario manejadorData;
        public frm_diario()
        {
            InitializeComponent();
        }

        public frm_diario(DataSistema ds) : base(ds) 
        {
            InitializeComponent();
            manejadorData = new ManejadorDiario(ds);
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarContabilidad();
                lista = manejadorData.consultarPorIdEmpresa(_datasistema.empresa.ID);
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
            UIDS_NOMBRE.Text = "";
            UIFLG_CONSOL_DIA.Checked = false;
        }

        public void guardar()
        {
            try
                {
                CONT_DIARIO m = new CONT_DIARIO { ID = 0, DS_NOMBRE = UIDS_NOMBRE.Text, FLG_CONSOL_DIA = char.Parse(UIFLG_CONSOL_DIA.EditValue.ToString()), ID_EMPRESA = _datasistema.empresa.ID };
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
                CONT_DIARIO m = (from u in _datasistema.ContextoContabilidad.CONT_DIARIO
                                       where u.ID == int.Parse(UIID.Text)
                                       select u).First();
           

                _datasistema.ContextoContabilidad.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoContabilidad.CONT_DIARIO.DeleteOnSubmit(m);
                _datasistema.ContextoContabilidad.SubmitChanges();
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
            UIDS_NOMBRE .DataBindings .Add("EditValue",lista,"DS_NOMBRE",false,DataSourceUpdateMode.Never );
            UIFLG_CONSOL_DIA .DataBindings .Add("EditValue",lista ,"FLG_CONSOL_DIA",false,DataSourceUpdateMode.Never );
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_NOMBRE.DataBindings.Clear();
            UIFLG_CONSOL_DIA.DataBindings.Clear();
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
