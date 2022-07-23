using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.VanPhong
{
    public class BaiDangBatDongSanVanPhong_BatDongSanEntities:Profile
    {
        public BaiDangBatDongSanVanPhong_BatDongSanEntities()
        {
            CreateMap<BaiDangBatDongSanVanPhong_DTO, BaiDangEntities>(MemberList.Source);
        }
    }
}
