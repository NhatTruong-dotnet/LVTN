using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Quat;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.Quat
{
    public class BaiDangDoGiaDungQuat_BaiDangEntites:Profile
    {
        public BaiDangDoGiaDungQuat_BaiDangEntites()
        {
            CreateMap<BaiDangDoGiaDungQuat_DTO, BaiDangDoGiaDungEntities>();
        }
    }
}
