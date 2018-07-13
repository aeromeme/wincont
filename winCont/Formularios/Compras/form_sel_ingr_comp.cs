using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using InventarioDB;
using System.Linq;
using ComprasDB;

namespace winCont.Formularios.Compras
{
    public partial class form_sel_ingr_comp : winCont.Formularios.MasterForm_Seleccion
    {
        private List<V_INV_ENCA_INGR > lista;
        private frm_compras frmpapa;
        public form_sel_ingr_comp()
        {
            InitializeComponent();
        }
        public form_sel_ingr_comp(DataSistema ds,frm_compras frm)
            : base(ds)
        {
            InitializeComponent();
            frmpapa = frm;
        }
        private void UIGRIDVIEW_DoubleClick(object sender, EventArgs e)
        {
            
        }

        public void Consultar()
        {
            try
            {
                _datasistema.conectarInventario();
                _datasistema.conectarCompras();
                lista = (from u in _datasistema.ContextoInventario.V_INV_ENCA_INGR where u.CD_ESTA_DOCUMENTO == 'A' && u.ID_EMPRESA ==_datasistema .empresa .ID && u.NM_EJERCICIO ==_datasistema .periodo .NM_EJERCICIO  && u.NM_PERIODO ==_datasistema .periodo .NM_PERIODO && u.ID_COMPRA ==0   select u).ToList();

                UIGRIDCONTROL.DataSource = lista;
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        private void form_sel_ingr_comp_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        private void UIGRIDVIEW_DoubleClick_1(object sender, EventArgs e)
        {
            if (UIGRIDVIEW.FocusedRowHandle >= 0)
            {
                V_INV_ENCA_INGR tupla = (V_INV_ENCA_INGR)UIGRIDVIEW.GetFocusedRow();
                int? comp = 0;
                int? error = 0;
                string msj = String.Empty;
                _datasistema.ContextoCompras.PR_COMP_IMPO_INGR_COMPR(tupla.ID, tupla.ID_EMPRESA, ref comp, ref error, ref msj);
                if (error != 0)
                {
                    MetodosForm.mensajeErrorDefault(msj, _datasistema);
                }
                else
                {
                    frmpapa.consultar();
                    MetodosForm.seleccionarFila(frmpapa.uigridview, "ID", comp);
                    this.Close();
                }


            }
        }

        
    }
}
