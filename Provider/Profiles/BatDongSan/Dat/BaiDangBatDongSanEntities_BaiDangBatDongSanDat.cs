using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.Dat
{
    public class BaiDangBatDongSanEntities_BaiDangBatDongSanDat:Profile
    {
        public BaiDangBatDongSanEntities_BaiDangBatDongSanDat()
        {
            CreateMap< BaiDangBatDongSanEntities, BaiDangBatDongSanDat_DTO>()
                   .ForMember(destinationMember => destinationMember.CanBan, opt => opt.MapFrom(sourceMember => sourceMember.CanBan));
        }
    }
}
