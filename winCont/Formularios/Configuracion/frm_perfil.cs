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
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_perfil : winCont.Formularios.MasterFormTab, Interfaz_forms
{
         List<SIS_PERFIL> lista;
         List<V_SIS_PERFIL_OPC_MENU> lista_opc_perf;
         List<V_SIS_OPC_MENU> lista_opc;
         ManejadorPerfil manejadorData;
         ManejadorOpcionMenu manejadorOpcionMenu;
         ManejadorOpcionesPerfil manejadorOpcionesPerfil;

    
         public frm_perfil()
        {
            InitializeComponent();
        }

         public frm_perfil(DataSistema ds):base(ds) {
            InitializeComponent();
            manejadorData = new ManejadorPerfil(ds);
            manejadorOpcionMenu = new ManejadorOpcionMenu(ds);
            manejadorOpcionesPerfil = new ManejadorOpcionesPerfil(ds);

        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                lista = manejadorData.consultar();
                uigridcontrol.DataSource = lista;
                UIID.Text = "";
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
            UIDS_PERFIL.Text = "";
        }

        public void guardar()
        {
            try
                {
            SIS_PERFIL m = new SIS_PERFIL { ID = 0, DS_PERFIL = UIDS_PERFIL.Text };
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
                SIS_PERFIL m = new SIS_PERFIL { ID = int.Parse (UIID.Text ) };
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
            UIDS_PERFIL.DataBindings.Add("EditValue", lista, "DS_PERFIL", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_PERFIL.DataBindings.Clear();
        }
        public override void refrescar()
        {
            consultar();
        }

        public bool validar()
        {
            return true;
        }
        public override void enlazar_aux()
        {
            desenlazar();
            enlazar();
        }

        public void consultarDetalle()
        {

            try
            {
                if (UIID.Text != "")
                {
                    lista_opc_perf = manejadorOpcionesPerfil .consultarVistaPorIDPerfil (int.Parse(UIID.Text.ToString()));

                    UIGRID_PERFIL_OPC .DataSource = lista_opc_perf;

                    lista_opc = manejadorOpcionMenu.consultarVistaSinPerfil(int.Parse(UIID.Text.ToString())); ;
                    UIGRID_OPC.DataSource = lista_opc;
                }
                else
                {
                    UIGRID_PERFIL_OPC.DataSource = null;
                    UIGRID_OPC.DataSource = null;
                }
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        private void UIGRID_PERF_OPC_DoubleClick(object sender, EventArgs e)
        {
            if (UIGRIDVIEW_PERFIL_OPC .FocusedRowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                try
                {
                    SIS_PERFIL_OPC_MENU m = new SIS_PERFIL_OPC_MENU {ID=int.Parse(UIGRIDVIEW_PERFIL_OPC.GetFocusedRowCellValue("ID").ToString())};
                    manejadorOpcionesPerfil.eliminar(m);
                    consultarDetalle();
                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                }
            }
        }

        private void UIGRID_OPC_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SIS_PERFIL_OPC_MENU m = new SIS_PERFIL_OPC_MENU { ID = 0, ID_OPC_MENU = int.Parse(UIGRIDVIEW_OPC.GetFocusedRowCellValue("ID").ToString()), ID_PERFIL = int.Parse(UIID.Text.ToString()) };
                manejadorOpcionesPerfil.insertar(m);
                consultarDetalle();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        private void UIID_EditValueChanged(object sender, EventArgs e)
        {
            consultarDetalle();
        }
    }
}
