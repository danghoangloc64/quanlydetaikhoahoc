using AutoMapper;
using QuanLyDeTaiKhoaHoc.Model;
using System;
using System.ComponentModel;

namespace QuanLyDeTaiKhoaHoc.DTO
{
    public class ChuNhiemViewModel
    {
        public ChuNhiemViewModel()
        {

        }

        public ChuNhiemViewModel(ChuNhiem dataChuNhiem)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ChuNhiem, ChuNhiemViewModel>());
            var mapper = new Mapper(config);
            mapper.Map(dataChuNhiem, this);
        }

        [DisplayName("Mã chủ nhiệm:")]
        public string MaChuNhiem { get; set; }
        [DisplayName("Họ tên chủ nhiệm:")]
        public string TenChuNhiem { get; set; }
        [DisplayName("Ngày sinh:")]
        public DateTime? NgaySinh { get; set; }
        [DisplayName("Giới tính:")]
        public string GioiTinh { get; set; }
        [DisplayName("Số điện thoại:")]
        public string SoDienThoai { get; set; }
        [DisplayName("Email:")]
        public string Email { get; set; }
        [DisplayName("Quê quán:")]
        public string QueQuan { get; set; }
        [DisplayName("Chuyên ngành:")]
        public string ChuyenNganh { get; set; }
        [DisplayName("Học hàm/Học vị:")]
        public string HocHamHocVi { get; set; }
        [DisplayName("Đơn vị công tác:")]
        public string DonViCongTac { get; set; }
    }
}
