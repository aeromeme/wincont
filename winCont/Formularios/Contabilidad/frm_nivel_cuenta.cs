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
using winCont.Logica.Contabilidad;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_nivel_cuenta : winCont.Formularios.MasterFormTab,Interfaz_forms 
    {
        List<CONT_NIVEL_CUENTA > lista;
        ManejadorNivelCuenta manejadorData;
        public frm_nivel_cuenta()
        {
            InitializeComponent();
        }
        public frm_nivel_cuenta(DataSistema ds) : base(ds) {
            InitializeComponent();
            manejadorData = new ManejadorNivelCuenta(ds);
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarContabilidad();
                lista = manejadorData .consultarPorIdEmpresa (_datasistema .empresa .ID );
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
            UINM_NIVEL.EditValue = null;
            UINM_CANT_CARACTERES.EditValue = 1;
        }

        public void guardar()
        {
            try
            {

                CONT_NIVEL_CUENTA m = new CONT_NIVEL_CUENTA { ID = 0, NM_NIVEL = 0, ID_EMPRESA = _datasistema.empresa.ID, NM_CANT_CARACTERES = int.Parse(UINM_CANT_CARACTERES.EditValue.ToString()) };
                if (UIID.Text == "")
                {
                    _datasistema.ContextoContabilidad.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //Validar
                    if (manejadorData .consultarPorIdEmpresa (_datasistema .empresa .ID).Count() == 0)
                    {
                        m.NM_NIVEL = 1;
                    }else{
                        m.NM_NIVEL = manejadorData.consultarMaxNivelPorIdEmpresa (_datasistema .empresa .ID)+ 1;    
                    }
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
                CONT_NIVEL_CUENTA m = new CONT_NIVEL_CUENTA { ID = int.Parse(UIID.Text) };

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
            UINM_NIVEL.DataBindings.Add("EditValue", lista, "NM_NIVEL", false, DataSourceUpdateMode.Never);
            UINM_CANT_CARACTERES.DataBindings.Add("EditValue", lista, "NM_CANT_CARACTERES", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UINM_NIVEL.DataBindings.Clear();
            UINM_CANT_CARACTERES.DataBindings.Clear();
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
