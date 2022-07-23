using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.Chim
{
    public class BaiDangThuCungEntities_BaiDangThuCungChim:Profile
    {
        public BaiDangThuCungEntities_BaiDangThuCungChim()
        {
            CreateMap< BaiDangThuCungEntities,BaiDangThuCungChim_DTO>();
        }
    }
}
