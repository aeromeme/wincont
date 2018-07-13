namespace winCont.Formularios.Configuracion
{
    partial class frm_sel_empresa
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
            this.vSISUSEREMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_USER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE_USUARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).BeginInit();
            this.UI_GRP_SELEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISUSEREMPRESABindingSource)).BeginInit();
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
            this.UIGRIDCONTROL.DataSource = this.vSISUSEREMPRESABindingSource;
            this.UIGRIDCONTROL.DoubleClick += new System.EventHandler(this.UIGRIDCONTROL_DoubleClick);
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 15F);
            this.UIGRIDVIEW.Appearance.Row.Options.UseFont = true;
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_EMPRESA,
            this.colID_USER,
            this.colDS_NOMBRE_USUARIO,
            this.colDS_EMPRESA});
            this.UIGRIDVIEW.OptionsBehavior.Editable = false;
            this.UIGRIDVIEW.OptionsBehavior.ReadOnly = true;
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            this.UIGRIDVIEW.OptionsView.ShowGroupPanel = false;
            this.UIGRIDVIEW.RowHeight = 30;
            // 
            // vSISUSEREMPRESABindingSource
            // 
            this.vSISUSEREMPRESABindingSource.DataSource = typeof(Sistema.V_SIS_USER_EMPRESA);
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
            // colID_USER
            // 
            this.colID_USER.FieldName = "ID_USER";
            this.colID_USER.Name = "colID_USER";
            // 
            // colDS_NOMBRE_USUARIO
            // 
            this.colDS_NOMBRE_USUARIO.FieldName = "DS_NOMBRE_USUARIO";
            this.colDS_NOMBRE_USUARIO.Name = "colDS_NOMBRE_USUARIO";
            // 
            // colDS_EMPRESA
            // 
            this.colDS_EMPRESA.Caption = "Empresa";
            this.colDS_EMPRESA.FieldName = "DS_EMPRESA";
            this.colDS_EMPRESA.Name = "colDS_EMPRESA";
            this.colDS_EMPRESA.Visible = true;
            this.colDS_EMPRESA.VisibleIndex = 0;
            // 
            // frm_sel_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 350);
            this.Name = "frm_sel_empresa";
            this.Activated += new System.EventHandler(this.frm_sel_empresa_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).EndInit();
            this.UI_GRP_SELEC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISUSEREMPRESABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vSISUSEREMPRESABindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colID_USER;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE_USUARIO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_EMPRESA;
    }
}
