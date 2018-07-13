namespace winCont.Formularios.Configuracion
{
    partial class frm_documentos
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
            this.UIDS_DOCUMENTO = new DevExpress.XtraEditors.TextEdit();
            this.UICD_TIPO_DOC = new DevExpress.XtraEditors.LookUpEdit();
            this.clsGenericaParesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSISUSEREMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISDOCUMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISDOCUMENTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_TIPO_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_DOCUMENTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_TIPO_DOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISUSEREMPRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISDOCUMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISDOCUMENTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.Location = new System.Drawing.Point(2, 2);
            this.uimaintabcontrol.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uimaintabcontrol.Size = new System.Drawing.Size(1001, 655);
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uitabpage_datalist.Size = new System.Drawing.Size(938, 649);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uitabpage_data.Size = new System.Drawing.Size(938, 649);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.sISDOCUMENTOBindingSource1;
            this.uigridcontrol.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uigridcontrol.Size = new System.Drawing.Size(938, 649);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDS_DOCUMENTO,
            this.colCD_TIPO_DOCUMENTO});
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
            this.UINAV.Location = new System.Drawing.Point(2, 619);
            this.UINAV.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.UINAV.Size = new System.Drawing.Size(1001, 38);
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.UICD_TIPO_DOC);
            this.uipaneldata.Controls.Add(this.UIDS_DOCUMENTO);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.labelControl1);
            this.uipaneldata.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uipaneldata.Size = new System.Drawing.Size(938, 649);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.uilbl_opcion.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uilbl_opcion.Size = new System.Drawing.Size(1005, 52);
            // 
            // uicontenedor
            // 
            this.uicontenedor.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uicontenedor.Size = new System.Drawing.Size(1005, 659);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(129, 58);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(64, 109);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Documento";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 165);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(118, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tipo Documento";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(170, 54);
            this.UIID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(170, 26);
            this.UIID.TabIndex = 3;
            // 
            // UIDS_DOCUMENTO
            // 
            this.UIDS_DOCUMENTO.Location = new System.Drawing.Point(170, 105);
            this.UIDS_DOCUMENTO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UIDS_DOCUMENTO.Name = "UIDS_DOCUMENTO";
            this.UIDS_DOCUMENTO.Properties.MaxLength = 100;
            this.UIDS_DOCUMENTO.Size = new System.Drawing.Size(370, 26);
            this.UIDS_DOCUMENTO.TabIndex = 4;
            // 
            // UICD_TIPO_DOC
            // 
            this.UICD_TIPO_DOC.Location = new System.Drawing.Point(170, 160);
            this.UICD_TIPO_DOC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UICD_TIPO_DOC.Name = "UICD_TIPO_DOC";
            this.UICD_TIPO_DOC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UICD_TIPO_DOC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Tipo Documento", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UICD_TIPO_DOC.Properties.DataSource = this.clsGenericaParesBindingSource;
            this.UICD_TIPO_DOC.Properties.DisplayMember = "descripcion";
            this.UICD_TIPO_DOC.Properties.ValueMember = "id";
            this.UICD_TIPO_DOC.Size = new System.Drawing.Size(210, 26);
            this.UICD_TIPO_DOC.TabIndex = 5;
            // 
            // clsGenericaParesBindingSource
            // 
            this.clsGenericaParesBindingSource.DataSource = typeof(winCont.Clases.clsGenericaPares);
            // 
            // vSISUSEREMPRESABindingSource
            // 
            this.vSISUSEREMPRESABindingSource.DataSource = typeof(Sistema.V_SIS_USER_EMPRESA);
            // 
            // sISDOCUMENTOBindingSource
            // 
            this.sISDOCUMENTOBindingSource.DataSource = typeof(Sistema.SIS_DOCUMENTO);
            // 
            // sISDOCUMENTOBindingSource1
            // 
            this.sISDOCUMENTOBindingSource1.DataSource = typeof(Sistema.SIS_DOCUMENTO);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colDS_DOCUMENTO
            // 
            this.colDS_DOCUMENTO.Caption = "Nombre Documento";
            this.colDS_DOCUMENTO.FieldName = "DS_DOCUMENTO";
            this.colDS_DOCUMENTO.Name = "colDS_DOCUMENTO";
            this.colDS_DOCUMENTO.Visible = true;
            this.colDS_DOCUMENTO.VisibleIndex = 1;
            this.colDS_DOCUMENTO.Width = 380;
            // 
            // colCD_TIPO_DOCUMENTO
            // 
            this.colCD_TIPO_DOCUMENTO.Caption = "Tipo Documento";
            this.colCD_TIPO_DOCUMENTO.FieldName = "CD_TIPO_DOCUMENTO";
            this.colCD_TIPO_DOCUMENTO.Name = "colCD_TIPO_DOCUMENTO";
            this.colCD_TIPO_DOCUMENTO.Visible = true;
            this.colCD_TIPO_DOCUMENTO.VisibleIndex = 2;
            this.colCD_TIPO_DOCUMENTO.Width = 446;
            // 
            // frm_documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1005, 711);
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "frm_documentos";
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_DOCUMENTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_TIPO_DOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISUSEREMPRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISDOCUMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISDOCUMENTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit UICD_TIPO_DOC;
        private DevExpress.XtraEditors.TextEdit UIDS_DOCUMENTO;
        private DevExpress.XtraEditors.TextEdit UIID;
        private System.Windows.Forms.BindingSource clsGenericaParesBindingSource;
        private System.Windows.Forms.BindingSource sISDOCUMENTOBindingSource;
        private System.Windows.Forms.BindingSource vSISUSEREMPRESABindingSource;
        private System.Windows.Forms.BindingSource sISDOCUMENTOBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_TIPO_DOCUMENTO;
    }
}
