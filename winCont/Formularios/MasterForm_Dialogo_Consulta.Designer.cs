namespace winCont.Formularios
{
    partial class MasterForm_Dialogo_Consulta
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
            this.UIGRIDCONTROL = new DevExpress.XtraGrid.GridControl();
            this.UIGRIDVIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.UIGRIDCONTROL);
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIGRIDCONTROL.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UIGRIDCONTROL.Location = new System.Drawing.Point(2, 2);
            this.UIGRIDCONTROL.MainView = this.UIGRIDVIEW;
            this.UIGRIDCONTROL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UIGRIDCONTROL.Name = "UIGRIDCONTROL";
            this.UIGRIDCONTROL.Size = new System.Drawing.Size(610, 322);
            this.UIGRIDCONTROL.TabIndex = 1;
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
            this.UIGRIDVIEW.OptionsView.ShowGroupPanel = false;
            // 
            // MasterForm_Dialogo_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(614, 360);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MasterForm_Dialogo_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl UIGRIDCONTROL;
        public DevExpress.XtraGrid.Views.Grid.GridView UIGRIDVIEW;
    }
}
