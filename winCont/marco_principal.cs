using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Dynamic;
using DevExpress.XtraBars.Helpers;
using winCont.Formularios.Configuracion;
using winCont.Utilidades;
using Sistema;
using winCont.Clases;
using System.Reflection;
using winCont.Formularios;

namespace winCont
{
    public partial class marco_principal : Form
    {
        public DataSistema _dataSistema;

        public marco_principal()
        {
            InitializeComponent();
        }

        private void marco_principal_Load(object sender, EventArgs e)
        {
            prepararLogin();
        }

        public void cargarMenu() {

            if (_dataSistema.usuario.CD_LOGIN == "root")
            {
                uinv_bar_sistemas.Visible = true;
                uigrp_general.Visible = false;
            }
            else
            {
                uinv_bar_sistemas.Visible = false;

                List<SIS_MENU> lista_menu = (from u in _dataSistema.contextoSistema.SIS_MENU
                                               where (from y in _dataSistema.contextoSistema.SIS_PERFIL_OPC_MENU where y.SIS_OPC_MENU.ID_MENU == u.ID  && y.ID_PERFIL ==_dataSistema .usuario .ID_PERFIL  select y).Count() > 0
                                               select u).ToList();
                List<SIS_FORM> lista_opcion;
                List<clsImagen> listaimagen = MetodosForm.listaDeImagenesModulo();
                foreach (SIS_MENU  menu_item in lista_menu)
                {
                    DevExpress.XtraNavBar.NavBarGroup menu = uinavbarmenu.Groups.Add();
                    menu.Caption = menu_item.DS_MENU ;
                    menu.Expanded = false;
                    lista_opcion = (from u in _dataSistema .contextoSistema .SIS_FORM 
                                    orderby u.DS_ALT_NOMBRE ascending     
                                    where (from y in _dataSistema .contextoSistema .SIS_PERFIL_OPC_MENU  where y.ID_PERFIL==_dataSistema .usuario .ID_PERFIL && y.SIS_OPC_MENU .ID_FORM ==u.ID && y.SIS_OPC_MENU .ID_MENU ==menu_item.ID  select y).Count ()>0
                                          select u  ).ToList ();

                    foreach (SIS_FORM item_form in lista_opcion)
                    {
                        DevExpress.XtraNavBar.NavBarItemLink opcion = menu.AddItem();
                        opcion.Item.Caption = item_form.DS_ALT_NOMBRE ;
                        opcion.Item.Tag = item_form;
                        opcion.Item.SmallImage = MetodosForm.encontrarImagen(int.Parse (item_form.SIS_MODULO.CD_IMAGEN_ICO.ToString()) ,listaimagen);
                        //AddHandler opcion.Item.LinkClicked, AddressOf NavBarItemClicked
                        opcion.Item.LinkClicked  += new DevExpress.XtraNavBar.NavBarLinkEventHandler(NavBarItemClicked);
                        opcion.Item.Hint = item_form.DS_TOOLTIP;

                    }
                }

                
            }
               
        }

        public void selEmpresa() {
            if (_dataSistema.usuario.CD_LOGIN == "root")
            {
               
            }
            else
            {
                _dataSistema.nombreVentana = "Empresas";
                frm_sel_empresa f = new frm_sel_empresa(_dataSistema);
                f.ShowDialog();
                
                if (f.empresa != null)
                {
                    _dataSistema.empresa = f.empresa;
                    uibtnempresa.Caption = _dataSistema.empresa.DS_EMPRESA;
                    Preferencias.guardarParamGeneEmpre(_dataSistema.empresa.ID);
                }
                
            }
        }

        public void selPeriodo()
        {
            if (_dataSistema.empresa == null) {
                MetodosForm.mensajeErrorDefault("No selecciono una empresa",_dataSistema );
                return;
            }
            if (_dataSistema.usuario.CD_LOGIN == "root")
            {

            }
            else
            {
                _dataSistema.nombreVentana = "Periodos";
                frm_sel_periodo f = new frm_sel_periodo(_dataSistema);
                f.ShowDialog();

                if (f.periodo != null)
                {
                    _dataSistema.periodo = f.periodo;
                    uibtnperiodo .Caption = MetodosForm .encontrarMes (int.Parse (_dataSistema .periodo .NM_PERIODO.ToString ()) ).ToUpper().Substring (0,3) +" "+_dataSistema.periodo.NM_EJERCICIO.ToString ();
                    Preferencias.guardarParamGenePeriodo (int.Parse (_dataSistema.periodo .NM_PERIODO.ToString ()),int.Parse(_dataSistema .periodo .NM_EJERCICIO.ToString ()) );
                }

            }
        }

        private void NavBarItemClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SIS_FORM a= (SIS_FORM)e.Link .Item .Tag ;

            Boolean flgcrear = true;
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage item in this.uicontrolpaginas.Pages )
            {
                if (item.MdiChild.Name.Equals(a.CD_FORM.Split ('.')[1] )){
                    flgcrear = false;
                    this.uicontrolpaginas.SelectedPage = item;
                }
            }

            if (flgcrear) {
                if (a.FLG_REQ_EMPRESA == 'S' && _dataSistema.empresa == null)
                {
                    MetodosForm.mensajeErrorDefault("No selecciono una empresa", _dataSistema);
                    return;
                }
                if (a.FLG_REQ_PERIODO == 'S' && _dataSistema.periodo == null)
                {
                    MetodosForm.mensajeErrorDefault("No selecciono un periodo", _dataSistema);
                    return;
                }
                DataSistema ds = MetodosForm.obtenerCopy(_dataSistema);
                //con esta copia resguarda una informacion no recuerdo cual
                ds.nombreOpcion = a.DS_NOMBRE;
                ds.nombreVentana = a.DS_ALT_NOMBRE;
                ds.modoInterfaz = (int)a.CD_MODO_INTERFAZ;
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                Assembly ass = Assembly.LoadFrom(path);
                string projandform = "winCont.Formularios." + a.CD_FORM;
                Type FormInstanceType = ass.GetType(projandform);
                Form objForm = (Form)Activator.CreateInstance(FormInstanceType, ds);
                objForm.MdiParent = this;
                objForm.Show();
            }
           
        }

        #region menu_admin_config

        private void uinvbarconfig_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _dataSistema = MetodosForm.obtenerCopy(_dataSistema);
            _dataSistema.nombreVentana = "Config";
            _dataSistema.nombreOpcion = "Configuracion";
            _dataSistema.modoInterfaz = 1;
            configuracion c = new configuracion(_dataSistema);
            c.MdiParent = this;
            c.Show();
        }
        private void uinvbar_menu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _dataSistema = MetodosForm.obtenerCopy(_dataSistema);
            _dataSistema.nombreVentana = "Menu";
            _dataSistema.nombreOpcion = "Menu";
            _dataSistema.modoInterfaz = 1;
            frm_menu c = new frm_menu(_dataSistema);
            c.MdiParent = this;
            c.Show();
        }

        private void uinvbar_modulos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _dataSistema = MetodosForm.obtenerCopy(_dataSistema);
            _dataSistema.nombreVentana = "Modulo";
            _dataSistema.nombreOpcion = "Modulo";
            _dataSistema.modoInterfaz = 1;
            frm_modulo c = new frm_modulo(_dataSistema);
            c.MdiParent = this;
            c.Show();
        }
        private void uinvbar_formularios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _dataSistema = MetodosForm.obtenerCopy(_dataSistema);
            _dataSistema.nombreVentana = "Formulario";
            _dataSistema.nombreOpcion = "Formulario";
            _dataSistema.modoInterfaz = 1;
            frm_formulario c = new frm_formulario(_dataSistema);
            c.MdiParent = this;
            c.Show();
        }

        private void uinvbar_opcmenu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _dataSistema = MetodosForm.obtenerCopy(_dataSistema);
            _dataSistema.nombreVentana = "Opciones de menu";
            _dataSistema.nombreOpcion = "Opciones de menu";
            _dataSistema.modoInterfaz = 2;
            frm_opc_menu c = new frm_opc_menu(_dataSistema);
            c.MdiParent = this;
            c.Show();
        }

        private void uinvbar_perfil_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _dataSistema = MetodosForm.obtenerCopy(_dataSistema);
            _dataSistema.nombreVentana = "Perfiles";
            _dataSistema.nombreOpcion = "Perfiles";
            _dataSistema.modoInterfaz = 1;
            frm_perfil c = new frm_perfil(_dataSistema);
            c.MdiParent = this;
            c.Show();
        }
        private void uinvbar_usuarios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            _dataSistema = MetodosForm.obtenerCopy(_dataSistema);
            _dataSistema.nombreVentana = "Usuarios";
            _dataSistema.nombreOpcion = "usuarios";
            _dataSistema.modoInterfaz = 1;
            frm_usuarios c = new frm_usuarios(_dataSistema);
            c.MdiParent = this;
            c.Show();
        }

        #endregion

        #region opciones_CRUD
        private void uibtnrefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (verificarmdiChild())
            {
                dynamic f = this.ActiveMdiChild;
                f.consultar();
            }

        }
        private void uibtncerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (verificarmdiChild()){
                this.ActiveMdiChild.Close(); 
            }
            
        }
        private void uibtnnuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (verificarmdiChild())
            {
                dynamic f = this.ActiveMdiChild;
                f.nuevo();
            }
        }

        private void uibtnguardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (verificarmdiChild())
            {
                if (!MetodosForm.preguntar(2))
                {
                    return;
                }
                dynamic f = this.ActiveMdiChild;
                f.guardar();
            }
        }

        private void uibtneliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (verificarmdiChild())
            {
                if (!MetodosForm.preguntar(3)) {
                    return;
                }
                dynamic f = this.ActiveMdiChild;
                f.eliminar();
            }
        }

        private void uibtnimprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (verificarmdiChild())
            {
                dynamic f = this.ActiveMdiChild;
                f.imprimir();
            }
        }
        private bool verificarmdiChild() { 
        if (this.ActiveMdiChild==null){
            return false;
        }
        return true;
        }
        #endregion

        /// <summary>
        ///
        /// </summary>
        /// <param name="modo">0: normal, 1: oculto los parametros generales e imprimir</param>
        public void adaptarInterfaz(int modo) { 
            switch  (modo){
                case 0:
                    //uigrp_general.Visible = true;
                    //uibtnimprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always ;
                    //uibtnnuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //uibtnguardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    //uibtneliminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    if (_dataSistema != null)
                    {
                        if (_dataSistema.usuario.CD_LOGIN != "root")
                        {
                            uigrp_general.Visible = true;
                        }
                    }
                    else {
                        uigrp_general.Visible = true;
                    }
                   
                    uibtnimprimir.Enabled = true;
                    uibtnnuevo.Enabled = true;
                    uibtnguardar.Enabled = true;
                    uibtneliminar.Enabled = true;
                    uibtnrefrescar.Enabled = true;
                    break;
                case 1:
                    //uigrp_general.Visible = false;
                    //uibtnimprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    uigrp_general.Visible = false;
                    uibtnimprimir.Enabled = false;
                    break;
                case 2:
                    //uigrp_general.Visible = false;
                    //uibtnnuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //uibtnguardar .Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //uibtneliminar .Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //uibtnimprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    uigrp_general.Visible = false;
                    uibtnimprimir.Enabled = false;
                    uibtnnuevo.Enabled = false;
                    uibtnguardar.Enabled = false;
                    uibtneliminar.Enabled = false;
                    break;
                case 3:
                    //uigrp_general.Visible = false;
                    //uibtnnuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //uibtnguardar .Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //uibtneliminar .Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    //uibtnimprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    uigrp_general.Visible = true;
                    uibtnimprimir.Enabled = false;
                    uibtnnuevo.Enabled = false;
                    uibtnguardar.Enabled = false;
                    uibtneliminar.Enabled = false;
                    break;
            }


        
        }

        private void uibtnempresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selEmpresa();
        }

        private void uibtnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void uibtnperiodo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selPeriodo();
        }

        private void uibtnventanadatos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (verificarmdiChild())
            {
                try
                {
                    MasterFormTab f = (MasterFormTab)this.ActiveMdiChild;

                    Control[] tab = f.Controls.Find("uimaintabcontrol", true);
                    if (tab.Length == 1)
                    {
                        if (f.uimaintabcontrol.SelectedTabPageIndex == 0)
                        {
                            f.uimaintabcontrol.SelectedTabPageIndex = 1;
                        }
                        else
                        {
                            f.uimaintabcontrol.SelectedTabPageIndex = 0;
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
                
            }
        }

        private void uibtnampliar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (uinavbarmenu.Visible)
            {
                uinavbarmenu.Visible = false;
            }
            else {
                uinavbarmenu.Visible = true;
            }
        }

        private void uibtncerrar_sesion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _dataSistema = null;
            foreach (var item in this.MdiChildren )
            {
                item.Close();
            }
            uinavbarmenu.Items.Clear();
            uinavbarmenu.Groups.Clear();
            uibtnempresa.Caption = "Empresa";
            uitxtperfil.Caption = "Perfil";
            uitxtusuario.Caption = "Usuario";
            uigrp_general.Visible = true;
            prepararLogin();     
        }

        private void prepararLogin() {
            IsMdiContainer = true;
            DevExpress.UserSkins.BonusSkins.Register();
            SkinHelper.InitSkinGallery(uirbn_gallery_theme, true);
            this.Enabled = false;
            uinv_bar_sistemas.Visible = false;
            Login l = new Login();
            l.ShowDialog();
            if (l.flg_user_autenticado)
            {
                //cargar el sistema
                this.Enabled = true;
                _dataSistema = l._dataSistema;
                _dataSistema.mainForm = this;
                if (_dataSistema.usuario.CD_LOGIN != "root")
                {
                    uitxtperfil.Caption = _dataSistema.usuario.SIS_PERFIL.DS_PERFIL;
                    uitxtusuario.Caption = _dataSistema.usuario.DS_NOMBRE_USUARIO;
                }
                cargarMenu();
                selEmpresa();
            }
            else
            {
                this.Close();
            } 
        }


    

    }
}
