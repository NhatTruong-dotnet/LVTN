using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Bep;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.Bep
{
    public class BaiDangDoGiaDungBep_BaiDangEntites:Profile
    {
        public BaiDangDoGiaDungBep_BaiDangEntites()
        {
            CreateMap<BaiDangDoGiaDungBep_DTO, BaiDangDoGiaDungEntities>();

        }
    }
}
