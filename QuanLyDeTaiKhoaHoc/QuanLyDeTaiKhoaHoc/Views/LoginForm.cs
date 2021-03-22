using DevExpress.XtraEditors;
using QuanLyDeTaiKhoaHoc.BLL;
using QuanLyDeTaiKhoaHoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeTaiKhoaHoc.Views
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private AccountLoginModel m_objAccountLoginModel;

        private AccountBLL m_objAccountBLL;
        private QuyenAccountBLL m_objQuyenAccountBLL;
        public LoginForm()
        {
            InitializeComponent();
            m_objQuyenAccountBLL = new QuyenAccountBLL();
            quyenAccountViewModelBindingSource.DataSource = m_objQuyenAccountBLL.GetListViewModel();

            m_objAccountBLL = new AccountBLL();
            m_objAccountLoginModel = new AccountLoginModel();
            accountLoginModelBindingSource.DataSource = m_objAccountLoginModel;
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

            }
            else
            {
                XtraMessageBox.Show("Vui lòng kiểm tra thông tin tên đăng nhập và mật khẩu.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {

        }
    }
}