namespace winCont.Formularios.Configuracion
{
    partial class frm_sel_periodo
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
            this.sISPERIODOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EJERCICIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_PERIODO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIS_EMPRESAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vSISPERIODOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colDS_MES = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).BeginInit();
            this.UI_GRP_SELEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISPERIODOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISPERIODOBindingSource)).BeginInit();
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
            this.UIGRIDCONTROL.DataSource = this.vSISPERIODOBindingSource;
            this.UIGRIDCONTROL.DoubleClick += new System.EventHandler(this.UIGRIDCONTROL_DoubleClick);
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_EMPRESA,
            this.colNM_EJERCICIO,
            this.colNM_PERIODO,
            this.colCD_ESTADO,
            this.colSIS_EMPRESAS,
            this.colDS_MES});
            this.UIGRIDVIEW.OptionsBehavior.Editable = false;
            this.UIGRIDVIEW.OptionsBehavior.ReadOnly = true;
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            this.UIGRIDVIEW.OptionsView.ShowGroupPanel = false;
            // 
            // sISPERIODOBindingSource
            // 
            this.sISPERIODOBindingSource.DataSource = typeof(Sistema.SIS_PERIODO);
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
            this.colNM_EJERCICIO.Caption = "Ejercicio";
            this.colNM_EJERCICIO.FieldName = "NM_EJERCICIO";
            this.colNM_EJERCICIO.Name = "colNM_EJERCICIO";
            this.colNM_EJERCICIO.Visible = true;
            this.colNM_EJERCICIO.VisibleIndex = 0;
            this.colNM_EJERCICIO.Width = 180;
            // 
            // colNM_PERIODO
            // 
            this.colNM_PERIODO.Caption = "Periodo";
            this.colNM_PERIODO.FieldName = "NM_PERIODO";
            this.colNM_PERIODO.Name = "colNM_PERIODO";
            this.colNM_PERIODO.Visible = true;
            this.colNM_PERIODO.VisibleIndex = 1;
            this.colNM_PERIODO.Width = 54;
            // 
            // colCD_ESTADO
            // 
            this.colCD_ESTADO.FieldName = "CD_ESTADO";
            this.colCD_ESTADO.Name = "colCD_ESTADO";
            // 
            // colSIS_EMPRESAS
            // 
            this.colSIS_EMPRESAS.FieldName = "SIS_EMPRESAS";
            this.colSIS_EMPRESAS.Name = "colSIS_EMPRESAS";
            // 
            // vSISPERIODOBindingSource
            // 
            this.vSISPERIODOBindingSource.DataSource = typeof(Sistema.V_SIS_PERIODO);
            // 
            // colDS_MES
            // 
            this.colDS_MES.Caption = "Mes";
            this.colDS_MES.FieldName = "DS_MES";
            this.colDS_MES.Name = "colDS_MES";
            this.colDS_MES.Visible = true;
            this.colDS_MES.VisibleIndex = 2;
            this.colDS_MES.Width = 308;
            // 
            // frm_sel_periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 350);
            this.Name = "frm_sel_periodo";
            this.Activated += new System.EventHandler(this.frm_sel_periodo_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).EndInit();
            this.UI_GRP_SELEC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISPERIODOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISPERIODOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sISPERIODOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EJERCICIO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_PERIODO;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_ESTADO;
        private DevExpress.XtraGrid.Columns.GridColumn colSIS_EMPRESAS;
        private System.Windows.Forms.BindingSource vSISPERIODOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MES;
    }
}
