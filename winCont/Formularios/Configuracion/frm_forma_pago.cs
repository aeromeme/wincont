using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using System.Linq;
using Sistema;
using winCont.Logica.Configuracion;

namespace winCont.Formularios.Configuracion
{
    public partial class frm_forma_pago : winCont.Formularios.MasterFormTab,Interfaz_forms
    {
        List<SIS_FORMA_PAGO> lista;
        ManejadorFormaPago manejadorData;
        public frm_forma_pago()
        {
            InitializeComponent();
        }

        public frm_forma_pago(DataSistema ds):base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorFormaPago(ds);
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarSistema();
                lista = manejadorData.consultarPorIdEmpresa(_datasistema .empresa .ID );
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                if (lista.Count() == 0)
                {
                    nuevo();
                }
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void nuevo()
        {
            desenlazar();
            UIID.Text = "";
            UIDS_FORMA_PAGO.Text = "";
            UINM_DIAS_PLAZO.EditValue = 0;
            UIFLG_CREDITO.Checked = false;
        }

        public void guardar()
        {
            try
                {
                SIS_FORMA_PAGO m = new SIS_FORMA_PAGO
                {
                    ID = 0,
                    DS_FORMA_PAGO = UIDS_FORMA_PAGO.Text,
                    ID_EMPRESA = _datasistema.empresa.ID,
                    FLG_CREDITO = char.Parse(UIFLG_CREDITO.EditValue.ToString()),
                    NM_DIAS_PLAZO = int.Parse(UINM_DIAS_PLAZO.EditValue.ToString())
                };
                if (UIID.Text == "")
                {
                    m=manejadorData.insertar(m);
                }

                else
                {
                    m.ID = int.Parse(UIID.Text);
                    manejadorData.modificar(m);
                }
                consultar();
                MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
                }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
        }

        public void eliminar()
        {
            try
            {
                SIS_FORMA_PAGO m = new SIS_FORMA_PAGO {ID=int.Parse (UIID.Text )};
                manejadorData.eliminar(m);
                consultar();
            }
            catch (Exception e)
            {

                MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
            }
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
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
            UIDS_FORMA_PAGO.DataBindings.Add("EditValue", lista, "DS_FORMA_PAGO", false, DataSourceUpdateMode.Never);
            UINM_DIAS_PLAZO.DataBindings.Add("EditValue", lista, "NM_DIAS_PLAZO", false, DataSourceUpdateMode.Never);
            UIFLG_CREDITO.DataBindings.Add("EditValue", lista, "FLG_CREDITO", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_FORMA_PAGO.DataBindings.Clear();
            UINM_DIAS_PLAZO.DataBindings.Clear();
            UIFLG_CREDITO.DataBindings.Clear();
        }
        public override void refrescar()
        {
            consultar();
        }

        public bool validar()
        {
            return true;
        }

        public override void enlazar_aux()
        {
            desenlazar();
            enlazar();
        }

    }
}
