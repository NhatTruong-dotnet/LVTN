using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.PhongTro
{
    public class BaiDangBatDongSanPhongTro_BatDongSanEntities: Profile
    {
        public BaiDangBatDongSanPhongTro_BatDongSanEntities()
        {
            CreateMap<BaiDangBatDongSanPhongTro_DTO, BaiDangEntities>(MemberList.Source);
        }
    }
}
