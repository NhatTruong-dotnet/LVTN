using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDungVanPhong;
using STU.LVTN.SERVER.Model.DTO.MeVaBe;

namespace STU.LVTN.SERVER.Provider.Profiles.MeVaBe
{
    public class BaiDangDoDungVanPhong_BaiDangDoDungVanPhong : Profile
    {
        public BaiDangDoDungVanPhong_BaiDangDoDungVanPhong()
        {
            CreateMap<BaiDangDoDungVanPhong_DTO, BaiDangDoDungVanPhongEntities>();
        }
    }
}
