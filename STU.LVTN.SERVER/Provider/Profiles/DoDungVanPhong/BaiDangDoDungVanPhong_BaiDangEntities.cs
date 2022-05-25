using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.DoDungVanPhong;
using STU.LVTN.SERVER.Model.DTO.MeVaBe;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDungVanPhong
{
    public class BaiDangDoDungVanPhong_BaiDangEntities : Profile
    {
        public BaiDangDoDungVanPhong_BaiDangEntities()
        {
            CreateMap<BaiDangDoDungVanPhong_DTO, BaiDangEntities>();
        }
    }
}
