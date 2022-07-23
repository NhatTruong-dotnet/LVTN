using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.Dat
{
    public class BaiDangEntities_BaiDangBatDongSanDat:Profile
    {
        public BaiDangEntities_BaiDangBatDongSanDat()
        {
            CreateMap<BaiDangEntities, BaiDangBatDongSanDat_DTO>(MemberList.Source);
        }
    }
}
