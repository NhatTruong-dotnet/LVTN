using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.BanGhe;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.BanGhe
{
    public class BaiDangDoGiaDungBanGhe_BaiDangDoGiaDungEntites:Profile
    {
        public BaiDangDoGiaDungBanGhe_BaiDangDoGiaDungEntites()
        {
            CreateMap<BaiDangDoGiaDungBanGhe_DTO, BaiDangEntities>();
        }
    }
}
