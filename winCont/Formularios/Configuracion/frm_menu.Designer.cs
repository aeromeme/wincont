namespace winCont.Formularios.Configuracion
{
    partial class frm_menu
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
            this.sISMENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MENU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.UIID = new DevExpress.XtraEditors.TextEdit();
            this.UIDS_MENU = new DevExpress.XtraEditors.TextEdit();
            this.sISMENUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_MENU1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.sISMENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_MENU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISMENUBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uimaintabcontrol.SelectedTabPage = this.uitabpage_data;
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.sISMENUBindingSource1;
            this.uigridcontrol.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colDS_MENU1});
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
            this.UINAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.UIDS_MENU);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.labelControl1);
            this.uipaneldata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            // 
            // sISMENUBindingSource
            // 
            this.sISMENUBindingSource.DataSource = typeof(Sistema.SIS_MENU);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDS_MENU
            // 
            this.colDS_MENU.Caption = "Menu";
            this.colDS_MENU.FieldName = "DS_MENU";
            this.colDS_MENU.Name = "colDS_MENU";
            this.colDS_MENU.Visible = true;
            this.colDS_MENU.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Menu";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(61, 47);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(96, 20);
            this.UIID.TabIndex = 2;
            // 
            // UIDS_MENU
            // 
            this.UIDS_MENU.Location = new System.Drawing.Point(61, 81);
            this.UIDS_MENU.Name = "UIDS_MENU";
            this.UIDS_MENU.Properties.MaxLength = 100;
            this.UIDS_MENU.Size = new System.Drawing.Size(227, 20);
            this.UIDS_MENU.TabIndex = 3;
            // 
            // sISMENUBindingSource1
            // 
            this.sISMENUBindingSource1.DataSource = typeof(Sistema.SIS_MENU);
            // 
            // colID1
            // 
            this.colID1.Caption = "ID";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 251;
            // 
            // colDS_MENU1
            // 
            this.colDS_MENU1.Caption = "Menu";
            this.colDS_MENU1.FieldName = "DS_MENU";
            this.colDS_MENU1.Name = "colDS_MENU1";
            this.colDS_MENU1.Visible = true;
            this.colDS_MENU1.VisibleIndex = 1;
            this.colDS_MENU1.Width = 987;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frm_menu";
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
            ((System.ComponentModel.ISupportInitialize)(this.sISMENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_MENU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISMENUBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sISMENUBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MENU;
        private DevExpress.XtraEditors.TextEdit UIDS_MENU;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource sISMENUBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MENU1;
    }
}
