using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles.BatDongSan.ChungCu_CanHo
{
    public class BaiDangBatDongSanEntities_BaiDangBatDongSanCC:Profile
    {
        public BaiDangBatDongSanEntities_BaiDangBatDongSanCC()
        {
            CreateMap<BaiDangBatDongSanEntities,BaiDangBatDongSanCC_DTO >()
               .ForMember(destinationMember => destinationMember.Block, opt => opt.MapFrom(sourceMember => sourceMember.CcBlock))
               .ForMember(destinationMember => destinationMember.MaCan, opt => opt.MapFrom(sourceMember => sourceMember.CcMaCan))
               .ForMember(destinationMember => destinationMember.TangSo, opt => opt.MapFrom(sourceMember => sourceMember.CcTangSo))
               .ForMember(destinationMember => destinationMember.ChuaBanGiao, opt => opt.MapFrom(sourceMember => sourceMember.CcChuaBanGiao))
               .ForMember(destinationMember => destinationMember.LoaiHinh, opt => opt.MapFrom(sourceMember => sourceMember.CcLoaiHinh))
               .ForMember(destinationMember => destinationMember.SoPhongNgu, opt => opt.MapFrom(sourceMember => sourceMember.CcSoPhongNgu))
               .ForMember(destinationMember => destinationMember.CanBan, opt => opt.MapFrom(sourceMember => sourceMember.CanBan))
               .ForMember(destinationMember => destinationMember.soToilet, opt => opt.MapFrom(sourceMember => sourceMember.soToilet));
        }
    }
}
