
namespace QuanLyDeTaiKhoaHoc.Views
{
    partial class MainForm
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
            this.tabPaneChuNhiem = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneChuNhiem)).BeginInit();
            this.tabPaneChuNhiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPaneChuNhiem
            // 
            this.tabPaneChuNhiem.Controls.Add(this.tabNavigationPage);
            this.tabPaneChuNhiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneChuNhiem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabPaneChuNhiem.Location = new System.Drawing.Point(0, 0);
            this.tabPaneChuNhiem.Name = "tabPaneChuNhiem";
            this.tabPaneChuNhiem.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage});
            this.tabPaneChuNhiem.RegularSize = new System.Drawing.Size(762, 450);
            this.tabPaneChuNhiem.SelectedPage = this.tabNavigationPage;
            this.tabPaneChuNhiem.Size = new System.Drawing.Size(762, 450);
            this.tabPaneChuNhiem.TabIndex = 0;
            this.tabPaneChuNhiem.Text = "tabPane";
            this.tabPaneChuNhiem.Click += new System.EventHandler(this.tabPaneChuNhiem_Click);
            // 
            // tabNavigationPage
            // 
            this.tabNavigationPage.Caption = "Chủ nhiệm";
            this.tabNavigationPage.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabNavigationPage.Name = "tabNavigationPage";
            this.tabNavigationPage.Size = new System.Drawing.Size(762, 417);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.tabPaneChuNhiem);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đề tài khoa học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneChuNhiem)).EndInit();
            this.tabPaneChuNhiem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPaneChuNhiem;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage;
    }
}