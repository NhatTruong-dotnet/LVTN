using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles
{
    public class BaiDangBatDongSanDat_BaiDangEntities:Profile
    {
        public BaiDangBatDongSanDat_BaiDangEntities()
        {
            CreateMap<BaiDangBatDongSanNhaO_DTO, BaiDangEntities>(MemberList.Source);
        }
    }
}
