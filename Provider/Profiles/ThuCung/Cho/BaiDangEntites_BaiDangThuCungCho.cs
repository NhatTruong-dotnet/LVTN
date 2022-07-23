using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.Cho
{
    public class BaiDangEntites_BaiDangThuCungCho:Profile
    {
        public BaiDangEntites_BaiDangThuCungCho()
        {
            CreateMap< BaiDangEntities,BaiDangThuCungCho_DTO>();
        }
    }
}
