namespace winCont.Formularios.Configuracion
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.uichkrecordarme = new DevExpress.XtraEditors.CheckEdit();
            this.uibtnlogin = new DevExpress.XtraEditors.SimpleButton();
            this.uitxtpassword = new DevExpress.XtraEditors.TextEdit();
            this.uitxtusuario = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uichkrecordarme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtusuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(642, 363);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Black;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.uichkrecordarme);
            this.panelControl1.Controls.Add(this.uibtnlogin);
            this.panelControl1.Controls.Add(this.uitxtpassword);
            this.panelControl1.Controls.Add(this.uitxtusuario);
            this.panelControl1.Location = new System.Drawing.Point(284, 12);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(346, 339);
            this.panelControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(342, 83);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Bienvenido ";
            // 
            // uichkrecordarme
            // 
            this.uichkrecordarme.Location = new System.Drawing.Point(130, 280);
            this.uichkrecordarme.Name = "uichkrecordarme";
            this.uichkrecordarme.Properties.Caption = "recordarme";
            this.uichkrecordarme.Size = new System.Drawing.Size(89, 19);
            this.uichkrecordarme.TabIndex = 3;
            // 
            // uibtnlogin
            // 
            this.uibtnlogin.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.uibtnlogin.Appearance.Options.UseFont = true;
            this.uibtnlogin.Image = global::winCont.Properties.Resources.key_48;
            this.uibtnlogin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.uibtnlogin.Location = new System.Drawing.Point(74, 209);
            this.uibtnlogin.Name = "uibtnlogin";
            this.uibtnlogin.Size = new System.Drawing.Size(206, 49);
            this.uibtnlogin.TabIndex = 2;
            this.uibtnlogin.Text = "Iniciar";
            this.uibtnlogin.Click += new System.EventHandler(this.uibtnlogin_Click);
            // 
            // uitxtpassword
            // 
            this.uitxtpassword.Location = new System.Drawing.Point(74, 161);
            this.uitxtpassword.Name = "uitxtpassword";
            this.uitxtpassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.uitxtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.uitxtpassword.Properties.Appearance.Options.UseFont = true;
            this.uitxtpassword.Properties.Appearance.Options.UseForeColor = true;
            this.uitxtpassword.Properties.MaxLength = 50;
            this.uitxtpassword.Properties.NullText = "Contraseña";
            this.uitxtpassword.Size = new System.Drawing.Size(206, 30);
            this.uitxtpassword.TabIndex = 1;
            this.uitxtpassword.TextChanged += new System.EventHandler(this.uitxtpassword_TextChanged);
            this.uitxtpassword.Leave += new System.EventHandler(this.uitxtpassword_Leave);
            // 
            // uitxtusuario
            // 
            this.uitxtusuario.Location = new System.Drawing.Point(74, 103);
            this.uitxtusuario.Name = "uitxtusuario";
            this.uitxtusuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.uitxtusuario.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.uitxtusuario.Properties.Appearance.Options.UseFont = true;
            this.uitxtusuario.Properties.Appearance.Options.UseForeColor = true;
            this.uitxtusuario.Properties.MaxLength = 50;
            this.uitxtusuario.Properties.NullText = "Usuario";
            this.uitxtusuario.Size = new System.Drawing.Size(206, 30);
            this.uitxtusuario.TabIndex = 0;
            this.uitxtusuario.TextChanged += new System.EventHandler(this.uitxtusuario_TextChanged);
            this.uitxtusuario.Leave += new System.EventHandler(this.uitxtusuario_Leave);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::winCont.Properties.Resources.manager_512;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Size = new System.Drawing.Size(268, 339);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 4;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(642, 363);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureEdit1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(272, 343);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(272, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(350, 343);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(642, 363);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "winCont";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uichkrecordarme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitxtusuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton uibtnlogin;
        private DevExpress.XtraEditors.TextEdit uitxtpassword;
        private DevExpress.XtraEditors.TextEdit uitxtusuario;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.CheckEdit uichkrecordarme;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}