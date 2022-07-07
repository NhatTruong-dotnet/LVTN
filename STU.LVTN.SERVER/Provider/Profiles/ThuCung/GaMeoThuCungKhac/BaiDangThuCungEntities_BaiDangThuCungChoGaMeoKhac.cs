using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.GaMeoThuCungKhac
{
    public class BaiDangThuCungEntities_BaiDangThuCungChoGaMeoKhac:Profile
    {
        public BaiDangThuCungEntities_BaiDangThuCungChoGaMeoKhac()
        {
            CreateMap< BaiDangThuCungEntities,BaiDangThuCungGaMeoThuCungKhac_DTO>();
        }
    }
}
