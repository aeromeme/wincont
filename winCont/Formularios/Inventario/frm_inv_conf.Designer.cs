namespace winCont.Formularios.Inventario
{
    partial class frm_inv_conf
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.UIID_CUENTA_INVE = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vCONTCUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCD_CUENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDS_CUENTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UICD_NIVEL_CONT_INVE = new DevExpress.XtraEditors.LookUpEdit();
            this.clsGenericaParesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UIID_CUENTA_CONSUMO = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UIID_CUENTA_VENTA = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UICD_NIVEL_CONT_CONSUMO = new DevExpress.XtraEditors.LookUpEdit();
            this.UICD_NIVEL_CONT_VENTA = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_CUENTA_INVE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCONTCUENTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_NIVEL_CONT_INVE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_CUENTA_CONSUMO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_CUENTA_VENTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_NIVEL_CONT_CONSUMO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_NIVEL_CONT_VENTA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Size = new System.Drawing.Size(549, 34);
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.UICD_NIVEL_CONT_VENTA);
            this.uicontenedor.Controls.Add(this.UICD_NIVEL_CONT_CONSUMO);
            this.uicontenedor.Controls.Add(this.UIID_CUENTA_VENTA);
            this.uicontenedor.Controls.Add(this.UIID_CUENTA_CONSUMO);
            this.uicontenedor.Controls.Add(this.UICD_NIVEL_CONT_INVE);
            this.uicontenedor.Controls.Add(this.UIID_CUENTA_INVE);
            this.uicontenedor.Controls.Add(this.labelControl6);
            this.uicontenedor.Controls.Add(this.labelControl5);
            this.uicontenedor.Controls.Add(this.labelControl4);
            this.uicontenedor.Controls.Add(this.labelControl3);
            this.uicontenedor.Controls.Add(this.labelControl2);
            this.uicontenedor.Controls.Add(this.labelControl1);
            this.uicontenedor.Size = new System.Drawing.Size(549, 450);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(68, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cuenta invetario";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(68, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Cuenta consumo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(82, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Cuenta venta";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(68, 213);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Nivel inventario";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(74, 251);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Nivel consumo";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(88, 289);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Nivel venta";
            // 
            // UIID_CUENTA_INVE
            // 
            this.UIID_CUENTA_INVE.Location = new System.Drawing.Point(176, 50);
            this.UIID_CUENTA_INVE.Name = "UIID_CUENTA_INVE";
            this.UIID_CUENTA_INVE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIID_CUENTA_INVE.Properties.DataSource = this.vCONTCUENTABindingSource;
            this.UIID_CUENTA_INVE.Properties.DisplayMember = "CD_CUENTA";
            this.UIID_CUENTA_INVE.Properties.ValueMember = "ID";
            this.UIID_CUENTA_INVE.Properties.View = this.gridLookUpEdit1View;
            this.UIID_CUENTA_INVE.Size = new System.Drawing.Size(148, 20);
            this.UIID_CUENTA_INVE.TabIndex = 6;
            // 
            // vCONTCUENTABindingSource
            // 
            this.vCONTCUENTABindingSource.DataSource = typeof(ContabilidadDB.V_CONT_CUENTA);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCD_CUENTA,
            this.colDS_CUENTA});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCD_CUENTA
            // 
            this.colCD_CUENTA.Caption = "Cuenta";
            this.colCD_CUENTA.FieldName = "CD_CUENTA";
            this.colCD_CUENTA.Name = "colCD_CUENTA";
            this.colCD_CUENTA.Visible = true;
            this.colCD_CUENTA.VisibleIndex = 0;
            // 
            // colDS_CUENTA
            // 
            this.colDS_CUENTA.Caption = "Nombre";
            this.colDS_CUENTA.FieldName = "DS_CUENTA";
            this.colDS_CUENTA.Name = "colDS_CUENTA";
            this.colDS_CUENTA.Visible = true;
            this.colDS_CUENTA.VisibleIndex = 1;
            // 
            // UICD_NIVEL_CONT_INVE
            // 
            this.UICD_NIVEL_CONT_INVE.Location = new System.Drawing.Point(176, 210);
            this.UICD_NIVEL_CONT_INVE.Name = "UICD_NIVEL_CONT_INVE";
            this.UICD_NIVEL_CONT_INVE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UICD_NIVEL_CONT_INVE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Nivel", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UICD_NIVEL_CONT_INVE.Properties.DataSource = this.clsGenericaParesBindingSource;
            this.UICD_NIVEL_CONT_INVE.Properties.DisplayMember = "descripcion";
            this.UICD_NIVEL_CONT_INVE.Properties.ValueMember = "id";
            this.UICD_NIVEL_CONT_INVE.Size = new System.Drawing.Size(148, 20);
            this.UICD_NIVEL_CONT_INVE.TabIndex = 7;
            // 
            // clsGenericaParesBindingSource
            // 
            this.clsGenericaParesBindingSource.DataSource = typeof(winCont.Clases.clsGenericaPares);
            // 
            // UIID_CUENTA_CONSUMO
            // 
            this.UIID_CUENTA_CONSUMO.Location = new System.Drawing.Point(176, 81);
            this.UIID_CUENTA_CONSUMO.Name = "UIID_CUENTA_CONSUMO";
            this.UIID_CUENTA_CONSUMO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIID_CUENTA_CONSUMO.Properties.DataSource = this.vCONTCUENTABindingSource;
            this.UIID_CUENTA_CONSUMO.Properties.DisplayMember = "CD_CUENTA";
            this.UIID_CUENTA_CONSUMO.Properties.ValueMember = "ID";
            this.UIID_CUENTA_CONSUMO.Properties.View = this.gridView1;
            this.UIID_CUENTA_CONSUMO.Size = new System.Drawing.Size(148, 20);
            this.UIID_CUENTA_CONSUMO.TabIndex = 8;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cuenta";
            this.gridColumn1.FieldName = "CD_CUENTA";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "DS_CUENTA";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // UIID_CUENTA_VENTA
            // 
            this.UIID_CUENTA_VENTA.Location = new System.Drawing.Point(176, 116);
            this.UIID_CUENTA_VENTA.Name = "UIID_CUENTA_VENTA";
            this.UIID_CUENTA_VENTA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIID_CUENTA_VENTA.Properties.DataSource = this.vCONTCUENTABindingSource;
            this.UIID_CUENTA_VENTA.Properties.DisplayMember = "CD_CUENTA";
            this.UIID_CUENTA_VENTA.Properties.ValueMember = "ID";
            this.UIID_CUENTA_VENTA.Properties.View = this.gridView2;
            this.UIID_CUENTA_VENTA.Size = new System.Drawing.Size(148, 20);
            this.UIID_CUENTA_VENTA.TabIndex = 9;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cuenta";
            this.gridColumn3.FieldName = "CD_CUENTA";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nombre";
            this.gridColumn4.FieldName = "DS_CUENTA";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // UICD_NIVEL_CONT_CONSUMO
            // 
            this.UICD_NIVEL_CONT_CONSUMO.Location = new System.Drawing.Point(176, 244);
            this.UICD_NIVEL_CONT_CONSUMO.Name = "UICD_NIVEL_CONT_CONSUMO";
            this.UICD_NIVEL_CONT_CONSUMO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UICD_NIVEL_CONT_CONSUMO.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Nivel", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UICD_NIVEL_CONT_CONSUMO.Properties.DataSource = this.clsGenericaParesBindingSource;
            this.UICD_NIVEL_CONT_CONSUMO.Properties.DisplayMember = "descripcion";
            this.UICD_NIVEL_CONT_CONSUMO.Properties.ValueMember = "id";
            this.UICD_NIVEL_CONT_CONSUMO.Size = new System.Drawing.Size(148, 20);
            this.UICD_NIVEL_CONT_CONSUMO.TabIndex = 10;
            // 
            // UICD_NIVEL_CONT_VENTA
            // 
            this.UICD_NIVEL_CONT_VENTA.Location = new System.Drawing.Point(176, 286);
            this.UICD_NIVEL_CONT_VENTA.Name = "UICD_NIVEL_CONT_VENTA";
            this.UICD_NIVEL_CONT_VENTA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UICD_NIVEL_CONT_VENTA.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Nivel", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UICD_NIVEL_CONT_VENTA.Properties.DataSource = this.clsGenericaParesBindingSource;
            this.UICD_NIVEL_CONT_VENTA.Properties.DisplayMember = "descripcion";
            this.UICD_NIVEL_CONT_VENTA.Properties.ValueMember = "id";
            this.UICD_NIVEL_CONT_VENTA.Size = new System.Drawing.Size(148, 20);
            this.UICD_NIVEL_CONT_VENTA.TabIndex = 11;
            // 
            // frm_inv_conf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(549, 484);
            this.Name = "frm_inv_conf";
            this.Load += new System.EventHandler(this.frm_inv_conf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            this.uicontenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_CUENTA_INVE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCONTCUENTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_NIVEL_CONT_INVE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_CUENTA_CONSUMO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_CUENTA_VENTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_NIVEL_CONT_CONSUMO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_NIVEL_CONT_VENTA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit UICD_NIVEL_CONT_VENTA;
        private System.Windows.Forms.BindingSource clsGenericaParesBindingSource;
        private DevExpress.XtraEditors.LookUpEdit UICD_NIVEL_CONT_CONSUMO;
        private DevExpress.XtraEditors.GridLookUpEdit UIID_CUENTA_VENTA;
        private System.Windows.Forms.BindingSource vCONTCUENTABindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GridLookUpEdit UIID_CUENTA_CONSUMO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LookUpEdit UICD_NIVEL_CONT_INVE;
        private DevExpress.XtraEditors.GridLookUpEdit UIID_CUENTA_INVE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_CUENTA;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_CUENTA;
    }
}
