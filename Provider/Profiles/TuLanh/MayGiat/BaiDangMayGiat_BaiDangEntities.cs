using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayGiat;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayGiat
{
    public class BaiDangDoSuuTam_BaiDangEntities:Profile
    {
        public BaiDangDoSuuTam_BaiDangEntities()
        {
            CreateMap<BaiDangTuLanhMayGiat_DTO, BaiDangEntities>();

        }
    }
}
