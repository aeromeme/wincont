namespace winCont.Formularios.Contabilidad
{
    partial class frm_centro_costos
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.UIID = new DevExpress.XtraEditors.TextEdit();
            this.UIDS_NOMBRE = new DevExpress.XtraEditors.TextEdit();
            this.cONTCENTROCOSTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_NOMBRE1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_NOMBRE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTCENTROCOSTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.cONTCENTROCOSTOBindingSource;
            this.uigridcontrol.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colDS_NOMBRE1});
            this.uigridview.OptionsBehavior.Editable = false;
            this.uigridview.OptionsBehavior.ReadOnly = true;
            this.uigridview.OptionsView.ShowDetailButtons = false;
            // 
            // UINAV
            // 
            this.UINAV.Buttons.Append.Visible = false;
            this.UINAV.Buttons.CancelEdit.Visible = false;
            this.UINAV.Buttons.Edit.Visible = false;
            this.UINAV.Buttons.EndEdit.Visible = false;
            this.UINAV.Buttons.Remove.Visible = false;
            this.UINAV.Location = new System.Drawing.Point(2, 619);
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.UIDS_NOMBRE);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.labelControl1);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(85, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Descripcion";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(120, 48);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(168, 26);
            this.UIID.TabIndex = 2;
            // 
            // UIDS_NOMBRE
            // 
            this.UIDS_NOMBRE.Location = new System.Drawing.Point(120, 102);
            this.UIDS_NOMBRE.Name = "UIDS_NOMBRE";
            this.UIDS_NOMBRE.Properties.MaxLength = 100;
            this.UIDS_NOMBRE.Size = new System.Drawing.Size(420, 26);
            this.UIDS_NOMBRE.TabIndex = 3;
            // 
            // cONTCENTROCOSTOBindingSource
            // 
            this.cONTCENTROCOSTOBindingSource.DataSource = typeof(ContabilidadDB.CONT_CENTRO_COSTO);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            this.colID_EMPRESA.Visible = true;
            this.colID_EMPRESA.VisibleIndex = 1;
            // 
            // colDS_NOMBRE
            // 
            this.colDS_NOMBRE.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE.Name = "colDS_NOMBRE";
            this.colDS_NOMBRE.Visible = true;
            this.colDS_NOMBRE.VisibleIndex = 2;
            // 
            // colID1
            // 
            this.colID1.Caption = "ID";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colDS_NOMBRE1
            // 
            this.colDS_NOMBRE1.Caption = "Nombre";
            this.colDS_NOMBRE1.FieldName = "DS_NOMBRE";
            this.colDS_NOMBRE1.Name = "colDS_NOMBRE1";
            this.colDS_NOMBRE1.Visible = true;
            this.colDS_NOMBRE1.VisibleIndex = 1;
            // 
            // frm_centro_costos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(792, 711);
            this.Name = "frm_centro_costos";
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
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_NOMBRE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTCENTROCOSTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit UIDS_NOMBRE;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource cONTCENTROCOSTOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_NOMBRE1;
    }
}
