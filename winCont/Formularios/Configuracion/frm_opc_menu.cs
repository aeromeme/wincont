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
    public partial class frm_opc_menu : winCont.Formularios.MasterForm, Interfaz_forms 
    {
        List<SIS_MENU> lista;
        List<V_SIS_OPC_MENU > lista_opc;
        List<SIS_FORM> lista_forms;
        ManejadorOpcionMenu manejadorData;
        ManejadorForm manejadorFormularios;
        ManejadorMenu manejadorMenu;
        public frm_opc_menu()
        {
            InitializeComponent();
        }

        public frm_opc_menu(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorOpcionMenu(ds);
            manejadorMenu = new ManejadorMenu(ds);
            manejadorFormularios = new ManejadorForm(ds);

        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                lista = manejadorMenu.consultar(); 
                UILSTMENU .DataSource =lista;

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
           
        }

        public void desenlazar()
        {
            
        }
        public bool validar()
        {
            return true;
        }

        private void UILSTMENU_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultarDetalle();
            
        }
        public void consultarDetalle() {
            try
            {
                 if (UILSTMENU.SelectedValue!=null){
                     lista_opc = manejadorData.consultarVistaPorIDMenu(int.Parse(UILSTMENU.SelectedValue.ToString()));

                UILSTOPCIONES.DataSource = lista_opc;
       
                lista_forms =manejadorFormularios.consultarSinMenu();
                UILSTFORMULARIO.DataSource = lista_forms;
                }else{
                    UILSTOPCIONES .DataSource =null;
                    UILSTFORMULARIO .DataSource =null;
                }
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message,_datasistema );
            }
        }



        private void UILSTFORMULARIO_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SIS_OPC_MENU m = new SIS_OPC_MENU { ID = 0, ID_FORM  = int.Parse (UILSTFORMULARIO .SelectedValue.ToString()),ID_MENU =int.Parse (UILSTMENU .SelectedValue .ToString ())  };
                manejadorData.insertar(m);
                consultarDetalle();
            }
            catch (Exception ex)
            {
                
                 MetodosForm.mensajeErrorDefault(ex.Message,_datasistema );
            }
        }

        

        private void UILSTOPCIONES_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SIS_OPC_MENU m = (from u in _datasistema.contextoSistema.SIS_OPC_MENU
                              where u.ID == int.Parse(UILSTOPCIONES .SelectedValue .ToString())
                              select u).First();
                manejadorData.eliminar(m);
                consultarDetalle();
            }
            catch (Exception ex)
            {
                
                MetodosForm.mensajeErrorDefault(ex.Message,_datasistema );
            }
        }

        private void frm_opc_menu_Load(object sender, EventArgs e)
        {
            consultar();
        }
    }
}
