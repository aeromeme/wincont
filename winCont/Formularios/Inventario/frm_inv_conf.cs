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
using winCont.Clases;
using ContabilidadDB;

namespace winCont.Formularios.Inventario
{
    public partial class frm_inv_conf : winCont.Formularios.MasterForm,Interfaz_forms
    {
        INV_CONFIG invConf; 
        public frm_inv_conf()
        {
            InitializeComponent();
        }
        public frm_inv_conf(DataSistema ds) : base(ds)
        {
            InitializeComponent();
        }

        public void llenarcombos() { 
              List<clsGenericaPares> listaNivel= MetodosForm .listaNivelesContabilidad();
              UICD_NIVEL_CONT_CONSUMO.Properties.DataSource = listaNivel;
              UICD_NIVEL_CONT_INVE.Properties.DataSource = listaNivel;
              UICD_NIVEL_CONT_VENTA.Properties.DataSource = listaNivel;

              List<V_CONT_CUENTA> listaCuentas = (from u in _datasistema.ContextoContabilidad.V_CONT_CUENTA where u.FLG_DETALLE.Equals("S") select u).ToList();
              UIID_CUENTA_CONSUMO.Properties.DataSource = listaCuentas;
              UIID_CUENTA_INVE.Properties.DataSource = listaCuentas;
              UIID_CUENTA_VENTA.Properties.DataSource = listaCuentas;

        }

        public void consultar()
        {
           
            try
            {
                _datasistema.conectarInventario();
                _datasistema.conectarContabilidad();
                if ((from u in _datasistema.ContextoInventario.INV_CONFIG where u.ID_EMPRESA == _datasistema.empresa.ID select u).Count() > 0)
                {
                    invConf = (from u in _datasistema.ContextoInventario.INV_CONFIG where u.ID_EMPRESA == _datasistema.empresa.ID select u).First();
                    UICD_NIVEL_CONT_CONSUMO.EditValue = invConf.CD_NIVEL_CONT_CONSUMO;
                    UICD_NIVEL_CONT_INVE.EditValue = invConf.CD_NIVEL_CONT_INVE;
                    UICD_NIVEL_CONT_VENTA.EditValue = invConf.CD_NIVEL_CONT_VENTA;

                    UIID_CUENTA_CONSUMO.EditValue = invConf.ID_CUENTA_CONSUMO;
                    UIID_CUENTA_INVE.EditValue = invConf.ID_CUENTA_INVE;
                    UIID_CUENTA_VENTA.EditValue = invConf.ID_CUENTA_VENTA;
               }
                llenarcombos();
              
            }
            catch (Exception e)
            {
                
              MetodosForm.mensajeErrorDefault(e.Message ,_datasistema );
            }

        }

        public void nuevo()
        {
           
        }

        public void guardar()
        {
            try
            {
                if ((from u in _datasistema.ContextoInventario.INV_CONFIG where u.ID_EMPRESA == _datasistema.empresa.ID select u).Count() > 0)
                {

                    invConf = (from u in _datasistema.ContextoInventario.INV_CONFIG where u.ID_EMPRESA==_datasistema .empresa .ID  select u).First();
                    invConf.ID_CUENTA_VENTA = (int)UIID_CUENTA_VENTA.EditValue;
                    invConf.ID_CUENTA_INVE = (int)UIID_CUENTA_INVE.EditValue;
                    invConf.ID_CUENTA_CONSUMO = (int)UIID_CUENTA_CONSUMO.EditValue;

                    invConf.CD_NIVEL_CONT_VENTA = (char)UICD_NIVEL_CONT_VENTA.EditValue;
                    invConf.CD_NIVEL_CONT_INVE = (char)UICD_NIVEL_CONT_INVE.EditValue;
                    invConf.CD_NIVEL_CONT_CONSUMO = (char)UICD_NIVEL_CONT_CONSUMO.EditValue;

                    _datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoInventario.SubmitChanges();

                    consultar();
                    
                }
                else
                {
                    invConf = new INV_CONFIG()
                    {
                        ID_EMPRESA = _datasistema.empresa.ID,
                        ID_CUENTA_CONSUMO = (int)UIID_CUENTA_CONSUMO.EditValue,
                        ID_CUENTA_INVE = (int)UIID_CUENTA_INVE.EditValue,
                        ID_CUENTA_VENTA = (int)UIID_CUENTA_VENTA.EditValue,
                        CD_NIVEL_CONT_CONSUMO = (char)UICD_NIVEL_CONT_CONSUMO.EditValue,
                        CD_NIVEL_CONT_INVE = (char)UICD_NIVEL_CONT_INVE.EditValue,
                        CD_NIVEL_CONT_VENTA = (char)UICD_NIVEL_CONT_VENTA.EditValue
                    };

                    _datasistema .ContextoInventario .INV_CONFIG.InsertOnSubmit(invConf);
                    _datasistema .ContextoInventario .SubmitChanges ();
                    consultar();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
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

        private void frm_inv_conf_Load(object sender, EventArgs e)
        {
            consultar();
        }
    }
}
