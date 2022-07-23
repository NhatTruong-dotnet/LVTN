using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.DenCayCanhNoiThat;

namespace STU.LVTN.SERVER.Provider.Profiles.DoGiaDung.DenCayCanhNoiThat
{
    public class BaiDangDoGiaDungDenCayCanhNoiThat_BaiDangEntites:Profile
    {
        public BaiDangDoGiaDungDenCayCanhNoiThat_BaiDangEntites()
        {
            CreateMap<BaiDangDoGiaDungDenCayCanhNoiThat_DTO, BaiDangDoGiaDungEntities>();

        }
    }
}
