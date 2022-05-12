using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.Dat
{
    public class BaiDangBatDongSanDat_BaiDangEntities:Profile
    {
        public BaiDangBatDongSanDat_BaiDangEntities()
        {
            CreateMap<BaiDangBatDongSanDat_DTO, BaiDangEntities>(MemberList.Source);

        }
    }
}
