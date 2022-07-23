using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles
{
    public class BaiDangBatDongSanCC_BaiDangEntities:Profile
    {
        public BaiDangBatDongSanCC_BaiDangEntities()
        {
            CreateMap<BaiDangBatDongSanCC_DTO, BaiDangEntities>(MemberList.Source);
        }
    }
}
