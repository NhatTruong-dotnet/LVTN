using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.ThietBiVeSinh;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.ThietBiVeSinh
{
    public class BaiDangDoGiaDungThietBiVeSinh_BaiDangEntites:Profile
    {
        public BaiDangDoGiaDungThietBiVeSinh_BaiDangEntites()
        {
            CreateMap<BaiDangDoGiaDungThietBiVeSinh_DTO, BaiDangDoGiaDungEntities>();

        }
    }
}
