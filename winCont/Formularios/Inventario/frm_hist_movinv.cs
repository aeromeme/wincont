using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventarioDB;
using winCont.Utilidades;
using System.Linq;

namespace winCont.Formularios.Inventario
{
    public partial class frm_hist_movinv : winCont.Formularios.MasterForm_Consulta_Filtro,Interfaz_forms 
    {
        List<V_INV_ARTICULO> lista;
        List<V_INV_MOV> lista_movs;
        public frm_hist_movinv()
        {
            InitializeComponent();
        }
        public frm_hist_movinv(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
        }
        public void llenarcombos() {
            lista = (from u in _datasistema.ContextoInventario.V_INV_ARTICULO where u.ID_EMPRESA == _datasistema.empresa.ID select u
                ).ToList();

            uiid_articulo.Properties.DataSource = lista;

            
            uiid_bodega .Properties.DataSource = (from u in _datasistema.contextoSistema.SIS_UBICACION where u.ID_EMPRESA == _datasistema.empresa.ID && u.CD_TIPO_UBICACION == 'B' select u).ToList();
        }
        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                _datasistema.conectarInventario();
                llenarcombos();
                
                if (uiid_articulo.EditValue != null && uiid_bodega .EditValue !=null) {
                    lista_movs = (from u in _datasistema.ContextoInventario.V_INV_MOV where u.ID_EMPRESA == _datasistema.empresa.ID && u.ID_ARTICULO == (int)uiid_articulo.EditValue && u.NM_PERIODO == _datasistema.periodo.NM_PERIODO && u.NM_EJERCICIO == _datasistema.periodo.NM_EJERCICIO && u.ID_BODEGA ==(int)uiid_bodega .EditValue  select u
                        ).ToList();

                   uigridcontrol .DataSource  = lista_movs ;
                }
                
                
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
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
            this.Close ();
        }

        public void enlazar()
        {
           
        }

        public void desenlazar()
        {
           
        }

        public bool validar()
        {
            return false;
        }
        public override void refrescar()
        {
            consultar();
        }

        private void uibtnrecargar_Click(object sender, EventArgs e)
        {
            consultar();
        }
    }
}
