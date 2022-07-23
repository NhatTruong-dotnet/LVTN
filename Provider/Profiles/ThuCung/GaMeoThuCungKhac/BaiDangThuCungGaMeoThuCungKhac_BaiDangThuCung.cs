using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.GaMeoThuCungKhac
{
    public class BaiDangThuCungGaMeoThuCungKhac_BaiDangThuCung:Profile
    {
        public BaiDangThuCungGaMeoThuCungKhac_BaiDangThuCung()
        {
            CreateMap<BaiDangThuCungGaMeoThuCungKhac_DTO, BaiDangThuCungEntities>();
        }
    }
}
