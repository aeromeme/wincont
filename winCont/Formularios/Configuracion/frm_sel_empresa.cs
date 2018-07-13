using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades ;
using winCont.Clases ;
using System.Linq;
using Sistema;
using winCont.Logica.Configuracion;
namespace winCont.Formularios.Configuracion
{
    public partial class frm_sel_empresa : winCont.Formularios.MasterForm_Seleccion
    {
        
        public frm_sel_empresa()
        {
            InitializeComponent();
        }
        public frm_sel_empresa(DataSistema ds):base(ds)
        {
            InitializeComponent();
            manejadorUsuarioEmpresa = new ManejadorUsuarioEmpresa(ds);
            manejadorEmpresa = new ManejadorEmpresas(ds);
        }
        public List<V_SIS_USER_EMPRESA> lst_empresas;
        public SIS_EMPRESAS empresa;
        ManejadorUsuarioEmpresa manejadorUsuarioEmpresa;
        ManejadorEmpresas manejadorEmpresa;
        public void Consultar() {
            _datasistema.conectarSistema();
            lst_empresas = manejadorUsuarioEmpresa.consultarVistaPorUsuario(_datasistema.usuario.ID);
            UIGRIDCONTROL.DataSource = lst_empresas;
        }

        private void frm_sel_empresa_Activated(object sender, EventArgs e)
        {
            Consultar();
        }

        private void UIGRIDCONTROL_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int id_empresa = int.Parse(UIGRIDVIEW.GetFocusedRowCellValue("ID_EMPRESA").ToString());
                empresa = manejadorEmpresa.consultarPorIdEmpresa(id_empresa);
                this.Close();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message ,_datasistema );
            }
            


        }
    }
}
