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
    public partial class frm_sel_ord : winCont.Formularios.MasterForm_Seleccion
    {
        private V_INV_ENCA_INGR  enca;
        private frm_ingreso frmpapa;
        private List<V_INV_DETA_ORDEN > lista;
        private List<V_INV_DETA_ORDEN> lista_aux;
        private List<int> lista_ingr;
        public frm_sel_ord()
        {
            InitializeComponent();
        }



        public frm_sel_ord(DataSistema ds, V_INV_ENCA_INGR _enca, frm_ingreso  _frmpapa)
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
                V_INV_DETA_ORDEN  tupla = (V_INV_DETA_ORDEN )UIGRIDVIEW.GetFocusedRow();
                INV_DETA_INGR tupla_nueva = new INV_DETA_INGR  { ID_ARTICULO = (int)tupla.ID_ARTICULO, ID_INGR  = enca.ID, FLG_INGR = 'N', ID_DETA_ORDEN = tupla.ID, NM_CANTIDAD = tupla.NM_CANT_FALTANTE,NM_PRECIO =tupla.NM_PRECIO  };
                frmpapa.insertardetalle(tupla_nueva);
                Consultar();

            }
        }

        public void Consultar() {
            try
            {
                 _datasistema.conectarInventario();
                 lista_aux = (from u in _datasistema.ContextoInventario.V_INV_DETA_ORDEN where u.NM_CANT_FALTANTE > 0 && u.CD_ESTA_DOCUMENTO == 'A' && u.ID_TERCERO == enca.ID_TERCERO && u.ID_EMPRESA  == _datasistema.empresa.ID  select u
                    ).ToList();

                 lista_ingr = (from u in _datasistema.ContextoInventario.V_INV_DETA_INGR where u.CD_ESTA_DOCUMENTO == 'D' && u.ID_EMPRESA  ==_datasistema .empresa .ID  select u.ID_DETA_ORDEN).ToList();

                lista=new List<V_INV_DETA_ORDEN >();

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
