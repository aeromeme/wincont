namespace winCont.Formularios.Ventas
{
    partial class frm_vendedores
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
            this.fACVENDEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_VENDEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.UIID = new DevExpress.XtraEditors.TextEdit();
            this.UIDS_VENDEDOR = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.UICD_VENDEDOR = new DevExpress.XtraEditors.TextEdit();
            this.UIDS_CORREO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.UIDS_TELEFONO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.colCD_VENDEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CORREO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_TELEFONO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.fACVENDEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_VENDEDOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_VENDEDOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_CORREO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_TELEFONO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uimaintabcontrol
            // 
            this.uimaintabcontrol.SelectedTabPage = this.uitabpage_data;
            this.uimaintabcontrol.Size = new System.Drawing.Size(524, 399);
            // 
            // uitabpage_datalist
            // 
            this.uitabpage_datalist.Size = new System.Drawing.Size(461, 393);
            // 
            // uitabpage_data
            // 
            this.uitabpage_data.Size = new System.Drawing.Size(461, 393);
            // 
            // uigridcontrol
            // 
            this.uigridcontrol.DataSource = this.fACVENDEDORBindingSource;
            this.uigridcontrol.Size = new System.Drawing.Size(461, 393);
            // 
            // uigridview
            // 
            this.uigridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_EMPRESA,
            this.colDS_VENDEDOR,
            this.colCD_VENDEDOR,
            this.colDS_CORREO,
            this.colDS_TELEFONO});
            this.uigridview.OptionsBehavior.Editable = false;
            this.uigridview.OptionsBehavior.ReadOnly = true;
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
            this.uipaneldata.Controls.Add(this.UIDS_TELEFONO);
            this.uipaneldata.Controls.Add(this.labelControl5);
            this.uipaneldata.Controls.Add(this.UIDS_CORREO);
            this.uipaneldata.Controls.Add(this.labelControl4);
            this.uipaneldata.Controls.Add(this.UICD_VENDEDOR);
            this.uipaneldata.Controls.Add(this.labelControl3);
            this.uipaneldata.Controls.Add(this.UIDS_VENDEDOR);
            this.uipaneldata.Controls.Add(this.UIID);
            this.uipaneldata.Controls.Add(this.labelControl2);
            this.uipaneldata.Controls.Add(this.labelControl1);
            this.uipaneldata.Size = new System.Drawing.Size(461, 393);
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            // 
            // fACVENDEDORBindingSource
            // 
            this.fACVENDEDORBindingSource.DataSource = typeof(VentasDB.FAC_VENDEDOR);
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
            // colDS_VENDEDOR
            // 
            this.colDS_VENDEDOR.Caption = "Vendedor";
            this.colDS_VENDEDOR.FieldName = "DS_VENDEDOR";
            this.colDS_VENDEDOR.Name = "colDS_VENDEDOR";
            this.colDS_VENDEDOR.Visible = true;
            this.colDS_VENDEDOR.VisibleIndex = 1;
            this.colDS_VENDEDOR.Width = 226;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Vendedor";
            // 
            // UIID
            // 
            this.UIID.Location = new System.Drawing.Point(67, 41);
            this.UIID.Name = "UIID";
            this.UIID.Properties.ReadOnly = true;
            this.UIID.Size = new System.Drawing.Size(100, 20);
            this.UIID.TabIndex = 2;
            // 
            // UIDS_VENDEDOR
            // 
            this.UIDS_VENDEDOR.Location = new System.Drawing.Point(67, 73);
            this.UIDS_VENDEDOR.Name = "UIDS_VENDEDOR";
            this.UIDS_VENDEDOR.Size = new System.Drawing.Size(215, 20);
            this.UIDS_VENDEDOR.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Codigo";
            // 
            // UICD_VENDEDOR
            // 
            this.UICD_VENDEDOR.Location = new System.Drawing.Point(67, 106);
            this.UICD_VENDEDOR.Name = "UICD_VENDEDOR";
            this.UICD_VENDEDOR.Size = new System.Drawing.Size(100, 20);
            this.UICD_VENDEDOR.TabIndex = 5;
            // 
            // UIDS_CORREO
            // 
            this.UIDS_CORREO.Location = new System.Drawing.Point(67, 136);
            this.UIDS_CORREO.Name = "UIDS_CORREO";
            this.UIDS_CORREO.Size = new System.Drawing.Size(215, 20);
            this.UIDS_CORREO.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Correo";
            // 
            // UIDS_TELEFONO
            // 
            this.UIDS_TELEFONO.Location = new System.Drawing.Point(67, 171);
            this.UIDS_TELEFONO.Name = "UIDS_TELEFONO";
            this.UIDS_TELEFONO.Size = new System.Drawing.Size(215, 20);
            this.UIDS_TELEFONO.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Telefono";
            // 
            // colCD_VENDEDOR
            // 
            this.colCD_VENDEDOR.Caption = "Codigo";
            this.colCD_VENDEDOR.FieldName = "CD_VENDEDOR";
            this.colCD_VENDEDOR.Name = "colCD_VENDEDOR";
            this.colCD_VENDEDOR.Visible = true;
            this.colCD_VENDEDOR.VisibleIndex = 2;
            this.colCD_VENDEDOR.Width = 85;
            // 
            // colDS_CORREO
            // 
            this.colDS_CORREO.FieldName = "DS_CORREO";
            this.colDS_CORREO.Name = "colDS_CORREO";
            // 
            // colDS_TELEFONO
            // 
            this.colDS_TELEFONO.FieldName = "DS_TELEFONO";
            this.colDS_TELEFONO.Name = "colDS_TELEFONO";
            // 
            // frm_vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Name = "frm_vendedores";
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
            ((System.ComponentModel.ISupportInitialize)(this.fACVENDEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_VENDEDOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_VENDEDOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_CORREO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_TELEFONO.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource fACVENDEDORBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_VENDEDOR;
        private DevExpress.XtraEditors.TextEdit UIDS_VENDEDOR;
        private DevExpress.XtraEditors.TextEdit UIID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_VENDEDOR;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CORREO;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_TELEFONO;
        private DevExpress.XtraEditors.TextEdit UIDS_TELEFONO;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit UIDS_CORREO;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit UICD_VENDEDOR;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
