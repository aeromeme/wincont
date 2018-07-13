using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using VentasDB;
using System.Linq;

namespace winCont.Formularios.Ventas
{
    public partial class frm_vendedores : winCont.Formularios.MasterFormTab,Interfaz_forms
    {
        List<FAC_VENDEDOR> lista;
        public frm_vendedores()
        {
            InitializeComponent();
        }
        public frm_vendedores(DataSistema ds):base(ds)
        {
            InitializeComponent();
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarVentas();
                lista = (from u in _datasistema.ContextoVentas.FAC_VENDEDOR  where u.ID_EMPRESA == _datasistema.empresa.ID select u
                    ).ToList();
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
            UIDS_VENDEDOR.Text = "";
            UICD_VENDEDOR.Text = "";
            UIDS_CORREO.Text = "";
            UIDS_TELEFONO.Text = "";

        }

        public void guardar()
        {
            if (UIID.Text == "")
            {
                try
                {
                    FAC_VENDEDOR m = new FAC_VENDEDOR
                    {
                        ID = 0,
                        DS_VENDEDOR = UIDS_VENDEDOR.Text,
                        ID_EMPRESA = _datasistema.empresa.ID,
                        DS_CORREO =UIDS_CORREO .Text ,
                        DS_TELEFONO =UIDS_TELEFONO .Text ,
                        CD_VENDEDOR =UICD_VENDEDOR .Text 
                    };
                    _datasistema.ContextoVentas.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoVentas.FAC_VENDEDOR.InsertOnSubmit(m);
                    _datasistema.ContextoVentas.SubmitChanges();
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
                    FAC_VENDEDOR m = (from u in _datasistema.ContextoVentas.FAC_VENDEDOR
                                   where u.ID == int.Parse(UIID.Text)
                                   select u).First();

                    {
                        m.DS_VENDEDOR = UIDS_VENDEDOR.Text;
                        m.DS_TELEFONO = UIDS_TELEFONO.Text;
                        m.DS_CORREO = UIDS_CORREO.Text;
                        m.CD_VENDEDOR = UICD_VENDEDOR.Text;
                        _datasistema.ContextoVentas.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                        _datasistema.ContextoVentas.SubmitChanges();
                        consultar();
                        MetodosForm.seleccionarFila(uigridview, "ID", m.ID);
                    }

                }
                catch
                    (Exception e)
                {

                    MetodosForm.mensajeErrorDefault(e.Message, _datasistema);
                }
            }
        }

        public void eliminar()
        {
            try
            {
                FAC_VENDEDOR m = (from u in _datasistema.ContextoVentas.FAC_VENDEDOR
                               where u.ID == int.Parse(UIID.Text)
                               select u).First();

                _datasistema.ContextoVentas.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoVentas.FAC_VENDEDOR.DeleteOnSubmit(m);
                _datasistema.ContextoVentas.SubmitChanges();
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
            UIDS_VENDEDOR.DataBindings.Add("EditValue", lista, "DS_VENDEDOR", false, DataSourceUpdateMode.Never);
            UICD_VENDEDOR .DataBindings .Add("EditValue",lista,"CD_VENDEDOR",false,DataSourceUpdateMode.Never );
            UIDS_TELEFONO.DataBindings.Add("EditValue", lista, "DS_TELEFONO", false, DataSourceUpdateMode.Never);
            UIDS_CORREO.DataBindings.Add("EditValue", lista, "DS_CORREO", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_VENDEDOR .DataBindings .Clear ();
            UICD_VENDEDOR.DataBindings.Clear();
            UIDS_CORREO.DataBindings.Clear();
            UIDS_TELEFONO.DataBindings.Clear();
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
