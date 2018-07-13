namespace winCont.Formularios.Compras
{
    partial class frm_consultar_ingr_comp
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
            this.vINVDETAINGRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ARTICULO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_INGR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE_ALTER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UNIMED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFLG_INGR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_SERIE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_NUMERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_ESTA_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EXEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_PRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_RENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_SUBTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DETA_ORDEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_SOLICITADA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_RECIBIDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_FALTANTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vINVDETAINGRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.DataSource = this.vINVDETAINGRBindingSource;
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_ARTICULO,
            this.colID_INGR,
            this.colNM_CANTIDAD,
            this.colDS_NOMBRE,
            this.colDS_NOMBRE_ALTER,
            this.colDS_UNIMED,
            this.colFLG_INGR,
            this.colCD_SERIE,
            this.colCD_NUMERO,
            this.colDS_UBICACION,
            this.colDS_DOCUMENTO,
            this.colCD_ESTA_DOCUMENTO,
            this.colNM_EXEN,
            this.colNM_IVA,
            this.colNM_PRECIO,
            this.colNM_RENTA,
            this.colNM_SUBTOTAL,
            this.colNM_TOTAL,
            this.colID_DETA_ORDEN,
            this.colNM_CANT_SOLICITADA,
            this.colNM_CANT_RECIBIDA,
            this.colNM_CANT_FALTANTE,
            this.colID_EMPRESA});
            this.UIGRIDVIEW.OptionsBehavior.Editable = false;
            this.UIGRIDVIEW.OptionsBehavior.ReadOnly = true;
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            this.UIGRIDVIEW.OptionsView.ShowFooter = true;
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // vINVDETAINGRBindingSource
            // 
            this.vINVDETAINGRBindingSource.DataSource = typeof(InventarioDB.V_INV_DETA_INGR);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colID_ARTICULO
            // 
            this.colID_ARTICULO.FieldName = "ID_ARTICULO";
            this.colID_ARTICULO.Name = "colID_ARTICULO";
            // 
            // colID_INGR
            // 
            this.colID_INGR.FieldName = "ID_INGR";
            this.colID_INGR.Name = "colID_INGR";
            // 
            // colNM_CANTIDAD
            // 
            this.colNM_CANTIDAD.Caption = "Cantidad";
            this.colNM_CANTIDAD.FieldName = "NM_CANTIDAD";
            this.colNM_CANTIDAD.Name = "colNM_CANTIDAD";
            this.colNM_CANTIDAD.Visible = true;
            this.colNM_CANTIDAD.VisibleIndex = 1;
            this.colNM_CANTIDAD.Width = 135;
            // 
            // colDS_NOMBRE
            // 
            this.colDS_NOMBRE.Caption = "Articulo";
            this.colDS_NOMBRE.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE.Name = "colDS_NOMBRE";
            this.colDS_NOMBRE.Visible = true;
            this.colDS_NOMBRE.VisibleIndex = 0;
            this.colDS_NOMBRE.Width = 305;
            // 
            // colDS_NOMBRE_ALTER
            // 
            this.colDS_NOMBRE_ALTER.FieldName = "DS_NOMBRE_ALTER";
            this.colDS_NOMBRE_ALTER.Name = "colDS_NOMBRE_ALTER";
            // 
            // colDS_UNIMED
            // 
            this.colDS_UNIMED.FieldName = "DS_UNIMED";
            this.colDS_UNIMED.Name = "colDS_UNIMED";
            // 
            // colFLG_INGR
            // 
            this.colFLG_INGR.FieldName = "FLG_INGR";
            this.colFLG_INGR.Name = "colFLG_INGR";
            // 
            // colCD_SERIE
            // 
            this.colCD_SERIE.FieldName = "CD_SERIE";
            this.colCD_SERIE.Name = "colCD_SERIE";
            // 
            // colCD_NUMERO
            // 
            this.colCD_NUMERO.FieldName = "CD_NUMERO";
            this.colCD_NUMERO.Name = "colCD_NUMERO";
            // 
            // colDS_UBICACION
            // 
            this.colDS_UBICACION.FieldName = "DS_UBICACION";
            this.colDS_UBICACION.Name = "colDS_UBICACION";
            // 
            // colDS_DOCUMENTO
            // 
            this.colDS_DOCUMENTO.FieldName = "DS_DOCUMENTO";
            this.colDS_DOCUMENTO.Name = "colDS_DOCUMENTO";
            // 
            // colCD_ESTA_DOCUMENTO
            // 
            this.colCD_ESTA_DOCUMENTO.FieldName = "CD_ESTA_DOCUMENTO";
            this.colCD_ESTA_DOCUMENTO.Name = "colCD_ESTA_DOCUMENTO";
            // 
            // colNM_EXEN
            // 
            this.colNM_EXEN.FieldName = "NM_EXEN";
            this.colNM_EXEN.Name = "colNM_EXEN";
            // 
            // colNM_IVA
            // 
            this.colNM_IVA.Caption = "IVA";
            this.colNM_IVA.FieldName = "NM_IVA";
            this.colNM_IVA.Name = "colNM_IVA";
            this.colNM_IVA.Visible = true;
            this.colNM_IVA.VisibleIndex = 3;
            this.colNM_IVA.Width = 89;
            // 
            // colNM_PRECIO
            // 
            this.colNM_PRECIO.Caption = "Precio";
            this.colNM_PRECIO.FieldName = "NM_PRECIO";
            this.colNM_PRECIO.Name = "colNM_PRECIO";
            this.colNM_PRECIO.Visible = true;
            this.colNM_PRECIO.VisibleIndex = 2;
            this.colNM_PRECIO.Width = 111;
            // 
            // colNM_RENTA
            // 
            this.colNM_RENTA.FieldName = "NM_RENTA";
            this.colNM_RENTA.Name = "colNM_RENTA";
            // 
            // colNM_SUBTOTAL
            // 
            this.colNM_SUBTOTAL.FieldName = "NM_SUBTOTAL";
            this.colNM_SUBTOTAL.Name = "colNM_SUBTOTAL";
            // 
            // colNM_TOTAL
            // 
            this.colNM_TOTAL.Caption = "Total";
            this.colNM_TOTAL.FieldName = "NM_TOTAL";
            this.colNM_TOTAL.Name = "colNM_TOTAL";
            this.colNM_TOTAL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_TOTAL", "{0:n2}")});
            this.colNM_TOTAL.Visible = true;
            this.colNM_TOTAL.VisibleIndex = 4;
            this.colNM_TOTAL.Width = 157;
            // 
            // colID_DETA_ORDEN
            // 
            this.colID_DETA_ORDEN.FieldName = "ID_DETA_ORDEN";
            this.colID_DETA_ORDEN.Name = "colID_DETA_ORDEN";
            // 
            // colNM_CANT_SOLICITADA
            // 
            this.colNM_CANT_SOLICITADA.FieldName = "NM_CANT_SOLICITADA";
            this.colNM_CANT_SOLICITADA.Name = "colNM_CANT_SOLICITADA";
            // 
            // colNM_CANT_RECIBIDA
            // 
            this.colNM_CANT_RECIBIDA.FieldName = "NM_CANT_RECIBIDA";
            this.colNM_CANT_RECIBIDA.Name = "colNM_CANT_RECIBIDA";
            // 
            // colNM_CANT_FALTANTE
            // 
            this.colNM_CANT_FALTANTE.FieldName = "NM_CANT_FALTANTE";
            this.colNM_CANT_FALTANTE.Name = "colNM_CANT_FALTANTE";
            // 
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            // 
            // frm_consultar_ingr_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(819, 443);
            this.Name = "frm_consultar_ingr_comp";
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vINVDETAINGRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vINVDETAINGRBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ARTICULO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_INGR;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE_ALTER;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UNIMED;
        private DevExpress.XtraGrid.Columns.GridColumn colFLG_INGR;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_SERIE;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_NUMERO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UBICACION;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_ESTA_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EXEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_IVA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_PRECIO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_RENTA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_SUBTOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DETA_ORDEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_SOLICITADA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_RECIBIDA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_FALTANTE;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
    }
}
