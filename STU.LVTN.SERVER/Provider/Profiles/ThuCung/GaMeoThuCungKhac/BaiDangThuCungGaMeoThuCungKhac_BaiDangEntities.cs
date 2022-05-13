using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.GaMeoThuCungKhac
{
    public class BaiDangThuCungGaMeoThuCungKhac_BaiDangEntities:Profile
    {
        public BaiDangThuCungGaMeoThuCungKhac_BaiDangEntities()
        {
            CreateMap<BaiDangThuCungGaMeoThuCungKhac_DTO, BaiDangEntities>();
        }
    }
}
