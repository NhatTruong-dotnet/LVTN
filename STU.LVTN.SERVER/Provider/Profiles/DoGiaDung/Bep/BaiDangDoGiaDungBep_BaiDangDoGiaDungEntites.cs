using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Bep;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.Bep
{
    public class BaiDangDoGiaDungBep_BaiDangDoGiaDungEntites:Profile
    {
        public BaiDangDoGiaDungBep_BaiDangDoGiaDungEntites()
        {
            CreateMap<BaiDangDoGiaDungBep_DTO, BaiDangEntities>();

        }
    }
}
