using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.ViecLam;

namespace STU.LVTN.SERVER.Provider.Profiles.ViecLam
{
    public class BaiDangViecLam_BaiDangEntities:Profile
    {
        public BaiDangViecLam_BaiDangEntities()
        {
            CreateMap<BaiDangViecLamDTO, BaiDangEntities>();
        }
    }
}
