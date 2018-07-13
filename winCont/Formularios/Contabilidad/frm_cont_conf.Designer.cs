namespace winCont.Formularios.Contabilidad
{
    partial class frm_cont_conf
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
            this.UIID_NIVEL_MAYOR = new DevExpress.XtraEditors.LookUpEdit();
            this.cONTNIVELCUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.UIDS_NOMBRE_CONTADOR = new DevExpress.XtraEditors.TextEdit();
            this.UIFLG_USA_CENTRO_COSTO = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_NIVEL_MAYOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTNIVELCUENTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_NOMBRE_CONTADOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFLG_USA_CENTRO_COSTO.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uilbl_opcion.Size = new System.Drawing.Size(856, 52);
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.UIFLG_USA_CENTRO_COSTO);
            this.uicontenedor.Controls.Add(this.UIDS_NOMBRE_CONTADOR);
            this.uicontenedor.Controls.Add(this.labelControl2);
            this.uicontenedor.Controls.Add(this.labelControl1);
            this.uicontenedor.Controls.Add(this.UIID_NIVEL_MAYOR);
            this.uicontenedor.Size = new System.Drawing.Size(856, 470);
            // 
            // UIID_NIVEL_MAYOR
            // 
            this.UIID_NIVEL_MAYOR.Location = new System.Drawing.Point(169, 98);
            this.UIID_NIVEL_MAYOR.Name = "UIID_NIVEL_MAYOR";
            this.UIID_NIVEL_MAYOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UIID_NIVEL_MAYOR.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 40, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EMPRESA", "ID_EMPRESA", 105, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_NIVEL", "Nivel", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_CANT_CARACTERES", "Caracteres", 192, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UIID_NIVEL_MAYOR.Properties.DataSource = this.cONTNIVELCUENTABindingSource;
            this.UIID_NIVEL_MAYOR.Properties.DisplayMember = "NM_NIVEL";
            this.UIID_NIVEL_MAYOR.Properties.ValueMember = "ID";
            this.UIID_NIVEL_MAYOR.Size = new System.Drawing.Size(201, 26);
            this.UIID_NIVEL_MAYOR.TabIndex = 0;
            // 
            // cONTNIVELCUENTABindingSource
            // 
            this.cONTNIVELCUENTABindingSource.DataSource = typeof(ContabilidadDB.CONT_NIVEL_CUENTA);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nivel Mayor";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 158);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Contador";
            // 
            // UIDS_NOMBRE_CONTADOR
            // 
            this.UIDS_NOMBRE_CONTADOR.Location = new System.Drawing.Point(169, 158);
            this.UIDS_NOMBRE_CONTADOR.Name = "UIDS_NOMBRE_CONTADOR";
            this.UIDS_NOMBRE_CONTADOR.Properties.MaxLength = 100;
            this.UIDS_NOMBRE_CONTADOR.Size = new System.Drawing.Size(393, 26);
            this.UIDS_NOMBRE_CONTADOR.TabIndex = 3;
            // 
            // UIFLG_USA_CENTRO_COSTO
            // 
            this.UIFLG_USA_CENTRO_COSTO.EditValue = 'N';
            this.UIFLG_USA_CENTRO_COSTO.Location = new System.Drawing.Point(169, 215);
            this.UIFLG_USA_CENTRO_COSTO.Name = "UIFLG_USA_CENTRO_COSTO";
            this.UIFLG_USA_CENTRO_COSTO.Properties.Caption = "Centro de costo";
            this.UIFLG_USA_CENTRO_COSTO.Properties.ValueChecked = 'S';
            this.UIFLG_USA_CENTRO_COSTO.Properties.ValueUnchecked = 'N';
            this.UIFLG_USA_CENTRO_COSTO.Size = new System.Drawing.Size(181, 24);
            this.UIFLG_USA_CENTRO_COSTO.TabIndex = 4;
            // 
            // frm_cont_conf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(856, 522);
            this.Name = "frm_cont_conf";
            this.Load += new System.EventHandler(this.frm_cont_conf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            this.uicontenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UIID_NIVEL_MAYOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTNIVELCUENTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIDS_NOMBRE_CONTADOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIFLG_USA_CENTRO_COSTO.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit UIFLG_USA_CENTRO_COSTO;
        private DevExpress.XtraEditors.TextEdit UIDS_NOMBRE_CONTADOR;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit UIID_NIVEL_MAYOR;
        private System.Windows.Forms.BindingSource cONTNIVELCUENTABindingSource;
    }
}
