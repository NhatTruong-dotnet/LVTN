using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.Chim
{
    public class BaiDangThuCungChim_BaiDangEntities:Profile
    {
        public BaiDangThuCungChim_BaiDangEntities()
        {
            CreateMap<BaiDangThuCungChim_DTO, BaiDangEntities>();
        }
    }
}
