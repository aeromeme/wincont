using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using ContabilidadDB;
using winCont.Clases ;
using System.Linq;
using winCont.Logica.Contabilidad;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_aux_cuenta : winCont.Formularios.MasterForm
    {
        List<CONT_RUBROS> lista_rubros;
        List<clsGenericaPares> lista_saldos;
        ManejadorRubro manejadorRubro;
        ManejadorCuenta manejadorCuenta;
        ManejadorNivelCuenta manejadorNivelCuenta;
        public frm_aux_cuenta()
        {
            InitializeComponent();
        }
        public frm_aux_cuenta(DataSistema ds) : base(ds) {
            InitializeComponent();
            manejadorRubro = new ManejadorRubro(ds);
            manejadorCuenta = new ManejadorCuenta(ds);
            manejadorNivelCuenta = new ManejadorNivelCuenta(ds);
        }
        public void consultar() {
            try
            {
                lista_rubros = manejadorRubro.consultarPorIdEmpresa(_datasistema.empresa.ID);
                UIID_RUBRO.Properties.DataSource = lista_rubros;

                lista_saldos = MetodosForm.listaSaldos();
                UICD_TIPO_SALDO.Properties.DataSource = lista_saldos;


            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message ,_datasistema);
            }
        }


        private void frm_aux_cuenta_Load(object sender, EventArgs e)
        {
            consultar();
        }

        private void uibtnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UICD_TIPO_SALDO.EditValue == null)
                {
                    MetodosForm.mensajeErrorDefault("Seleccione el tipo de saldo", _datasistema);
                    return;
                }
                if (UICD_CUENTA.Text.Length == manejadorNivelCuenta .consultarPorIdNivel  (_datasistema .empresa .ID,1).NM_CANT_CARACTERES)
                {
                    if (manejadorCuenta.consultarPorIdEmpresaPorRubro(_datasistema.empresa.ID, int.Parse(UIID_RUBRO.EditValue.ToString())).Count() > 0)
                    {
                        MetodosForm.mensajeErrorDefault("Rubro ya registrado", _datasistema);
                        return;
                    }
                    //int idnivel = (from u in _datasistema.ContextoContabilidad.CONT_NIVEL_CUENTA where u.ID_EMPRESA == _datasistema.empresa.ID select u.ID).First();
                    int idnivel = 1;
                    CONT_CUENTA c = new CONT_CUENTA { ID_EMPRESA = _datasistema.empresa.ID, CD_CUENTA = UICD_CUENTA.Text, DS_CUENTA = UIDS_CUENTA.Text, CD_TIPO_SALDO = char.Parse(UICD_TIPO_SALDO.EditValue.ToString()), ID_CUENTA_PADRE = 0 ,FLG_DETALLE ='N',ID_RUBRO =int.Parse (UIID_RUBRO .EditValue.ToString ()),ID_NIVEL =idnivel };

                    manejadorCuenta.insertar(c);
                    this.Close();
                }
                else {
                    MetodosForm.mensajeErrorDefault("Numero de caracteres invalido para la cuenta", _datasistema);
                }
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }


    }
}
