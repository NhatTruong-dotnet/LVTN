using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;

namespace STU.LVTN.SERVER.Provider.Profiles
{
    public class HinhAnhBaiDang_HinhAnhBaiDangEntites:Profile
    {
        public HinhAnhBaiDang_HinhAnhBaiDangEntites()
        {
            CreateMap<HinhAnh_BaiDangDTO, HinhAnhBaiDangEntities>()
                 .ForMember(destinationMember => destinationMember.IdHinhAnh, opt => opt.MapFrom(sourceMember => sourceMember.id));
        }
    }
}
