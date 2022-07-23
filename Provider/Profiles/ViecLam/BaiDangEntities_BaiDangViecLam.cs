using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ViecLam;

namespace STU.LVTN.SERVER.Provider.Profiles.ViecLam
{
    public class BaiDangEntities_BaiDangViecLam:Profile
    {
        public BaiDangEntities_BaiDangViecLam()
        {
            CreateMap< BaiDangEntities,BaiDangViecLamDTO>();
        }
    }
}
