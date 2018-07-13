namespace winCont.Formularios.Configuracion
{
    partial class frm_talonario
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.UIID = new DevExpress.XtraEditors.TextEdit();
            this.UI_CD_SERIE = new DevExpress.XtraEditors.TextEdit();
            this.UI_NM_INICIAL = new DevExpress.XtraEditors.TextEdit();
            this.UI_NM_ACTUAL = new DevExpress.XtraEditors.TextEdit();
            this.UI_NM_FINAL = new DevExpress.XtraEditors.TextEdit();
            this.UI_DOCUMENTO = new DevExpress.XtraEditors.LookUpEdit();
            this.sISDOCUMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UI_UBICACION = new DevExpress.XtraEditors.LookUpEdit();
            this.sISUBICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsGenericaParesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UI_CD_ESTADO = new DevExpress.XtraEditors.LookUpEdit();
            this.sISPERIODOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSISTALONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCD_SERIE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_INICIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_ACTUAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_FINAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_UBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.UI_CD_SERIE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NM_INICIAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NM_ACTUAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NM_FINAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_DOCUMENTO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISDOCUMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_UBICACION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISUBICACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_CD_ESTADO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISPERIODOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISTALONARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.Size = new System.Drawing.Size(644, 475);
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Size = new System.Drawing.Size(581, 469);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Size = new System.Drawing.Size(581, 469);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.vSISTALONARIOBindingSource;
            this.uigridcontrol.Size = new System.Drawing.Size(581, 469);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCD_SERIE,
            this.colNM_INICIAL,
            this.colNM_ACTUAL,
            this.colNM_FINAL,
            this.colCD_ESTADO,
            this.colDS_DOCUMENTO,
            this.colDS_UBICACION,
            this.colID});
            this.uigridview.OptionsBehavior.Editable = false;
            this.uigridview.OptionsBehavior.ReadOnly = true;
            this.uigridview.OptionsView.ShowAutoFilterRow = true;
            this.uigridview.OptionsView.ShowDetailButtons = false;
            this.uigridview.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCD_ESTADO, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // UINAV
            // 
            this.UINAV.Buttons.Append.Visible = false;
            this.UINAV.Buttons.CancelEdit.Visible = false;
            this.UINAV.Buttons.Edit.Visible = false;
            this.UINAV.Buttons.EndEdit.Visible = false;
            this.UINAV.Buttons.Remove.Visible = false;
            this.UINAV.Location = new System.Drawing.Point(2, 452);
            this.UINAV.Size = new System.Drawing.Size(644, 25);
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.UI_UBICACION);
            this.uipaneldata.Controls.Add(this.UI_DOCUMENTO);
            this.uipaneldata.Controls.Add(this.UI_NM_FINAL);
            this.uipaneldata.Controls.Add(this.UI_NM_ACTUAL);
            this.uipaneldata.Controls.Add(this.UI_NM_INICIAL);
            this.uipaneldata.Controls.Add(this.UI_CD_SERIE);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl8);
            this.uipaneldata.Controls.Add(this.labelControl7);
            this.uipaneldata.Controls.Add(this.labelControl6);
            this.uipaneldata.Controls.Add(this.labelControl5);
            this.uipaneldata.Controls.Add(this.labelControl4);
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.labelControl1);
            this.uipaneldata.Controls.Add(this.UI_CD_ESTADO);
            this.uipaneldata.Size = new System.Drawing.Size(581, 469);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.uilbl_opcion.Size = new System.Drawing.Size(648, 34);
            this.uilbl_opcion.Text = "Talonario";
            // 
            // uicontenedor
            // 
            this.uicontenedor.Size = new System.Drawing.Size(648, 479);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(115, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(49, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tipo Documento";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(58, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tipo Ubicacion";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(55, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Serie Talonario";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(59, 185);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Numero Inicial";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(56, 219);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Numero Actual";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(64, 252);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Numero Final";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(93, 281);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(33, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Estado";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(143, 51);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(101, 20);
            this.UIID.TabIndex = 8;
            // 
            // UI_CD_SERIE
            // 
            this.UI_CD_SERIE.Location = new System.Drawing.Point(143, 149);
            this.UI_CD_SERIE.Name = "UI_CD_SERIE";
            this.UI_CD_SERIE.Properties.MaxLength = 10;
            this.UI_CD_SERIE.Size = new System.Drawing.Size(185, 20);
            this.UI_CD_SERIE.TabIndex = 9;
            // 
            // UI_NM_INICIAL
            // 
            this.UI_NM_INICIAL.Location = new System.Drawing.Point(143, 182);
            this.UI_NM_INICIAL.Name = "UI_NM_INICIAL";
            this.UI_NM_INICIAL.Properties.Mask.EditMask = "\\d+";
            this.UI_NM_INICIAL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.UI_NM_INICIAL.Size = new System.Drawing.Size(185, 20);
            this.UI_NM_INICIAL.TabIndex = 10;
            // 
            // UI_NM_ACTUAL
            // 
            this.UI_NM_ACTUAL.Location = new System.Drawing.Point(143, 216);
            this.UI_NM_ACTUAL.Name = "UI_NM_ACTUAL";
            this.UI_NM_ACTUAL.Properties.ReadOnly = true;
            this.UI_NM_ACTUAL.Size = new System.Drawing.Size(185, 20);
            this.UI_NM_ACTUAL.TabIndex = 11;
            // 
            // UI_NM_FINAL
            // 
            this.UI_NM_FINAL.Location = new System.Drawing.Point(143, 249);
            this.UI_NM_FINAL.Name = "UI_NM_FINAL";
            this.UI_NM_FINAL.Properties.Mask.EditMask = "\\d+";
            this.UI_NM_FINAL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.UI_NM_FINAL.Size = new System.Drawing.Size(185, 20);
            this.UI_NM_FINAL.TabIndex = 12;
            // 
            // UI_DOCUMENTO
            // 
            this.UI_DOCUMENTO.Location = new System.Drawing.Point(143, 84);
            this.UI_DOCUMENTO.Name = "UI_DOCUMENTO";
            this.UI_DOCUMENTO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UI_DOCUMENTO.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EMPRESA", "ID_EMPRESA", 73, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_DOCUMENTO", "Documento", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_TIPO_DOCUMENTO", "CD_TIPO_DOCUMENTO", 124, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EMPRESAS", "SIS_EMPRESAS", 84, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.UI_DOCUMENTO.Properties.DataSource = this.sISDOCUMENTOBindingSource;
            this.UI_DOCUMENTO.Properties.DisplayMember = "DS_DOCUMENTO";
            this.UI_DOCUMENTO.Properties.ValueMember = "ID";
            this.UI_DOCUMENTO.Size = new System.Drawing.Size(185, 20);
            this.UI_DOCUMENTO.TabIndex = 13;
            // 
            // sISDOCUMENTOBindingSource
            // 
            this.sISDOCUMENTOBindingSource.DataSource = typeof(Sistema.SIS_DOCUMENTO);
            // 
            // UI_UBICACION
            // 
            this.UI_UBICACION.Location = new System.Drawing.Point(143, 117);
            this.UI_UBICACION.Name = "UI_UBICACION";
            this.UI_UBICACION.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UI_UBICACION.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EMPRESA", "ID_EMPRESA", 73, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_UBICACION", "Ubicacion", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_TIPO_UBICACION", "CD_TIPO_UBICACION", 117, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EMPRESAS", "SIS_EMPRESAS", 84, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.UI_UBICACION.Properties.DataSource = this.sISUBICACIONBindingSource;
            this.UI_UBICACION.Properties.DisplayMember = "DS_UBICACION";
            this.UI_UBICACION.Properties.ValueMember = "ID";
            this.UI_UBICACION.Size = new System.Drawing.Size(185, 20);
            this.UI_UBICACION.TabIndex = 14;
            // 
            // sISUBICACIONBindingSource
            // 
            this.sISUBICACIONBindingSource.DataSource = typeof(Sistema.SIS_UBICACION);
            // 
            // clsGenericaParesBindingSource
            // 
            this.clsGenericaParesBindingSource.DataSource = typeof(winCont.Clases.clsGenericaPares);
            // 
            // UI_CD_ESTADO
            // 
            this.UI_CD_ESTADO.Location = new System.Drawing.Point(143, 278);
            this.UI_CD_ESTADO.Name = "UI_CD_ESTADO";
            this.UI_CD_ESTADO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.UI_CD_ESTADO.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UI_CD_ESTADO.Properties.DataSource = this.clsGenericaParesBindingSource;
            this.UI_CD_ESTADO.Properties.DisplayMember = "descripcion";
            this.UI_CD_ESTADO.Properties.ReadOnly = true;
            this.UI_CD_ESTADO.Properties.ValueMember = "id";
            this.UI_CD_ESTADO.Size = new System.Drawing.Size(185, 20);
            this.UI_CD_ESTADO.TabIndex = 15;
            // 
            // sISPERIODOBindingSource
            // 
            this.sISPERIODOBindingSource.DataSource = typeof(Sistema.SIS_PERIODO);
            // 
            // vSISTALONARIOBindingSource
            // 
            this.vSISTALONARIOBindingSource.DataSource = typeof(Sistema.V_SIS_TALONARIO);
            // 
            // colCD_SERIE
            // 
            this.colCD_SERIE.Caption = "Serie";
            this.colCD_SERIE.FieldName = "CD_SERIE";
            this.colCD_SERIE.Name = "colCD_SERIE";
            this.colCD_SERIE.Visible = true;
            this.colCD_SERIE.VisibleIndex = 1;
            this.colCD_SERIE.Width = 136;
            // 
            // colNM_INICIAL
            // 
            this.colNM_INICIAL.Caption = "Numero Inicial";
            this.colNM_INICIAL.FieldName = "NM_INICIAL";
            this.colNM_INICIAL.Name = "colNM_INICIAL";
            this.colNM_INICIAL.Visible = true;
            this.colNM_INICIAL.VisibleIndex = 4;
            this.colNM_INICIAL.Width = 110;
            // 
            // colNM_ACTUAL
            // 
            this.colNM_ACTUAL.Caption = "Numero Actual";
            this.colNM_ACTUAL.FieldName = "NM_ACTUAL";
            this.colNM_ACTUAL.Name = "colNM_ACTUAL";
            this.colNM_ACTUAL.Visible = true;
            this.colNM_ACTUAL.VisibleIndex = 5;
            this.colNM_ACTUAL.Width = 102;
            // 
            // colNM_FINAL
            // 
            this.colNM_FINAL.Caption = "Numero Final";
            this.colNM_FINAL.FieldName = "NM_FINAL";
            this.colNM_FINAL.Name = "colNM_FINAL";
            this.colNM_FINAL.Visible = true;
            this.colNM_FINAL.VisibleIndex = 6;
            this.colNM_FINAL.Width = 105;
            // 
            // colCD_ESTADO
            // 
            this.colCD_ESTADO.Caption = "Estado";
            this.colCD_ESTADO.FieldName = "CD_ESTADO";
            this.colCD_ESTADO.Name = "colCD_ESTADO";
            this.colCD_ESTADO.Visible = true;
            this.colCD_ESTADO.VisibleIndex = 7;
            this.colCD_ESTADO.Width = 245;
            // 
            // colDS_DOCUMENTO
            // 
            this.colDS_DOCUMENTO.Caption = "Documento";
            this.colDS_DOCUMENTO.FieldName = "DS_DOCUMENTO";
            this.colDS_DOCUMENTO.Name = "colDS_DOCUMENTO";
            this.colDS_DOCUMENTO.Visible = true;
            this.colDS_DOCUMENTO.VisibleIndex = 2;
            this.colDS_DOCUMENTO.Width = 139;
            // 
            // colDS_UBICACION
            // 
            this.colDS_UBICACION.Caption = "Ubicacion";
            this.colDS_UBICACION.FieldName = "DS_UBICACION";
            this.colDS_UBICACION.Name = "colDS_UBICACION";
            this.colDS_UBICACION.Visible = true;
            this.colDS_UBICACION.VisibleIndex = 3;
            this.colDS_UBICACION.Width = 150;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 68;
            // 
            // frm_talonario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(648, 513);
            this.Name = "frm_talonario";
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
            ((System.ComponentModel.ISupportInitialize)(this.UI_CD_SERIE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NM_INICIAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NM_ACTUAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NM_FINAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_DOCUMENTO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISDOCUMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_UBICACION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISUBICACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_CD_ESTADO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISPERIODOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISTALONARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit UI_NM_FINAL;
        private DevExpress.XtraEditors.TextEdit UI_NM_ACTUAL;
        private DevExpress.XtraEditors.TextEdit UI_NM_INICIAL;
        private DevExpress.XtraEditors.TextEdit UI_CD_SERIE;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LookUpEdit UI_UBICACION;
        private DevExpress.XtraEditors.LookUpEdit UI_DOCUMENTO;
        private DevExpress.XtraEditors.LookUpEdit UI_CD_ESTADO;
        private System.Windows.Forms.BindingSource clsGenericaParesBindingSource;
        private System.Windows.Forms.BindingSource sISDOCUMENTOBindingSource;
        private System.Windows.Forms.BindingSource sISUBICACIONBindingSource;
        private System.Windows.Forms.BindingSource sISPERIODOBindingSource;
        private System.Windows.Forms.BindingSource vSISTALONARIOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_SERIE;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_INICIAL;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_ACTUAL;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_FINAL;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_ESTADO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_UBICACION;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
    }
}
