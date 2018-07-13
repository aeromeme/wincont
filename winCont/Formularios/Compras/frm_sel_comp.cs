using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using ComprasDB;
using System.Linq;


namespace winCont.Formularios.Compras
{
    public partial class frm_sel_comp : winCont.Formularios.MasterForm_Seleccion
    {
        private V_COMP_QUEDAN   enca;
        private frm_quedan frmpapa;
        private List<V_COMP_COMPRA  > lista;
        private List<V_COMP_COMPRA> lista_aux;
        private List<int?> lista_ingr;
        public frm_sel_comp()
        {
            InitializeComponent();
        }



        public frm_sel_comp(DataSistema ds, V_COMP_QUEDAN _enca, frm_quedan  _frmpapa)
            : base(ds)
        {
            InitializeComponent();
            enca = _enca;
            frmpapa = _frmpapa;
        }

        private void UIGRIDVIEW_DoubleClick(object sender, EventArgs e)
        {
            if (UIGRIDVIEW.FocusedRowHandle >= 0) {
                //int tupla = (int)UIGRIDVIEW.GetFocusedRowCellValue("ID");
                V_COMP_COMPRA tupla = (V_COMP_COMPRA)UIGRIDVIEW.GetFocusedRow();
                COMP_DETA_QUEDAN tupla_nueva = new COMP_DETA_QUEDAN { ID =0,ID_COMPRA =tupla.ID,ID_QUEDAN =enca.ID   };
                frmpapa.insertardetalle(tupla_nueva);
                Consultar();

            }
        }

        public void Consultar() {
            try
            {
                 _datasistema.conectarCompras ();
                 lista_aux = (from u in _datasistema.ContextoCompras.V_COMP_COMPRA where  u.CD_ESTADO == 'A' && u.ID_TERCERO == enca.ID_TERCERO  && u.ID_EMPRESA ==_datasistema .empresa .ID  select u
                    ).ToList();

                 lista_ingr = (from u in _datasistema.ContextoCompras.V_COMP_DETA_QUEDAN   select u.ID_QUEDAN ).ToList();

                 lista = new List<V_COMP_COMPRA>();

                foreach (var item in lista_aux )
                {
                    if (!lista_ingr.Contains(item.ID))
                    {
                        lista.Add(item);
                    }
                }
                

                UIGRIDCONTROL .DataSource = lista;
            }
            catch (Exception ex)
            {
                
               MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        private void frm_sel_req_Load(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
