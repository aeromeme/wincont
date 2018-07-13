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
    public partial class frm_modulo : winCont.Formularios.MasterFormTab, Interfaz_forms
    {
        List<SIS_MODULO> lista;
        List<clsImagen> lista_img;
        ManejadorModulo manejadorData;
        public frm_modulo()
        {
            InitializeComponent();
        }
        public frm_modulo(DataSistema ds): base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorModulo(ds);

        }
        public void consultar()
        {
            try
            {
                lista = manejadorData.consultar();
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                lista_img = MetodosForm.listaDeImagenesModulo();
                UICD_IMAGEN_ICO.Properties .DataSource  = lista_img;
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
            UIDS_MODULO.Text = "";
            UICD_IMAGEN_ICO.EditValue = null;
        }

        public void guardar()
        {
             try
                {
                SIS_MODULO m = new SIS_MODULO { ID = 0, DS_MODULO = UIDS_MODULO.Text, CD_IMAGEN_ICO = int.Parse(UICD_IMAGEN_ICO.EditValue.ToString()) };
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
                SIS_MODULO m = new SIS_MODULO { ID = int.Parse (UIID .Text) };
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
            UIDS_MODULO.DataBindings.Add("EditValue", lista, "DS_MODULO", false, DataSourceUpdateMode.Never);
            UICD_IMAGEN_ICO.DataBindings.Add("EditValue", lista, "CD_IMAGEN_ICO", false, DataSourceUpdateMode.Never);

        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_MODULO.DataBindings.Clear();
            UICD_IMAGEN_ICO.DataBindings.Clear();
        }
        public bool validar()
        {
            return true;
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
