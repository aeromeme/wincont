using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winCont.Utilidades;
using VentasDB;
using InventarioDB;
using System.Linq;

namespace winCont.Formularios.Ventas
{
    public partial class frm_lista_precio : winCont.Formularios.MasterFormTab, Interfaz_forms 
    {
        List<FAC_LISTA_PRECIO> lista;
        public frm_lista_precio()
        {
            InitializeComponent();
        }
        public frm_lista_precio(DataSistema ds)
            : base(ds)
        {
            InitializeComponent();
        }
        public void consultar()
        {
            try
            {
                _datasistema.conectarVentas();
                lista = (from u in _datasistema.ContextoVentas.FAC_LISTA_PRECIO where u.ID_EMPRESA == _datasistema.empresa.ID select u
                    ).ToList();
                uigridcontrol.DataSource = lista;
                desenlazar();
                enlazar();
                if (lista.Count() == 0)
                {
                    nuevo();
                }
                consultarDetalle();
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
            UIDS_LISTA.Text = "";
        }

        public void guardar()
        {
            if (UIID.Text == "")
            {
                try
                {
                    FAC_LISTA_PRECIO m = new FAC_LISTA_PRECIO
                    {
                        ID = 0,
                        DS_LISTA  = UIDS_LISTA.Text,
                        ID_EMPRESA = _datasistema.empresa.ID
                    };
                    _datasistema.ContextoVentas.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    _datasistema.ContextoVentas.FAC_LISTA_PRECIO.InsertOnSubmit(m);
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
                    FAC_LISTA_PRECIO m = (from u in _datasistema.ContextoVentas.FAC_LISTA_PRECIO
                                      where u.ID == int.Parse(UIID.Text)
                                      select u).First();

                    {
                        m.DS_LISTA = UIDS_LISTA.Text;
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
                FAC_LISTA_PRECIO m = (from u in _datasistema.ContextoVentas.FAC_LISTA_PRECIO
                                  where u.ID == int.Parse(UIID.Text)
                                  select u).First();

                _datasistema.ContextoVentas.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                _datasistema.ContextoVentas.FAC_LISTA_PRECIO.DeleteOnSubmit(m);
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
            throw new NotImplementedException();
        }

        public void cerrar()
        {
            this.Close();
        }

        public void enlazar()
        {
            UIID.DataBindings.Add("EditValue", lista, "ID", false, DataSourceUpdateMode.Never);
            UIDS_LISTA.DataBindings.Add("EditValue", lista, "DS_LISTA", false, DataSourceUpdateMode.Never);
        }

        public void desenlazar()
        {
            UIID.DataBindings.Clear();
            UIDS_LISTA.DataBindings.Clear();
        }

        public bool validar()
        {
            return true;
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

        private void UIID_EditValueChanged(object sender, EventArgs e)
        {
            consultarDetalle();
        }
        public void consultarDetalle() {
            try
            {
                _datasistema.conectarInventario();
                _datasistema.conectarVentas();
                if (int.Parse(UIID.Text) != 0)
                {
                    List<V_FAC_DETA_LISTA_PRECIO> listaPrecio = (from u in _datasistema.ContextoVentas.V_FAC_DETA_LISTA_PRECIO
                                                                 where u.ID_LISTA == int.Parse(UIID.Text)
                                                                 select u).ToList();
                    int?[] listaDetaPrecio = (from u in _datasistema.ContextoVentas.V_FAC_DETA_LISTA_PRECIO
                                              where u.ID_LISTA == int.Parse(UIID.Text)
                                              select u.ID_ARTICULO).ToArray();

                    List<V_INV_ARTICULO> listaArti = (from u in _datasistema.ContextoInventario.V_INV_ARTICULO
                                                      where u.FLG_INVENTARIABLE == 'S' && !listaDetaPrecio.Contains(u.ID)
                                                      select u).ToList();

                    UIGRIDCONTROL_ARTICULOS.DataSource = listaArti;
                    UIGRIDCONTROL_DETALIST.DataSource = listaPrecio;
                }
                
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
            

          
        }
        public void insertarDetalle(FAC_DETA_LISTA_PRECIO d) {
            try
            {
                _datasistema.conectarVentas();
                _datasistema.ContextoVentas.FAC_DETA_LISTA_PRECIO.InsertOnSubmit(d);
                _datasistema.ContextoVentas.SubmitChanges();
                consultarDetalle();
            }
            catch (Exception ex)
            {
                consultarDetalle();
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }
        public void modificarDetalle(FAC_DETA_LISTA_PRECIO d)
        {
            try
            {
                _datasistema.conectarVentas();
                FAC_DETA_LISTA_PRECIO tupla = (from u in _datasistema.ContextoVentas.FAC_DETA_LISTA_PRECIO where u.ID == d.ID select u).First();
                tupla.NM_PRECIO = d.NM_PRECIO;
                _datasistema.ContextoVentas.SubmitChanges();
                consultarDetalle();

            }
            catch (Exception ex)
            {
                consultarDetalle();
                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        public void eliminarDetalle(FAC_DETA_LISTA_PRECIO d)
        {
            try
            {
                _datasistema.conectarVentas();
                FAC_DETA_LISTA_PRECIO tupla = (from u in _datasistema.ContextoVentas.FAC_DETA_LISTA_PRECIO where u.ID == d.ID select u).First();
                _datasistema.ContextoVentas.FAC_DETA_LISTA_PRECIO.DeleteOnSubmit(tupla);
                _datasistema.ContextoVentas.SubmitChanges();
                consultarDetalle();

            }
            catch (Exception ex)
            {
                consultarDetalle();
                 MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

        private void UIGRIDVIEW_DETALIST_DoubleClick(object sender, EventArgs e)
        {
            V_FAC_DETA_LISTA_PRECIO arti = (V_FAC_DETA_LISTA_PRECIO)UIGRIDVIEW_DETALIST.GetFocusedRow();
            FAC_DETA_LISTA_PRECIO artilist = new FAC_DETA_LISTA_PRECIO
            {
                ID_ARTICULO = arti.ID,
                NM_PRECIO = arti.NM_PRECIO ,
                ID_LISTA = int.Parse(UIID.Text),
                ID=arti.ID 
            };
            eliminarDetalle(artilist);
        }

        private void UIGRIDVIEW_ARTICULOS_DoubleClick(object sender, EventArgs e)
        {
            V_INV_ARTICULO arti = (V_INV_ARTICULO )UIGRIDVIEW_ARTICULOS.GetFocusedRow();
            FAC_DETA_LISTA_PRECIO artilist = new FAC_DETA_LISTA_PRECIO
            {
                ID_ARTICULO = arti.ID,
                NM_PRECIO = 0,
                ID_LISTA = int.Parse(UIID.Text)
            };

            insertarDetalle(artilist );

        }

        private void UIGRIDVIEW_DETALIST_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            V_FAC_DETA_LISTA_PRECIO arti = (V_FAC_DETA_LISTA_PRECIO)e.Row;
             FAC_DETA_LISTA_PRECIO artilist = new FAC_DETA_LISTA_PRECIO
            {
                ID_ARTICULO = arti.ID,
                NM_PRECIO = arti.NM_PRECIO ,
                ID_LISTA = int.Parse(UIID.Text),
                ID=arti.ID 
            };
             modificarDetalle(artilist);
        }

    }
}
