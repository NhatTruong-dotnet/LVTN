using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.PhongTro
{
    public class BaiDangBatDongSanPhongTro_BatDongSanPhongTro:Profile
    {
        public BaiDangBatDongSanPhongTro_BatDongSanPhongTro()
        {
            CreateMap<BaiDangBatDongSanPhongTro_DTO, BaiDangBatDongSanEntities>(MemberList.Source);
        }
    }
}
