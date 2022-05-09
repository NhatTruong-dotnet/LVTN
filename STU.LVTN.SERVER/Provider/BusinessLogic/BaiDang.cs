using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDang
    {
        private LVTNContext _context = new LVTNContext();

        public async Task<List<BaiDangHomePageDTO>> RenderHomePage(int lastestSubCategories)
        {
            List<BaiDangHomePageDTO> baiDangHomePageDTOs = new List<BaiDangHomePageDTO>();
            if (lastestSubCategories == 0)
            {
               List<BaiDangEntities> lastest20BaiDang =  _context.BaiDangs
                    .Where(baiDang => baiDang.AnTin == false && baiDang.TrangThai == true)
                    .OrderByDescending(baidang => baidang.IdBaiDang)
                    .Take(20)
                    .ToList();
                foreach (var baiDang in lastest20BaiDang)
                {
                    BaiDangHomePageDTO newBaiDang = new BaiDangHomePageDTO();
                    newBaiDang.IDBaiDang = baiDang.IdBaiDang;
                    newBaiDang.IDHinhAnh = _context.HinhAnhBaiDangs.Where(item => item.IdSanPham == baiDang.IdBaiDang)
                        .OrderByDescending(item => item.IdHinhAnh)
                        .FirstOrDefault().IdMediaCloud;
                    newBaiDang.TieuDe = baiDang.TieuDe;
                    newBaiDang.ThanhPho = baiDang.ThanhPho;
                    newBaiDang.Gia = baiDang.Gia;
                    newBaiDang.NgayTao = baiDang.CreatedDate;

                    baiDangHomePageDTOs.Add(newBaiDang);
                }
            }
            else
            {
                List<BaiDangEntities> lastest20BaiDang = _context.BaiDangs
                    .Where(baiDang => baiDang.AnTin == false && baiDang.TrangThai == true && baiDang.IdDanhMucCon == lastestSubCategories)
                    .OrderByDescending(baidang => baidang.IdBaiDang)
                    .Take(20)
                    .ToList();

                foreach (var baiDang in lastest20BaiDang)
                {
                    BaiDangHomePageDTO newBaiDang = new BaiDangHomePageDTO();
                    newBaiDang.IDBaiDang = baiDang.IdBaiDang;
                    newBaiDang.IDHinhAnh = _context.HinhAnhBaiDangs.Where(item => item.IdSanPham == baiDang.IdBaiDang)
                        .OrderByDescending(item => item.IdHinhAnh)
                        .FirstOrDefault().IdMediaCloud;
                    newBaiDang.TieuDe = baiDang.TieuDe;
                    newBaiDang.ThanhPho = baiDang.ThanhPho;
                    newBaiDang.Gia = baiDang.Gia;
                    newBaiDang.NgayTao = baiDang.CreatedDate;

                    baiDangHomePageDTOs.Add(newBaiDang);
                }
            }
            return baiDangHomePageDTOs;
        }

        
    }
}
