namespace winCont.Formularios.Ventas
{
    partial class frm_sel_pedido
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
            this.vFACPEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EJERCICIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_PERIODO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TERCERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE_CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DIR_ENTREGA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_VENDEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFE_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TIPO_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_SERIE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_NUMERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_GRAVADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EXENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_PERCEPCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_RETENCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_RF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_NIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_RZN_COMER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_VENDEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_VENDEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TIENDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).BeginInit();
            this.UI_GRP_SELEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFACPEDIDOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_GRP_SELEC
            // 
            this.UI_GRP_SELEC.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.UI_GRP_SELEC.Appearance.Options.UseFont = true;
            this.UI_GRP_SELEC.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UI_GRP_SELEC.AppearanceCaption.Options.UseFont = true;
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.DataSource = this.vFACPEDIDOBindingSource;
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_EMPRESA,
            this.colNM_EJERCICIO,
            this.colNM_PERIODO,
            this.colID_TERCERO,
            this.colDS_NOMBRE_CLIENTE,
            this.colDS_DIR_ENTREGA,
            this.colID_VENDEDOR,
            this.colFE_FECHA,
            this.colID_TIPO_DOCUMENTO,
            this.colCD_SERIE,
            this.colCD_NUMERO,
            this.colNM_GRAVADO,
            this.colNM_EXENTO,
            this.colNM_IVA,
            this.colNM_PERCEPCION,
            this.colNM_RETENCION,
            this.colNM_TOTAL,
            this.colCD_ESTADO,
            this.colDS_NM_RF,
            this.colDS_NM_NIT,
            this.colDS_NOMBRE,
            this.colDS_RZN_COMER,
            this.colCD_VENDEDOR,
            this.colDS_VENDEDOR,
            this.colDS_DOCUMENTO,
            this.colDS_UBICACION,
            this.colID_TIENDA});
            this.UIGRIDVIEW.OptionsBehavior.Editable = false;
            this.UIGRIDVIEW.OptionsBehavior.ReadOnly = true;
            this.UIGRIDVIEW.OptionsSelection.MultiSelect = true;
            this.UIGRIDVIEW.OptionsView.ColumnAutoWidth = false;
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            this.UIGRIDVIEW.OptionsView.ShowDetailButtons = false;
            this.UIGRIDVIEW.OptionsView.ShowFooter = true;
            this.UIGRIDVIEW.OptionsView.ShowGroupPanel = false;
            this.UIGRIDVIEW.DoubleClick += new System.EventHandler(this.UIGRIDVIEW_DoubleClick);
            // 
            // vFACPEDIDOBindingSource
            // 
            this.vFACPEDIDOBindingSource.DataSource = typeof(VentasDB.V_FAC_PEDIDO);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
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
            // colDS_NOMBRE_CLIENTE
            // 
            this.colDS_NOMBRE_CLIENTE.Caption = "Cliente";
            this.colDS_NOMBRE_CLIENTE.FieldName = "DS_NOMBRE_CLIENTE";
            this.colDS_NOMBRE_CLIENTE.Name = "colDS_NOMBRE_CLIENTE";
            this.colDS_NOMBRE_CLIENTE.Visible = true;
            this.colDS_NOMBRE_CLIENTE.VisibleIndex = 5;
            this.colDS_NOMBRE_CLIENTE.Width = 461;
            // 
            // colDS_DIR_ENTREGA
            // 
            this.colDS_DIR_ENTREGA.FieldName = "DS_DIR_ENTREGA";
            this.colDS_DIR_ENTREGA.Name = "colDS_DIR_ENTREGA";
            // 
            // colID_VENDEDOR
            // 
            this.colID_VENDEDOR.FieldName = "ID_VENDEDOR";
            this.colID_VENDEDOR.Name = "colID_VENDEDOR";
            // 
            // colFE_FECHA
            // 
            this.colFE_FECHA.Caption = "Fecha";
            this.colFE_FECHA.FieldName = "FE_FECHA";
            this.colFE_FECHA.Name = "colFE_FECHA";
            this.colFE_FECHA.Visible = true;
            this.colFE_FECHA.VisibleIndex = 4;
            this.colFE_FECHA.Width = 137;
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
            this.colCD_SERIE.VisibleIndex = 2;
            this.colCD_SERIE.Width = 104;
            // 
            // colCD_NUMERO
            // 
            this.colCD_NUMERO.Caption = "Numero";
            this.colCD_NUMERO.FieldName = "CD_NUMERO";
            this.colCD_NUMERO.Name = "colCD_NUMERO";
            this.colCD_NUMERO.Visible = true;
            this.colCD_NUMERO.VisibleIndex = 3;
            this.colCD_NUMERO.Width = 97;
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
            // colNM_IVA
            // 
            this.colNM_IVA.FieldName = "NM_IVA";
            this.colNM_IVA.Name = "colNM_IVA";
            // 
            // colNM_PERCEPCION
            // 
            this.colNM_PERCEPCION.FieldName = "NM_PERCEPCION";
            this.colNM_PERCEPCION.Name = "colNM_PERCEPCION";
            // 
            // colNM_RETENCION
            // 
            this.colNM_RETENCION.FieldName = "NM_RETENCION";
            this.colNM_RETENCION.Name = "colNM_RETENCION";
            // 
            // colNM_TOTAL
            // 
            this.colNM_TOTAL.Caption = "Total";
            this.colNM_TOTAL.FieldName = "NM_TOTAL";
            this.colNM_TOTAL.Name = "colNM_TOTAL";
            this.colNM_TOTAL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_TOTAL", "{0:n2}")});
            this.colNM_TOTAL.Visible = true;
            this.colNM_TOTAL.VisibleIndex = 7;
            this.colNM_TOTAL.Width = 179;
            // 
            // colCD_ESTADO
            // 
            this.colCD_ESTADO.FieldName = "CD_ESTADO";
            this.colCD_ESTADO.Name = "colCD_ESTADO";
            // 
            // colDS_NM_RF
            // 
            this.colDS_NM_RF.FieldName = "DS_NM_RF";
            this.colDS_NM_RF.Name = "colDS_NM_RF";
            // 
            // colDS_NM_NIT
            // 
            this.colDS_NM_NIT.FieldName = "DS_NM_NIT";
            this.colDS_NM_NIT.Name = "colDS_NM_NIT";
            // 
            // colDS_NOMBRE
            // 
            this.colDS_NOMBRE.Caption = "Cliente";
            this.colDS_NOMBRE.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE.Name = "colDS_NOMBRE";
            // 
            // colDS_RZN_COMER
            // 
            this.colDS_RZN_COMER.FieldName = "DS_RZN_COMER";
            this.colDS_RZN_COMER.Name = "colDS_RZN_COMER";
            // 
            // colCD_VENDEDOR
            // 
            this.colCD_VENDEDOR.FieldName = "CD_VENDEDOR";
            this.colCD_VENDEDOR.Name = "colCD_VENDEDOR";
            // 
            // colDS_VENDEDOR
            // 
            this.colDS_VENDEDOR.Caption = "Vendedor";
            this.colDS_VENDEDOR.FieldName = "DS_VENDEDOR";
            this.colDS_VENDEDOR.Name = "colDS_VENDEDOR";
            this.colDS_VENDEDOR.Visible = true;
            this.colDS_VENDEDOR.VisibleIndex = 6;
            this.colDS_VENDEDOR.Width = 229;
            // 
            // colDS_DOCUMENTO
            // 
            this.colDS_DOCUMENTO.Caption = "Pedido";
            this.colDS_DOCUMENTO.FieldName = "DS_DOCUMENTO";
            this.colDS_DOCUMENTO.Name = "colDS_DOCUMENTO";
            this.colDS_DOCUMENTO.Visible = true;
            this.colDS_DOCUMENTO.VisibleIndex = 0;
            this.colDS_DOCUMENTO.Width = 110;
            // 
            // colID_TIENDA
            // 
            this.colID_TIENDA.FieldName = "ID_TIENDA";
            this.colID_TIENDA.Name = "colID_TIENDA";
            // 
            // colDS_UBICACION
            // 
            this.colDS_UBICACION.Caption = "Tienda";
            this.colDS_UBICACION.FieldName = "DS_UBICACION";
            this.colDS_UBICACION.Name = "colDS_UBICACION";
            this.colDS_UBICACION.Visible = true;
            this.colDS_UBICACION.VisibleIndex = 1;
            this.colDS_UBICACION.Width = 118;
            // 
            // frm_sel_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 350);
            this.Name = "frm_sel_pedido";
            this.Load += new System.EventHandler(this.frm_sel_pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).EndInit();
            this.UI_GRP_SELEC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFACPEDIDOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vFACPEDIDOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EJERCICIO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_PERIODO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TERCERO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE_CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DIR_ENTREGA;
        private DevExpress.XtraGrid.Columns.GridColumn colID_VENDEDOR;
        private DevExpress.XtraGrid.Columns.GridColumn colFE_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TIPO_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_SERIE;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_NUMERO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_GRAVADO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EXENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_IVA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_PERCEPCION;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_RETENCION;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_ESTADO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_RF;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_NIT;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_RZN_COMER;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_VENDEDOR;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_VENDEDOR;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TIENDA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UBICACION;
    }
}
