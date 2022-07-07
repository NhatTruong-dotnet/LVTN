using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.Cho
{
    public class BaiDangThuCungEntities_BaiDangThuCungCho:Profile
    {
        public BaiDangThuCungEntities_BaiDangThuCungCho()
        {
            CreateMap< BaiDangThuCungEntities,BaiDangThuCungCho_DTO>();
        }
    }
}
