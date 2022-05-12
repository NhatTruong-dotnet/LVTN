using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.NhaO
{
    public class BaiDangBatDongSanDat_BatDongSanDat:Profile
    {
        public BaiDangBatDongSanDat_BatDongSanDat()
        {
            CreateMap<BaiDangBatDongSanNhaO_DTO, BaiDangBatDongSanEntities>()
                    .ForMember(destinationMember => destinationMember.CanBan, opt => opt.MapFrom(sourceMember => sourceMember.CanBan));
        }
    }
}
