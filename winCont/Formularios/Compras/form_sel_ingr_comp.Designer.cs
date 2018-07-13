namespace winCont.Formularios.Compras
{
    partial class form_sel_ingr_comp
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
            this.vINVENCAINGRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID_UBICACION_INGR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TERCERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_TIPO_CONTRIBUYENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TIPO_DOCUMENTO_PROV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_SERIE_PROV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_NUMERO_PROV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DOCUMENTO_PROV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_FORMA_PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_PERIODO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EJERCICIO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TIPO_DOCUMENTO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_SERIE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_NUMERO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFE_FECHA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_REFERENCIA2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_ESTA_DOCUMENTO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DOCUMENTO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UBICACION2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).BeginInit();
            this.UI_GRP_SELEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vINVENCAINGRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_GRP_SELEC
            // 
            this.UI_GRP_SELEC.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.UI_GRP_SELEC.Appearance.Options.UseFont = true;
            this.UI_GRP_SELEC.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UI_GRP_SELEC.AppearanceCaption.Options.UseFont = true;
            this.UI_GRP_SELEC.Margin = new System.Windows.Forms.Padding(5);
            this.UI_GRP_SELEC.Size = new System.Drawing.Size(1113, 622);
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.DataSource = this.vINVENCAINGRBindingSource;
            this.UIGRIDCONTROL.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.UIGRIDCONTROL.Location = new System.Drawing.Point(2, 48);
            this.UIGRIDCONTROL.Margin = new System.Windows.Forms.Padding(5);
            this.UIGRIDCONTROL.Size = new System.Drawing.Size(1109, 572);
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID4,
            this.colID_EMPRESA3,
            this.colNM_PERIODO1,
            this.colNM_EJERCICIO1,
            this.colID_TIPO_DOCUMENTO1,
            this.colCD_SERIE1,
            this.colCD_NUMERO1,
            this.colFE_FECHA1,
            this.colDS_REFERENCIA2,
            this.colCD_ESTA_DOCUMENTO1,
            this.colDS_DOCUMENTO1,
            this.colCD_SERIE_PROV,
            this.colCD_NUMERO_PROV,
            this.colDS_UBICACION2,
            this.colID_UBICACION_INGR,
            this.colID_TERCERO,
            this.colCD_TIPO_CONTRIBUYENTE,
            this.colDS_NOMBRE3,
            this.colID_TIPO_DOCUMENTO_PROV,
            this.colDS_DOCUMENTO_PROV,
            this.colDS_FORMA_PAGO});
            this.UIGRIDVIEW.OptionsBehavior.Editable = false;
            this.UIGRIDVIEW.OptionsBehavior.ReadOnly = true;
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            this.UIGRIDVIEW.OptionsView.ShowDetailButtons = false;
            this.UIGRIDVIEW.OptionsView.ShowGroupPanel = false;
            this.UIGRIDVIEW.DoubleClick += new System.EventHandler(this.UIGRIDVIEW_DoubleClick_1);
            // 
            // vINVENCAINGRBindingSource
            // 
            this.vINVENCAINGRBindingSource.DataSource = typeof(InventarioDB.V_INV_ENCA_INGR);
            // 
            // colID_UBICACION_INGR
            // 
            this.colID_UBICACION_INGR.FieldName = "ID_UBICACION_INGR";
            this.colID_UBICACION_INGR.Name = "colID_UBICACION_INGR";
            // 
            // colID_TERCERO
            // 
            this.colID_TERCERO.FieldName = "ID_TERCERO";
            this.colID_TERCERO.Name = "colID_TERCERO";
            // 
            // colCD_TIPO_CONTRIBUYENTE
            // 
            this.colCD_TIPO_CONTRIBUYENTE.FieldName = "CD_TIPO_CONTRIBUYENTE";
            this.colCD_TIPO_CONTRIBUYENTE.Name = "colCD_TIPO_CONTRIBUYENTE";
            // 
            // colID_TIPO_DOCUMENTO_PROV
            // 
            this.colID_TIPO_DOCUMENTO_PROV.FieldName = "ID_TIPO_DOCUMENTO_PROV";
            this.colID_TIPO_DOCUMENTO_PROV.Name = "colID_TIPO_DOCUMENTO_PROV";
            // 
            // colCD_SERIE_PROV
            // 
            this.colCD_SERIE_PROV.Caption = "Serie Rec.";
            this.colCD_SERIE_PROV.FieldName = "CD_SERIE_PROV";
            this.colCD_SERIE_PROV.Name = "colCD_SERIE_PROV";
            this.colCD_SERIE_PROV.Visible = true;
            this.colCD_SERIE_PROV.VisibleIndex = 7;
            // 
            // colCD_NUMERO_PROV
            // 
            this.colCD_NUMERO_PROV.Caption = "Numero Rec.";
            this.colCD_NUMERO_PROV.FieldName = "CD_NUMERO_PROV";
            this.colCD_NUMERO_PROV.Name = "colCD_NUMERO_PROV";
            this.colCD_NUMERO_PROV.Visible = true;
            this.colCD_NUMERO_PROV.VisibleIndex = 8;
            // 
            // colDS_DOCUMENTO_PROV
            // 
            this.colDS_DOCUMENTO_PROV.Caption = "Documento Rec.";
            this.colDS_DOCUMENTO_PROV.FieldName = "DS_DOCUMENTO_PROV";
            this.colDS_DOCUMENTO_PROV.Name = "colDS_DOCUMENTO_PROV";
            this.colDS_DOCUMENTO_PROV.Visible = true;
            this.colDS_DOCUMENTO_PROV.VisibleIndex = 6;
            // 
            // colDS_FORMA_PAGO
            // 
            this.colDS_FORMA_PAGO.Caption = "Forma de pago";
            this.colDS_FORMA_PAGO.FieldName = "DS_FORMA_PAGO";
            this.colDS_FORMA_PAGO.Name = "colDS_FORMA_PAGO";
            // 
            // colID4
            // 
            this.colID4.Caption = "ID";
            this.colID4.FieldName = "ID";
            this.colID4.Name = "colID4";
            this.colID4.Visible = true;
            this.colID4.VisibleIndex = 0;
            this.colID4.Width = 37;
            // 
            // colID_EMPRESA3
            // 
            this.colID_EMPRESA3.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA3.Name = "colID_EMPRESA3";
            // 
            // colNM_PERIODO1
            // 
            this.colNM_PERIODO1.FieldName = "NM_PERIODO";
            this.colNM_PERIODO1.Name = "colNM_PERIODO1";
            // 
            // colNM_EJERCICIO1
            // 
            this.colNM_EJERCICIO1.FieldName = "NM_EJERCICIO";
            this.colNM_EJERCICIO1.Name = "colNM_EJERCICIO1";
            // 
            // colID_TIPO_DOCUMENTO1
            // 
            this.colID_TIPO_DOCUMENTO1.FieldName = "ID_TIPO_DOCUMENTO";
            this.colID_TIPO_DOCUMENTO1.Name = "colID_TIPO_DOCUMENTO1";
            // 
            // colCD_SERIE1
            // 
            this.colCD_SERIE1.Caption = "Serie";
            this.colCD_SERIE1.FieldName = "CD_SERIE";
            this.colCD_SERIE1.Name = "colCD_SERIE1";
            this.colCD_SERIE1.Visible = true;
            this.colCD_SERIE1.VisibleIndex = 2;
            this.colCD_SERIE1.Width = 39;
            // 
            // colCD_NUMERO1
            // 
            this.colCD_NUMERO1.Caption = "Numero";
            this.colCD_NUMERO1.FieldName = "CD_NUMERO";
            this.colCD_NUMERO1.Name = "colCD_NUMERO1";
            this.colCD_NUMERO1.Visible = true;
            this.colCD_NUMERO1.VisibleIndex = 3;
            this.colCD_NUMERO1.Width = 45;
            // 
            // colFE_FECHA1
            // 
            this.colFE_FECHA1.Caption = "Fecha";
            this.colFE_FECHA1.FieldName = "FE_FECHA";
            this.colFE_FECHA1.Name = "colFE_FECHA1";
            this.colFE_FECHA1.Visible = true;
            this.colFE_FECHA1.VisibleIndex = 4;
            this.colFE_FECHA1.Width = 66;
            // 
            // colDS_REFERENCIA2
            // 
            this.colDS_REFERENCIA2.Caption = "Referencia";
            this.colDS_REFERENCIA2.FieldName = "DS_REFERENCIA";
            this.colDS_REFERENCIA2.Name = "colDS_REFERENCIA2";
            this.colDS_REFERENCIA2.Width = 102;
            // 
            // colCD_ESTA_DOCUMENTO1
            // 
            this.colCD_ESTA_DOCUMENTO1.Caption = "Estado";
            this.colCD_ESTA_DOCUMENTO1.FieldName = "CD_ESTA_DOCUMENTO";
            this.colCD_ESTA_DOCUMENTO1.Name = "colCD_ESTA_DOCUMENTO1";
            this.colCD_ESTA_DOCUMENTO1.Width = 77;
            // 
            // colDS_DOCUMENTO1
            // 
            this.colDS_DOCUMENTO1.Caption = "Documento";
            this.colDS_DOCUMENTO1.FieldName = "DS_DOCUMENTO";
            this.colDS_DOCUMENTO1.Name = "colDS_DOCUMENTO1";
            this.colDS_DOCUMENTO1.Visible = true;
            this.colDS_DOCUMENTO1.VisibleIndex = 1;
            this.colDS_DOCUMENTO1.Width = 68;
            // 
            // colDS_UBICACION2
            // 
            this.colDS_UBICACION2.Caption = "Bodega";
            this.colDS_UBICACION2.FieldName = "DS_UBICACION";
            this.colDS_UBICACION2.Name = "colDS_UBICACION2";
            // 
            // colDS_NOMBRE3
            // 
            this.colDS_NOMBRE3.Caption = "Proveedor";
            this.colDS_NOMBRE3.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE3.Name = "colDS_NOMBRE3";
            this.colDS_NOMBRE3.Visible = true;
            this.colDS_NOMBRE3.VisibleIndex = 5;
            // 
            // form_sel_ingr_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1113, 622);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "form_sel_ingr_comp";
            this.Load += new System.EventHandler(this.form_sel_ingr_comp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).EndInit();
            this.UI_GRP_SELEC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vINVENCAINGRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vINVENCAINGRBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID_UBICACION_INGR;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TERCERO;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_TIPO_CONTRIBUYENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TIPO_DOCUMENTO_PROV;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_SERIE_PROV;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_NUMERO_PROV;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DOCUMENTO_PROV;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_FORMA_PAGO;
        private DevExpress.XtraGrid.Columns.GridColumn colID4;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA3;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_PERIODO1;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EJERCICIO1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TIPO_DOCUMENTO1;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_SERIE1;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_NUMERO1;
        private DevExpress.XtraGrid.Columns.GridColumn colFE_FECHA1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_REFERENCIA2;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_ESTA_DOCUMENTO1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DOCUMENTO1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UBICACION2;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE3;
    }
}
