using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.Profiles
{
    public class BaiDangBatDongSanCC_BatDongSanCC: Profile
    {
        public BaiDangBatDongSanCC_BatDongSanCC()
        {
            CreateMap<BaiDangBatDongSanCC_DTO, BaiDangBatDongSanEntities>()
                .ForMember(destinationMember => destinationMember.CcBlock, opt => opt.MapFrom(sourceMember => sourceMember.Block))
                .ForMember(destinationMember => destinationMember.CcMaCan, opt => opt.MapFrom(sourceMember => sourceMember.MaCan))
                .ForMember(destinationMember => destinationMember.CcTangSo, opt => opt.MapFrom(sourceMember => sourceMember.TangSo))
                .ForMember(destinationMember => destinationMember.CcChuaBanGiao, opt => opt.MapFrom(sourceMember => sourceMember.ChuaBanGiao))
                .ForMember(destinationMember => destinationMember.CcLoaiHinh, opt => opt.MapFrom(sourceMember => sourceMember.LoaiHinh))
                .ForMember(destinationMember => destinationMember.CcSoPhongNgu, opt => opt.MapFrom(sourceMember => sourceMember.SoPhongNgu))
                .ForMember(destinationMember => destinationMember.CanBan, opt => opt.MapFrom(sourceMember => sourceMember.CanBan));

        }
    }
}
