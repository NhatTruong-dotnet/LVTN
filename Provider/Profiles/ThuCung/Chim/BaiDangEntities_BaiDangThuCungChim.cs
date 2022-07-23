using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.Chim
{
    public class BaiDangEntities_BaiDangThuCungChim:Profile
    {
        public BaiDangEntities_BaiDangThuCungChim()
        {
            CreateMap< BaiDangEntities,BaiDangThuCungChim_DTO>();
        }
    }
}
