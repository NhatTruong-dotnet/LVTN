using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.Chim
{
    public class BaiDangThuCungChim_BaiDangThuCung:Profile
    {
        public BaiDangThuCungChim_BaiDangThuCung()
        {
            CreateMap<BaiDangThuCungChim_DTO, BaiDangThuCungEntities>();
        }
    }
}
