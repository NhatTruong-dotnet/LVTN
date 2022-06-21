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
                List<BaiDangEntities> lastest20BaiDang = new List<BaiDangEntities>();
                switch (lastestSubCategories)
                {
                    case 1:
                        lastest20BaiDang = await GetPostByIdDanhMucCon(13);
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(14));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(15));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(16));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(17));
                        break;
                    case 2:
                        lastest20BaiDang = await GetPostByIdDanhMucCon(18);
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(19));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(20));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(21));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(22));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(23));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(24));
                        break;
                    case 3:
                        lastest20BaiDang = await GetPostByIdDanhMucCon(25);
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(26));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(27));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(28));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(29));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(30));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(31));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(32));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(33));
                        break;
                    case 5:
                        lastest20BaiDang = await GetPostByIdDanhMucCon(34);
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(35));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(36));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(37));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(38));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(39));
                        break;
                    case 7:
                        lastest20BaiDang = await GetPostByIdDanhMucCon(40);
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(41));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(42));
                        break;
                    case 8:
                        lastest20BaiDang = await GetPostByIdDanhMucCon(43);
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(41));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(42));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(43));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(44));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(45));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(46));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(47));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(48));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(49));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(50));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(51));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(52));
                        break;
                    case 10:
                        lastest20BaiDang = await GetPostByIdDanhMucCon(53);
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(54));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(55));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(56));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(57));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(58));
                        break;
                    case 11:
                        lastest20BaiDang = await GetPostByIdDanhMucCon(59);
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(60));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(61));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(62));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(63));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(63));
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(64));
                        break;
                    case 12:
                        lastest20BaiDang = await GetPostByIdDanhMucCon(65);
                        lastest20BaiDang.AddRange(await GetPostByIdDanhMucCon(66));
                        break;
                    default:
                        break;
                }
                if (lastest20BaiDang.Count == 0)
                    lastest20BaiDang =await GetPostByIdDanhMucCon(lastestSubCategories);
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
        public async Task<List<BaiDangEntities>> GetPostByIdDanhMucCon(int IdDanhMucCon)
        {
            return  _context.BaiDangs
                    .Where(baiDang => baiDang.AnTin == false && baiDang.TrangThai == true && baiDang.IdDanhMucCon == IdDanhMucCon && baiDang.isReviewed == true)
                    .OrderByDescending(baidang => baidang.IdBaiDang)
                    .Take(20)
                    .ToList();
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

