using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.DenCayCanhNoiThat;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.DenCayCanhNoiThat
{
    public class BaiDangDoGiaDungDenCayCanhNoiThat_BaiDangDoGiaDungEntites:Profile
    {
        public BaiDangDoGiaDungDenCayCanhNoiThat_BaiDangDoGiaDungEntites()
        {
            CreateMap<BaiDangDoGiaDungDenCayCanhNoiThat_DTO, BaiDangEntities>();

        }
    }
}
