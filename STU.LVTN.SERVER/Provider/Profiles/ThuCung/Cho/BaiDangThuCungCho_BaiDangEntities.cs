using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.Cho
{
    public class BaiDangThuCungCho_BaiDangEntities:Profile
    {
        public BaiDangThuCungCho_BaiDangEntities()
        {
            CreateMap<BaiDangThuCungCho_DTO, BaiDangEntities>();
        }
    }
}
