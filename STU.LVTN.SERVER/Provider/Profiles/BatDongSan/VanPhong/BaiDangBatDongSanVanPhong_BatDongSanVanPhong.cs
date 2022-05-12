using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.VanPhong
{
    public class BaiDangBatDongSanVanPhong_BatDongSanVanPhong:Profile
    {
        public BaiDangBatDongSanVanPhong_BatDongSanVanPhong()
        {
            CreateMap<BaiDangBatDongSanVanPhong_DTO, BaiDangBatDongSanEntities>(MemberList.Source);

        }
    }
}
