using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;
using System.Globalization;

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
        public async Task<bool> SendApproveResult(ApproveResultDTO approveResult)
        { 
            try
            {
                BaiDangEntities baiDang = _context.BaiDangs.Where(item => item.IdBaiDang == approveResult.IDPost).FirstOrDefault();
                baiDang.TrangThai = approveResult.ApproveResult;
                baiDang.isReviewed = true;
                _context.BaiDangs.Update(baiDang);

                ThongBaoEntities thongBao = new ThongBaoEntities();
                thongBao.IDPost = baiDang.IdBaiDang;
                thongBao.SdtNguoiDung = baiDang.SdtNguoiBan;
                thongBao.TieuDeThongBao = approveResult.ApproveResult == false ? "Bài đăng của bạn đã bị từ chối" :"Bài đăng của bạn đã được phê duyệt";
                thongBao.Comment = approveResult.Comment == null ? null : approveResult.Comment;
                thongBao.Checked = false;
                _context.ThongBaos.Add(thongBao);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<List<BaiDangHomePageDTO>> RenderHomePage(int lastestSubCategories)
        {
            List<BaiDangHomePageDTO> baiDangHomePageDTOs = new List<BaiDangHomePageDTO>();
            if (lastestSubCategories == 0)
            {
               List<BaiDangEntities> lastest20BaiDang =  _context.BaiDangs
                    .Where(baiDang => baiDang.AnTin == false && baiDang.TrangThai == true && baiDang.isReviewed == true)
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
                    newBaiDang.NgayTao = $"{baiDang.CreatedDate:dd-MM-yyyy HH:mm}" ;

                    baiDangHomePageDTOs.Add(newBaiDang);
                }
            }
            else
            {
                List<BaiDangEntities> lastest20BaiDang = _context.BaiDangs
                    .Where(baiDang => baiDang.AnTin == false && baiDang.TrangThai == true && baiDang.IdDanhMucCon == lastestSubCategories && baiDang.isReviewed == true)
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
                    newBaiDang.NgayTao = $"{baiDang.CreatedDate:dd-MM-yyyy HH:mm}";

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
                    newBaiDang.NgayTao = $"{baiDang.CreatedDate:dd-MM-yyyy HH:mm}";

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

        public async Task<BaiDangEntities> GetPostByID(int IDPost)
        {
            try
            {
                return _context.BaiDangs.Where(baiDang => baiDang.IdBaiDang == IDPost).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int NumberOfPost()
        {
            return _context.BaiDangs.OrderByDescending(item => item.IdBaiDang).FirstOrDefault().IdBaiDang;
        }
        public List<Admin_PostDTO> GetAllPost()
        {
            List<BaiDangEntities> baiDangs = _context.BaiDangs.OrderByDescending(item => item.IdBaiDang).ToList();
            List<Admin_PostDTO> result = new List<Admin_PostDTO>();
            foreach (var item in baiDangs)
            {
                Admin_PostDTO temp = new Admin_PostDTO();
                temp.IDPost = item.IdBaiDang;
                temp.SDTNguoiBan = item.SdtNguoiBan;
                temp.TieuDe = item.TieuDe;
                temp.IsReviewed = (bool)item.isReviewed;
                temp.TenDanhMuc = _context.DanhMucs.Where(danhMuc => danhMuc.IdDanhMuc == item.IdDanhMucCon).First().TenDanhMuc;
                result.Add(temp);
            }
            return result;
        }
    }
}

