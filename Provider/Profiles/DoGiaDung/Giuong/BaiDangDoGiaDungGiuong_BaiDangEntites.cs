using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Giuong;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.Giuong
{
    public class BaiDangDoGiaDungGiuong_BaiDangEntites:Profile
    {
        public BaiDangDoGiaDungGiuong_BaiDangEntites()
        {
            CreateMap<BaiDangDoGiaDungGiuong_DTO, BaiDangDoGiaDungEntities>();

        }

    }
}
