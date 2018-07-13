using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using VentasDB;
using System.Linq;

namespace winCont.Formularios.Ventas
{
    public partial class frm_sel_pedido : winCont.Formularios.MasterForm_Seleccion
    {
  
   
        private List<V_FAC_PEDIDO> lista;
        private int idCliente=0;
        private FAC_PEDIDO   pedidoSelected = null;
        public frm_sel_pedido()
        {
            InitializeComponent();
        }



        public frm_sel_pedido(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
        }

        public void Consultar()
        {
            try
            {
                _datasistema.conectarVentas();

               //falta definir el CD_ESTADO del pedido cuando ya este despachado o sea muy viejo
                lista = (from u in _datasistema.ContextoVentas .V_FAC_PEDIDO  where u.CD_ESTADO == 'A' && u.ID_TERCERO == idCliente  && u.ID_EMPRESA == _datasistema.empresa.ID 
                         && (u.NM_PERIODO < _datasistema .periodo .NM_PERIODO && u.NM_EJERCICIO ==_datasistema .periodo .NM_EJERCICIO || u.NM_EJERCICIO < _datasistema .periodo .NM_EJERCICIO ) select u
                   ).ToList();

         


                UIGRIDCONTROL.DataSource = lista;
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        private void UIGRIDVIEW_DoubleClick(object sender, EventArgs e)
        {
            if (UIGRIDVIEW.FocusedRowHandle >= 0)
            {
               V_FAC_PEDIDO tupla  = (V_FAC_PEDIDO )UIGRIDVIEW.GetFocusedRow();
               pedidoSelected = (from u in _datasistema.ContextoVentas.FAC_PEDIDO where u.ID == tupla.ID select u).First();
                this.Close();

            }
        }

        private void frm_sel_pedido_Load(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
