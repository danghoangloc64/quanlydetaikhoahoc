
namespace QuanLyDeTaiKhoaHoc.Views
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnForgot = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TenDangNhapTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.accountLoginModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MatKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.QuyenComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTenDangNhap = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMatKhau = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQuyen = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TenDangNhapTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountLoginModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuyenComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnForgot);
            this.dataLayoutControl1.Controls.Add(this.btnLogin);
            this.dataLayoutControl1.Controls.Add(this.labelControl1);
            this.dataLayoutControl1.Controls.Add(this.TenDangNhapTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MatKhauTextEdit);
            this.dataLayoutControl1.Controls.Add(this.QuyenComboBoxEdit);
            this.dataLayoutControl1.DataSource = this.accountLoginModelBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(372, 210);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnForgot
            // 
            this.btnForgot.Location = new System.Drawing.Point(187, 164);
            this.btnForgot.Name = "btnForgot";
            this.btnForgot.Size = new System.Drawing.Size(173, 22);
            this.btnForgot.StyleController = this.dataLayoutControl1;
            this.btnForgot.TabIndex = 8;
            this.btnForgot.Text = "Quên mật khẩu";
            this.btnForgot.Click += new System.EventHandler(this.btnForgot_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(171, 22);
            this.btnLogin.StyleController = this.dataLayoutControl1;
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(348, 25);
            this.labelControl1.StyleController = this.dataLayoutControl1;
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Đăng nhập";
            // 
            // TenDangNhapTextEdit
            // 
            this.TenDangNhapTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountLoginModelBindingSource, "TenDangNhap", true));
            this.TenDangNhapTextEdit.Location = new System.Drawing.Point(96, 61);
            this.TenDangNhapTextEdit.Name = "TenDangNhapTextEdit";
            this.TenDangNhapTextEdit.Size = new System.Drawing.Size(264, 20);
            this.TenDangNhapTextEdit.StyleController = this.dataLayoutControl1;
            this.TenDangNhapTextEdit.TabIndex = 9;
            this.TenDangNhapTextEdit.Leave += new System.EventHandler(this.TenDangNhapTextEdit_Leave);
            // 
            // accountLoginModelBindingSource
            // 
            this.accountLoginModelBindingSource.DataSource = typeof(QuanLyDeTaiKhoaHoc.DTO.AccountLoginModel);
            // 
            // MatKhauTextEdit
            // 
            this.MatKhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountLoginModelBindingSource, "MatKhau", true));
            this.MatKhauTextEdit.Location = new System.Drawing.Point(96, 109);
            this.MatKhauTextEdit.Name = "MatKhauTextEdit";
            this.MatKhauTextEdit.Properties.UseSystemPasswordChar = true;
            this.MatKhauTextEdit.Size = new System.Drawing.Size(264, 20);
            this.MatKhauTextEdit.StyleController = this.dataLayoutControl1;
            this.MatKhauTextEdit.TabIndex = 10;
            // 
            // QuyenComboBoxEdit
            // 
            this.QuyenComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.accountLoginModelBindingSource, "Quyen", true));
            this.QuyenComboBoxEdit.Location = new System.Drawing.Point(96, 85);
            this.QuyenComboBoxEdit.Name = "QuyenComboBoxEdit";
            this.QuyenComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.QuyenComboBoxEdit.Properties.PopupSizeable = true;
            this.QuyenComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.QuyenComboBoxEdit.Size = new System.Drawing.Size(264, 20);
            this.QuyenComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.QuyenComboBoxEdit.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(372, 210);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem2,
            this.emptySpaceItem4,
            this.layoutControlItem3,
            this.ItemForTenDangNhap,
            this.ItemForMatKhau,
            this.ItemForQuyen});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(352, 190);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 10);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(352, 29);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 39);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(352, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 121);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(352, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(352, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnLogin;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 152);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(175, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 178);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(352, 12);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnForgot;
            this.layoutControlItem3.Location = new System.Drawing.Point(175, 152);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(177, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // ItemForTenDangNhap
            // 
            this.ItemForTenDangNhap.Control = this.TenDangNhapTextEdit;
            this.ItemForTenDangNhap.Location = new System.Drawing.Point(0, 49);
            this.ItemForTenDangNhap.Name = "ItemForTenDangNhap";
            this.ItemForTenDangNhap.Size = new System.Drawing.Size(352, 24);
            this.ItemForTenDangNhap.Text = "Tên đăng nhập";
            this.ItemForTenDangNhap.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForMatKhau
            // 
            this.ItemForMatKhau.Control = this.MatKhauTextEdit;
            this.ItemForMatKhau.Location = new System.Drawing.Point(0, 97);
            this.ItemForMatKhau.Name = "ItemForMatKhau";
            this.ItemForMatKhau.Size = new System.Drawing.Size(352, 24);
            this.ItemForMatKhau.Text = "Mật khẩu";
            this.ItemForMatKhau.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForQuyen
            // 
            this.ItemForQuyen.Control = this.QuyenComboBoxEdit;
            this.ItemForQuyen.Location = new System.Drawing.Point(0, 73);
            this.ItemForQuyen.Name = "ItemForQuyen";
            this.ItemForQuyen.Size = new System.Drawing.Size(352, 24);
            this.ItemForQuyen.Text = "Quyền";
            this.ItemForQuyen.TextSize = new System.Drawing.Size(72, 13);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 210);
            this.Controls.Add(this.dataLayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TenDangNhapTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountLoginModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuyenComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton btnForgot;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit TenDangNhapTextEdit;
        private System.Windows.Forms.BindingSource accountLoginModelBindingSource;
        private DevExpress.XtraEditors.TextEdit MatKhauTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenDangNhap;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMatKhau;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQuyen;
        private DevExpress.XtraEditors.ComboBoxEdit QuyenComboBoxEdit;
    }
}