using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.VanPhong
{
    public class BaiDangBatDongSanEntities_BaiDangBatDongSanVanPhong:Profile
    {
        public BaiDangBatDongSanEntities_BaiDangBatDongSanVanPhong()
        {
            CreateMap< BaiDangBatDongSanEntities, BaiDangBatDongSanVanPhong_DTO>(MemberList.Source);
        }
    }
}
