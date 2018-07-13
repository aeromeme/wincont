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
using Sistema;
using winCont.Clases ;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_talonario : winCont.Formularios.MasterFormTab, Interfaz_forms
    {
         List<V_SIS_TALONARIO> lista;
         //List<V_SIS_TALONARIO> lista_Talonarios;
         List<SIS_DOCUMENTO> lista_Documentos;
         List<SIS_UBICACION> lista_Ubicacion;
         List<clsGenericaPares> lista_EstTalonario;
        ManejadorTalonario manejadorData;
        ManejadorDocumento manejadorDocumento;
        ManejadorUbicacion manejadorUbicacion;
        
 
       
        public frm_talonario()
        {
            InitializeComponent();
        }

        public frm_talonario(DataSistema ds) : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorTalonario(ds);
            manejadorDocumento = new ManejadorDocumento(ds);
            manejadorUbicacion = new ManejadorUbicacion(ds);
        }

        public void llenarCombos()
        {
            lista_Documentos = manejadorDocumento .consultarPorEmpresa (_datasistema .empresa .ID );
            UI_DOCUMENTO.Properties.DataSource = lista_Documentos;

            lista_Ubicacion = manejadorUbicacion .consultarPorIdEmpresa (_datasistema .empresa .ID );
            UI_UBICACION.Properties.DataSource = lista_Ubicacion;

            lista_EstTalonario = MetodosForm.listaEstadoTalonario();
            UI_CD_ESTADO.Properties.DataSource = lista_EstTalonario;

        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                lista = manejadorData.consultarVistaPorEmpresa(_datasistema.empresa.ID);
                UIID.Text = "";
                llenarCombos();
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
            UI_DOCUMENTO.EditValue = null;
            UI_UBICACION.EditValue = null;
            UI_CD_SERIE.Text = "";
            UI_NM_INICIAL.Text = "";
            UI_NM_ACTUAL.Text = "";
            UI_NM_FINAL.Text = "";
            UI_CD_ESTADO.EditValue = 'D';
        }

        public void guardar()
        {
            if (!validar())
            {
                return;
            }

            try
                {
                SIS_TALONARIO m = new SIS_TALONARIO
                {
                    ID = 0,
                    ID_EMPRESA = _datasistema.empresa.ID,
                    ID_DOCUMENTO = int.Parse(UI_DOCUMENTO.EditValue.ToString()),
                    ID_UBICACION = int.Parse(UI_UBICACION.EditValue.ToString()),
                    CD_SERIE = UI_CD_SERIE.Text,
                    NM_INICIAL = int.Parse(UI_NM_INICIAL.EditValue.ToString()),
                    NM_FINAL = int.Parse(UI_NM_FINAL.EditValue.ToString()),
                    CD_ESTADO = char.Parse(UI_CD_ESTADO.EditValue.ToString())
                };
                m.NM_ACTUAL = m.NM_INICIAL;
                if (m.NM_INICIAL > m.NM_FINAL)
                {
                    return;
                }
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
                SIS_TALONARIO m = new SIS_TALONARIO { ID = int.Parse(UIID.Text) };
                if (m.CD_ESTADO ==char.Parse ("A")){
                    return;
                }
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
            UI_DOCUMENTO.DataBindings.Add("EditValue", lista, "ID_DOCUMENTO", false, DataSourceUpdateMode.Never);
            UI_UBICACION.DataBindings.Add("EditValue", lista, "ID_UBICACION", false, DataSourceUpdateMode.Never);
            UI_CD_SERIE.DataBindings.Add("EditValue", lista, "CD_SERIE", false, DataSourceUpdateMode.Never);
            UI_NM_INICIAL.DataBindings.Add("EditValue", lista, "NM_INICIAL", false, DataSourceUpdateMode.Never);
            UI_NM_ACTUAL.DataBindings.Add("EditValue", lista, "NM_ACTUAL",false, DataSourceUpdateMode.Never);
            UI_NM_FINAL.DataBindings.Add("EditValue", lista, "NM_FINAL", false, DataSourceUpdateMode.Never);
            UI_CD_ESTADO.DataBindings.Add("EditValue", lista, "CD_ESTADO", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UI_DOCUMENTO.DataBindings.Clear();
            UI_UBICACION.DataBindings.Clear();UI_CD_SERIE.DataBindings.Clear();
            UI_NM_INICIAL.DataBindings.Clear();
            UI_NM_ACTUAL.DataBindings.Clear();
            UI_NM_FINAL.DataBindings.Clear();
            UI_CD_ESTADO.DataBindings.Clear();
        }

        public override void refrescar(){
            consultar();
        }

        public bool validar()
        {
            try
            {
                if (UI_CD_SERIE.Text .Length<1)
                {
                    throw new Exception("Digite una serie correcta");
                }
                if (int.Parse(UI_NM_ACTUAL.EditValue.ToString()) < 1) {
                    throw new Exception("Digite una un numero actual correcto");
                }
                if (int.Parse(UI_NM_FINAL .EditValue.ToString()) < int.Parse(UI_NM_ACTUAL.EditValue.ToString()))
                {
                    throw new Exception("Digite una un numero final correcto");
                }            
            }
            catch (Exception ex)
            {
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                return false;
            }
            return true;
        }

        public override void enlazar_aux()
        {
            desenlazar();
            enlazar();
        }

        }
    }
    
