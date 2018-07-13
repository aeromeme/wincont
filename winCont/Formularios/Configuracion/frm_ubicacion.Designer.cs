namespace winCont.Formularios.Configuracion
{
    partial class frm_ubicacion
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
            this.UIDS_UBICACION = new DevExpress.XtraEditors.TextEdit();
            this.UICD_TIPO_UBICA = new DevExpress.XtraEditors.LookUpEdit();
            this.clsGenericaParesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISUBICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_TIPO_UBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_UBICACION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_TIPO_UBICA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISUBICACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.Margin = new System.Windows.Forms.Padding(2);
            this.uimaintabcontrol.Size = new System.Drawing.Size(616, 424);
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Margin = new System.Windows.Forms.Padding(2);
            this.uitabpage_datalist.Size = new System.Drawing.Size(553, 418);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Margin = new System.Windows.Forms.Padding(2);
            this.uitabpage_data.Size = new System.Drawing.Size(553, 418);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.sISUBICACIONBindingSource;
            this.uigridcontrol.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.uigridcontrol.Margin = new System.Windows.Forms.Padding(2);
            this.uigridcontrol.Size = new System.Drawing.Size(553, 418);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDS_UBICACION,
            this.colCD_TIPO_UBICACION});
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
            this.UINAV.Size = new System.Drawing.Size(616, 25);
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.UICD_TIPO_UBICA);
            this.uipaneldata.Controls.Add(this.UIDS_UBICACION);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.labelControl1);
            this.uipaneldata.Margin = new System.Windows.Forms.Padding(2);
            this.uipaneldata.Size = new System.Drawing.Size(553, 418);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.uilbl_opcion.Margin = new System.Windows.Forms.Padding(2);
            this.uilbl_opcion.Size = new System.Drawing.Size(620, 34);
            // 
            // uicontenedor
            // 
            this.uicontenedor.Margin = new System.Windows.Forms.Padding(2);
            this.uicontenedor.Size = new System.Drawing.Size(620, 428);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(81, 45);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 77);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ubicacion";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 109);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tipo Ubicacion";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(107, 44);
            this.UIID.Margin = new System.Windows.Forms.Padding(2);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(99, 20);
            this.UIID.TabIndex = 3;
            // 
            // UIDS_UBICACION
            // 
            this.UIDS_UBICACION.Location = new System.Drawing.Point(107, 75);
            this.UIDS_UBICACION.Margin = new System.Windows.Forms.Padding(2);
            this.UIDS_UBICACION.Name = "UIDS_UBICACION";
            this.UIDS_UBICACION.Properties.MaxLength = 50;
            this.UIDS_UBICACION.Size = new System.Drawing.Size(273, 20);
            this.UIDS_UBICACION.TabIndex = 4;
            // 
            // UICD_TIPO_UBICA
            // 
            this.UICD_TIPO_UBICA.Location = new System.Drawing.Point(107, 105);
            this.UICD_TIPO_UBICA.Margin = new System.Windows.Forms.Padding(2);
            this.UICD_TIPO_UBICA.Name = "UICD_TIPO_UBICA";
            this.UICD_TIPO_UBICA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UICD_TIPO_UBICA.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 36, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Tipo Ubicacion", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UICD_TIPO_UBICA.Properties.DataSource = this.clsGenericaParesBindingSource;
            this.UICD_TIPO_UBICA.Properties.DisplayMember = "descripcion";
            this.UICD_TIPO_UBICA.Properties.ValueMember = "id";
            this.UICD_TIPO_UBICA.Size = new System.Drawing.Size(143, 20);
            this.UICD_TIPO_UBICA.TabIndex = 5;
            // 
            // clsGenericaParesBindingSource
            // 
            this.clsGenericaParesBindingSource.DataSource = typeof(winCont.Clases.clsGenericaPares);
            // 
            // sISUBICACIONBindingSource
            // 
            this.sISUBICACIONBindingSource.DataSource = typeof(Sistema.SIS_UBICACION);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 115;
            // 
            // colDS_UBICACION
            // 
            this.colDS_UBICACION.Caption = "Ubicacion";
            this.colDS_UBICACION.FieldName = "DS_UBICACION";
            this.colDS_UBICACION.Name = "colDS_UBICACION";
            this.colDS_UBICACION.Visible = true;
            this.colDS_UBICACION.VisibleIndex = 1;
            this.colDS_UBICACION.Width = 355;
            // 
            // colCD_TIPO_UBICACION
            // 
            this.colCD_TIPO_UBICACION.Caption = "Tipo Ubicacion";
            this.colCD_TIPO_UBICACION.FieldName = "CD_TIPO_UBICACION";
            this.colCD_TIPO_UBICACION.Name = "colCD_TIPO_UBICACION";
            this.colCD_TIPO_UBICACION.Visible = true;
            this.colCD_TIPO_UBICACION.VisibleIndex = 2;
            this.colCD_TIPO_UBICACION.Width = 375;
            // 
            // frm_ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(620, 462);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frm_ubicacion";
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_UBICACION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_TIPO_UBICA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISUBICACIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit UICD_TIPO_UBICA;
        private System.Windows.Forms.BindingSource clsGenericaParesBindingSource;
        private DevExpress.XtraEditors.TextEdit UIDS_UBICACION;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource sISUBICACIONBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UBICACION;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_TIPO_UBICACION;
    }
}
