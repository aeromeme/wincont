using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using winCont.Utilidades;
using ContabilidadDB;
using winCont.Clases ;
using winCont.Logica.Contabilidad;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_cuenta : winCont.Formularios.MasterForm,Interfaz_forms 
    {
        List<V_CONT_CUENTA > lista;
        List<CONT_RUBROS > lista_rubros_bases;
        List<CONT_NIVEL_CUENTA> lista_niveles;
        List<clsGenericaPares> lista_saldos;
        CONT_CUENTA Cuentapadre;
        ManejadorCuenta manejadorData;
        ManejadorNivelCuenta manejadorNivel;
        ManejadorRubro manejadorRubro;
        public frm_cuenta()
        {
            InitializeComponent();
        }
        public frm_cuenta(DataSistema ds) : base(ds) {
            InitializeComponent();
            manejadorData = new ManejadorCuenta(ds);
            manejadorNivel = new ManejadorNivelCuenta(ds);
            manejadorRubro = new ManejadorRubro(ds);
        }

        public void llenarcombos() {
            lista_rubros_bases = manejadorRubro.consultarPorIdEmpresa(_datasistema.empresa.ID);
            UIID_RUBRO.Properties.DataSource = lista_rubros_bases;
            lista_niveles = manejadorNivel.consultarPorIdEmpresa(_datasistema.empresa.ID);
            UIID_NIVEL.Properties.DataSource = lista_niveles;
            lista_saldos = MetodosForm.listaSaldos();
            UICD_TIPO_SALDO.Properties.DataSource = lista_saldos;
        }
        public void consultar()
        {
            try
            {
                lista = manejadorData.consultarVistaPorIdEmpresa(_datasistema.empresa.ID);
                UITREE_CATALOGOCUENTAS.DataSource = lista;
                llenarcombos();
                desenlazar();
                enlazar();
                if (lista.Count() == 0)
                {
                    nuevo();
                }
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        public void nuevo()
        {
            if (UIID.Text == "") {
                return;
            }
            CONT_CUENTA Cuenta=manejadorData .consultarPorId (int.Parse (UIID.Text ));
            if (Cuenta.FLG_DETALLE == 'S') {
                MetodosForm.mensajeErrorDefault("La cuenta es de detalle", _datasistema);
                return;
            }

           CONT_NIVEL_CUENTA Nivel =manejadorNivel.consultarPorId (int.Parse (UIID_NIVEL .EditValue .ToString()));
           if (manejadorNivel .consultarPorNivel (_datasistema .empresa .ID ,Nivel.NM_NIVEL.Value ).Count() == 0) { 
            MetodosForm.mensajeErrorDefault("No existe el siguiente nivel", _datasistema);
           return;
           }
           Nivel = manejadorNivel .consultarSiguienteNivel (Nivel .NM_NIVEL .Value );

            UIID.Text = "";
            UICD_CUENTA.Text = null;
            UIDS_CUENTA.Text = "";
            UICD_TIPO_SALDO.EditValue = null;
            UIFLG_DETALLE.Checked = true;
            UICD_CUENTA_PADRE.Text = Cuenta .CD_CUENTA ;
            Cuentapadre = Cuenta; //variable temporal
            UIID_NIVEL.EditValue = Nivel.ID ;
            //UIID_RUBRO.EditValue = null;


        }

        public void guardar()
        {
            try
            {
                if (UICD_TIPO_SALDO.EditValue == null)
                {
                    MetodosForm.mensajeErrorDefault("Seleccione el tipo de saldo", _datasistema);
                    return;
                }
                CONT_CUENTA c = new CONT_CUENTA { ID_EMPRESA = _datasistema.empresa.ID, CD_CUENTA = UICD_CUENTA.Text, DS_CUENTA = UIDS_CUENTA.Text, CD_TIPO_SALDO = char.Parse(UICD_TIPO_SALDO.EditValue.ToString()), ID_CUENTA_PADRE = Cuentapadre.ID, FLG_DETALLE = char.Parse(UIFLG_DETALLE.EditValue.ToString()), ID_RUBRO = int.Parse(UIID_RUBRO.EditValue.ToString()), ID_NIVEL = int.Parse(UIID_NIVEL.EditValue.ToString()) };

                
                if (UIID.Text == "")
                {
                    c=manejadorData.insertar(c);
                }
                else {
                    c.ID = int.Parse(UIID.Text);
                    manejadorData.modificar(c); 
                }
                consultar();
                UITREE_CATALOGOCUENTAS.FocusedNode = UITREE_CATALOGOCUENTAS.FindNodeByKeyID(c.ID);
                
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        public void eliminar()
        {
            try
            {
                CONT_CUENTA c = new CONT_CUENTA { ID =int.Parse (UIID .Text)};
                manejadorData.eliminar(c);
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
            UICD_CUENTA.DataBindings.Add("EditValue", lista, "CD_CUENTA", false, DataSourceUpdateMode.Never);
            UIDS_CUENTA.DataBindings.Add("EditValue", lista, "DS_CUENTA", false, DataSourceUpdateMode.Never);
            UICD_TIPO_SALDO.DataBindings.Add("EditValue", lista, "CD_TIPO_SALDO", false, DataSourceUpdateMode.Never);
            UIFLG_DETALLE.DataBindings.Add("EditValue", lista, "FLG_DETALLE", false, DataSourceUpdateMode.Never);
            UICD_CUENTA_PADRE.DataBindings.Add("EditValue", lista, "CD_CUENTA_PADRE", false, DataSourceUpdateMode.Never);
            UIID_RUBRO.DataBindings.Add("EditValue", lista, "ID_RUBRO", false, DataSourceUpdateMode.Never);
            UIID_NIVEL.DataBindings.Add("EditValue", lista, "ID_NIVEL", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear ();
            UICD_CUENTA.DataBindings.Clear();
            UIDS_CUENTA.DataBindings.Clear();
            UICD_TIPO_SALDO.DataBindings.Clear();
            UIFLG_DETALLE.DataBindings.Clear();
            UICD_CUENTA_PADRE.DataBindings.Clear();
            UIID_RUBRO.DataBindings.Clear();
            UIID_NIVEL.DataBindings.Clear();
        }

        public bool validar()
        {
            return true;
        }

        private void frm_cuenta_Load(object sender, EventArgs e)
        {
            consultar();
        }

        private void uibtnini_rubros_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _datasistema.nombreVentana = "Inicializar rubro contable";
            _datasistema.nombreOpcion = "Inicializar rubro";
            frm_aux_cuenta f = new frm_aux_cuenta(_datasistema);
            f.ShowDialog();
            consultar();
        }
    }
}
