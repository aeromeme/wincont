namespace winCont.Formularios.Configuracion
{
    partial class frm_forma_pago
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
            this.UIDS_FORMA_PAGO = new DevExpress.XtraEditors.TextEdit();
            this.UINM_DIAS_PLAZO = new DevExpress.XtraEditors.CalcEdit();
            this.UIFLG_CREDITO = new DevExpress.XtraEditors.CheckEdit();
            this.sISFORMAPAGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_FORMA_PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFLG_CREDITO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_DIAS_PLAZO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIS_EMPRESAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.uigflg_credito = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_FORMA_PAGO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_DIAS_PLAZO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFLG_CREDITO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISFORMAPAGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uigflg_credito)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.SelectedTabPage = this.uitabpage_data;
            this.uimaintabcontrol.Size = new System.Drawing.Size(749, 568);
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Size = new System.Drawing.Size(686, 562);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Size = new System.Drawing.Size(686, 562);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.sISFORMAPAGOBindingSource;
            this.uigridcontrol.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.uigflg_credito});
            this.uigridcontrol.Size = new System.Drawing.Size(686, 562);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_EMPRESA,
            this.colDS_FORMA_PAGO,
            this.colFLG_CREDITO,
            this.colNM_DIAS_PLAZO,
            this.colSIS_EMPRESAS});
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
            this.UINAV.Location = new System.Drawing.Point(2, 545);
            this.UINAV.Size = new System.Drawing.Size(749, 25);
            // 
            // uipaneldata
            // 
            this.uipaneldata.Controls.Add(this.UIFLG_CREDITO);
            this.uipaneldata.Controls.Add(this.UINM_DIAS_PLAZO);
            this.uipaneldata.Controls.Add(this.UIDS_FORMA_PAGO);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.labelControl1);
            this.uipaneldata.Size = new System.Drawing.Size(686, 562);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.uilbl_opcion.Size = new System.Drawing.Size(753, 34);
            // 
            // uicontenedor
            // 
            this.uicontenedor.Size = new System.Drawing.Size(753, 572);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(89, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Forma de pago";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(52, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Dias plazo";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(119, 36);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(100, 20);
            this.UIID.TabIndex = 3;
            // 
            // UIDS_FORMA_PAGO
            // 
            this.UIDS_FORMA_PAGO.Location = new System.Drawing.Point(119, 67);
            this.UIDS_FORMA_PAGO.Name = "UIDS_FORMA_PAGO";
            this.UIDS_FORMA_PAGO.Size = new System.Drawing.Size(204, 20);
            this.UIDS_FORMA_PAGO.TabIndex = 4;
            // 
            // UINM_DIAS_PLAZO
            // 
            this.UINM_DIAS_PLAZO.Location = new System.Drawing.Point(119, 118);
            this.UINM_DIAS_PLAZO.Name = "UINM_DIAS_PLAZO";
            this.UINM_DIAS_PLAZO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UINM_DIAS_PLAZO.Size = new System.Drawing.Size(100, 20);
            this.UINM_DIAS_PLAZO.TabIndex = 5;
            // 
            // UIFLG_CREDITO
            // 
            this.UIFLG_CREDITO.EditValue = 'N';
            this.UIFLG_CREDITO.Location = new System.Drawing.Point(117, 93);
            this.UIFLG_CREDITO.Name = "UIFLG_CREDITO";
            this.UIFLG_CREDITO.Properties.Caption = "Credito";
            this.UIFLG_CREDITO.Properties.ValueChecked = 'S';
            this.UIFLG_CREDITO.Properties.ValueUnchecked = 'N';
            this.UIFLG_CREDITO.Size = new System.Drawing.Size(75, 19);
            this.UIFLG_CREDITO.TabIndex = 6;
            // 
            // sISFORMAPAGOBindingSource
            // 
            this.sISFORMAPAGOBindingSource.DataSource = typeof(Sistema.SIS_FORMA_PAGO);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            // 
            // colDS_FORMA_PAGO
            // 
            this.colDS_FORMA_PAGO.Caption = "Forma de pago";
            this.colDS_FORMA_PAGO.FieldName = "DS_FORMA_PAGO";
            this.colDS_FORMA_PAGO.Name = "colDS_FORMA_PAGO";
            this.colDS_FORMA_PAGO.Visible = true;
            this.colDS_FORMA_PAGO.VisibleIndex = 1;
            // 
            // colFLG_CREDITO
            // 
            this.colFLG_CREDITO.Caption = "Credito";
            this.colFLG_CREDITO.ColumnEdit = this.uigflg_credito;
            this.colFLG_CREDITO.FieldName = "FLG_CREDITO";
            this.colFLG_CREDITO.Name = "colFLG_CREDITO";
            this.colFLG_CREDITO.Visible = true;
            this.colFLG_CREDITO.VisibleIndex = 2;
            // 
            // colNM_DIAS_PLAZO
            // 
            this.colNM_DIAS_PLAZO.Caption = "Dias plazo";
            this.colNM_DIAS_PLAZO.FieldName = "NM_DIAS_PLAZO";
            this.colNM_DIAS_PLAZO.Name = "colNM_DIAS_PLAZO";
            this.colNM_DIAS_PLAZO.Visible = true;
            this.colNM_DIAS_PLAZO.VisibleIndex = 3;
            // 
            // colSIS_EMPRESAS
            // 
            this.colSIS_EMPRESAS.FieldName = "SIS_EMPRESAS";
            this.colSIS_EMPRESAS.Name = "colSIS_EMPRESAS";
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // uigflg_credito
            // 
            this.uigflg_credito.AutoHeight = false;
            this.uigflg_credito.Name = "uigflg_credito";
            this.uigflg_credito.ValueChecked = 'S';
            this.uigflg_credito.ValueUnchecked = 'N';
            // 
            // frm_forma_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(753, 606);
            this.Name = "frm_forma_pago";
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
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_FORMA_PAGO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_DIAS_PLAZO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFLG_CREDITO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISFORMAPAGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uigflg_credito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit UIFLG_CREDITO;
        private DevExpress.XtraEditors.CalcEdit UINM_DIAS_PLAZO;
        private DevExpress.XtraEditors.TextEdit UIDS_FORMA_PAGO;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource sISFORMAPAGOBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit uigflg_credito;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_FORMA_PAGO;
        private DevExpress.XtraGrid.Columns.GridColumn colFLG_CREDITO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_DIAS_PLAZO;
        private DevExpress.XtraGrid.Columns.GridColumn colSIS_EMPRESAS;
    }
}
