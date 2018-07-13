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
    public partial class frm_ubicacion : winCont.Formularios.MasterFormTab, Interfaz_forms

    {
        List<SIS_UBICACION> lista;
        List<clsGenericaPares> lista_tipoubic;
        ManejadorUbicacion manejadorData;

        public frm_ubicacion()
        {
            InitializeComponent();
        }

        public frm_ubicacion(DataSistema ds): base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorUbicacion(ds);
        }

        public void llenarcombos()
        {
            lista_tipoubic = MetodosForm.listaTipoUbicacion();
            UICD_TIPO_UBICA.Properties.DataSource = lista_tipoubic;
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                lista = manejadorData .consultarPorIdEmpresa (_datasistema .empresa .ID );
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
            UIDS_UBICACION.Text = "";
            UICD_TIPO_UBICA.EditValue = null;
        }

        public void guardar()
        {
            try
                {
                SIS_UBICACION m = new SIS_UBICACION
                {
                    ID = 0,
                    DS_UBICACION = UIDS_UBICACION.Text,
                    ID_EMPRESA = _datasistema.empresa.ID,
                    CD_TIPO_UBICACION = char.Parse(UICD_TIPO_UBICA.EditValue.ToString())
                };
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
                SIS_UBICACION m = new SIS_UBICACION {ID=int.Parse (UIID.Text )} ;
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
            UIDS_UBICACION.DataBindings.Add("EditValue", lista, "DS_UBICACION", false, DataSourceUpdateMode.Never);
            UICD_TIPO_UBICA.DataBindings.Add("EditValue", lista, "CD_TIPO_UBICACION", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_UBICACION.DataBindings.Clear();
            UICD_TIPO_UBICA.DataBindings.Clear();
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

