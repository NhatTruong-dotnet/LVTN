using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ViecLam;

namespace STU.LVTN.SERVER.Provider.Profiles.ViecLam
{
    public class BaiDangViecLamEntities_BaiDangViecLam:Profile
    {
        public BaiDangViecLamEntities_BaiDangViecLam()
        {
            CreateMap< BaiDangViecLamEntities,BaiDangViecLamDTO>();
        }
    }
}
