namespace winCont.Formularios.Contabilidad
{
    partial class frm_actu_part_borr
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
            this.repositoryItemCheckEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.vCONTENCAPARTBORRADORBindingSource = new System.Windows.Forms.BindingSource();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFE_PARTIDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_DIARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_PERIODO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EJERCICIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CONCEPTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_REFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_ESTA_PART = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_PART_DIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_TIPO_DIARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uirbnbtn_actu_massive = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCONTENCAPARTBORRADORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.DataSource = this.vCONTENCAPARTBORRADORBindingSource;
            this.UIGRIDCONTROL.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit5,
            this.repositoryItemCheckEdit4,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit1});
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFE_PARTIDA,
            this.colID_DIARIO,
            this.colID_EMPRESA,
            this.colNM_PERIODO,
            this.colNM_EJERCICIO,
            this.colDS_CONCEPTO,
            this.colDS_REFERENCIA,
            this.colCD_ESTA_PART,
            this.colID_PART_DIA,
            this.colDS_TIPO_DIARIO});
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            this.UIGRIDVIEW.OptionsView.ShowDetailButtons = false;
            this.UIGRIDVIEW.OptionsView.ShowGroupPanel = false;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.uirbnbtn_actu_massive});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 320);
            this.ribbonControl1.MaxItemId = 2;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.uirbnbtn_actu_massive);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // repositoryItemCheckEdit5
            // 
            this.repositoryItemCheckEdit5.AutoHeight = false;
            this.repositoryItemCheckEdit5.Name = "repositoryItemCheckEdit5";
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // vCONTENCAPARTBORRADORBindingSource
            // 
            this.vCONTENCAPARTBORRADORBindingSource.DataSource = typeof(ContabilidadDB.V_CONT_ENCA_PART_BORRADOR);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colFE_PARTIDA
            // 
            this.colFE_PARTIDA.Caption = "Fecha";
            this.colFE_PARTIDA.FieldName = "FE_PARTIDA";
            this.colFE_PARTIDA.Name = "colFE_PARTIDA";
            this.colFE_PARTIDA.OptionsColumn.AllowEdit = false;
            this.colFE_PARTIDA.OptionsColumn.ReadOnly = true;
            this.colFE_PARTIDA.Visible = true;
            this.colFE_PARTIDA.VisibleIndex = 1;
            // 
            // colID_DIARIO
            // 
            this.colID_DIARIO.FieldName = "ID_DIARIO";
            this.colID_DIARIO.Name = "colID_DIARIO";
            this.colID_DIARIO.OptionsColumn.AllowEdit = false;
            this.colID_DIARIO.OptionsColumn.ReadOnly = true;
            // 
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            this.colID_EMPRESA.OptionsColumn.AllowEdit = false;
            this.colID_EMPRESA.OptionsColumn.ReadOnly = true;
            // 
            // colNM_PERIODO
            // 
            this.colNM_PERIODO.FieldName = "NM_PERIODO";
            this.colNM_PERIODO.Name = "colNM_PERIODO";
            this.colNM_PERIODO.OptionsColumn.AllowEdit = false;
            this.colNM_PERIODO.OptionsColumn.ReadOnly = true;
            // 
            // colNM_EJERCICIO
            // 
            this.colNM_EJERCICIO.FieldName = "NM_EJERCICIO";
            this.colNM_EJERCICIO.Name = "colNM_EJERCICIO";
            this.colNM_EJERCICIO.OptionsColumn.AllowEdit = false;
            this.colNM_EJERCICIO.OptionsColumn.ReadOnly = true;
            // 
            // colDS_CONCEPTO
            // 
            this.colDS_CONCEPTO.FieldName = "DS_CONCEPTO";
            this.colDS_CONCEPTO.Name = "colDS_CONCEPTO";
            this.colDS_CONCEPTO.OptionsColumn.AllowEdit = false;
            this.colDS_CONCEPTO.OptionsColumn.ReadOnly = true;
            // 
            // colDS_REFERENCIA
            // 
            this.colDS_REFERENCIA.Caption = "Referencia";
            this.colDS_REFERENCIA.FieldName = "DS_REFERENCIA";
            this.colDS_REFERENCIA.Name = "colDS_REFERENCIA";
            this.colDS_REFERENCIA.OptionsColumn.AllowEdit = false;
            this.colDS_REFERENCIA.OptionsColumn.ReadOnly = true;
            this.colDS_REFERENCIA.Visible = true;
            this.colDS_REFERENCIA.VisibleIndex = 2;
            // 
            // colCD_ESTA_PART
            // 
            this.colCD_ESTA_PART.Caption = "Estado";
            this.colCD_ESTA_PART.FieldName = "CD_ESTA_PART";
            this.colCD_ESTA_PART.Name = "colCD_ESTA_PART";
            this.colCD_ESTA_PART.OptionsColumn.AllowEdit = false;
            this.colCD_ESTA_PART.OptionsColumn.ReadOnly = true;
            this.colCD_ESTA_PART.Visible = true;
            this.colCD_ESTA_PART.VisibleIndex = 3;
            // 
            // colID_PART_DIA
            // 
            this.colID_PART_DIA.FieldName = "ID_PART_DIA";
            this.colID_PART_DIA.Name = "colID_PART_DIA";
            this.colID_PART_DIA.OptionsColumn.AllowEdit = false;
            this.colID_PART_DIA.OptionsColumn.ReadOnly = true;
            // 
            // colDS_TIPO_DIARIO
            // 
            this.colDS_TIPO_DIARIO.Caption = "Tipo Diario";
            this.colDS_TIPO_DIARIO.FieldName = "DS_TIPO_DIARIO";
            this.colDS_TIPO_DIARIO.Name = "colDS_TIPO_DIARIO";
            this.colDS_TIPO_DIARIO.OptionsColumn.AllowEdit = false;
            this.colDS_TIPO_DIARIO.OptionsColumn.ReadOnly = true;
            this.colDS_TIPO_DIARIO.Visible = true;
            this.colDS_TIPO_DIARIO.VisibleIndex = 4;
            // 
            // uirbnbtn_actu_massive
            // 
            this.uirbnbtn_actu_massive.Caption = "Actualizar partidas";
            this.uirbnbtn_actu_massive.Id = 1;
            this.uirbnbtn_actu_massive.LargeGlyph = global::winCont.Properties.Resources.approval_24;
            this.uirbnbtn_actu_massive.LargeWidth = 60;
            this.uirbnbtn_actu_massive.Name = "uirbnbtn_actu_massive";
            this.uirbnbtn_actu_massive.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.uirbnbtn_actu_massive.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.uirbnbtn_actu_massive_ItemClick);
            // 
            // frm_actu_part_borr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(704, 462);
            this.Name = "frm_actu_part_borr";
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCONTENCAPARTBORRADORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vCONTENCAPARTBORRADORBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFE_PARTIDA;
        private DevExpress.XtraGrid.Columns.GridColumn colID_DIARIO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_PERIODO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EJERCICIO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CONCEPTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_REFERENCIA;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_ESTA_PART;
        private DevExpress.XtraGrid.Columns.GridColumn colID_PART_DIA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_TIPO_DIARIO;
        private DevExpress.XtraBars.BarButtonItem uirbnbtn_actu_massive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit5;
    }
}
