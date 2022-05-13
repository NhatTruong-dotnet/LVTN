using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.TuKe;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.TuKe
{
    public class BaiDangDoGiaDungTuKe_BaiDangDoGiaDungEntites:Profile
    {
        public BaiDangDoGiaDungTuKe_BaiDangDoGiaDungEntites()
        {
            CreateMap<BaiDangDoGiaDungTuKe_DTO, BaiDangEntities>();

        }
    }
}
