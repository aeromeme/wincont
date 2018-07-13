namespace winCont.Formularios.Configuracion
{
    partial class frm_periodos
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.UIGRIDCONTROL = new DevExpress.XtraGrid.GridControl();
            this.sISPERIODOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UIGRIDVIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_EMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_EJERCICIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNM_PERIODO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIS_EMPRESAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.uibtnaddPeriodo = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.vSISPERIODOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colDS_MES = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISPERIODOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISPERIODOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Size = new System.Drawing.Size(712, 34);
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.layoutControl1);
            this.uicontenedor.Size = new System.Drawing.Size(712, 446);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.UIGRIDCONTROL);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(708, 442);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // UIGRIDCONTROL
            // 
            this.UIGRIDCONTROL.DataSource = this.vSISPERIODOBindingSource;
            this.UIGRIDCONTROL.Location = new System.Drawing.Point(12, 12);
            this.UIGRIDCONTROL.MainView = this.UIGRIDVIEW;
            this.UIGRIDCONTROL.Name = "UIGRIDCONTROL";
            this.UIGRIDCONTROL.Size = new System.Drawing.Size(684, 355);
            this.UIGRIDCONTROL.TabIndex = 5;
            this.UIGRIDCONTROL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UIGRIDVIEW});
            // 
            // sISPERIODOBindingSource
            // 
            this.sISPERIODOBindingSource.DataSource = typeof(Sistema.SIS_PERIODO);
            // 
            // UIGRIDVIEW
            // 
            this.UIGRIDVIEW.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colID_EMPRESA,
            this.colNM_EJERCICIO,
            this.colNM_PERIODO,
            this.colCD_ESTADO,
            this.colSIS_EMPRESAS,
            this.colDS_MES});
            this.UIGRIDVIEW.GridControl = this.UIGRIDCONTROL;
            this.UIGRIDVIEW.Name = "UIGRIDVIEW";
            this.UIGRIDVIEW.OptionsBehavior.Editable = false;
            this.UIGRIDVIEW.OptionsBehavior.ReadOnly = true;
            this.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true;
            this.UIGRIDVIEW.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colID_EMPRESA
            // 
            this.colID_EMPRESA.FieldName = "ID_EMPRESA";
            this.colID_EMPRESA.Name = "colID_EMPRESA";
            // 
            // colNM_EJERCICIO
            // 
            this.colNM_EJERCICIO.Caption = "Ejercicio";
            this.colNM_EJERCICIO.FieldName = "NM_EJERCICIO";
            this.colNM_EJERCICIO.Name = "colNM_EJERCICIO";
            this.colNM_EJERCICIO.Visible = true;
            this.colNM_EJERCICIO.VisibleIndex = 0;
            // 
            // colNM_PERIODO
            // 
            this.colNM_PERIODO.Caption = "Periodo";
            this.colNM_PERIODO.FieldName = "NM_PERIODO";
            this.colNM_PERIODO.Name = "colNM_PERIODO";
            this.colNM_PERIODO.Visible = true;
            this.colNM_PERIODO.VisibleIndex = 1;
            // 
            // colCD_ESTADO
            // 
            this.colCD_ESTADO.Caption = "Estado";
            this.colCD_ESTADO.FieldName = "CD_ESTADO";
            this.colCD_ESTADO.Name = "colCD_ESTADO";
            this.colCD_ESTADO.Visible = true;
            this.colCD_ESTADO.VisibleIndex = 3;
            // 
            // colSIS_EMPRESAS
            // 
            this.colSIS_EMPRESAS.FieldName = "SIS_EMPRESAS";
            this.colSIS_EMPRESAS.Name = "colSIS_EMPRESAS";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.uibtnaddPeriodo);
            this.panelControl1.Location = new System.Drawing.Point(12, 371);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(684, 59);
            this.panelControl1.TabIndex = 4;
            // 
            // uibtnaddPeriodo
            // 
            this.uibtnaddPeriodo.Dock = System.Windows.Forms.DockStyle.Right;
            this.uibtnaddPeriodo.Location = new System.Drawing.Point(421, 2);
            this.uibtnaddPeriodo.Name = "uibtnaddPeriodo";
            this.uibtnaddPeriodo.Size = new System.Drawing.Size(261, 55);
            this.uibtnaddPeriodo.TabIndex = 0;
            this.uibtnaddPeriodo.Text = "Agregar";
            this.uibtnaddPeriodo.Click += new System.EventHandler(this.uibtnaddPeriodo_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(708, 442);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 359);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 63);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(201, 63);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(688, 63);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.UIGRIDCONTROL;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(688, 359);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // vSISPERIODOBindingSource
            // 
            this.vSISPERIODOBindingSource.DataSource = typeof(Sistema.V_SIS_PERIODO);
            // 
            // colDS_MES
            // 
            this.colDS_MES.Caption = "Mes";
            this.colDS_MES.FieldName = "DS_MES";
            this.colDS_MES.Name = "colDS_MES";
            this.colDS_MES.Visible = true;
            this.colDS_MES.VisibleIndex = 2;
            // 
            // frm_periodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 480);
            this.Name = "frm_periodos";
            this.Load += new System.EventHandler(this.frm_periodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISPERIODOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIGRIDVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISPERIODOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl UIGRIDCONTROL;
        private System.Windows.Forms.BindingSource sISPERIODOBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView UIGRIDVIEW;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colID_EMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_EJERCICIO;
        private DevExpress.XtraGrid.Columns.GridColumn colNM_PERIODO;
        private DevExpress.XtraGrid.Columns.GridColumn colCD_ESTADO;
        private DevExpress.XtraGrid.Columns.GridColumn colSIS_EMPRESAS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton uibtnaddPeriodo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource vSISPERIODOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDS_MES;
    }
}
