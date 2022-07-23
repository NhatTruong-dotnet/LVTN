using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.NhaO
{
    public class BaiDangBatDongSan_BaiDangEntities:Profile
    {
        public BaiDangBatDongSan_BaiDangEntities()
        {
            CreateMap< BaiDangEntities, BaiDangBatDongSanNhaO_DTO>(MemberList.Source);
        }
    }
}
