namespace winCont.Formularios
{
    partial class MasterForm_Seleccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_GRP_SELEC = new DevExpress.XtraEditors.GroupControl();
            this.UIGRIDCONTROL = new DevExpress.XtraGrid.GridControl();
            this.UIGRIDVIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).BeginInit();
            this.UI_GRP_SELEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_GRP_SELEC
            // 
            this.UI_GRP_SELEC.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.UI_GRP_SELEC.Appearance.Options.UseFont = true;
            this.UI_GRP_SELEC.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UI_GRP_SELEC.AppearanceCaption.Options.UseFont = true;
            this.UI_GRP_SELEC.Controls.Add(this.UIGRIDCONTROL);
            this.UI_GRP_SELEC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UI_GRP_SELEC.Location = new System.Drawing.Point(0, 0);
            this.UI_GRP_SELEC.Name = "UI_GRP_SELEC";
            this.UI_GRP_SELEC.Size = new System.Drawing.Size(562, 350);
            this.UI_GRP_SELEC.TabIndex = 0;
            this.UI_GRP_SELEC.Text = "Seleccione";
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIGRIDCONTROL.Location = new System.Drawing.Point(2, 41);
            this.UIGRIDCONTROL.MainView = this.UIGRIDVIEW;
            this.UIGRIDCONTROL.Name = "UIGRIDCONTROL";
            this.UIGRIDCONTROL.Size = new System.Drawing.Size(558, 307);
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
            this.UIGRIDVIEW.OptionsView.ShowGroupPanel = false;
            // 
            // MasterForm_Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 350);
            this.Controls.Add(this.UI_GRP_SELEC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterForm_Seleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterForm_Seleccion";
            ((System.ComponentModel.ISupportInitialize)(this.UI_GRP_SELEC)).EndInit();
            this.UI_GRP_SELEC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.GroupControl UI_GRP_SELEC;
        public DevExpress.XtraGrid.GridControl UIGRIDCONTROL;
        public DevExpress.XtraGrid.Views.Grid.GridView UIGRIDVIEW;

    }
}