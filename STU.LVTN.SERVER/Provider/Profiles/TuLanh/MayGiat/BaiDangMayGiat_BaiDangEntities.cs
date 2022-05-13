using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayGiat;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayGiat
{
    public class BaiDangMayGiat_BaiDangEntities:Profile
    {
        public BaiDangMayGiat_BaiDangEntities()
        {
            CreateMap<BaiDangTuLanhMayGiat_DTO, BaiDangEntities>();

        }
    }
}
