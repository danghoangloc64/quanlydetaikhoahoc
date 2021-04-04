using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using QuanLyDeTaiKhoaHoc.BLL;
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
    public partial class ChuNhiemUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private ChuNhiemBLL m_objChuNhiemBLL;
        public ChuNhiemUserControl()
        {
            InitializeComponent();
            m_objChuNhiemBLL = new ChuNhiemBLL();

            gridControl.DataSource = m_objChuNhiemBLL.GetListViewModel();
            foreach (GridColumn objCol in gridView.Columns)
            {
                objCol.AppearanceHeader.BackColor = Color.FromArgb(50, 196, 255);
                objCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                objCol.AppearanceHeader.Font = new Font("Tahoma", 9, FontStyle.Bold);
            }
        }
    }
}
