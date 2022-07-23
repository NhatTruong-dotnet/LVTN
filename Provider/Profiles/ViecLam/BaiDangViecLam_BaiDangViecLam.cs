using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ViecLam;

namespace STU.LVTN.SERVER.Provider.Profiles.ViecLam
{
    public class BaiDangViecLam_BaiDangViecLam:Profile
    {
        public BaiDangViecLam_BaiDangViecLam()
        {
            CreateMap<BaiDangViecLamDTO, BaiDangViecLamEntities>();
        }
    }
}
