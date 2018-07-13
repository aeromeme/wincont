namespace winCont.Formularios
{
    partial class MasterForm_Consulta
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
            this.UIGRIDCONTROL = new DevExpress.XtraGrid.GridControl();
            this.UIGRIDVIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.uimenugrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uidialogogrid = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            this.uimenugrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Size = new System.Drawing.Size(886, 42);
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.UIGRIDCONTROL);
            this.uicontenedor.Size = new System.Drawing.Size(886, 527);
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIGRIDCONTROL.Location = new System.Drawing.Point(2, 2);
            this.UIGRIDCONTROL.MainView = this.UIGRIDVIEW;
            this.UIGRIDCONTROL.Name = "UIGRIDCONTROL";
            this.UIGRIDCONTROL.Size = new System.Drawing.Size(882, 523);
            this.UIGRIDCONTROL.TabIndex = 0;
            this.UIGRIDCONTROL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UIGRIDVIEW});
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.GridControl = this.UIGRIDCONTROL;
            this.UIGRIDVIEW.Name = "UIGRIDVIEW";
            this.UIGRIDVIEW.OptionsBehavior.Editable = false;
            this.UIGRIDVIEW.OptionsBehavior.ReadOnly = true;
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            // 
            // uimenugrid
            // 
            this.uimenugrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelToolStripMenuItem});
            this.uimenugrid.Name = "uimenugrid";
            this.uimenugrid.Size = new System.Drawing.Size(185, 50);
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click);
            // 
            // uidialogogrid
            // 
            this.uidialogogrid.Filter = "Archivos Excel | *.xlsx";
            // 
            // MasterForm_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(886, 569);
            this.Name = "MasterForm_Consulta";
            this.Load += new System.EventHandler(this.MasterForm_Consulta_Load);
            this.Controls.SetChildIndex(this.uilbl_opcion, 0);
            this.Controls.SetChildIndex(this.uicontenedor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            this.uimenugrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip uimenugrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog uidialogogrid;
        public DevExpress.XtraGrid.GridControl UIGRIDCONTROL;
        public DevExpress.XtraGrid.Views.Grid.GridView UIGRIDVIEW;
    }
}
