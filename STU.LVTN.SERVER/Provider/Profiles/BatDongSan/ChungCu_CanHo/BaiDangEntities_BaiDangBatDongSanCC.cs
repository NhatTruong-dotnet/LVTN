using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.ChungCu_CanHo
{
    public class BaiDangEntities_BaiDangBatDongSanCC:Profile
    {
        public BaiDangEntities_BaiDangBatDongSanCC()
        {
            CreateMap<BaiDangEntities,BaiDangBatDongSanCC_DTO >(MemberList.Source);
        }
    }
}
