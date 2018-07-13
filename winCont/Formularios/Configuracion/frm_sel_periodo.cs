using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades ;
using Sistema;
using System.Linq;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_sel_periodo : winCont.Formularios.MasterForm_Seleccion
    {
        ManejadorPeriodo manejadorData;
        public frm_sel_periodo()
        {
            InitializeComponent();
        }
        public frm_sel_periodo(DataSistema ds) : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorPeriodo(ds);
        }
        public List<V_SIS_PERIODO> lst_periodo;
        public SIS_PERIODO periodo;
        public void Consultar()
        {
            _datasistema.conectarSistema();
            lst_periodo = manejadorData.consultarVistaPorIdEmpresa(_datasistema.empresa.ID);
            UIGRIDCONTROL.DataSource = lst_periodo;
        }


        private void frm_sel_periodo_Activated(object sender, EventArgs e)
        {
            Consultar();
        }

        private void UIGRIDCONTROL_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int id_periodo = int.Parse(UIGRIDVIEW.GetFocusedRowCellValue("ID").ToString());
                periodo =manejadorData.consultarPorID (id_periodo);
                this.Close();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }

        }

    }
}
