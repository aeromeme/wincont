using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using Sistema;
using System.Linq;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_periodos : winCont.Formularios.MasterForm,Interfaz_forms 
    {
        List<V_SIS_PERIODO> listas;
        ManejadorPeriodo manejadorData;
        public frm_periodos()
        {
            InitializeComponent();
        }
        public frm_periodos(DataSistema ds):base(ds) {
            InitializeComponent();
            manejadorData = new ManejadorPeriodo(ds);
        }
        public void consultar()
        {
            try
            {
                _datasistema .conectarSistema ();
                listas = manejadorData.consultarVistaPorIdEmpresa(_datasistema.empresa.ID);
                UIGRIDCONTROL.DataSource = listas;
            }
            catch (Exception ex)
            {
                MetodosForm.mensajeErrorDefault(ex.Message,_datasistema );
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
        private void uibtnaddPeriodo_Click(object sender, EventArgs e)
        {
            if (MetodosForm.preguntar("¿Esta seguro de agregar el siguiente periodo?")) {
                manejadorData.insertarSiguientePeriodo();
                consultar();

            }
        }

        private void frm_periodos_Load(object sender, EventArgs e)
        {
            consultar();
        }
    }
}
