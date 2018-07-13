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

namespace winCont.Formularios.Compras
{
    public partial class frm_consultar_ingr_comp : winCont.Formularios.MasterForm_Dialogo_Consulta
    {
        public int idingr;
        public List<V_INV_DETA_INGR> lista;
        public frm_consultar_ingr_comp()
        {
            InitializeComponent();
        }
        public frm_consultar_ingr_comp(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
        }
        public void consultar() {
            try
            {
                _datasistema.conectarInventario();
                lista = (from u in _datasistema.ContextoInventario.V_INV_DETA_INGR  where u.ID_EMPRESA == _datasistema.empresa.ID && u.ID_INGR ==idingr  select u
                    ).ToList();
                
                UIGRIDCONTROL.DataSource = lista;
                
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

    }
}
