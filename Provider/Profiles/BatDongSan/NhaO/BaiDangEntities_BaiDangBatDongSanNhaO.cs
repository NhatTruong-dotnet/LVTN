using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.NhaO
{
    public class BaiDangEntities_BaiDangBatDongSanNhaO:Profile
    {
        public BaiDangEntities_BaiDangBatDongSanNhaO()
        {
            CreateMap< BaiDangBatDongSanEntities, BaiDangBatDongSanNhaO_DTO>()
                    .ForMember(destinationMember => destinationMember.CanBan, opt => opt.MapFrom(sourceMember => sourceMember.CanBan));
        }
    }
}
