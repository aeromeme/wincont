namespace winCont.Formularios
{
    partial class MasterFormTab
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
            this.uimaintabcontrol = new DevExpress.XtraTab.XtraTabControl();
            this.uitabpage_data = new DevExpress.XtraTab.XtraTabPage();
            this.uipaneldata = new DevExpress.XtraEditors.PanelControl();
            this.uitabpage_datalist = new DevExpress.XtraTab.XtraTabPage();
            this.uigridcontrol = new DevExpress.XtraGrid.GridControl();
            this.uigridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.uidialogogrid = new System.Windows.Forms.SaveFileDialog();
            this.uimenugrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UINAV = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uimaintabcontrol)).BeginInit();
            this.uimaintabcontrol.SuspendLayout();
            this.uitabpage_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipaneldata)).BeginInit();
            this.uitabpage_datalist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uigridcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uigridview)).BeginInit();
            this.uimenugrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.uimaintabcontrol);
            this.uicontenedor.Margin = new System.Windows.Forms.Padding(3);
            this.uicontenedor.Size = new System.Drawing.Size(792, 621);
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uimaintabcontrol.Location = new System.Drawing.Point(2, 2);
            this.uimaintabcontrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uimaintabcontrol.Name = "uimaintabcontrol";
            this.uimaintabcontrol.SelectedTabPage = this.uitabpage_data;
            this.uimaintabcontrol.Size = new System.Drawing.Size(788, 617);
            this.uimaintabcontrol.TabIndex = 0;
            this.uimaintabcontrol.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.uitabpage_data,
            this.uitabpage_datalist});
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Controls.Add(this.uipaneldata);
            this.uitabpage_data.Image = global::winCont.Properties.Resources.document_24;
            this.uitabpage_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitabpage_data.Name = "uitabpage_data";
            this.uitabpage_data.Size = new System.Drawing.Size(782, 578);
            this.uitabpage_data.Text = "Datos";
            this.uitabpage_data.Tooltip = "Informacion del registro";
            // 
            // uipaneldata
            // 
            this.uipaneldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uipaneldata.Location = new System.Drawing.Point(0, 0);
            this.uipaneldata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uipaneldata.Name = "uipaneldata";
            this.uipaneldata.Size = new System.Drawing.Size(782, 578);
            this.uipaneldata.TabIndex = 0;
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Controls.Add(this.uigridcontrol);
            this.uitabpage_datalist.Image = global::winCont.Properties.Resources.data_sheet_24;
            this.uitabpage_datalist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uitabpage_datalist.Name = "uitabpage_datalist";
            this.uitabpage_datalist.Size = new System.Drawing.Size(782, 578);
            this.uitabpage_datalist.Text = "Detalle";
            this.uitabpage_datalist.Tooltip = "Listado de registros";
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uigridcontrol.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uigridcontrol.Location = new System.Drawing.Point(0, 0);
            this.uigridcontrol.MainView = this.uigridview;
            this.uigridcontrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uigridcontrol.Name = "uigridcontrol";
            this.uigridcontrol.Size = new System.Drawing.Size(782, 578);
            this.uigridcontrol.TabIndex = 0;
            this.uigridcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.uigridview});
            // 
            // uigridview
            // 
            this.uigridview.GridControl = this.uigridcontrol;
            this.uigridview.Name = "uigridview";
            this.uigridview.OptionsBehavior.Editable = false;
            this.uigridview.OptionsBehavior.ReadOnly = true;
            this.uigridview.OptionsSelection.MultiSelect = true;
            this.uigridview.OptionsView.ColumnAutoWidth = false;
            this.uigridview.OptionsView.ShowAutoFilterRow = true;
            this.uigridview.OptionsView.ShowDetailButtons = false;
            this.uigridview.DoubleClick += new System.EventHandler(this.uigridview_DoubleClick);
            // 
            // uidialogogrid
            // 
            this.uidialogogrid.Filter = "Archivos Excel | *.xlsx";
            // 
            // uimenugrid
            // 
            this.uimenugrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelToolStripMenuItem});
            this.uimenugrid.Name = "uimenugrid";
            this.uimenugrid.Size = new System.Drawing.Size(208, 34);
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click);
            // 
            // UINAV
            // 
            this.UINAV.Buttons.Append.Visible = false;
            this.UINAV.Buttons.CancelEdit.Visible = false;
            this.UINAV.Buttons.Edit.Visible = false;
            this.UINAV.Buttons.EndEdit.Visible = false;
            this.UINAV.Buttons.Remove.Visible = false;
            this.UINAV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UINAV.Location = new System.Drawing.Point(0, 673);
            this.UINAV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UINAV.Name = "UINAV";
            this.UINAV.NavigatableControl = this.uigridcontrol;
            this.UINAV.Size = new System.Drawing.Size(792, 38);
            this.UINAV.TabIndex = 2;
            this.UINAV.Text = "ControlNavigator1";
            this.UINAV.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            // 
            // MasterFormTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(792, 711);
            this.Controls.Add(this.UINAV);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "MasterFormTab";
            this.Load += new System.EventHandler(this.MasterFormTab_Load);
            this.Controls.SetChildIndex(this.uilbl_opcion, 0);
            this.Controls.SetChildIndex(this.UINAV, 0);
            this.Controls.SetChildIndex(this.uicontenedor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uimaintabcontrol)).EndInit();
            this.uimaintabcontrol.ResumeLayout(false);
            this.uitabpage_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipaneldata)).EndInit();
            this.uitabpage_datalist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uigridcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uigridview)).EndInit();
            this.uimenugrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTab.XtraTabControl uimaintabcontrol;
        public DevExpress.XtraTab.XtraTabPage uitabpage_datalist;
        public DevExpress.XtraTab.XtraTabPage uitabpage_data;
        public DevExpress.XtraGrid.GridControl uigridcontrol;
        public DevExpress.XtraGrid.Views.Grid.GridView uigridview;
        private System.Windows.Forms.SaveFileDialog uidialogogrid;
        private System.Windows.Forms.ContextMenuStrip uimenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        public DevExpress.XtraEditors.ControlNavigator UINAV;
        public DevExpress.XtraEditors.PanelControl uipaneldata;

    }
}
