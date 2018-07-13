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
using winCont.Logica .Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_usuarios : winCont.Formularios.MasterFormTab,Interfaz_forms 
    {
        List<SIS_USER > lista;
        List<SIS_PERFIL> lista_perf;
        ManejadorUsuario manejadorData;
        ManejadorPerfil manejadorPerfil;
        ManejadorEmpresas manejadorEmpresas;
        ManejadorUsuarioEmpresa manejadorUsuarioEmpresa;
        public frm_usuarios()
        {
            InitializeComponent();
        }
        public frm_usuarios(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorUsuario(ds);
            manejadorPerfil = new ManejadorPerfil(ds);
            manejadorEmpresas = new ManejadorEmpresas(ds);
            manejadorUsuarioEmpresa = new ManejadorUsuarioEmpresa(ds);
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                lista = manejadorData.consultar(); ;
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                if (lista.Count() == 0)
                {
                    nuevo();
                }
                lista_perf = manejadorPerfil.consultar(); ;
                UIID_PERFIL.Properties.DataSource = lista_perf;

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
            UICD_LOGIN .Text = "";
            UICD_PASSWORD .Text = "";
            UIDS_NOMBRE_USUARIO.Text = "";
            UIID_PERFIL .EditValue  =null;
        }

        public void guardar()
        {
            try
                {
                    SIS_USER m = new SIS_USER { ID = 0, CD_LOGIN = UICD_LOGIN.Text, CD_PASSWORD = UICD_PASSWORD.Text, DS_NOMBRE_USUARIO = UIDS_NOMBRE_USUARIO.Text, CD_ESTADO = 'A', ID_PERFIL = int.Parse(UIID_PERFIL.EditValue.ToString()) };
            
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
                SIS_USER m = new SIS_USER { ID=int.Parse (UIID.Text )};

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
            UICD_LOGIN.DataBindings.Add("EditValue", lista, "CD_LOGIN", false, DataSourceUpdateMode.Never);
            UICD_PASSWORD.DataBindings.Add("EditValue", lista, "CD_PASSWORD", false, DataSourceUpdateMode.Never);
            UIDS_NOMBRE_USUARIO.DataBindings.Add("EditValue", lista, "DS_NOMBRE_USUARIO", false, DataSourceUpdateMode.Never);
            UIID_PERFIL.DataBindings .Add("EditValue",lista ,"ID_PERFIL",false,DataSourceUpdateMode.Never );
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UICD_LOGIN.DataBindings.Clear();
            UICD_PASSWORD.DataBindings.Clear();
            UIDS_NOMBRE_USUARIO.DataBindings.Clear();
            UIID_PERFIL.DataBindings.Clear();
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

#region EMPRESAS
        List<V_SIS_USER_EMPRESA> lista_usuaempre;
        List<SIS_EMPRESAS> lista_empre;
        private void uilst_empresas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SIS_USER_EMPRESA  m = new SIS_USER_EMPRESA  { ID = 0, ID_EMPRESA  = int.Parse(uilst_empresas .SelectedValue.ToString()), ID_USER  = int.Parse(UIID .Text ) };

                manejadorUsuarioEmpresa.insertar(m);
                consultarempresas ();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        private void uilst_usuarioempresa_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SIS_USER_EMPRESA m = new SIS_USER_EMPRESA { ID = int.Parse(uilst_usuarioempresa.SelectedValue.ToString()) };
                manejadorUsuarioEmpresa.eliminar(m);
                consultarempresas();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }

        }
        public void consultarempresas() {
            try
            {
                 if (UIID.Text != "")
            {
                lista_empre = manejadorEmpresas.consultarVistaPorIdUsuarioConsiderUsuEmpr(int.Parse(UIID.Text));
                lista_usuaempre = manejadorUsuarioEmpresa .consultarVistaPorUsuario (int.Parse (UIID.Text));

                uilst_empresas.DataSource = lista_empre;
                uilst_usuarioempresa.DataSource = lista_usuaempre;
             }   
            else
            {
                uilst_empresas.DataSource = null ;
                uilst_usuarioempresa.DataSource = null ;
            }

            }
            catch (Exception e)
            {
                MetodosForm.mensajeErrorDefault(e.Message,_datasistema );
            }
            

        }

#endregion

        private void UIID_EditValueChanged(object sender, EventArgs e)
        {
           
                consultarempresas();
            
        }
    }
}
