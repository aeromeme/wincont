namespace winCont.Formularios.Inventario
{
    partial class frm_unimed
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
            this.iNVUNIMEDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UNIMED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.UIID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.UIDS_UNIMED = new DevExpress.XtraEditors.TextEdit();
            this.UIDS_SIMBOLO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.colDS_SIMBOLO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.iNVUNIMEDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_UNIMED.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_SIMBOLO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.Location = new System.Drawing.Point(2, 2);
            this.uimaintabcontrol.SelectedTabPage = this.uitabpage_data;
            this.uimaintabcontrol.Size = new System.Drawing.Size(524, 390);
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Size = new System.Drawing.Size(518, 351);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Size = new System.Drawing.Size(518, 351);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.iNVUNIMEDBindingSource;
            this.uigridcontrol.Size = new System.Drawing.Size(518, 351);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_EMPRESA,
            this.colDS_UNIMED,
            this.colDS_SIMBOLO});
            this.uigridview.OptionsBehavior.Editable = false;
            this.uigridview.OptionsBehavior.ReadOnly = true;
            this.uigridview.OptionsSelection.MultiSelect = true;
            this.uigridview.OptionsView.ColumnAutoWidth = false;
            this.uigridview.OptionsView.ShowAutoFilterRow = true;
            this.uigridview.OptionsView.ShowDetailButtons = false;
            // 
            // UINAV
            // 
            this.UINAV.Buttons.Append.Visible = false;
            this.UINAV.Buttons.CancelEdit.Visible = false;
            this.UINAV.Buttons.Edit.Visible = false;
            this.UINAV.Buttons.EndEdit.Visible = false;
            this.UINAV.Buttons.Remove.Visible = false;
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.UIDS_SIMBOLO);
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.UIDS_UNIMED);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl1);
            this.uipaneldata.Size = new System.Drawing.Size(518, 351);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            // 
            // iNVUNIMEDBindingSource
            // 
            this.iNVUNIMEDBindingSource.DataSource = typeof(InventarioDB.INV_UNIMED);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 53;
            // 
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            // 
            // colDS_UNIMED
            // 
            this.colDS_UNIMED.Caption = "Unidad de medida";
            this.colDS_UNIMED.FieldName = "DS_UNIMED";
            this.colDS_UNIMED.Name = "colDS_UNIMED";
            this.colDS_UNIMED.Visible = true;
            this.colDS_UNIMED.VisibleIndex = 1;
            this.colDS_UNIMED.Width = 248;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(107, 29);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(100, 20);
            this.UIID.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Unidad de medida";
            // 
            // UIDS_UNIMED
            // 
            this.UIDS_UNIMED.Location = new System.Drawing.Point(107, 76);
            this.UIDS_UNIMED.Name = "UIDS_UNIMED";
            this.UIDS_UNIMED.Properties.MaxLength = 100;
            this.UIDS_UNIMED.Size = new System.Drawing.Size(176, 20);
            this.UIDS_UNIMED.TabIndex = 3;
            // 
            // UIDS_SIMBOLO
            // 
            this.UIDS_SIMBOLO.Location = new System.Drawing.Point(107, 120);
            this.UIDS_SIMBOLO.Name = "UIDS_SIMBOLO";
            this.UIDS_SIMBOLO.Properties.MaxLength = 3;
            this.UIDS_SIMBOLO.Size = new System.Drawing.Size(53, 20);
            this.UIDS_SIMBOLO.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(65, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Simbolo";
            // 
            // colDS_SIMBOLO
            // 
            this.colDS_SIMBOLO.Caption = "Simbolo";
            this.colDS_SIMBOLO.FieldName = "DS_SIMBOLO";
            this.colDS_SIMBOLO.Name = "colDS_SIMBOLO";
            this.colDS_SIMBOLO.Visible = true;
            this.colDS_SIMBOLO.VisibleIndex = 2;
            this.colDS_SIMBOLO.Width = 128;
            // 
            // frm_unimed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Name = "frm_unimed";
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
            ((System.ComponentModel.ISupportInitialize)(this.iNVUNIMEDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_UNIMED.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_SIMBOLO.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource iNVUNIMEDBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UNIMED;
        private DevExpress.XtraEditors.TextEdit UIDS_UNIMED;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit UIDS_SIMBOLO;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_SIMBOLO;
    }
}
