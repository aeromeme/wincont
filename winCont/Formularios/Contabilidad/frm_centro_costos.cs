using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContabilidadDB;
using winCont.Utilidades;
using winCont.Logica.Contabilidad;

namespace winCont.Formularios.Contabilidad
{
    public partial class frm_centro_costos : winCont.Formularios.MasterFormTab, Interfaz_forms
    {
         List<CONT_CENTRO_COSTO> lista;
         ManejadorCentroCosto manejadorData;

        public frm_centro_costos()
        {
            InitializeComponent();
        }

        public frm_centro_costos(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
            manejadorData = new ManejadorCentroCosto(ds);
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarContabilidad ();
                lista = manejadorData.consultarPorIdEmpresa(_datasistema.empresa.ID);
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
            UIDS_NOMBRE.Text = "";

        }

        public void guardar()
        {
             try
                {
                CONT_CENTRO_COSTO m = new CONT_CENTRO_COSTO { ID = 0, DS_NOMBRE = UIDS_NOMBRE.Text, ID_EMPRESA = _datasistema.empresa.ID };
                if (UIID.Text == "")
                {
                   m= manejadorData.insertar(m);
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
                CONT_CENTRO_COSTO m = new CONT_CENTRO_COSTO { ID=int.Parse (UIID.Text )};
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
            throw new NotImplementedException();
        }

        public void cerrar()
        {
            this.Close();
        }

        public void enlazar()
        {
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
            UIDS_NOMBRE.DataBindings.Add("EditValue", lista, "DS_NOMBRE", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_NOMBRE.DataBindings.Clear();
        }

        public override void refrescar()
        {
            consultar();
        }
        public override void enlazar_aux()
        {
            desenlazar();
            enlazar();
        }
        public bool validar()
        {
            return true;
        }
    }
}
