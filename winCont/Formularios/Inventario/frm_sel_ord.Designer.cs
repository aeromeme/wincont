namespace winCont.Formularios.Inventario
{
    partial class frm_sel_ord
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
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ARTICULO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_REQ1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANTIDAD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE_ALTER1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UNIMED1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_DESP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_FALTANTE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_SERIE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_NUMERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).BeginInit();
            this.UI_GRP_SELEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vINVDETAREQBindingSource)).BeginInit();
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
            this.UIGRIDCONTROL.DataSource = this.vINVDETAREQBindingSource;
            this.UIGRIDCONTROL.Size = new System.Drawing.Size(592, 307);
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colID_ARTICULO1,
            this.colID_REQ1,
            this.colNM_CANTIDAD1,
            this.colDS_NOMBRE1,
            this.colDS_NOMBRE_ALTER1,
            this.colDS_UNIMED1,
            this.colNM_CANT_DESP1,
            this.colNM_CANT_FALTANTE1,
            this.colCD_SERIE,
            this.colCD_NUMERO,
            this.colDS_UBICACION,
            this.colDS_DOCUMENTO});
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
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            // 
            // colID_ARTICULO1
            // 
            this.colID_ARTICULO1.FieldName = "ID_ARTICULO";
            this.colID_ARTICULO1.Name = "colID_ARTICULO1";
            // 
            // colID_REQ1
            // 
            this.colID_REQ1.FieldName = "ID_REQ";
            this.colID_REQ1.Name = "colID_REQ1";
            // 
            // colNM_CANTIDAD1
            // 
            this.colNM_CANTIDAD1.FieldName = "NM_CANTIDAD";
            this.colNM_CANTIDAD1.Name = "colNM_CANTIDAD1";
            // 
            // colDS_NOMBRE1
            // 
            this.colDS_NOMBRE1.Caption = "Articulo";
            this.colDS_NOMBRE1.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE1.Name = "colDS_NOMBRE1";
            this.colDS_NOMBRE1.Visible = true;
            this.colDS_NOMBRE1.VisibleIndex = 3;
            this.colDS_NOMBRE1.Width = 148;
            // 
            // colDS_NOMBRE_ALTER1
            // 
            this.colDS_NOMBRE_ALTER1.FieldName = "DS_NOMBRE_ALTER";
            this.colDS_NOMBRE_ALTER1.Name = "colDS_NOMBRE_ALTER1";
            // 
            // colDS_UNIMED1
            // 
            this.colDS_UNIMED1.Caption = "U.";
            this.colDS_UNIMED1.FieldName = "DS_UNIMED";
            this.colDS_UNIMED1.Name = "colDS_UNIMED1";
            this.colDS_UNIMED1.Visible = true;
            this.colDS_UNIMED1.VisibleIndex = 5;
            this.colDS_UNIMED1.Width = 38;
            // 
            // colNM_CANT_DESP1
            // 
            this.colNM_CANT_DESP1.FieldName = "NM_CANT_DESP";
            this.colNM_CANT_DESP1.Name = "colNM_CANT_DESP1";
            // 
            // colNM_CANT_FALTANTE1
            // 
            this.colNM_CANT_FALTANTE1.Caption = "Faltante";
            this.colNM_CANT_FALTANTE1.FieldName = "NM_CANT_FALTANTE";
            this.colNM_CANT_FALTANTE1.Name = "colNM_CANT_FALTANTE1";
            this.colNM_CANT_FALTANTE1.Visible = true;
            this.colNM_CANT_FALTANTE1.VisibleIndex = 4;
            this.colNM_CANT_FALTANTE1.Width = 74;
            // 
            // colCD_SERIE
            // 
            this.colCD_SERIE.Caption = "Serie";
            this.colCD_SERIE.FieldName = "CD_SERIE";
            this.colCD_SERIE.Name = "colCD_SERIE";
            this.colCD_SERIE.Visible = true;
            this.colCD_SERIE.VisibleIndex = 1;
            this.colCD_SERIE.Width = 54;
            // 
            // colCD_NUMERO
            // 
            this.colCD_NUMERO.Caption = "Num.";
            this.colCD_NUMERO.FieldName = "CD_NUMERO";
            this.colCD_NUMERO.Name = "colCD_NUMERO";
            this.colCD_NUMERO.Visible = true;
            this.colCD_NUMERO.VisibleIndex = 2;
            this.colCD_NUMERO.Width = 50;
            // 
            // colDS_UBICACION
            // 
            this.colDS_UBICACION.Caption = "Solicitante";
            this.colDS_UBICACION.FieldName = "DS_UBICACION";
            this.colDS_UBICACION.Name = "colDS_UBICACION";
            this.colDS_UBICACION.Visible = true;
            this.colDS_UBICACION.VisibleIndex = 6;
            this.colDS_UBICACION.Width = 103;
            // 
            // colDS_DOCUMENTO
            // 
            this.colDS_DOCUMENTO.Caption = "Documento";
            this.colDS_DOCUMENTO.FieldName = "DS_DOCUMENTO";
            this.colDS_DOCUMENTO.Name = "colDS_DOCUMENTO";
            this.colDS_DOCUMENTO.Visible = true;
            this.colDS_DOCUMENTO.VisibleIndex = 0;
            // 
            // frm_sel_req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(596, 350);
            this.Name = "frm_sel_req";
            this.Load += new System.EventHandler(this.frm_sel_req_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).EndInit();
            this.UI_GRP_SELEC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vINVDETAREQBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ARTICULO1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_REQ1;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANTIDAD1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE_ALTER1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UNIMED1;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_DESP1;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_FALTANTE1;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_SERIE;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_NUMERO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UBICACION;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DOCUMENTO;
    }
}
