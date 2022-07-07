using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.GaMeoThuCungKhac
{
    public class BaiDangEntities_BaiDangThuCungGaMeoThuCungKhac:Profile
    {
        public BaiDangEntities_BaiDangThuCungGaMeoThuCungKhac()
        {
            CreateMap< BaiDangEntities,BaiDangThuCungGaMeoThuCungKhac_DTO>();
        }
    }
}
