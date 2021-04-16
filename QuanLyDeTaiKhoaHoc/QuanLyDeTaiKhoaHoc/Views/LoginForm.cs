using DevExpress.XtraEditors;
using QuanLyDeTaiKhoaHoc.BLL;
using QuanLyDeTaiKhoaHoc.DAL;
using QuanLyDeTaiKhoaHoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTaiKhoaHoc.Views
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private ForgotAccountForm m_objForgotAccountForm;
        private AccountLoginModel m_objAccountLoginModel;
        private AccountBLL m_objAccountBLL;
        private QuyenBLL m_objQuyenAccountBLL;

        public LoginForm()
        {
            InitializeComponent();
            m_objQuyenAccountBLL = new QuyenBLL();

            m_objAccountBLL = new AccountBLL();
            m_objAccountLoginModel = new AccountLoginModel();
            accountLoginModelBindingSource.DataSource = m_objAccountLoginModel;

            using (var context = new QuanLyDeTaiKhoaHocContext())
            {
                context.SaveChanges();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_objAccountLoginModel.TenDangNhap) || string.IsNullOrEmpty(m_objAccountLoginModel.MatKhau)
                                                                         || string.IsNullOrEmpty(m_objAccountLoginModel.Quyen))
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin tên đăng nhập và mật khẩu.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (m_objAccountBLL.Login(m_objAccountLoginModel) == true)
            {
                Thread thread = new Thread(delegate ()
                {
                    Application.Run(new MainForm());
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

                Close();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng kiểm tra thông tin tên đăng nhập và mật khẩu.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            m_objForgotAccountForm = new ForgotAccountForm();
            m_objForgotAccountForm.ShowDialog();
        }

        private void TenDangNhapTextEdit_Leave(object sender, EventArgs e)
        {
            m_objAccountLoginModel.TenDangNhap = TenDangNhapTextEdit.Text;
            if (!string.IsNullOrEmpty(m_objAccountLoginModel.TenDangNhap))
            {
                QuyenComboBoxEdit.Properties.Items.AddRange(m_objQuyenAccountBLL.GetListViewModelByUserName(m_objAccountLoginModel.TenDangNhap));
            }
        }
    }
}