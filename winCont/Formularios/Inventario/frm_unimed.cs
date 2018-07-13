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
using winCont.Logica.Inventario;

namespace winCont.Formularios.Inventario
{
    public partial class frm_unimed : winCont.Formularios.MasterFormTab,Interfaz_forms
    {
        public List<INV_UNIMED> lista;
        ManejadorUnidadDeMedida manejadorUniMed;
        public frm_unimed()
        {
            InitializeComponent();
        }
        public frm_unimed(DataSistema ds):base(ds)
        {
            InitializeComponent();
            manejadorUniMed = new ManejadorUnidadDeMedida(ds);
        }


        public void consultar()
        {
            try
            {
                //_datasistema.conectarInventario ();
                //lista = (from u in _datasistema.ContextoInventario .INV_UNIMED  where u.ID_EMPRESA == _datasistema.empresa.ID select u
                //    ).ToList();
                lista = manejadorUniMed.consultarPorIdEmpresa(_datasistema.empresa.ID);
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                if (lista.Count == 0)
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
            UIDS_UNIMED.Text = "";
            UIDS_SIMBOLO.Text = "";
        }

        public void guardar()
        {
            if (UIID.Text == "")
            {
                try
                {
                    INV_UNIMED m = new INV_UNIMED { ID = 0, DS_UNIMED  = UIDS_UNIMED.Text, ID_EMPRESA = _datasistema.empresa.ID, DS_SIMBOLO =UIDS_SIMBOLO .Text  };
                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.INV_UNIMED.InsertOnSubmit(m);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    m = manejadorUniMed.insertar(m);
                    consultar();
                    MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
                }
                catch (Exception e)
                {

                    MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
                }
            }

            else
            {
                try
                {
                    INV_UNIMED m = new INV_UNIMED { ID = int.Parse(UIID.Text), DS_UNIMED = UIDS_UNIMED.Text, ID_EMPRESA = _datasistema.empresa.ID, DS_SIMBOLO =UIDS_SIMBOLO .Text  };
                    //m.DS_UNIMED = UIDS_UNIMED.Text;
                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    manejadorUniMed.modificar(m);
                    consultar();
                    MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
                }
                catch (Exception e)
                {

                    MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
                }

            }
        }

        public void eliminar()
        {
            try
            {
                //INV_UNIMED m = (from u in _datasistema.ContextoInventario.INV_UNIMED
                //                 where u.ID == int.Parse(UIID.Text)
                //                 select u).First();
                INV_UNIMED m = new INV_UNIMED { ID = int.Parse(UIID.Text ), ID_EMPRESA = _datasistema.empresa.ID };
                //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                //_datasistema.ContextoInventario.INV_UNIMED.DeleteOnSubmit(m);
                //_datasistema.ContextoInventario.SubmitChanges();
                manejadorUniMed.eliminar(m);
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
            UIID.DataBindings.Add("EditValue", lista, "ID", true, DataSourceUpdateMode.Never);
            UIDS_UNIMED.DataBindings.Add("EditValue", lista, "DS_UNIMED", false, DataSourceUpdateMode.Never);
            UIDS_SIMBOLO.DataBindings.Add("EditValue", lista, "DS_SIMBOLO", false, DataSourceUpdateMode.Never);

        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_UNIMED.DataBindings.Clear();
            UIDS_SIMBOLO.DataBindings.Clear();
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
