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
    public partial class ForgotAccountForm : DevExpress.XtraEditors.XtraForm
    {
        private AccountBLL m_objAccountBLL;
        private AccountForgetModel m_objAccountForgetModel;

        public ForgotAccountForm()
        {
            InitializeComponent();
            m_objAccountBLL = new AccountBLL();
            m_objAccountForgetModel = new AccountForgetModel();
            accountForgetModelBindingSource.DataSource = m_objAccountForgetModel;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_objAccountForgetModel.TenDangNhap) || string.IsNullOrEmpty(m_objAccountForgetModel.Email))
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin để lấy lại mật khẩu.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EmailMethod.IsValidEmail(m_objAccountForgetModel.Email) == false)
            {
                XtraMessageBox.Show("Địa chỉ email không hợp lệ.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (m_objAccountBLL.ForgetPassword(m_objAccountForgetModel))
            {
                XtraMessageBox.Show($"Đã gửi email cập nhật mật khẩu vào email {m_objAccountForgetModel.Email}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin để lấy lại mật khẩu.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}