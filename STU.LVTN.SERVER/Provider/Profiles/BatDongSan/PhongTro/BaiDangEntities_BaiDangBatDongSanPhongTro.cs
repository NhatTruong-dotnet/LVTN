using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.PhongTro
{
    public class BaiDangEntities_BaiDangBatDongSanPhongTro:Profile
    {
        public BaiDangEntities_BaiDangBatDongSanPhongTro()
        {
            CreateMap<BaiDangEntities,BaiDangBatDongSanPhongTro_DTO >(MemberList.Source);
        }
    }
}
