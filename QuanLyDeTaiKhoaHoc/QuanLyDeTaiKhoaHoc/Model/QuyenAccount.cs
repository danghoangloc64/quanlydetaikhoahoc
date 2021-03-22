using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeTaiKhoaHoc.Model
{
    public class QuyenAccount : AuditableEntity<Guid>
    {
        public string MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
