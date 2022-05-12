using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDang
    {
        private LVTNContext _context = new LVTNContext();
        private readonly IMapper _mapper;

        public BaiDang(IMapper mapper)
        {
            _mapper = mapper;
        }
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

        public async Task<List<BaiDangHomePageDTO>> GetSoldPostBySoDienThoai(string soDienThoai)
        {
            List<BaiDangHomePageDTO> baiDangHomePageDTOs = new List<BaiDangHomePageDTO>();
                List<BaiDangEntities> lastest20BaiDang = _context.BaiDangs
                     .Where(baiDang => baiDang.SdtNguoiBan == soDienThoai)
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
            

            return baiDangHomePageDTOs;
        }

        public async Task<bool> AddBaiDang(BaiDangEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangs.Add(baiDangRequest);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
