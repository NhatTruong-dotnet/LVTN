using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ThuCung;

namespace STU.LVTN.SERVER.Provider.Profiles.ThuCung.Cho
{
    public class BaiDangThuCungCho_BaiDangThuCung:Profile
    {
        public BaiDangThuCungCho_BaiDangThuCung()
        {
            CreateMap<BaiDangThuCungCho_DTO, BaiDangThuCungEntities>();

        }
    }
}
