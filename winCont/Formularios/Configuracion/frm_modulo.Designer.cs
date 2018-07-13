namespace winCont.Formularios.Configuracion
{
    partial class frm_modulo
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.UIID = new DevExpress.XtraEditors.TextEdit();
            this.UIDS_MODULO = new DevExpress.XtraEditors.TextEdit();
            this.clsImagenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UICD_IMAGEN_ICO = new DevExpress.XtraEditors.GridLookUpEdit();
            this.MARCOIMAGEN = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sISMODULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MODULO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_IMAGEN_ICO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_MODULO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsImagenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_IMAGEN_ICO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MARCOIMAGEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISMODULOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.sISMODULOBindingSource;
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colDS_MODULO,
            this.colCD_IMAGEN_ICO});
            this.uigridview.OptionsBehavior.Editable = false;
            this.uigridview.OptionsBehavior.ReadOnly = true;
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
            this.uipaneldata.Controls.Add(this.UICD_IMAGEN_ICO);
            this.uipaneldata.Controls.Add(this.UIDS_MODULO);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.labelControl1);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Modulo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Imagen";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(64, 40);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(100, 20);
            this.UIID.TabIndex = 4;
            // 
            // UIDS_MODULO
            // 
            this.UIDS_MODULO.Location = new System.Drawing.Point(64, 66);
            this.UIDS_MODULO.Name = "UIDS_MODULO";
            this.UIDS_MODULO.Properties.MaxLength = 100;
            this.UIDS_MODULO.Size = new System.Drawing.Size(258, 20);
            this.UIDS_MODULO.TabIndex = 5;
            // 
            // clsImagenBindingSource
            // 
            this.clsImagenBindingSource.DataSource = typeof(winCont.Clases.clsImagen);
            // 
            // UICD_IMAGEN_ICO
            // 
            this.UICD_IMAGEN_ICO.Location = new System.Drawing.Point(64, 92);
            this.UICD_IMAGEN_ICO.Name = "UICD_IMAGEN_ICO";
            this.UICD_IMAGEN_ICO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UICD_IMAGEN_ICO.Properties.DataSource = this.clsImagenBindingSource;
            this.UICD_IMAGEN_ICO.Properties.DisplayMember = "nombre";
            this.UICD_IMAGEN_ICO.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MARCOIMAGEN});
            this.UICD_IMAGEN_ICO.Properties.ValueMember = "id";
            this.UICD_IMAGEN_ICO.Properties.View = this.gridLookUpEdit1View;
            this.UICD_IMAGEN_ICO.Size = new System.Drawing.Size(257, 20);
            this.UICD_IMAGEN_ICO.TabIndex = 6;
            // 
            // MARCOIMAGEN
            // 
            this.MARCOIMAGEN.Name = "MARCOIMAGEN";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colimagen,
            this.colnombre});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colimagen
            // 
            this.colimagen.Caption = "Imagen";
            this.colimagen.ColumnEdit = this.MARCOIMAGEN;
            this.colimagen.FieldName = "imagen";
            this.colimagen.Name = "colimagen";
            this.colimagen.Visible = true;
            this.colimagen.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            // 
            // sISMODULOBindingSource
            // 
            this.sISMODULOBindingSource.DataSource = typeof(Sistema.SIS_MODULO);
            // 
            // colID1
            // 
            this.colID1.Caption = "ID";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 69;
            // 
            // colDS_MODULO
            // 
            this.colDS_MODULO.Caption = "Modulo";
            this.colDS_MODULO.FieldName = "DS_MODULO";
            this.colDS_MODULO.Name = "colDS_MODULO";
            this.colDS_MODULO.Visible = true;
            this.colDS_MODULO.VisibleIndex = 1;
            this.colDS_MODULO.Width = 374;
            // 
            // colCD_IMAGEN_ICO
            // 
            this.colCD_IMAGEN_ICO.FieldName = "CD_IMAGEN_ICO";
            this.colCD_IMAGEN_ICO.Name = "colCD_IMAGEN_ICO";
            // 
            // frm_modulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Name = "frm_modulo";
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_MODULO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsImagenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_IMAGEN_ICO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MARCOIMAGEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISMODULOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit UIDS_MODULO;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource clsImagenBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit UICD_IMAGEN_ICO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colimagen;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit MARCOIMAGEN;
        private System.Windows.Forms.BindingSource sISMODULOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MODULO;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_IMAGEN_ICO;
    }
}
