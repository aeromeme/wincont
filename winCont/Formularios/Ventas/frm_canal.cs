using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentasDB;
using winCont.Utilidades;
using System.Linq;

namespace winCont.Formularios.Ventas
{
    public partial class frm_canal : winCont.Formularios.MasterFormTab,Interfaz_forms
    {
        List<FAC_CANAL> lista;
        public frm_canal()
        {
            InitializeComponent();
        }
        public frm_canal(DataSistema ds):base(ds)
        {
            InitializeComponent();
        }

        public void consultar()
        {
            try
            {
                _datasistema.conectarVentas();
                lista = (from u in _datasistema.ContextoVentas .FAC_CANAL where u.ID_EMPRESA == _datasistema.empresa.ID select u
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
            UIDS_CANAL.Text = "";
        }

        public void guardar()
        {
            if (UIID.Text == "")
            {
                try
                {
                    FAC_CANAL m = new FAC_CANAL
                    {
                        ID = 0,
                        DS_CANAL = UIDS_CANAL.Text,
                        ID_EMPRESA = _datasistema.empresa.ID
                    };
                    _datasistema.ContextoVentas.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoVentas.FAC_CANAL.InsertOnSubmit(m);
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
                    FAC_CANAL m = (from u in _datasistema.ContextoVentas.FAC_CANAL
                                        where u.ID == int.Parse(UIID.Text)
                                        select u).First();

                    {
                        m.DS_CANAL = UIDS_CANAL.Text;
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
                FAC_CANAL m = (from u in _datasistema.ContextoVentas.FAC_CANAL
                                    where u.ID == int.Parse(UIID.Text)
                                    select u).First();

                _datasistema.ContextoVentas.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoVentas .FAC_CANAL.DeleteOnSubmit(m);
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
            UIDS_CANAL.DataBindings.Add("EditValue", lista, "DS_CANAL", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_CANAL.DataBindings.Clear();
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
