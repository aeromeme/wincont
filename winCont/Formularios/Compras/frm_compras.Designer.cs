namespace winCont.Formularios.Compras
{
    partial class frm_compras
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.vCOMPCOMPRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EJERCICIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_PERIODO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TERCERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_FORMA_PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFE_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFE_VENCIMIENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TIPO_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_SERIE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_NUMERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_GRAVADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EXENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_SUJETO_A_RENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_RETENCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_RENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_SALDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DIRECCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_RZN_COMER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_RF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_NIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_DUI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_FORMA_PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFLG_CREDITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.UIID_TERCERO = new DevExpress.XtraEditors.GridLookUpEdit();
            this.sISTERCEROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_RZN_COMER1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_NIT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_DUI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_RF1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_TIPO_CONTRIBUYENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_MUNICIPIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DIRECCION1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_TELEFONO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CORREO_E = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CONTACTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFLG_CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFLG_PROVEEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_CUENTAXCOBRAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_CUENTAXPAGAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFLG_CREDITO_CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFLG_CREDITO_PROVEEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_TIPO_PERSONA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sISFORMAPAGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UIID_TIPO_DOCUMENTO = new DevExpress.XtraEditors.LookUpEdit();
            this.sISDOCUMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UIFE_FECHA = new DevExpress.XtraEditors.DateEdit();
            this.UIFE_VENCIMIENTO = new DevExpress.XtraEditors.DateEdit();
            this.UICD_SERIE = new DevExpress.XtraEditors.TextEdit();
            this.UICD_NUMERO = new DevExpress.XtraEditors.TextEdit();
            this.UINM_GRAVADO = new DevExpress.XtraEditors.CalcEdit();
            this.UINM_EXENTO = new DevExpress.XtraEditors.CalcEdit();
            this.UINM_SUJETO_A_RENTA = new DevExpress.XtraEditors.CalcEdit();
            this.UINM_IVA = new DevExpress.XtraEditors.TextEdit();
            this.UINM_RETENCION = new DevExpress.XtraEditors.TextEdit();
            this.UINM_RENTA = new DevExpress.XtraEditors.TextEdit();
            this.UINM_TOTAL = new DevExpress.XtraEditors.TextEdit();
            this.UICD_ESTADO = new DevExpress.XtraEditors.LookUpEdit();
            this.clsGenericaParesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.UIID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.uirbn_actualizar = new DevExpress.XtraBars.BarButtonItem();
            this.uirbn_btn_import_ingr = new DevExpress.XtraBars.BarButtonItem();
            this.uirbn_btn_rev_ingr = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.UIFE_RECEPCION = new DevExpress.XtraEditors.DateEdit();
            this.UIFLG_CREDITO = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.uimaintabcontrol)).BeginInit();
            this.uimaintabcontrol.SuspendLayout();
            this.uitabpage_datalist.SuspendLayout();
            this.uitabpage_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uigridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uigridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uipaneldata)).BeginInit();
            this.uipaneldata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vCOMPCOMPRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_TERCERO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTERCEROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISFORMAPAGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_TIPO_DOCUMENTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISDOCUMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_FECHA.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_FECHA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_VENCIMIENTO.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_VENCIMIENTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_SERIE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_NUMERO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_GRAVADO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_EXENTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_SUJETO_A_RENTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_IVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_RETENCION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_RENTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_TOTAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_ESTADO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_RECEPCION.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_RECEPCION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFLG_CREDITO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.Margin = new System.Windows.Forms.Padding(5);
            this.uimaintabcontrol.SelectedTabPage = this.uitabpage_data;
            this.uimaintabcontrol.Size = new System.Drawing.Size(1296, 675);
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Margin = new System.Windows.Forms.Padding(5);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Margin = new System.Windows.Forms.Padding(5);
            this.uitabpage_data.Size = new System.Drawing.Size(1233, 669);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.vCOMPCOMPRABindingSource;
            this.uigridcontrol.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_EMPRESA,
            this.colNM_EJERCICIO,
            this.colNM_PERIODO,
            this.colID_TERCERO,
            this.colID_FORMA_PAGO,
            this.colFE_FECHA,
            this.colFE_VENCIMIENTO,
            this.colID_TIPO_DOCUMENTO,
            this.colCD_SERIE,
            this.colCD_NUMERO,
            this.colNM_GRAVADO,
            this.colNM_EXENTO,
            this.colNM_SUJETO_A_RENTA,
            this.colNM_IVA,
            this.colNM_RETENCION,
            this.colNM_RENTA,
            this.colNM_SALDO,
            this.colCD_ESTADO,
            this.colDS_NOMBRE,
            this.colDS_DIRECCION,
            this.colDS_RZN_COMER,
            this.colDS_NM_RF,
            this.colDS_NM_NIT,
            this.colDS_NM_DUI,
            this.colDS_FORMA_PAGO,
            this.colFLG_CREDITO,
            this.colDS_DOCUMENTO,
            this.colNM_TOTAL});
            this.uigridview.OptionsBehavior.Editable = false;
            this.uigridview.OptionsBehavior.ReadOnly = true;
            this.uigridview.OptionsView.ColumnAutoWidth = false;
            this.uigridview.OptionsView.ShowAutoFilterRow = true;
            this.uigridview.OptionsView.ShowDetailButtons = false;
            // 
            // UINAV
            // 
            this.UINAV.Buttons.Append.Visible = false;
            this.UINAV.Buttons.CancelEdit.Visible = false;
            this.UINAV.Buttons.Edit.Visible = false;
            this.UINAV.Buttons.EndEdit.Visible = false;
            this.UINAV.Buttons.Remove.Visible = false;
            this.UINAV.Location = new System.Drawing.Point(0, 721);
            this.UINAV.Margin = new System.Windows.Forms.Padding(5);
            this.UINAV.Size = new System.Drawing.Size(1300, 31);
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.UIFLG_CREDITO);
            this.uipaneldata.Controls.Add(this.labelControl16);
            this.uipaneldata.Controls.Add(this.UIFE_RECEPCION);
            this.uipaneldata.Controls.Add(this.labelControl15);
            this.uipaneldata.Controls.Add(this.labelControl9);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl13);
            this.uipaneldata.Controls.Add(this.labelControl14);
            this.uipaneldata.Controls.Add(this.labelControl11);
            this.uipaneldata.Controls.Add(this.labelControl12);
            this.uipaneldata.Controls.Add(this.labelControl10);
            this.uipaneldata.Controls.Add(this.labelControl7);
            this.uipaneldata.Controls.Add(this.labelControl8);
            this.uipaneldata.Controls.Add(this.labelControl5);
            this.uipaneldata.Controls.Add(this.labelControl6);
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.labelControl4);
            this.uipaneldata.Controls.Add(this.UICD_ESTADO);
            this.uipaneldata.Controls.Add(this.UINM_TOTAL);
            this.uipaneldata.Controls.Add(this.UINM_RENTA);
            this.uipaneldata.Controls.Add(this.UINM_RETENCION);
            this.uipaneldata.Controls.Add(this.UINM_IVA);
            this.uipaneldata.Controls.Add(this.UINM_SUJETO_A_RENTA);
            this.uipaneldata.Controls.Add(this.UINM_EXENTO);
            this.uipaneldata.Controls.Add(this.UINM_GRAVADO);
            this.uipaneldata.Controls.Add(this.UICD_NUMERO);
            this.uipaneldata.Controls.Add(this.UICD_SERIE);
            this.uipaneldata.Controls.Add(this.UIFE_VENCIMIENTO);
            this.uipaneldata.Controls.Add(this.UIFE_FECHA);
            this.uipaneldata.Controls.Add(this.UIID_TIPO_DOCUMENTO);
            this.uipaneldata.Controls.Add(this.UIID_TERCERO);
            this.uipaneldata.Controls.Add(this.labelControl1);
            this.uipaneldata.Margin = new System.Windows.Forms.Padding(5);
            this.uipaneldata.Size = new System.Drawing.Size(1233, 669);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.uilbl_opcion.Margin = new System.Windows.Forms.Padding(5);
            this.uilbl_opcion.Size = new System.Drawing.Size(1300, 42);
            // 
            // uicontenedor
            // 
            this.uicontenedor.Margin = new System.Windows.Forms.Padding(5);
            this.uicontenedor.Size = new System.Drawing.Size(1300, 679);
            // 
            // vCOMPCOMPRABindingSource
            // 
            this.vCOMPCOMPRABindingSource.DataSource = typeof(ComprasDB.V_COMP_COMPRA);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 41;
            // 
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            // 
            // colNM_EJERCICIO
            // 
            this.colNM_EJERCICIO.FieldName = "NM_EJERCICIO";
            this.colNM_EJERCICIO.Name = "colNM_EJERCICIO";
            // 
            // colNM_PERIODO
            // 
            this.colNM_PERIODO.FieldName = "NM_PERIODO";
            this.colNM_PERIODO.Name = "colNM_PERIODO";
            // 
            // colID_TERCERO
            // 
            this.colID_TERCERO.FieldName = "ID_TERCERO";
            this.colID_TERCERO.Name = "colID_TERCERO";
            // 
            // colID_FORMA_PAGO
            // 
            this.colID_FORMA_PAGO.FieldName = "ID_FORMA_PAGO";
            this.colID_FORMA_PAGO.Name = "colID_FORMA_PAGO";
            // 
            // colFE_FECHA
            // 
            this.colFE_FECHA.Caption = "Fecha";
            this.colFE_FECHA.FieldName = "FE_FECHA";
            this.colFE_FECHA.Name = "colFE_FECHA";
            this.colFE_FECHA.Visible = true;
            this.colFE_FECHA.VisibleIndex = 1;
            this.colFE_FECHA.Width = 73;
            // 
            // colFE_VENCIMIENTO
            // 
            this.colFE_VENCIMIENTO.FieldName = "FE_VENCIMIENTO";
            this.colFE_VENCIMIENTO.Name = "colFE_VENCIMIENTO";
            // 
            // colID_TIPO_DOCUMENTO
            // 
            this.colID_TIPO_DOCUMENTO.FieldName = "ID_TIPO_DOCUMENTO";
            this.colID_TIPO_DOCUMENTO.Name = "colID_TIPO_DOCUMENTO";
            // 
            // colCD_SERIE
            // 
            this.colCD_SERIE.Caption = "Serie";
            this.colCD_SERIE.FieldName = "CD_SERIE";
            this.colCD_SERIE.Name = "colCD_SERIE";
            this.colCD_SERIE.Visible = true;
            this.colCD_SERIE.VisibleIndex = 3;
            this.colCD_SERIE.Width = 37;
            // 
            // colCD_NUMERO
            // 
            this.colCD_NUMERO.Caption = "Numero";
            this.colCD_NUMERO.FieldName = "CD_NUMERO";
            this.colCD_NUMERO.Name = "colCD_NUMERO";
            this.colCD_NUMERO.Visible = true;
            this.colCD_NUMERO.VisibleIndex = 4;
            this.colCD_NUMERO.Width = 54;
            // 
            // colNM_GRAVADO
            // 
            this.colNM_GRAVADO.FieldName = "NM_GRAVADO";
            this.colNM_GRAVADO.Name = "colNM_GRAVADO";
            // 
            // colNM_EXENTO
            // 
            this.colNM_EXENTO.FieldName = "NM_EXENTO";
            this.colNM_EXENTO.Name = "colNM_EXENTO";
            // 
            // colNM_SUJETO_A_RENTA
            // 
            this.colNM_SUJETO_A_RENTA.FieldName = "NM_SUJETO_A_RENTA";
            this.colNM_SUJETO_A_RENTA.Name = "colNM_SUJETO_A_RENTA";
            // 
            // colNM_IVA
            // 
            this.colNM_IVA.FieldName = "NM_IVA";
            this.colNM_IVA.Name = "colNM_IVA";
            // 
            // colNM_RETENCION
            // 
            this.colNM_RETENCION.FieldName = "NM_RETENCION";
            this.colNM_RETENCION.Name = "colNM_RETENCION";
            // 
            // colNM_RENTA
            // 
            this.colNM_RENTA.FieldName = "NM_RENTA";
            this.colNM_RENTA.Name = "colNM_RENTA";
            // 
            // colNM_SALDO
            // 
            this.colNM_SALDO.FieldName = "NM_SALDO";
            this.colNM_SALDO.Name = "colNM_SALDO";
            // 
            // colCD_ESTADO
            // 
            this.colCD_ESTADO.Caption = "Estado";
            this.colCD_ESTADO.FieldName = "CD_ESTADO";
            this.colCD_ESTADO.Name = "colCD_ESTADO";
            this.colCD_ESTADO.Visible = true;
            this.colCD_ESTADO.VisibleIndex = 6;
            this.colCD_ESTADO.Width = 73;
            // 
            // colDS_NOMBRE
            // 
            this.colDS_NOMBRE.Caption = "Cliente";
            this.colDS_NOMBRE.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE.Name = "colDS_NOMBRE";
            this.colDS_NOMBRE.Visible = true;
            this.colDS_NOMBRE.VisibleIndex = 7;
            this.colDS_NOMBRE.Width = 142;
            // 
            // colDS_DIRECCION
            // 
            this.colDS_DIRECCION.FieldName = "DS_DIRECCION";
            this.colDS_DIRECCION.Name = "colDS_DIRECCION";
            // 
            // colDS_RZN_COMER
            // 
            this.colDS_RZN_COMER.Caption = "Razon comercial";
            this.colDS_RZN_COMER.FieldName = "DS_RZN_COMER";
            this.colDS_RZN_COMER.Name = "colDS_RZN_COMER";
            this.colDS_RZN_COMER.Visible = true;
            this.colDS_RZN_COMER.VisibleIndex = 8;
            this.colDS_RZN_COMER.Width = 57;
            // 
            // colDS_NM_RF
            // 
            this.colDS_NM_RF.Caption = "Reg. Fisc";
            this.colDS_NM_RF.FieldName = "DS_NM_RF";
            this.colDS_NM_RF.Name = "colDS_NM_RF";
            this.colDS_NM_RF.Visible = true;
            this.colDS_NM_RF.VisibleIndex = 9;
            this.colDS_NM_RF.Width = 57;
            // 
            // colDS_NM_NIT
            // 
            this.colDS_NM_NIT.Caption = "NIT";
            this.colDS_NM_NIT.FieldName = "DS_NM_NIT";
            this.colDS_NM_NIT.Name = "colDS_NM_NIT";
            this.colDS_NM_NIT.Visible = true;
            this.colDS_NM_NIT.VisibleIndex = 10;
            this.colDS_NM_NIT.Width = 57;
            // 
            // colDS_NM_DUI
            // 
            this.colDS_NM_DUI.Caption = "DUI";
            this.colDS_NM_DUI.FieldName = "DS_NM_DUI";
            this.colDS_NM_DUI.Name = "colDS_NM_DUI";
            this.colDS_NM_DUI.Visible = true;
            this.colDS_NM_DUI.VisibleIndex = 11;
            this.colDS_NM_DUI.Width = 57;
            // 
            // colDS_FORMA_PAGO
            // 
            this.colDS_FORMA_PAGO.Caption = "Forma de pago";
            this.colDS_FORMA_PAGO.FieldName = "DS_FORMA_PAGO";
            this.colDS_FORMA_PAGO.Name = "colDS_FORMA_PAGO";
            this.colDS_FORMA_PAGO.Visible = true;
            this.colDS_FORMA_PAGO.VisibleIndex = 12;
            this.colDS_FORMA_PAGO.Width = 93;
            // 
            // colFLG_CREDITO
            // 
            this.colFLG_CREDITO.FieldName = "FLG_CREDITO";
            this.colFLG_CREDITO.Name = "colFLG_CREDITO";
            // 
            // colDS_DOCUMENTO
            // 
            this.colDS_DOCUMENTO.Caption = "Doc.";
            this.colDS_DOCUMENTO.FieldName = "DS_DOCUMENTO";
            this.colDS_DOCUMENTO.Name = "colDS_DOCUMENTO";
            this.colDS_DOCUMENTO.Visible = true;
            this.colDS_DOCUMENTO.VisibleIndex = 2;
            this.colDS_DOCUMENTO.Width = 68;
            // 
            // colNM_TOTAL
            // 
            this.colNM_TOTAL.Caption = "Total";
            this.colNM_TOTAL.FieldName = "NM_TOTAL";
            this.colNM_TOTAL.Name = "colNM_TOTAL";
            this.colNM_TOTAL.Visible = true;
            this.colNM_TOTAL.VisibleIndex = 5;
            this.colNM_TOTAL.Width = 81;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(146, 153);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cliente";
            // 
            // UIID_TERCERO
            // 
            this.UIID_TERCERO.Location = new System.Drawing.Point(193, 149);
            this.UIID_TERCERO.Margin = new System.Windows.Forms.Padding(4);
            this.UIID_TERCERO.Name = "UIID_TERCERO";
            this.UIID_TERCERO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIID_TERCERO.Properties.DataSource = this.sISTERCEROBindingSource;
            this.UIID_TERCERO.Properties.DisplayMember = "DS_NOMBRE";
            this.UIID_TERCERO.Properties.ValueMember = "ID";
            this.UIID_TERCERO.Properties.View = this.gridLookUpEdit1View;
            this.UIID_TERCERO.Size = new System.Drawing.Size(575, 22);
            this.UIID_TERCERO.TabIndex = 1;
            // 
            // sISTERCEROBindingSource
            // 
            this.sISTERCEROBindingSource.DataSource = typeof(Sistema.SIS_TERCERO);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colID_EMPRESA1,
            this.colDS_NOMBRE1,
            this.colDS_RZN_COMER1,
            this.colDS_NM_NIT1,
            this.colDS_NM_DUI1,
            this.colDS_NM_RF1,
            this.colCD_TIPO_CONTRIBUYENTE,
            this.colID_MUNICIPIO,
            this.colDS_DIRECCION1,
            this.colDS_NM_TELEFONO,
            this.colDS_CORREO_E,
            this.colDS_CONTACTO,
            this.colDS_REFERENCIA,
            this.colFLG_CLIENTE,
            this.colFLG_PROVEEDOR,
            this.colID_CUENTAXCOBRAR,
            this.colID_CUENTAXPAGAR,
            this.colFLG_CREDITO_CLIENTE,
            this.colFLG_CREDITO_PROVEEDOR,
            this.colCD_TIPO_PERSONA});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            // 
            // colID_EMPRESA1
            // 
            this.colID_EMPRESA1.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA1.Name = "colID_EMPRESA1";
            // 
            // colDS_NOMBRE1
            // 
            this.colDS_NOMBRE1.Caption = "Cliente";
            this.colDS_NOMBRE1.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE1.Name = "colDS_NOMBRE1";
            this.colDS_NOMBRE1.Visible = true;
            this.colDS_NOMBRE1.VisibleIndex = 4;
            // 
            // colDS_RZN_COMER1
            // 
            this.colDS_RZN_COMER1.Caption = "Razon comercial";
            this.colDS_RZN_COMER1.FieldName = "DS_RZN_COMER";
            this.colDS_RZN_COMER1.Name = "colDS_RZN_COMER1";
            this.colDS_RZN_COMER1.Visible = true;
            this.colDS_RZN_COMER1.VisibleIndex = 3;
            // 
            // colDS_NM_NIT1
            // 
            this.colDS_NM_NIT1.Caption = "NIT";
            this.colDS_NM_NIT1.FieldName = "DS_NM_NIT";
            this.colDS_NM_NIT1.Name = "colDS_NM_NIT1";
            this.colDS_NM_NIT1.Visible = true;
            this.colDS_NM_NIT1.VisibleIndex = 2;
            // 
            // colDS_NM_DUI1
            // 
            this.colDS_NM_DUI1.Caption = "DUI";
            this.colDS_NM_DUI1.FieldName = "DS_NM_DUI";
            this.colDS_NM_DUI1.Name = "colDS_NM_DUI1";
            this.colDS_NM_DUI1.Visible = true;
            this.colDS_NM_DUI1.VisibleIndex = 0;
            // 
            // colDS_NM_RF1
            // 
            this.colDS_NM_RF1.Caption = "Reg. Fisc";
            this.colDS_NM_RF1.FieldName = "DS_NM_RF";
            this.colDS_NM_RF1.Name = "colDS_NM_RF1";
            this.colDS_NM_RF1.Visible = true;
            this.colDS_NM_RF1.VisibleIndex = 1;
            // 
            // colCD_TIPO_CONTRIBUYENTE
            // 
            this.colCD_TIPO_CONTRIBUYENTE.FieldName = "CD_TIPO_CONTRIBUYENTE";
            this.colCD_TIPO_CONTRIBUYENTE.Name = "colCD_TIPO_CONTRIBUYENTE";
            // 
            // colID_MUNICIPIO
            // 
            this.colID_MUNICIPIO.FieldName = "ID_MUNICIPIO";
            this.colID_MUNICIPIO.Name = "colID_MUNICIPIO";
            // 
            // colDS_DIRECCION1
            // 
            this.colDS_DIRECCION1.FieldName = "DS_DIRECCION";
            this.colDS_DIRECCION1.Name = "colDS_DIRECCION1";
            // 
            // colDS_NM_TELEFONO
            // 
            this.colDS_NM_TELEFONO.FieldName = "DS_NM_TELEFONO";
            this.colDS_NM_TELEFONO.Name = "colDS_NM_TELEFONO";
            // 
            // colDS_CORREO_E
            // 
            this.colDS_CORREO_E.FieldName = "DS_CORREO_E";
            this.colDS_CORREO_E.Name = "colDS_CORREO_E";
            // 
            // colDS_CONTACTO
            // 
            this.colDS_CONTACTO.FieldName = "DS_CONTACTO";
            this.colDS_CONTACTO.Name = "colDS_CONTACTO";
            // 
            // colDS_REFERENCIA
            // 
            this.colDS_REFERENCIA.FieldName = "DS_REFERENCIA";
            this.colDS_REFERENCIA.Name = "colDS_REFERENCIA";
            // 
            // colFLG_CLIENTE
            // 
            this.colFLG_CLIENTE.FieldName = "FLG_CLIENTE";
            this.colFLG_CLIENTE.Name = "colFLG_CLIENTE";
            // 
            // colFLG_PROVEEDOR
            // 
            this.colFLG_PROVEEDOR.FieldName = "FLG_PROVEEDOR";
            this.colFLG_PROVEEDOR.Name = "colFLG_PROVEEDOR";
            // 
            // colID_CUENTAXCOBRAR
            // 
            this.colID_CUENTAXCOBRAR.FieldName = "ID_CUENTAXCOBRAR";
            this.colID_CUENTAXCOBRAR.Name = "colID_CUENTAXCOBRAR";
            // 
            // colID_CUENTAXPAGAR
            // 
            this.colID_CUENTAXPAGAR.FieldName = "ID_CUENTAXPAGAR";
            this.colID_CUENTAXPAGAR.Name = "colID_CUENTAXPAGAR";
            // 
            // colFLG_CREDITO_CLIENTE
            // 
            this.colFLG_CREDITO_CLIENTE.FieldName = "FLG_CREDITO_CLIENTE";
            this.colFLG_CREDITO_CLIENTE.Name = "colFLG_CREDITO_CLIENTE";
            // 
            // colFLG_CREDITO_PROVEEDOR
            // 
            this.colFLG_CREDITO_PROVEEDOR.FieldName = "FLG_CREDITO_PROVEEDOR";
            this.colFLG_CREDITO_PROVEEDOR.Name = "colFLG_CREDITO_PROVEEDOR";
            // 
            // colCD_TIPO_PERSONA
            // 
            this.colCD_TIPO_PERSONA.FieldName = "CD_TIPO_PERSONA";
            this.colCD_TIPO_PERSONA.Name = "colCD_TIPO_PERSONA";
            // 
            // sISFORMAPAGOBindingSource
            // 
            this.sISFORMAPAGOBindingSource.DataSource = typeof(Sistema.SIS_FORMA_PAGO);
            // 
            // UIID_TIPO_DOCUMENTO
            // 
            this.UIID_TIPO_DOCUMENTO.Location = new System.Drawing.Point(193, 105);
            this.UIID_TIPO_DOCUMENTO.Margin = new System.Windows.Forms.Padding(4);
            this.UIID_TIPO_DOCUMENTO.Name = "UIID_TIPO_DOCUMENTO";
            this.UIID_TIPO_DOCUMENTO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIID_TIPO_DOCUMENTO.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EMPRESA", "ID_EMPRESA", 73, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_DOCUMENTO", "Documento", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_TIPO_DOCUMENTO", "CD_TIPO_DOCUMENTO", 124, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EMPRESAS", "SIS_EMPRESAS", 84, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.UIID_TIPO_DOCUMENTO.Properties.DataSource = this.sISDOCUMENTOBindingSource;
            this.UIID_TIPO_DOCUMENTO.Properties.DisplayMember = "DS_DOCUMENTO";
            this.UIID_TIPO_DOCUMENTO.Properties.ValueMember = "ID";
            this.UIID_TIPO_DOCUMENTO.Size = new System.Drawing.Size(233, 22);
            this.UIID_TIPO_DOCUMENTO.TabIndex = 3;
            // 
            // sISDOCUMENTOBindingSource
            // 
            this.sISDOCUMENTOBindingSource.DataSource = typeof(Sistema.SIS_DOCUMENTO);
            // 
            // UIFE_FECHA
            // 
            this.UIFE_FECHA.EditValue = null;
            this.UIFE_FECHA.Location = new System.Drawing.Point(193, 199);
            this.UIFE_FECHA.Margin = new System.Windows.Forms.Padding(4);
            this.UIFE_FECHA.Name = "UIFE_FECHA";
            this.UIFE_FECHA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIFE_FECHA.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UIFE_FECHA.Size = new System.Drawing.Size(133, 22);
            this.UIFE_FECHA.TabIndex = 4;
            // 
            // UIFE_VENCIMIENTO
            // 
            this.UIFE_VENCIMIENTO.EditValue = null;
            this.UIFE_VENCIMIENTO.Location = new System.Drawing.Point(535, 199);
            this.UIFE_VENCIMIENTO.Margin = new System.Windows.Forms.Padding(4);
            this.UIFE_VENCIMIENTO.Name = "UIFE_VENCIMIENTO";
            this.UIFE_VENCIMIENTO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIFE_VENCIMIENTO.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UIFE_VENCIMIENTO.Size = new System.Drawing.Size(233, 22);
            this.UIFE_VENCIMIENTO.TabIndex = 5;
            // 
            // UICD_SERIE
            // 
            this.UICD_SERIE.Location = new System.Drawing.Point(535, 105);
            this.UICD_SERIE.Margin = new System.Windows.Forms.Padding(4);
            this.UICD_SERIE.Name = "UICD_SERIE";
            this.UICD_SERIE.Size = new System.Drawing.Size(76, 22);
            this.UICD_SERIE.TabIndex = 6;
            // 
            // UICD_NUMERO
            // 
            this.UICD_NUMERO.Location = new System.Drawing.Point(627, 105);
            this.UICD_NUMERO.Margin = new System.Windows.Forms.Padding(4);
            this.UICD_NUMERO.Name = "UICD_NUMERO";
            this.UICD_NUMERO.Size = new System.Drawing.Size(141, 22);
            this.UICD_NUMERO.TabIndex = 7;
            // 
            // UINM_GRAVADO
            // 
            this.UINM_GRAVADO.Location = new System.Drawing.Point(193, 263);
            this.UINM_GRAVADO.Margin = new System.Windows.Forms.Padding(4);
            this.UINM_GRAVADO.Name = "UINM_GRAVADO";
            this.UINM_GRAVADO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UINM_GRAVADO.Properties.DisplayFormat.FormatString = "n6";
            this.UINM_GRAVADO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_GRAVADO.Properties.EditFormat.FormatString = "n6";
            this.UINM_GRAVADO.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_GRAVADO.Size = new System.Drawing.Size(233, 22);
            this.UINM_GRAVADO.TabIndex = 8;
            // 
            // UINM_EXENTO
            // 
            this.UINM_EXENTO.Location = new System.Drawing.Point(193, 316);
            this.UINM_EXENTO.Margin = new System.Windows.Forms.Padding(4);
            this.UINM_EXENTO.Name = "UINM_EXENTO";
            this.UINM_EXENTO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UINM_EXENTO.Properties.DisplayFormat.FormatString = "n6";
            this.UINM_EXENTO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_EXENTO.Properties.EditFormat.FormatString = "n6";
            this.UINM_EXENTO.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_EXENTO.Size = new System.Drawing.Size(233, 22);
            this.UINM_EXENTO.TabIndex = 9;
            // 
            // UINM_SUJETO_A_RENTA
            // 
            this.UINM_SUJETO_A_RENTA.Location = new System.Drawing.Point(193, 364);
            this.UINM_SUJETO_A_RENTA.Margin = new System.Windows.Forms.Padding(4);
            this.UINM_SUJETO_A_RENTA.Name = "UINM_SUJETO_A_RENTA";
            this.UINM_SUJETO_A_RENTA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UINM_SUJETO_A_RENTA.Properties.DisplayFormat.FormatString = "n6";
            this.UINM_SUJETO_A_RENTA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_SUJETO_A_RENTA.Properties.EditFormat.FormatString = "n6";
            this.UINM_SUJETO_A_RENTA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_SUJETO_A_RENTA.Size = new System.Drawing.Size(233, 22);
            this.UINM_SUJETO_A_RENTA.TabIndex = 10;
            // 
            // UINM_IVA
            // 
            this.UINM_IVA.Location = new System.Drawing.Point(535, 268);
            this.UINM_IVA.Margin = new System.Windows.Forms.Padding(4);
            this.UINM_IVA.Name = "UINM_IVA";
            this.UINM_IVA.Properties.DisplayFormat.FormatString = "n2";
            this.UINM_IVA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_IVA.Properties.ReadOnly = true;
            this.UINM_IVA.Size = new System.Drawing.Size(233, 22);
            this.UINM_IVA.TabIndex = 11;
            // 
            // UINM_RETENCION
            // 
            this.UINM_RETENCION.Location = new System.Drawing.Point(535, 320);
            this.UINM_RETENCION.Margin = new System.Windows.Forms.Padding(4);
            this.UINM_RETENCION.Name = "UINM_RETENCION";
            this.UINM_RETENCION.Properties.DisplayFormat.FormatString = "n2";
            this.UINM_RETENCION.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_RETENCION.Properties.ReadOnly = true;
            this.UINM_RETENCION.Size = new System.Drawing.Size(233, 22);
            this.UINM_RETENCION.TabIndex = 12;
            // 
            // UINM_RENTA
            // 
            this.UINM_RENTA.Location = new System.Drawing.Point(535, 369);
            this.UINM_RENTA.Margin = new System.Windows.Forms.Padding(4);
            this.UINM_RENTA.Name = "UINM_RENTA";
            this.UINM_RENTA.Properties.DisplayFormat.FormatString = "n2";
            this.UINM_RENTA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_RENTA.Properties.ReadOnly = true;
            this.UINM_RENTA.Size = new System.Drawing.Size(233, 22);
            this.UINM_RENTA.TabIndex = 13;
            // 
            // UINM_TOTAL
            // 
            this.UINM_TOTAL.Location = new System.Drawing.Point(881, 268);
            this.UINM_TOTAL.Margin = new System.Windows.Forms.Padding(4);
            this.UINM_TOTAL.Name = "UINM_TOTAL";
            this.UINM_TOTAL.Properties.DisplayFormat.FormatString = "n2";
            this.UINM_TOTAL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINM_TOTAL.Properties.ReadOnly = true;
            this.UINM_TOTAL.Size = new System.Drawing.Size(233, 22);
            this.UINM_TOTAL.TabIndex = 14;
            // 
            // UICD_ESTADO
            // 
            this.UICD_ESTADO.Location = new System.Drawing.Point(881, 105);
            this.UICD_ESTADO.Margin = new System.Windows.Forms.Padding(4);
            this.UICD_ESTADO.Name = "UICD_ESTADO";
            this.UICD_ESTADO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.UICD_ESTADO.Properties.DataSource = this.clsGenericaParesBindingSource;
            this.UICD_ESTADO.Properties.DisplayMember = "descripcion";
            this.UICD_ESTADO.Properties.ReadOnly = true;
            this.UICD_ESTADO.Properties.ValueMember = "id";
            this.UICD_ESTADO.Size = new System.Drawing.Size(233, 22);
            this.UICD_ESTADO.TabIndex = 15;
            // 
            // clsGenericaParesBindingSource
            // 
            this.clsGenericaParesBindingSource.DataSource = typeof(winCont.Clases.clsGenericaPares);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(121, 108);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 16);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Documento";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(151, 202);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 16);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Fecha";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(466, 324);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 16);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Retencion";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(487, 207);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Vence";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(103, 367);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 16);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Sujeto a renta";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(138, 266);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 16);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Gravado";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(147, 319);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 16);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Exento";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(489, 372);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(33, 16);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Renta";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(502, 271);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(20, 16);
            this.labelControl12.TabIndex = 25;
            this.labelControl12.Text = "IVA";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(173, 64);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(12, 16);
            this.labelControl13.TabIndex = 28;
            this.labelControl13.Text = "ID";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(835, 106);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(38, 16);
            this.labelControl14.TabIndex = 27;
            this.labelControl14.Text = "Estado";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(193, 60);
            this.UIID.Margin = new System.Windows.Forms.Padding(4);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(133, 22);
            this.UIID.TabIndex = 29;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(844, 269);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(29, 16);
            this.labelControl9.TabIndex = 30;
            this.labelControl9.Text = "Total";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(477, 108);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(45, 16);
            this.labelControl15.TabIndex = 31;
            this.labelControl15.Text = "Numero";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.uirbn_actualizar,
            this.uirbn_btn_import_ingr,
            this.uirbn_btn_rev_ingr});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 568);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1300, 153);
            // 
            // uirbn_actualizar
            // 
            this.uirbn_actualizar.Caption = "Actualizar";
            this.uirbn_actualizar.Id = 1;
            this.uirbn_actualizar.LargeGlyph = global::winCont.Properties.Resources.approval_24;
            this.uirbn_actualizar.LargeWidth = 60;
            this.uirbn_actualizar.Name = "uirbn_actualizar";
            this.uirbn_actualizar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.uirbn_actualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.uirbn_actualizar_ItemClick);
            // 
            // uirbn_btn_import_ingr
            // 
            this.uirbn_btn_import_ingr.Caption = "Importar ingresos";
            this.uirbn_btn_import_ingr.Id = 3;
            this.uirbn_btn_import_ingr.LargeGlyph = global::winCont.Properties.Resources.internal_24;
            this.uirbn_btn_import_ingr.LargeWidth = 60;
            this.uirbn_btn_import_ingr.Name = "uirbn_btn_import_ingr";
            this.uirbn_btn_import_ingr.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.uirbn_btn_import_ingr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.uirbn_btn_import_ingr_ItemClick);
            // 
            // uirbn_btn_rev_ingr
            // 
            this.uirbn_btn_rev_ingr.Caption = "Revisar ingreso";
            this.uirbn_btn_rev_ingr.Glyph = global::winCont.Properties.Resources.products;
            this.uirbn_btn_rev_ingr.Id = 4;
            this.uirbn_btn_rev_ingr.LargeWidth = 60;
            this.uirbn_btn_rev_ingr.Name = "uirbn_btn_rev_ingr";
            this.uirbn_btn_rev_ingr.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.uirbn_btn_rev_ingr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.uirbn_btn_rev_ingr_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.uirbn_actualizar);
            this.ribbonPageGroup1.ItemLinks.Add(this.uirbn_btn_import_ingr);
            this.ribbonPageGroup1.ItemLinks.Add(this.uirbn_btn_rev_ingr);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(815, 202);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(58, 16);
            this.labelControl16.TabIndex = 33;
            this.labelControl16.Text = "Recepcion";
            // 
            // UIFE_RECEPCION
            // 
            this.UIFE_RECEPCION.EditValue = null;
            this.UIFE_RECEPCION.Location = new System.Drawing.Point(881, 201);
            this.UIFE_RECEPCION.Margin = new System.Windows.Forms.Padding(4);
            this.UIFE_RECEPCION.Name = "UIFE_RECEPCION";
            this.UIFE_RECEPCION.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIFE_RECEPCION.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UIFE_RECEPCION.Size = new System.Drawing.Size(133, 22);
            this.UIFE_RECEPCION.TabIndex = 32;
            // 
            // UIFLG_CREDITO
            // 
            this.UIFLG_CREDITO.EditValue = 'N';
            this.UIFLG_CREDITO.Location = new System.Drawing.Point(879, 150);
            this.UIFLG_CREDITO.Margin = new System.Windows.Forms.Padding(4);
            this.UIFLG_CREDITO.Name = "UIFLG_CREDITO";
            this.UIFLG_CREDITO.Properties.Caption = "Credito";
            this.UIFLG_CREDITO.Properties.ValueChecked = 'S';
            this.UIFLG_CREDITO.Properties.ValueUnchecked = 'N';
            this.UIFLG_CREDITO.Size = new System.Drawing.Size(100, 21);
            this.UIFLG_CREDITO.TabIndex = 39;
            // 
            // frm_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1300, 752);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm_compras";
            this.Controls.SetChildIndex(this.UINAV, 0);
            this.Controls.SetChildIndex(this.uilbl_opcion, 0);
            this.Controls.SetChildIndex(this.uicontenedor, 0);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uimaintabcontrol)).EndInit();
            this.uimaintabcontrol.ResumeLayout(false);
            this.uitabpage_datalist.ResumeLayout(false);
            this.uitabpage_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uigridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uigridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uipaneldata)).EndInit();
            this.uipaneldata.ResumeLayout(false);
            this.uipaneldata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vCOMPCOMPRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_TERCERO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTERCEROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISFORMAPAGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_TIPO_DOCUMENTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISDOCUMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_FECHA.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_FECHA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_VENCIMIENTO.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_VENCIMIENTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_SERIE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_NUMERO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_GRAVADO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_EXENTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_SUJETO_A_RENTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_IVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_RETENCION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_RENTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_TOTAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_ESTADO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_RECEPCION.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFE_RECEPCION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFLG_CREDITO.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vCOMPCOMPRABindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EJERCICIO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_PERIODO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TERCERO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_FORMA_PAGO;
        private DevExpress.XtraGrid.Columns.GridColumn colFE_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn colFE_VENCIMIENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TIPO_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_SERIE;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_NUMERO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_GRAVADO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EXENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_SUJETO_A_RENTA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_IVA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_RETENCION;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_RENTA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_SALDO;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_ESTADO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DIRECCION;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_RZN_COMER;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_RF;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_NIT;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_DUI;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_FORMA_PAGO;
        private DevExpress.XtraGrid.Columns.GridColumn colFLG_CREDITO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_TOTAL;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit UICD_ESTADO;
        private DevExpress.XtraEditors.TextEdit UINM_TOTAL;
        private DevExpress.XtraEditors.TextEdit UINM_RENTA;
        private DevExpress.XtraEditors.TextEdit UINM_RETENCION;
        private DevExpress.XtraEditors.TextEdit UINM_IVA;
        private DevExpress.XtraEditors.CalcEdit UINM_SUJETO_A_RENTA;
        private DevExpress.XtraEditors.CalcEdit UINM_EXENTO;
        private DevExpress.XtraEditors.CalcEdit UINM_GRAVADO;
        private DevExpress.XtraEditors.TextEdit UICD_NUMERO;
        private DevExpress.XtraEditors.TextEdit UICD_SERIE;
        private DevExpress.XtraEditors.DateEdit UIFE_VENCIMIENTO;
        private DevExpress.XtraEditors.DateEdit UIFE_FECHA;
        private DevExpress.XtraEditors.LookUpEdit UIID_TIPO_DOCUMENTO;
        private DevExpress.XtraEditors.GridLookUpEdit UIID_TERCERO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.BindingSource clsGenericaParesBindingSource;
        private System.Windows.Forms.BindingSource sISDOCUMENTOBindingSource;
        private System.Windows.Forms.BindingSource sISFORMAPAGOBindingSource;
        private System.Windows.Forms.BindingSource sISTERCEROBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_RZN_COMER1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_NIT1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_DUI1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_RF1;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_TIPO_CONTRIBUYENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colID_MUNICIPIO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DIRECCION1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_TELEFONO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CORREO_E;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CONTACTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_REFERENCIA;
        private DevExpress.XtraGrid.Columns.GridColumn colFLG_CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colFLG_PROVEEDOR;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CUENTAXCOBRAR;
        private DevExpress.XtraGrid.Columns.GridColumn colID_CUENTAXPAGAR;
        private DevExpress.XtraGrid.Columns.GridColumn colFLG_CREDITO_CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colFLG_CREDITO_PROVEEDOR;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_TIPO_PERSONA;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem uirbn_actualizar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem uirbn_btn_import_ingr;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.DateEdit UIFE_RECEPCION;
        private DevExpress.XtraBars.BarButtonItem uirbn_btn_rev_ingr;
        private DevExpress.XtraEditors.CheckEdit UIFLG_CREDITO;
    }
}
