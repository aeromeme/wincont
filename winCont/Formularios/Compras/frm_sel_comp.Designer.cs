namespace winCont.Formularios.Compras
{
    partial class frm_sel_comp
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
            this.vINVDETAREQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ARTICULO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_REQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE_ALTER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UNIMED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_DESP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_FALTANTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vCOMPCOMPRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colDS_NOMBRE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DIRECCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_RZN_COMER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_RF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_NIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NM_DUI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_FORMA_PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFLG_CREDITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).BeginInit();
            this.UI_GRP_SELEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vINVDETAREQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCOMPCOMPRABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_GRP_SELEC
            // 
            this.UI_GRP_SELEC.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.UI_GRP_SELEC.Appearance.Options.UseFont = true;
            this.UI_GRP_SELEC.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UI_GRP_SELEC.AppearanceCaption.Options.UseFont = true;
            this.UI_GRP_SELEC.Size = new System.Drawing.Size(596, 350);
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.DataSource = this.vCOMPCOMPRABindingSource;
            this.UIGRIDCONTROL.Size = new System.Drawing.Size(592, 307);
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
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
            this.colDS_NOMBRE1,
            this.colDS_DIRECCION,
            this.colDS_RZN_COMER,
            this.colDS_NM_RF,
            this.colDS_NM_NIT,
            this.colDS_NM_DUI,
            this.colDS_FORMA_PAGO,
            this.colFLG_CREDITO,
            this.colDS_DOCUMENTO,
            this.colNM_TOTAL});
            this.UIGRIDVIEW.OptionsBehavior.Editable = false;
            this.UIGRIDVIEW.OptionsBehavior.ReadOnly = true;
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            this.UIGRIDVIEW.OptionsView.ShowGroupPanel = false;
            this.UIGRIDVIEW.DoubleClick += new System.EventHandler(this.UIGRIDVIEW_DoubleClick);
            // 
            // vINVDETAREQBindingSource
            // 
            this.vINVDETAREQBindingSource.DataSource = typeof(InventarioDB.V_INV_DETA_REQ);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colID_ARTICULO
            // 
            this.colID_ARTICULO.FieldName = "ID_ARTICULO";
            this.colID_ARTICULO.Name = "colID_ARTICULO";
            this.colID_ARTICULO.Visible = true;
            this.colID_ARTICULO.VisibleIndex = 1;
            // 
            // colID_REQ
            // 
            this.colID_REQ.FieldName = "ID_REQ";
            this.colID_REQ.Name = "colID_REQ";
            this.colID_REQ.Visible = true;
            this.colID_REQ.VisibleIndex = 2;
            // 
            // colNM_CANTIDAD
            // 
            this.colNM_CANTIDAD.FieldName = "NM_CANTIDAD";
            this.colNM_CANTIDAD.Name = "colNM_CANTIDAD";
            this.colNM_CANTIDAD.Visible = true;
            this.colNM_CANTIDAD.VisibleIndex = 3;
            // 
            // colDS_NOMBRE
            // 
            this.colDS_NOMBRE.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE.Name = "colDS_NOMBRE";
            this.colDS_NOMBRE.Visible = true;
            this.colDS_NOMBRE.VisibleIndex = 4;
            // 
            // colDS_NOMBRE_ALTER
            // 
            this.colDS_NOMBRE_ALTER.FieldName = "DS_NOMBRE_ALTER";
            this.colDS_NOMBRE_ALTER.Name = "colDS_NOMBRE_ALTER";
            this.colDS_NOMBRE_ALTER.Visible = true;
            this.colDS_NOMBRE_ALTER.VisibleIndex = 5;
            // 
            // colDS_UNIMED
            // 
            this.colDS_UNIMED.FieldName = "DS_UNIMED";
            this.colDS_UNIMED.Name = "colDS_UNIMED";
            this.colDS_UNIMED.Visible = true;
            this.colDS_UNIMED.VisibleIndex = 6;
            // 
            // colNM_CANT_DESP
            // 
            this.colNM_CANT_DESP.FieldName = "NM_CANT_DESP";
            this.colNM_CANT_DESP.Name = "colNM_CANT_DESP";
            this.colNM_CANT_DESP.Visible = true;
            this.colNM_CANT_DESP.VisibleIndex = 7;
            // 
            // colNM_CANT_FALTANTE
            // 
            this.colNM_CANT_FALTANTE.FieldName = "NM_CANT_FALTANTE";
            this.colNM_CANT_FALTANTE.Name = "colNM_CANT_FALTANTE";
            this.colNM_CANT_FALTANTE.Visible = true;
            this.colNM_CANT_FALTANTE.VisibleIndex = 8;
            // 
            // vCOMPCOMPRABindingSource
            // 
            this.vCOMPCOMPRABindingSource.DataSource = typeof(ComprasDB.V_COMP_COMPRA);
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
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
            this.colFE_FECHA.VisibleIndex = 0;
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
            this.colCD_SERIE.VisibleIndex = 2;
            // 
            // colCD_NUMERO
            // 
            this.colCD_NUMERO.Caption = "Numero";
            this.colCD_NUMERO.FieldName = "CD_NUMERO";
            this.colCD_NUMERO.Name = "colCD_NUMERO";
            this.colCD_NUMERO.Visible = true;
            this.colCD_NUMERO.VisibleIndex = 3;
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
            this.colCD_ESTADO.FieldName = "CD_ESTADO";
            this.colCD_ESTADO.Name = "colCD_ESTADO";
            // 
            // colDS_NOMBRE1
            // 
            this.colDS_NOMBRE1.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE1.Name = "colDS_NOMBRE1";
            // 
            // colDS_DIRECCION
            // 
            this.colDS_DIRECCION.FieldName = "DS_DIRECCION";
            this.colDS_DIRECCION.Name = "colDS_DIRECCION";
            // 
            // colDS_RZN_COMER
            // 
            this.colDS_RZN_COMER.FieldName = "DS_RZN_COMER";
            this.colDS_RZN_COMER.Name = "colDS_RZN_COMER";
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
            // colDS_NM_DUI
            // 
            this.colDS_NM_DUI.FieldName = "DS_NM_DUI";
            this.colDS_NM_DUI.Name = "colDS_NM_DUI";
            // 
            // colDS_FORMA_PAGO
            // 
            this.colDS_FORMA_PAGO.FieldName = "DS_FORMA_PAGO";
            this.colDS_FORMA_PAGO.Name = "colDS_FORMA_PAGO";
            // 
            // colFLG_CREDITO
            // 
            this.colFLG_CREDITO.FieldName = "FLG_CREDITO";
            this.colFLG_CREDITO.Name = "colFLG_CREDITO";
            // 
            // colDS_DOCUMENTO
            // 
            this.colDS_DOCUMENTO.Caption = "Documento";
            this.colDS_DOCUMENTO.FieldName = "DS_DOCUMENTO";
            this.colDS_DOCUMENTO.Name = "colDS_DOCUMENTO";
            this.colDS_DOCUMENTO.Visible = true;
            this.colDS_DOCUMENTO.VisibleIndex = 1;
            // 
            // colNM_TOTAL
            // 
            this.colNM_TOTAL.Caption = "Total";
            this.colNM_TOTAL.FieldName = "NM_TOTAL";
            this.colNM_TOTAL.Name = "colNM_TOTAL";
            this.colNM_TOTAL.Visible = true;
            this.colNM_TOTAL.VisibleIndex = 4;
            // 
            // frm_sel_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(596, 350);
            this.Name = "frm_sel_comp";
            this.Load += new System.EventHandler(this.frm_sel_req_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).EndInit();
            this.UI_GRP_SELEC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vINVDETAREQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCOMPCOMPRABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vINVDETAREQBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ARTICULO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_REQ;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE_ALTER;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UNIMED;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_DESP;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_FALTANTE;
        private System.Windows.Forms.BindingSource vCOMPCOMPRABindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DIRECCION;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_RZN_COMER;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_RF;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_NIT;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NM_DUI;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_FORMA_PAGO;
        private DevExpress.XtraGrid.Columns.GridColumn colFLG_CREDITO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_TOTAL;
    }
}
