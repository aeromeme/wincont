namespace winCont.Formularios.Contabilidad
{
    partial class frm_rubros
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
            this.UIDS_RUBRO = new DevExpress.XtraEditors.TextEdit();
            this.cONTRUBROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_RUBRO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UICD_RUBRO_BASE = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.colCD_RUBRO_BASE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clsGenericaParesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_RUBRO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRUBROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_RUBRO_BASE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.SelectedTabPage = this.uitabpage_data;
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Margin = new System.Windows.Forms.Padding(2);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Margin = new System.Windows.Forms.Padding(2);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.cONTRUBROSBindingSource;
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDS_RUBRO,
            this.colCD_RUBRO_BASE,
            this.colID_EMPRESA});
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
            this.UINAV.Margin = new System.Windows.Forms.Padding(2);
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.UICD_RUBRO_BASE);
            this.uipaneldata.Controls.Add(this.UIDS_RUBRO);
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
            this.labelControl1.Location = new System.Drawing.Point(67, 53);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 87);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Descripcion";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(99, 51);
            this.UIID.Margin = new System.Windows.Forms.Padding(2);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(105, 20);
            this.UIID.TabIndex = 2;
            // 
            // UIDS_RUBRO
            // 
            this.UIDS_RUBRO.Location = new System.Drawing.Point(99, 85);
            this.UIDS_RUBRO.Margin = new System.Windows.Forms.Padding(2);
            this.UIDS_RUBRO.Name = "UIDS_RUBRO";
            this.UIDS_RUBRO.Properties.MaxLength = 50;
            this.UIDS_RUBRO.Size = new System.Drawing.Size(204, 20);
            this.UIDS_RUBRO.TabIndex = 3;
            // 
            // cONTRUBROSBindingSource
            // 
            this.cONTRUBROSBindingSource.DataSource = typeof(ContabilidadDB.CONT_RUBROS);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDS_RUBRO
            // 
            this.colDS_RUBRO.Caption = "Descripcion";
            this.colDS_RUBRO.FieldName = "DS_RUBRO";
            this.colDS_RUBRO.Name = "colDS_RUBRO";
            this.colDS_RUBRO.Visible = true;
            this.colDS_RUBRO.VisibleIndex = 1;
            // 
            // UICD_RUBRO_BASE
            // 
            this.UICD_RUBRO_BASE.Location = new System.Drawing.Point(99, 122);
            this.UICD_RUBRO_BASE.Name = "UICD_RUBRO_BASE";
            this.UICD_RUBRO_BASE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UICD_RUBRO_BASE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Nombre1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Base")});
            this.UICD_RUBRO_BASE.Properties.DataSource = this.clsGenericaParesBindingSource;
            this.UICD_RUBRO_BASE.Properties.DisplayMember = "descripcion";
            this.UICD_RUBRO_BASE.Properties.ValueMember = "id";
            this.UICD_RUBRO_BASE.Size = new System.Drawing.Size(204, 20);
            this.UICD_RUBRO_BASE.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Base";
            // 
            // colCD_RUBRO_BASE
            // 
            this.colCD_RUBRO_BASE.FieldName = "CD_RUBRO_BASE";
            this.colCD_RUBRO_BASE.Name = "colCD_RUBRO_BASE";
            // 
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            // 
            // clsGenericaParesBindingSource
            // 
            this.clsGenericaParesBindingSource.DataSource = typeof(winCont.Clases.clsGenericaPares);
            // 
            // frm_rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frm_rubros";
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_RUBRO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRUBROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_RUBRO_BASE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit UIDS_RUBRO;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource cONTRUBROSBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_RUBRO;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit UICD_RUBRO_BASE;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_RUBRO_BASE;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private System.Windows.Forms.BindingSource clsGenericaParesBindingSource;
    }
}
