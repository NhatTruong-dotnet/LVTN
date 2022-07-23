using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.VanPhong
{
    public class BaiDangEntities_BaiDangBatDongSanVanPhong:Profile
    {
        public BaiDangEntities_BaiDangBatDongSanVanPhong()
        {
            CreateMap<BaiDangEntities, BaiDangBatDongSanVanPhong_DTO>(MemberList.Source);
        }
    }
}
