namespace winCont.Formularios.Contabilidad
{
    partial class frm_nivel_cuenta
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
            this.cONTNIVELCUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_NIVEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_CANT_CARACTERES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.UIID = new DevExpress.XtraEditors.TextEdit();
            this.UINM_NIVEL = new DevExpress.XtraEditors.SpinEdit();
            this.UINM_CANT_CARACTERES = new DevExpress.XtraEditors.SpinEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cONTNIVELCUENTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_NIVEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_CANT_CARACTERES.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.Location = new System.Drawing.Point(2, 2);
            this.uimaintabcontrol.Size = new System.Drawing.Size(524, 390);
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Size = new System.Drawing.Size(518, 351);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Size = new System.Drawing.Size(518, 351);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.cONTNIVELCUENTABindingSource;
            this.uigridcontrol.Size = new System.Drawing.Size(518, 351);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_EMPRESA,
            this.colNM_NIVEL,
            this.colNM_CANT_CARACTERES});
            this.uigridview.OptionsBehavior.Editable = false;
            this.uigridview.OptionsBehavior.ReadOnly = true;
            this.uigridview.OptionsSelection.MultiSelect = true;
            this.uigridview.OptionsView.ColumnAutoWidth = false;
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
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.UINM_CANT_CARACTERES);
            this.uipaneldata.Controls.Add(this.UINM_NIVEL);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.labelControl1);
            this.uipaneldata.Size = new System.Drawing.Size(518, 351);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            // 
            // cONTNIVELCUENTABindingSource
            // 
            this.cONTNIVELCUENTABindingSource.DataSource = typeof(ContabilidadDB.CONT_NIVEL_CUENTA);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 38;
            // 
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            // 
            // colNM_NIVEL
            // 
            this.colNM_NIVEL.Caption = "Nivel";
            this.colNM_NIVEL.FieldName = "NM_NIVEL";
            this.colNM_NIVEL.Name = "colNM_NIVEL";
            this.colNM_NIVEL.Visible = true;
            this.colNM_NIVEL.VisibleIndex = 1;
            this.colNM_NIVEL.Width = 110;
            // 
            // colNM_CANT_CARACTERES
            // 
            this.colNM_CANT_CARACTERES.Caption = "Caracteres";
            this.colNM_CANT_CARACTERES.FieldName = "NM_CANT_CARACTERES";
            this.colNM_CANT_CARACTERES.Name = "colNM_CANT_CARACTERES";
            this.colNM_CANT_CARACTERES.Visible = true;
            this.colNM_CANT_CARACTERES.VisibleIndex = 2;
            this.colNM_CANT_CARACTERES.Width = 98;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(86, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(74, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nivel";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Caracteres";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(107, 46);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(100, 20);
            this.UIID.TabIndex = 3;
            // 
            // UINM_NIVEL
            // 
            this.UINM_NIVEL.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UINM_NIVEL.Location = new System.Drawing.Point(107, 82);
            this.UINM_NIVEL.Name = "UINM_NIVEL";
            this.UINM_NIVEL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.UINM_NIVEL.Properties.MaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.UINM_NIVEL.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UINM_NIVEL.Properties.ReadOnly = true;
            this.UINM_NIVEL.Size = new System.Drawing.Size(100, 20);
            this.UINM_NIVEL.TabIndex = 4;
            // 
            // UINM_CANT_CARACTERES
            // 
            this.UINM_CANT_CARACTERES.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UINM_CANT_CARACTERES.Location = new System.Drawing.Point(107, 117);
            this.UINM_CANT_CARACTERES.Name = "UINM_CANT_CARACTERES";
            this.UINM_CANT_CARACTERES.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UINM_CANT_CARACTERES.Properties.MaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.UINM_CANT_CARACTERES.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UINM_CANT_CARACTERES.Size = new System.Drawing.Size(100, 20);
            this.UINM_CANT_CARACTERES.TabIndex = 5;
            // 
            // frm_nivel_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Name = "frm_nivel_cuenta";
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
            ((System.ComponentModel.ISupportInitialize)(this.cONTNIVELCUENTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_NIVEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_CANT_CARACTERES.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cONTNIVELCUENTABindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_NIVEL;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_CANT_CARACTERES;
        private DevExpress.XtraEditors.SpinEdit UINM_CANT_CARACTERES;
        private DevExpress.XtraEditors.SpinEdit UINM_NIVEL;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
