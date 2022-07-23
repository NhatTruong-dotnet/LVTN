using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Giuong;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.Giuong
{
    public class BaiDangDoGiaDungGiuong_BaiDangDoGiaDungEntites:Profile
    {
        public BaiDangDoGiaDungGiuong_BaiDangDoGiaDungEntites()
        {
            CreateMap<BaiDangDoGiaDungGiuong_DTO, BaiDangEntities>();

        }
    }
}
