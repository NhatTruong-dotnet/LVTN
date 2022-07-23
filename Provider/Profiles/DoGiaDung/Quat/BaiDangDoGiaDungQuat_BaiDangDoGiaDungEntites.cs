using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Quat;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.Quat
{
    public class BaiDangDoGiaDungQuat_BaiDangDoGiaDungEntites:Profile
    {
        public BaiDangDoGiaDungQuat_BaiDangDoGiaDungEntites()
        {
            CreateMap<BaiDangDoGiaDungQuat_DTO, BaiDangEntities>();
        }
    }
}
