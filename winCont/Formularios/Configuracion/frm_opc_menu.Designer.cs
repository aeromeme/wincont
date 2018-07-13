namespace winCont.Formularios.Configuracion
{
    partial class frm_opc_menu
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
            this.UILSTOPCIONES = new DevExpress.XtraEditors.ListBoxControl();
            this.sISFORMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UILSTMENU = new DevExpress.XtraEditors.ListBoxControl();
            this.sISMENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UILSTFORMULARIO = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.vSISOPCMENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UILSTOPCIONES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISFORMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UILSTMENU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISMENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UILSTFORMULARIO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISOPCMENUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.layoutControl1);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.UILSTOPCIONES);
            this.layoutControl1.Controls.Add(this.UILSTMENU);
            this.layoutControl1.Controls.Add(this.UILSTFORMULARIO);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(524, 424);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // UILSTOPCIONES
            // 
            this.UILSTOPCIONES.DataSource = this.vSISOPCMENUBindingSource;
            this.UILSTOPCIONES.DisplayMember = "DS_NOMBRE";
            this.UILSTOPCIONES.ItemHeight = 20;
            this.UILSTOPCIONES.Location = new System.Drawing.Point(187, 43);
            this.UILSTOPCIONES.Name = "UILSTOPCIONES";
            this.UILSTOPCIONES.Size = new System.Drawing.Size(141, 357);
            this.UILSTOPCIONES.StyleController = this.layoutControl1;
            this.UILSTOPCIONES.TabIndex = 6;
            this.UILSTOPCIONES.ToolTip = "Doble clic para quitar la opcion de menu";
            this.UILSTOPCIONES.ValueMember = "ID";
            this.UILSTOPCIONES.DoubleClick += new System.EventHandler(this.UILSTOPCIONES_DoubleClick);
            // 
            // sISFORMBindingSource
            // 
            this.sISFORMBindingSource.DataSource = typeof(Sistema.SIS_FORM);
            // 
            // UILSTMENU
            // 
            this.UILSTMENU.Appearance.BackColor = System.Drawing.Color.White;
            this.UILSTMENU.Appearance.Options.UseBackColor = true;
            this.UILSTMENU.DataSource = this.sISMENUBindingSource;
            this.UILSTMENU.DisplayMember = "DS_MENU";
            this.UILSTMENU.ItemHeight = 20;
            this.UILSTMENU.Location = new System.Drawing.Point(24, 43);
            this.UILSTMENU.Name = "UILSTMENU";
            this.UILSTMENU.Size = new System.Drawing.Size(135, 357);
            this.UILSTMENU.StyleController = this.layoutControl1;
            this.UILSTMENU.TabIndex = 5;
            this.UILSTMENU.ValueMember = "ID";
            this.UILSTMENU.SelectedIndexChanged += new System.EventHandler(this.UILSTMENU_SelectedIndexChanged);
            // 
            // sISMENUBindingSource
            // 
            this.sISMENUBindingSource.DataSource = typeof(Sistema.SIS_MENU);
            // 
            // UILSTFORMULARIO
            // 
            this.UILSTFORMULARIO.DataSource = this.sISFORMBindingSource;
            this.UILSTFORMULARIO.DisplayMember = "DS_NOMBRE";
            this.UILSTFORMULARIO.ItemHeight = 20;
            this.UILSTFORMULARIO.Location = new System.Drawing.Point(356, 43);
            this.UILSTFORMULARIO.Name = "UILSTFORMULARIO";
            this.UILSTFORMULARIO.Size = new System.Drawing.Size(144, 357);
            this.UILSTFORMULARIO.StyleController = this.layoutControl1;
            this.UILSTFORMULARIO.TabIndex = 4;
            this.UILSTFORMULARIO.ToolTip = "Doble clic para registrar la opcion de menu";
            this.UILSTFORMULARIO.ValueMember = "ID";
            this.UILSTFORMULARIO.DoubleClick += new System.EventHandler(this.UILSTFORMULARIO_DoubleClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(524, 424);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Menus";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(163, 404);
            this.layoutControlGroup2.Text = "Menus";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.UILSTMENU;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(139, 361);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Opciones de menu";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(163, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(169, 404);
            this.layoutControlGroup3.Text = "Opciones de menu";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.UILSTOPCIONES;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(145, 361);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Formularios";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(332, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(172, 404);
            this.layoutControlGroup4.Text = "Formularios";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.UILSTFORMULARIO;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(148, 361);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // vSISOPCMENUBindingSource
            // 
            this.vSISOPCMENUBindingSource.DataSource = typeof(Sistema.V_SIS_OPC_MENU);
            // 
            // frm_opc_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Name = "frm_opc_menu";
            this.Load += new System.EventHandler(this.frm_opc_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UILSTOPCIONES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISFORMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UILSTMENU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISMENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UILSTFORMULARIO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSISOPCMENUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ListBoxControl UILSTOPCIONES;
        private DevExpress.XtraEditors.ListBoxControl UILSTMENU;
        private System.Windows.Forms.BindingSource sISMENUBindingSource;
        private DevExpress.XtraEditors.ListBoxControl UILSTFORMULARIO;
        private System.Windows.Forms.BindingSource sISFORMBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private System.Windows.Forms.BindingSource vSISOPCMENUBindingSource;
    }
}
