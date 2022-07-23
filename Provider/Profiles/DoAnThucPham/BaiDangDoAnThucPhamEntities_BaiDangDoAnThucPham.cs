using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoAnThucPham;

namespace STU.LVTN.SERVER.Provider.Profiles.DoAnThucPham
{
    public class BaiDangDoAnThucPhamEntities_BaiDangDoAnThucPham:Profile
    {
        public BaiDangDoAnThucPhamEntities_BaiDangDoAnThucPham()
        {
            CreateMap< BaiDangDoAnThucPham_DTO,BaiDangDoAnThucPhamEntities>();
        }
    }
}
