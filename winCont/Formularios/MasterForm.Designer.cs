namespace winCont.Formularios
{
    partial class MasterForm
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
            this.uilbl_opcion = new DevExpress.XtraEditors.LabelControl();
            this.uicontenedor = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.uilbl_opcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.uilbl_opcion.Location = new System.Drawing.Point(0, 0);
            this.uilbl_opcion.Name = "uilbl_opcion";
            this.uilbl_opcion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.uilbl_opcion.Size = new System.Drawing.Size(528, 43);
            this.uilbl_opcion.TabIndex = 0;
            this.uilbl_opcion.Text = "labelControl1";
            // 
            // uicontenedor
            // 
            this.uicontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uicontenedor.Location = new System.Drawing.Point(0, 43);
            this.uicontenedor.Name = "uicontenedor";
            this.uicontenedor.Size = new System.Drawing.Size(528, 419);
            this.uicontenedor.TabIndex = 1;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Controls.Add(this.uicontenedor);
            this.Controls.Add(this.uilbl_opcion);
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.Activated += new System.EventHandler(this.MasterForm_Activated);
            this.Leave += new System.EventHandler(this.MasterForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl uilbl_opcion;
        public DevExpress.XtraEditors.PanelControl uicontenedor;

    }
}