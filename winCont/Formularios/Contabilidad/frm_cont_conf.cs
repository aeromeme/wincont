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
using winCont.Logica.Contabilidad;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_cont_conf : winCont.Formularios.MasterForm,Interfaz_forms
    {
        List<CONT_CONFIG > lista;
        ManejadorContConfig manejadorData;
        ManejadorNivelCuenta manejadorNivel;
        public frm_cont_conf()
        {
            InitializeComponent();
        }
        public frm_cont_conf(DataSistema ds):base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorContConfig(ds);
            manejadorNivel = new ManejadorNivelCuenta(ds);
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarContabilidad();
                lista = manejadorData .consultarPorIdEmpresa (_datasistema .empresa .ID);
                if (lista.Count() > 0)
                {
                    UIDS_NOMBRE_CONTADOR.Text = lista[0].DS_NOMBRE_CONTADOR;
                    UIID_NIVEL_MAYOR.EditValue = lista[0].ID_NIVEL_MAYOR;
                    UIFLG_USA_CENTRO_COSTO.EditValue = lista[0].FLG_USA_CENTRO_COSTO;
                }
                UIID_NIVEL_MAYOR.Properties.DataSource = manejadorNivel .consultarPorIdEmpresa (_datasistema .empresa .ID);
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
            CONT_CONFIG m = new CONT_CONFIG { ID = 0, ID_NIVEL_MAYOR = int.Parse(UIID_NIVEL_MAYOR.EditValue.ToString()), FLG_USA_CENTRO_COSTO = char.Parse(UIFLG_USA_CENTRO_COSTO.EditValue.ToString()), DS_NOMBRE_CONTADOR = UIDS_NOMBRE_CONTADOR.Text, ID_EMPRESA = _datasistema.empresa.ID };

            if (lista.Count() > 0)
            {
                try
                {
                    manejadorData.modificar(m);
                }
                catch (Exception e)
                {

                    MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
                }
            }
            else {
                try
                {

                    manejadorData.insertar(m);
                }
                catch (Exception e)
                {

                    MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
                }
            }
            consultar();
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

        private void frm_cont_conf_Load(object sender, EventArgs e)
        {
            consultar();
        }

    }
}
