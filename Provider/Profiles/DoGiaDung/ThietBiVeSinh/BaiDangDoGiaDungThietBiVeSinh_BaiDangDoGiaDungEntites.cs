using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.ThietBiVeSinh;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.ThietBiVeSinh
{
    public class BaiDangDoGiaDungThietBiVeSinh_BaiDangDoGiaDungEntites:Profile
    {
        public BaiDangDoGiaDungThietBiVeSinh_BaiDangDoGiaDungEntites()
        {
            CreateMap<BaiDangDoGiaDungThietBiVeSinh_DTO, BaiDangEntities>();

        }
    }
}
