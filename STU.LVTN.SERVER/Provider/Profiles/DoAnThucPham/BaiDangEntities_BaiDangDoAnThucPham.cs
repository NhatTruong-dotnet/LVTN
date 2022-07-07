using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoAnThucPham;

namespace STU.LVTN.SERVER.Provider.Profiles.DoAnThucPham
{
    public class BaiDangEntities_BaiDangDoAnThucPham:Profile
    {
        public BaiDangEntities_BaiDangDoAnThucPham()
        {
            CreateMap<BaiDangEntities, BaiDangDoAnThucPham_DTO>();
        }
    }
}
