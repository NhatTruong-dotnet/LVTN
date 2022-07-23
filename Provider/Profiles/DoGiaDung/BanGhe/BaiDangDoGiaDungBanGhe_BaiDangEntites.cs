using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.BanGhe;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.BanGhe
{
    public class BaiDangDoGiaDungBanGhe_BaiDangEntites:Profile
    {
        public BaiDangDoGiaDungBanGhe_BaiDangEntites()
        {
            CreateMap<BaiDangDoGiaDungBanGhe_DTO, BaiDangDoGiaDungEntities>();
        }
    }
}
