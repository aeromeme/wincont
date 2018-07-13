namespace winCont.Formularios.Inventario
{
    partial class frm_existencia
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
            this.vINVEXISTENCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EJERCICIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_PERIODO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_BODEGA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ARTICULO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_INI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_ENTRADA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_SALIDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_ACTUAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_COSTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_ARTICULO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vINVEXISTENCIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.DataSource = this.vINVEXISTENCIABindingSource;
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNM_EJERCICIO,
            this.colNM_PERIODO,
            this.colID_EMPRESA,
            this.colID_BODEGA,
            this.colID_ARTICULO,
            this.colNM_CANT_INI,
            this.colNM_ENTRADA,
            this.colNM_SALIDA,
            this.colNM_CANT_ACTUAL,
            this.colNM_COSTO,
            this.colDS_ARTICULO,
            this.colDS_UBICACION});
            this.UIGRIDVIEW.OptionsBehavior.Editable = false;
            this.UIGRIDVIEW.OptionsBehavior.ReadOnly = true;
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // vINVEXISTENCIABindingSource
            // 
            this.vINVEXISTENCIABindingSource.DataSource = typeof(InventarioDB.V_INV_EXISTENCIA);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
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
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            // 
            // colID_BODEGA
            // 
            this.colID_BODEGA.FieldName = "ID_BODEGA";
            this.colID_BODEGA.Name = "colID_BODEGA";
            // 
            // colID_ARTICULO
            // 
            this.colID_ARTICULO.FieldName = "ID_ARTICULO";
            this.colID_ARTICULO.Name = "colID_ARTICULO";
            // 
            // colNM_CANT_INI
            // 
            this.colNM_CANT_INI.Caption = "Cant. Inicial";
            this.colNM_CANT_INI.FieldName = "NM_CANT_INI";
            this.colNM_CANT_INI.Name = "colNM_CANT_INI";
            this.colNM_CANT_INI.Visible = true;
            this.colNM_CANT_INI.VisibleIndex = 2;
            this.colNM_CANT_INI.Width = 180;
            // 
            // colNM_ENTRADA
            // 
            this.colNM_ENTRADA.Caption = "Entradas";
            this.colNM_ENTRADA.FieldName = "NM_ENTRADA";
            this.colNM_ENTRADA.Name = "colNM_ENTRADA";
            this.colNM_ENTRADA.Visible = true;
            this.colNM_ENTRADA.VisibleIndex = 3;
            this.colNM_ENTRADA.Width = 180;
            // 
            // colNM_SALIDA
            // 
            this.colNM_SALIDA.Caption = "Salidas";
            this.colNM_SALIDA.FieldName = "NM_SALIDA";
            this.colNM_SALIDA.Name = "colNM_SALIDA";
            this.colNM_SALIDA.Visible = true;
            this.colNM_SALIDA.VisibleIndex = 4;
            this.colNM_SALIDA.Width = 180;
            // 
            // colNM_CANT_ACTUAL
            // 
            this.colNM_CANT_ACTUAL.Caption = "Existencia";
            this.colNM_CANT_ACTUAL.FieldName = "NM_CANT_ACTUAL";
            this.colNM_CANT_ACTUAL.Name = "colNM_CANT_ACTUAL";
            this.colNM_CANT_ACTUAL.Visible = true;
            this.colNM_CANT_ACTUAL.VisibleIndex = 5;
            this.colNM_CANT_ACTUAL.Width = 180;
            // 
            // colNM_COSTO
            // 
            this.colNM_COSTO.Caption = "Costo";
            this.colNM_COSTO.FieldName = "NM_COSTO";
            this.colNM_COSTO.Name = "colNM_COSTO";
            this.colNM_COSTO.Visible = true;
            this.colNM_COSTO.VisibleIndex = 6;
            this.colNM_COSTO.Width = 182;
            // 
            // colDS_ARTICULO
            // 
            this.colDS_ARTICULO.Caption = "Articulo";
            this.colDS_ARTICULO.FieldName = "DS_ARTICULO";
            this.colDS_ARTICULO.Name = "colDS_ARTICULO";
            this.colDS_ARTICULO.Visible = true;
            this.colDS_ARTICULO.VisibleIndex = 0;
            this.colDS_ARTICULO.Width = 504;
            // 
            // colDS_UBICACION
            // 
            this.colDS_UBICACION.Caption = "Bodega";
            this.colDS_UBICACION.FieldName = "DS_UBICACION";
            this.colDS_UBICACION.Name = "colDS_UBICACION";
            this.colDS_UBICACION.Visible = true;
            this.colDS_UBICACION.VisibleIndex = 1;
            this.colDS_UBICACION.Width = 328;
            // 
            // frm_existencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(886, 569);
            this.Name = "frm_existencia";
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vINVEXISTENCIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vINVEXISTENCIABindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EJERCICIO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_PERIODO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colID_BODEGA;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ARTICULO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_INI;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_ENTRADA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_SALIDA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_ACTUAL;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_COSTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_ARTICULO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UBICACION;
    }
}
