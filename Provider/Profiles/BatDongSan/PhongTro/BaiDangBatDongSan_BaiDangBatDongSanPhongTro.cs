using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.PhongTro
{
    public class BaiDangBatDongSan_BaiDangBatDongSanPhongTro:Profile
    {
        public BaiDangBatDongSan_BaiDangBatDongSanPhongTro()
        {
            CreateMap< BaiDangBatDongSanEntities, BaiDangBatDongSanPhongTro_DTO>(MemberList.Source);
        }
    }
}
