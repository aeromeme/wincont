using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using ContabilidadDB;
using Sistema;
using System.Linq;
using winCont.Logica.Contabilidad;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_impo_part_borr : winCont.Formularios.MasterForm_Dialogo
    {
        private int periodo;
        private int ejercicio;
        private int partida;
        private List<V_CONT_ULT_IMNPORT> lista;
        private List<V_CONT_ENCA_PART_BORRADOR> lista_borr;
        private List<V_SIS_PERIODO> lista_periodo;
        ManejadorPartidaBorrador manejadorPartida;
        ManejadorPeriodo manejadorPeriodo;
        public frm_impo_part_borr()
        {
            InitializeComponent();
        }
        public frm_impo_part_borr(DataSistema ds,int id_partida) : base(ds) 
        {
            InitializeComponent();
            periodo = (int)ds.periodo.NM_PERIODO;
            ejercicio = (int)ds.periodo.NM_EJERCICIO;
            partida = id_partida;
            manejadorPartida = new ManejadorPartidaBorrador(ds);
            manejadorPeriodo = new ManejadorPeriodo(ds);

        }
        public void consultar(){
            _datasistema.conectarContabilidad();
            _datasistema.conectarSistema();
            lista = manejadorPartida .consultarUltimasImportadas (_datasistema.empresa .ID,partida);
            UIGRIDCONTROL_IMPO.DataSource = lista;

            lista_periodo = manejadorPeriodo .consultarVistaPorIdEmpresa (_datasistema .empresa .ID );
            UIID_PERIODO.Properties.DataSource = lista_periodo;

            ////asigno por default el valor del periodo
            //SIS_PERIODO p =(from u in _datasistema .contextoSistema .SIS_PERIODO where u.NM_EJERCICIO ==ejercicio && u.NM_PERIODO ==periodo && u.ID_EMPRESA ==_datasistema .empresa .ID select u) .First ();
            UIID_PERIODO .EditValue =lista_periodo .First().ID ;

        }

        public void consultar_borrador() {
            lista_borr = manejadorPartida.consultarVistaPorIdEmpresaPorPeriodoExcluID(_datasistema.empresa .ID,_datasistema .periodo ,partida);
            UIGRIDCONTROL_PARTIDAS.DataSource = lista_borr;
        }


        private void UIID_PERIODO_EditValueChanged(object sender, EventArgs e)
        {
            SIS_PERIODO p = manejadorPeriodo .consultarPorID (int.Parse (UIID_PERIODO .EditValue .ToString() ));
            periodo = (int)p.NM_PERIODO;
            ejercicio = (int)p.NM_EJERCICIO;
            consultar_borrador();
        }

        private void frm_impo_part_borr_Load(object sender, EventArgs e)
        {
            if (_datasistema != null) {
                consultar();
                consultar_borrador();
            }
        }

        private void UIGRIDVIEW_IMPO_DoubleClick(object sender, EventArgs e)
        {
            if (UIGRIDVIEW_IMPO.FocusedRowHandle>= 0)
            {
                importarPartida((int)UIGRIDVIEW_IMPO.GetFocusedRowCellValue("ID_PART_BORR"));
            }
        }

        private void UIGRIDVIEW_PARTIDAS_DoubleClick(object sender, EventArgs e)
        {
            if (UIGRIDVIEW_PARTIDAS.FocusedRowHandle >= 0)
            {
                importarPartida((int)UIGRIDVIEW_PARTIDAS.GetFocusedRowCellValue("ID"));
            }
        }

        private void importarPartida(int idimpo) {
            try
            {
                if (!MetodosForm.preguntar("¿Esta seguro de importar la partida?")) {
                    return;
                }
                manejadorPartida.importarPartida(partida, idimpo);
                this.Close();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }
    }
}
