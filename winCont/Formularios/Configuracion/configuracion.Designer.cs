namespace winCont.Formularios.Configuracion
{
    partial class configuracion
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
            this.uitxtservidor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.uitxtbasedatos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.uitxtusuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.uitxtpassword = new DevExpress.XtraEditors.TextEdit();
            this.UINUME_EMPRE = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).BeginInit();
            this.uicontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtservidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtbasedatos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtusuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINUME_EMPRE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // uilbl_opcion
            // 
            this.uilbl_opcion.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // uicontenedor
            // 
            this.uicontenedor.Controls.Add(this.labelControl5);
            this.uicontenedor.Controls.Add(this.UINUME_EMPRE);
            this.uicontenedor.Controls.Add(this.uitxtpassword);
            this.uicontenedor.Controls.Add(this.labelControl4);
            this.uicontenedor.Controls.Add(this.uitxtusuario);
            this.uicontenedor.Controls.Add(this.labelControl3);
            this.uicontenedor.Controls.Add(this.uitxtbasedatos);
            this.uicontenedor.Controls.Add(this.labelControl2);
            this.uicontenedor.Controls.Add(this.uitxtservidor);
            this.uicontenedor.Controls.Add(this.labelControl1);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Servidor BD";
            // 
            // uitxtservidor
            // 
            this.uitxtservidor.Location = new System.Drawing.Point(127, 32);
            this.uitxtservidor.Name = "uitxtservidor";
            this.uitxtservidor.Size = new System.Drawing.Size(261, 20);
            this.uitxtservidor.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Base de datos";
            // 
            // uitxtbasedatos
            // 
            this.uitxtbasedatos.Location = new System.Drawing.Point(127, 58);
            this.uitxtbasedatos.Name = "uitxtbasedatos";
            this.uitxtbasedatos.Size = new System.Drawing.Size(261, 20);
            this.uitxtbasedatos.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(72, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Usuario";
            // 
            // uitxtusuario
            // 
            this.uitxtusuario.Location = new System.Drawing.Point(127, 84);
            this.uitxtusuario.Name = "uitxtusuario";
            this.uitxtusuario.Size = new System.Drawing.Size(261, 20);
            this.uitxtusuario.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(62, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Password";
            // 
            // uitxtpassword
            // 
            this.uitxtpassword.Location = new System.Drawing.Point(127, 110);
            this.uitxtpassword.Name = "uitxtpassword";
            this.uitxtpassword.Size = new System.Drawing.Size(261, 20);
            this.uitxtpassword.TabIndex = 7;
            // 
            // UINUME_EMPRE
            // 
            this.UINUME_EMPRE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UINUME_EMPRE.Location = new System.Drawing.Point(127, 136);
            this.UINUME_EMPRE.Name = "UINUME_EMPRE";
            this.UINUME_EMPRE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UINUME_EMPRE.Properties.DisplayFormat.FormatString = "n0";
            this.UINUME_EMPRE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINUME_EMPRE.Properties.EditFormat.FormatString = "n0";
            this.UINUME_EMPRE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UINUME_EMPRE.Properties.Mask.EditMask = "n0";
            this.UINUME_EMPRE.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UINUME_EMPRE.Size = new System.Drawing.Size(261, 20);
            this.UINUME_EMPRE.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 143);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Numero de empresas";
            // 
            // configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(528, 462);
            this.Name = "configuracion";
            this.Load += new System.EventHandler(this.configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uicontenedor)).EndInit();
            this.uicontenedor.ResumeLayout(false);
            this.uicontenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtservidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtbasedatos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtusuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UINUME_EMPRE.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit uitxtservidor;
        private DevExpress.XtraEditors.TextEdit uitxtpassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit uitxtusuario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit uitxtbasedatos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit UINUME_EMPRE;
    }
}
