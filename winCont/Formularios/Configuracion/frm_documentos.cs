using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContabilidadDB;
using Sistema;
using winCont.Utilidades;
using winCont.Clases;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_documentos : winCont.Formularios.MasterFormTab, Interfaz_forms{

         List<SIS_DOCUMENTO> lista;
         List<clsGenericaPares> lista_tipodoc;
         ManejadorDocumento manejadorDocumento;
        
        
        public frm_documentos()
        {
            InitializeComponent();
        }

         public frm_documentos(DataSistema ds):base(ds) {
            InitializeComponent();
            manejadorDocumento = new ManejadorDocumento(ds);
        }

        public void llenarcombos()
        {
            lista_tipodoc = MetodosForm.listaTipoDocumentos();
            UICD_TIPO_DOC.Properties.DataSource = lista_tipodoc;
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                lista = manejadorDocumento .consultarPorEmpresa (_datasistema .empresa .ID);
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
            UIDS_DOCUMENTO.Text = "";
            UICD_TIPO_DOC.EditValue = null;
        }

        public void guardar()
        {
            try
                {
                SIS_DOCUMENTO m = new SIS_DOCUMENTO
                {
                    ID = 0,
                    DS_DOCUMENTO = UIDS_DOCUMENTO.Text,
                    ID_EMPRESA = _datasistema.empresa.ID,
                    CD_TIPO_DOCUMENTO = UICD_TIPO_DOC.EditValue.ToString()
                };
                if (UIID.Text == "")
                {
                    manejadorDocumento.insertar(m);
                }
                else
                {
                    m.ID = int.Parse(UIID.Text);
                    manejadorDocumento.modificar(m);
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
                SIS_DOCUMENTO m = new SIS_DOCUMENTO {ID =int.Parse (UIID.Text) };
                manejadorDocumento.eliminar(m);
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
            UIDS_DOCUMENTO.DataBindings.Add("EditValue", lista, "DS_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UICD_TIPO_DOC.DataBindings.Add("EditValue", lista, "CD_TIPO_DOCUMENTO", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_DOCUMENTO.DataBindings.Clear();
            UICD_TIPO_DOC.DataBindings.Clear();
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

    }
}
