namespace winCont.Formularios.Configuracion
{
    partial class form_sis_config
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.UINM_PROC_IVA = new DevExpress.XtraEditors.CalcEdit();
            this.UINM_PORC_RETENCION = new DevExpress.XtraEditors.CalcEdit();
            this.UINM_MONTO_SOBRE_RETENCION = new DevExpress.XtraEditors.CalcEdit();
            this.UINM_PORC_RENTA = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_PROC_IVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_PORC_RETENCION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_MONTO_SOBRE_RETENCION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_PORC_RENTA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.UINM_PORC_RENTA);
            this.uicontenedor.Controls.Add(this.UINM_MONTO_SOBRE_RETENCION);
            this.uicontenedor.Controls.Add(this.UINM_PORC_RETENCION);
            this.uicontenedor.Controls.Add(this.UINM_PROC_IVA);
            this.uicontenedor.Controls.Add(this.labelControl4);
            this.uicontenedor.Controls.Add(this.labelControl3);
            this.uicontenedor.Controls.Add(this.labelControl2);
            this.uicontenedor.Controls.Add(this.labelControl1);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(161, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "IVA";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(54, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Impuesto sobre el IVA";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(90, 174);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Monto sobre iva";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(148, 218);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Renta";
            // 
            // UINM_PROC_IVA
            // 
            this.UINM_PROC_IVA.Location = new System.Drawing.Point(196, 80);
            this.UINM_PROC_IVA.Name = "UINM_PROC_IVA";
            this.UINM_PROC_IVA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UINM_PROC_IVA.Properties.Mask.EditMask = "n2";
            this.UINM_PROC_IVA.Size = new System.Drawing.Size(170, 22);
            this.UINM_PROC_IVA.TabIndex = 4;
            // 
            // UINM_PORC_RETENCION
            // 
            this.UINM_PORC_RETENCION.Location = new System.Drawing.Point(196, 129);
            this.UINM_PORC_RETENCION.Name = "UINM_PORC_RETENCION";
            this.UINM_PORC_RETENCION.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UINM_PORC_RETENCION.Properties.Mask.EditMask = "n2";
            this.UINM_PORC_RETENCION.Size = new System.Drawing.Size(170, 22);
            this.UINM_PORC_RETENCION.TabIndex = 5;
            // 
            // UINM_MONTO_SOBRE_RETENCION
            // 
            this.UINM_MONTO_SOBRE_RETENCION.Location = new System.Drawing.Point(196, 171);
            this.UINM_MONTO_SOBRE_RETENCION.Name = "UINM_MONTO_SOBRE_RETENCION";
            this.UINM_MONTO_SOBRE_RETENCION.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UINM_MONTO_SOBRE_RETENCION.Properties.Mask.EditMask = "n2";
            this.UINM_MONTO_SOBRE_RETENCION.Size = new System.Drawing.Size(170, 22);
            this.UINM_MONTO_SOBRE_RETENCION.TabIndex = 6;
            // 
            // UINM_PORC_RENTA
            // 
            this.UINM_PORC_RENTA.Location = new System.Drawing.Point(196, 215);
            this.UINM_PORC_RENTA.Name = "UINM_PORC_RENTA";
            this.UINM_PORC_RENTA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UINM_PORC_RENTA.Properties.Mask.EditMask = "n2";
            this.UINM_PORC_RENTA.Size = new System.Drawing.Size(170, 22);
            this.UINM_PORC_RENTA.TabIndex = 7;
            // 
            // form_sis_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(704, 569);
            this.Name = "form_sis_config";
            this.Load += new System.EventHandler(this.form_sis_config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            this.uicontenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_PROC_IVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_PORC_RETENCION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_MONTO_SOBRE_RETENCION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINM_PORC_RENTA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit UINM_PORC_RENTA;
        private DevExpress.XtraEditors.CalcEdit UINM_MONTO_SOBRE_RETENCION;
        private DevExpress.XtraEditors.CalcEdit UINM_PORC_RETENCION;
        private DevExpress.XtraEditors.CalcEdit UINM_PROC_IVA;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
