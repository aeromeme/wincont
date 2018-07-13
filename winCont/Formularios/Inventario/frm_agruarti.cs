using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using InventarioDB;
using winCont.Utilidades ;
using winCont.Logica.Inventario;

namespace winCont.Formularios.Inventario
{
    public partial class frm_agruarti : winCont.Formularios.MasterForm,Interfaz_forms 
    {
        System.ComponentModel.BindingList<INV_FAMILIA > lista_familia;
        System.ComponentModel.BindingList<INV_GRUPO > lista_grupo;
        System.ComponentModel.BindingList<INV_CATEGORIA> lista_categoria;
        ManejadorCategoria  manejadorCategoria;
        ManejadorFamilia manejadorFamilia;
        ManejadorGrupo manejadorGrupo;
        public frm_agruarti()
        {
            InitializeComponent();
            //lista_deta.AddingNew += list_AddinDeta;
        }
        public frm_agruarti(DataSistema ds)
            : base(ds)
            
        {
            InitializeComponent();
            manejadorCategoria = new ManejadorCategoria(ds);
            manejadorGrupo = new ManejadorGrupo(ds);
            manejadorFamilia = new ManejadorFamilia(ds);
        }
        private void list_AddinFamilia(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new INV_FAMILIA ();
        }
        private void list_AddinGrupo(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new INV_GRUPO ();
        }
        private void list_AddinCategoria(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new INV_CATEGORIA ();
        }

        #region grupo
            public void consultarGrupo()
            {
                try
                {
                    int fam=0;
                    if (UIGRIDVIEWFAMILIA.FocusedRowHandle >= 0)
                    {
                        try
                        {
                            fam = (int)(UIGRIDVIEWFAMILIA.GetFocusedRowCellValue("ID"));
                        }
                        catch (Exception)
                        {
                            
                        }
                        
                    }
                    //lista_grupo  = new System.ComponentModel.BindingList<INV_GRUPO >((from u in _datasistema.ContextoInventario.INV_GRUPO where u.ID_EMPRESA == _datasistema.empresa.ID &&  u.ID_FAMILIA == fam select u
                    //).ToList());
                    lista_grupo = new System.ComponentModel.BindingList<INV_GRUPO>(manejadorGrupo .consultarPorIdEmpresayIdFamilia(_datasistema.empresa .ID,fam));

                    lista_grupo.AddingNew += list_AddinGrupo ;

                    UIGRIDCONTROLGRUPO.DataSource = lista_grupo;
                    consultarCategoria();
                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                }
            }
            public void insertargrupo(INV_GRUPO  d)
            {
                try
                {
                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.INV_GRUPO.InsertOnSubmit(d);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    manejadorGrupo.insertar(d);
                    consultarGrupo();
                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                    consultarGrupo();
                }

            }

            public void modificargrupo(INV_GRUPO d)
            {
                try
                {
                    //INV_GRUPO tupla = (from u in _datasistema.ContextoInventario.INV_GRUPO
                    //                     where u.ID == d.ID
                    //                     select u).First();
                    //tupla.DS_GRUPO = d.DS_GRUPO;
                    //tupla.CD_LINEA = d.CD_LINEA;

                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    manejadorGrupo.modificar(d);
                    consultarGrupo();

                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                    consultarGrupo();
                }
            }

            public void eliminargrupo(INV_GRUPO d)
            {

                try
                {
                    //INV_GRUPO tupla = (from u in _datasistema.ContextoInventario.INV_GRUPO
                    //                     where u.ID == d.ID
                    //                     select u).First();
                    //_datasistema.ContextoInventario.INV_GRUPO.DeleteOnSubmit(tupla);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    manejadorGrupo.eliminar(d);
                    consultarGrupo ();
                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                    consultarGrupo();
                }
            }
        #endregion

        #region categoria
            public void consultarCategoria()
            {
                try
                {
                    int grupo = 0;
                    if (UIGRIDVIEWGRUPO .FocusedRowHandle >= 0)
                    {
                        try
                        {
                            grupo = (int)(UIGRIDVIEWGRUPO.GetFocusedRowCellValue("ID"));
                        }
                        catch (Exception)
                        {

                        }
                       
                    }
                   // lista_categoria = new System.ComponentModel.BindingList<INV_CATEGORIA >((from u in _datasistema.ContextoInventario.INV_CATEGORIA  where u.ID_EMPRESA == _datasistema.empresa.ID && u.ID_GRUPO  == grupo select u
                  //  ).ToList());
                    lista_categoria = new System.ComponentModel.BindingList<INV_CATEGORIA>(manejadorCategoria .consultarPorIdEmpresaPorGrupo (_datasistema .empresa .ID ,grupo) );

                    lista_categoria.AddingNew += list_AddinCategoria ;

                    UIGRIDCONTROLCATEGORIA .DataSource = lista_categoria ;
                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                }
            }
            public void insertarcategoria(INV_CATEGORIA d)
            {
                try
                {
                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.INV_CATEGORIA.InsertOnSubmit(d);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    manejadorCategoria.insertar(d);
                    consultarCategoria();
                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                    consultarCategoria();
                }

            }

            public void modificarcategoria(INV_CATEGORIA  d)
            {
                try
                {
                    //INV_CATEGORIA tupla = (from u in _datasistema.ContextoInventario.INV_CATEGORIA 
                    //                   where u.ID == d.ID
                    //                   select u).First();
                    //tupla.DS_CATEGORIA = d.DS_CATEGORIA;
                    //tupla.CD_LINEA = d.CD_LINEA;

                    manejadorCategoria.modificar(d);

                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    consultarCategoria();

                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                    consultarCategoria();
                }
            }

            public void eliminarcategoria(INV_CATEGORIA d)
            {

                try
                {
                    //INV_CATEGORIA tupla = (from u in _datasistema.ContextoInventario.INV_CATEGORIA
                    //                   where u.ID == d.ID
                    //                   select u).First();
                    //_datasistema.ContextoInventario.INV_CATEGORIA.DeleteOnSubmit(tupla);
                    //_datasistema.ContextoInventario.SubmitChanges();

                    manejadorCategoria.eliminar(d);

                    consultarCategoria();
                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                    consultarCategoria();
                }
            }
            #endregion

            public void consultar()
        {
            try
            {
                _datasistema.conectarInventario();
                    lista_familia  =  new System.ComponentModel.BindingList<INV_FAMILIA  >((from u in _datasistema.ContextoInventario .INV_FAMILIA   where u.ID_EMPRESA  ==_datasistema .empresa .ID  select u
                    ).ToList());

                    lista_familia = new System.ComponentModel.BindingList<INV_FAMILIA>(manejadorFamilia .consultarPorIdEmpresa (_datasistema .empresa .ID ));

                    lista_familia.AddingNew += list_AddinFamilia;

                    UIGRIDCONTROLFAMILIA .DataSource = lista_familia;
                    consultarGrupo();
            }
            catch (Exception ex)
            {

                MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
            }
        }

            public void insertarfamilia(INV_FAMILIA  d)
            {
                try
                {
                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.INV_FAMILIA.InsertOnSubmit(d);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    manejadorFamilia.insertar(d);
                    consultar();
                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                    consultar();
                }

            }

            public void modificarfamilia(INV_FAMILIA d)
            {
                try
                {
                    //INV_FAMILIA tupla = (from u in _datasistema.ContextoInventario.INV_FAMILIA
                    //                             where u.ID == d.ID
                    //                             select u).First();
                    //tupla.DS_FAMILIA = d.DS_FAMILIA;
                    //tupla.FLG_SERVICIO = d.FLG_SERVICIO ;
                    //tupla.CD_LINEA = d.CD_LINEA;

                    //_datasistema.ContextoInventario.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    manejadorFamilia.modificar(d);
                    consultar();

                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                    consultar();
                }
            }

            public void eliminarfamilia(INV_FAMILIA d)
            {

                try
                {
                    //INV_FAMILIA tupla = (from u in _datasistema.ContextoInventario.INV_FAMILIA
                    //                             where u.ID == d.ID
                    //                             select u).First();
                    //_datasistema.ContextoInventario.INV_FAMILIA.DeleteOnSubmit(tupla);
                    //_datasistema.ContextoInventario.SubmitChanges();
                    manejadorFamilia.eliminar(d);
                    consultar();
                }
                catch (Exception ex)
                {

                    MetodosForm.mensajeErrorDefault(ex.Message, _datasistema);
                    consultar();
                }
            }

            private void UIGRIDVIEWFAMILIA_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
            {
                UIGRIDVIEWFAMILIA.SetFocusedRowCellValue("ID", 0);
                UIGRIDVIEWFAMILIA.SetFocusedRowCellValue("ID_EMPRESA", _datasistema.empresa.ID);        
            }

            private void UIGRIDVIEWFAMILIA_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
            {
                INV_FAMILIA d = (INV_FAMILIA)e.Row;
                if (d.ID == 0)
                {
                    insertarfamilia(d);
                }
                else
                {
                    modificarfamilia(d);
                }
            }

            private void UIGRIDVIEWFAMILIA_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Delete && UIGRIDVIEWFAMILIA.FocusedRowHandle >= 0)
                {
                    if (MetodosForm.preguntar(3))
                    {
                        INV_FAMILIA d = new INV_FAMILIA()
                        {
                            ID = (int)UIGRIDVIEWFAMILIA.GetFocusedRowCellValue("ID")
                        };
                        eliminarfamilia(d);
                    }
                }
            }

        public void nuevo()
        {
 	       
        }

        public void guardar()
        {
 	       
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

        private void UIGRIDVIEWGRUPO_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            UIGRIDVIEWGRUPO.SetFocusedRowCellValue("ID", 0);
            UIGRIDVIEWGRUPO.SetFocusedRowCellValue("ID_EMPRESA", _datasistema.empresa.ID);
            int fam = 0;
            if (UIGRIDVIEWFAMILIA.FocusedRowHandle >= 0)
            {
                fam = (int)(UIGRIDVIEWFAMILIA.GetFocusedRowCellValue("ID"));
            }
            UIGRIDVIEWGRUPO.SetFocusedRowCellValue("ID_FAMILIA", fam);
        }

        private void UIGRIDVIEWGRUPO_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            INV_GRUPO d = (INV_GRUPO)e.Row;
            if (d.ID_FAMILIA == 0) {
                MetodosForm.mensajeErrorDefault("No selecciono una familia", _datasistema);
            }
            if (d.ID == 0)
            {
                insertargrupo (d);
            }
            else
            {
                modificargrupo(d);
            }
        }

        private void UIGRIDVIEWGRUPO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && UIGRIDVIEWGRUPO .FocusedRowHandle >= 0)
            {
                if (MetodosForm.preguntar(3))
                {
                    INV_GRUPO d = new INV_GRUPO()
                    {
                        ID = (int)UIGRIDVIEWGRUPO.GetFocusedRowCellValue("ID")
                    };
                    eliminargrupo (d);
                }
            }
        }

        private void UIGRIDVIEWCATEGORIA_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            UIGRIDVIEWCATEGORIA .SetFocusedRowCellValue("ID", 0);
            UIGRIDVIEWCATEGORIA .SetFocusedRowCellValue("ID_EMPRESA", _datasistema.empresa.ID);
            int grupo = 0;
            if (UIGRIDVIEWGRUPO  .FocusedRowHandle >= 0)
            {
                grupo = (int)(UIGRIDVIEWGRUPO .GetFocusedRowCellValue("ID"));
            }
            UIGRIDVIEWCATEGORIA.SetFocusedRowCellValue("ID_GRUPO", grupo);
        }

        private void UIGRIDVIEWCATEGORIA_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            INV_CATEGORIA d = (INV_CATEGORIA)e.Row;
            if (d.ID_GRUPO  == 0)
            {
                MetodosForm.mensajeErrorDefault("No selecciono un grupo", _datasistema);
            }
            if (d.ID == 0)
            {
                insertarcategoria(d);
            }
            else
            {
                modificarcategoria (d);
            }
        }

        private void UIGRIDVIEWCATEGORIA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && UIGRIDVIEWCATEGORIA .FocusedRowHandle >= 0)
            {
                if (MetodosForm.preguntar(3))
                {
                    INV_CATEGORIA d = new INV_CATEGORIA()
                    {
                        ID = (int)UIGRIDVIEWCATEGORIA .GetFocusedRowCellValue("ID")
                    };
                    eliminarcategoria(d);
                }
            }
        }

        private void UIGRIDVIEWFAMILIA_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
            consultarGrupo();  
        }

        private void UIGRIDVIEWGRUPO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            consultarCategoria();
        }

        private void frm_agruarti_Load(object sender, EventArgs e)
        {
            consultar();
        }


}
}
