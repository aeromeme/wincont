namespace winCont.Formularios.Contabilidad
{
    partial class frm_aux_cuenta
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
            this.uibtnagregar = new DevExpress.XtraEditors.SimpleButton();
            this.UICD_TIPO_SALDO = new DevExpress.XtraEditors.LookUpEdit();
            this.clsGenericaParesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UIDS_CUENTA = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.UIID_RUBRO = new DevExpress.XtraEditors.LookUpEdit();
            this.cONTRUBROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UICD_CUENTA = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.uilvlnivel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_TIPO_SALDO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_CUENTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_RUBRO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRUBROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_CUENTA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.uilvlnivel);
            this.uicontenedor.Controls.Add(this.UIID_RUBRO);
            this.uicontenedor.Controls.Add(this.UICD_CUENTA);
            this.uicontenedor.Controls.Add(this.labelControl7);
            this.uicontenedor.Controls.Add(this.labelControl1);
            this.uicontenedor.Controls.Add(this.UICD_TIPO_SALDO);
            this.uicontenedor.Controls.Add(this.UIDS_CUENTA);
            this.uicontenedor.Controls.Add(this.labelControl3);
            this.uicontenedor.Controls.Add(this.labelControl4);
            this.uicontenedor.Controls.Add(this.uibtnagregar);
            this.uicontenedor.Size = new System.Drawing.Size(528, 231);
            // 
            // uibtnagregar
            // 
            this.uibtnagregar.Location = new System.Drawing.Point(109, 149);
            this.uibtnagregar.Name = "uibtnagregar";
            this.uibtnagregar.Size = new System.Drawing.Size(247, 36);
            this.uibtnagregar.TabIndex = 0;
            this.uibtnagregar.Text = "Inicializar rubro";
            this.uibtnagregar.Click += new System.EventHandler(this.uibtnagregar_Click);
            // 
            // UICD_TIPO_SALDO
            // 
            this.UICD_TIPO_SALDO.Location = new System.Drawing.Point(109, 110);
            this.UICD_TIPO_SALDO.Name = "UICD_TIPO_SALDO";
            this.UICD_TIPO_SALDO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UICD_TIPO_SALDO.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 31, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Tipo Saldo", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UICD_TIPO_SALDO.Properties.DataSource = this.clsGenericaParesBindingSource;
            this.UICD_TIPO_SALDO.Properties.DisplayMember = "descripcion";
            this.UICD_TIPO_SALDO.Properties.ValueMember = "id";
            this.UICD_TIPO_SALDO.Size = new System.Drawing.Size(100, 20);
            this.UICD_TIPO_SALDO.TabIndex = 14;
            // 
            // clsGenericaParesBindingSource
            // 
            this.clsGenericaParesBindingSource.DataSource = typeof(winCont.Clases.clsGenericaPares);
            // 
            // UIDS_CUENTA
            // 
            this.UIDS_CUENTA.Location = new System.Drawing.Point(109, 76);
            this.UIDS_CUENTA.Name = "UIDS_CUENTA";
            this.UIDS_CUENTA.Size = new System.Drawing.Size(247, 20);
            this.UIDS_CUENTA.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Tipo de saldo";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(55, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Nombre";
            // 
            // UIID_RUBRO
            // 
            this.UIID_RUBRO.Location = new System.Drawing.Point(109, 20);
            this.UIID_RUBRO.Name = "UIID_RUBRO";
            this.UIID_RUBRO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIID_RUBRO.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_RUBRO", "Rubro", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_RUBRO_BASE", "CD_RUBRO_BASE", 96, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EMPRESA", "ID_EMPRESA", 73, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.UIID_RUBRO.Properties.DataSource = this.cONTRUBROSBindingSource;
            this.UIID_RUBRO.Properties.DisplayMember = "DS_RUBRO";
            this.UIID_RUBRO.Properties.ValueMember = "ID";
            this.UIID_RUBRO.Size = new System.Drawing.Size(247, 20);
            this.UIID_RUBRO.TabIndex = 18;
            // 
            // cONTRUBROSBindingSource
            // 
            this.cONTRUBROSBindingSource.DataSource = typeof(ContabilidadDB.CONT_RUBROS);
            // 
            // UICD_CUENTA
            // 
            this.UICD_CUENTA.Location = new System.Drawing.Point(109, 46);
            this.UICD_CUENTA.Name = "UICD_CUENTA";
            this.UICD_CUENTA.Properties.Mask.EditMask = "f0";
            this.UICD_CUENTA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UICD_CUENTA.Properties.MaxLength = 30;
            this.UICD_CUENTA.Size = new System.Drawing.Size(247, 20);
            this.UICD_CUENTA.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(64, 23);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Rubro";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Cuenta";
            // 
            // uilvlnivel
            // 
            this.uilvlnivel.Location = new System.Drawing.Point(363, 49);
            this.uilvlnivel.Name = "uilvlnivel";
            this.uilvlnivel.Size = new System.Drawing.Size(32, 13);
            this.uilvlnivel.TabIndex = 19;
            this.uilvlnivel.Text = "Nivel 1";
            // 
            // frm_aux_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 265);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_aux_cuenta";
            this.Load += new System.EventHandler(this.frm_aux_cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            this.uicontenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_TIPO_SALDO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGenericaParesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_CUENTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_RUBRO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRUBROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UICD_CUENTA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton uibtnagregar;
        private DevExpress.XtraEditors.LookUpEdit UICD_TIPO_SALDO;
        private DevExpress.XtraEditors.TextEdit UIDS_CUENTA;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl uilvlnivel;
        private DevExpress.XtraEditors.LookUpEdit UIID_RUBRO;
        private System.Windows.Forms.BindingSource cONTRUBROSBindingSource;
        private DevExpress.XtraEditors.TextEdit UICD_CUENTA;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource clsGenericaParesBindingSource;
    }
}
