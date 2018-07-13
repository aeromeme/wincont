using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema;
using winCont.Utilidades ;
using System.Linq;
using winCont.Logica.Configuracion ;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_menu : winCont.Formularios.MasterFormTab, Interfaz_forms 
    {
        List<SIS_MENU> lista;
        ManejadorMenu manejadorData;
        public frm_menu()
        {
            InitializeComponent();
        }
        public frm_menu(DataSistema ds):base(ds) {
            InitializeComponent();
            manejadorData = new ManejadorMenu(ds);
        }

        public void consultar()
        {
            try
            {
                lista = manejadorData.consultar();
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

                MetodosForm.mensajeErrorDefault(e.Message ,_datasistema );
            }
        }

        public void nuevo()
        {
            desenlazar();
            UIID.Text = "";
            UIDS_MENU.Text = "";

        }

        public void guardar()
        {
            try
            {
                SIS_MENU m = new SIS_MENU { ID = 0, DS_MENU = UIDS_MENU.Text };
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
                SIS_MENU m = new SIS_MENU { ID = int.Parse (UIID.Text )};
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
            UIDS_MENU.DataBindings.Add("EditValue", lista, "DS_MENU", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_MENU.DataBindings.Clear();
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
