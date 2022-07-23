using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.TuKe;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.TuKe
{
    public class BaiDangDoGiaDungTuKe_BaiDangEntites:Profile
    {
        public BaiDangDoGiaDungTuKe_BaiDangEntites()
        {
            CreateMap<BaiDangDoGiaDungTuKe_DTO, BaiDangDoGiaDungEntities>();
        }
    }
}
