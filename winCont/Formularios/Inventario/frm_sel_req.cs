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


namespace winCont.Formularios.Inventario
{
    public partial class frm_sel_req : winCont.Formularios.MasterForm_Seleccion
    {
        private V_INV_ENCA_DESP enca;
        private frm_despacho frmpapa;
        private List<V_INV_DETA_REQ> lista;
        private List<V_INV_DETA_REQ> lista_aux;
        private List<int?> lista_desp;
        public frm_sel_req()
        {
            InitializeComponent();
        }



        public frm_sel_req(DataSistema ds, V_INV_ENCA_DESP _enca, frm_despacho _frmpapa):base(ds)
        {
            InitializeComponent();
            enca = _enca;
            frmpapa = _frmpapa;
        }

        private void UIGRIDVIEW_DoubleClick(object sender, EventArgs e)
        {
            if (UIGRIDVIEW.FocusedRowHandle >= 0) {
                //int tupla = (int)UIGRIDVIEW.GetFocusedRowCellValue("ID");
                V_INV_DETA_REQ tupla = (V_INV_DETA_REQ )UIGRIDVIEW.GetFocusedRow();
                INV_DETA_DESP tupla_nueva = new INV_DETA_DESP { ID_ARTICULO = tupla.ID_ARTICULO, ID_DESP = enca.ID, FLG_DESP = 'N', ID_DETA_REQ = tupla.ID, NM_CANTIDAD = tupla.NM_CANT_FALTANTE };

                frmpapa.insertardetalle(tupla_nueva);
                Consultar();

            }
        }

        public void Consultar() {
            try
            {
                 _datasistema.conectarInventario();
                 lista_aux = (from u in _datasistema.ContextoInventario.V_INV_DETA_REQ where u.NM_CANT_FALTANTE >0 && u.CD_ESTA_DOCUMENTO=='A' && _datasistema .empresa .ID ==u.ID_EMPRESA  select u
                    ).ToList();

                 lista_desp = (from u in _datasistema.ContextoInventario.V_INV_DETA_DESP where u.CD_ESTA_DOCUMENTO == 'D' && _datasistema .empresa .ID ==u.ID_EMPRESA   select u.ID_DETA_REQ ).ToList();

                lista=new List<V_INV_DETA_REQ>();

                foreach (var item in lista_aux )
                {
                    if (!lista_desp.Contains(item.ID)) {
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
