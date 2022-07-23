using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangXeCo
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangXeCoEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangXeCos.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangXeCos.OrderByDescending(item => item.IdBaiDang).First().IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int UpdateBaiDang(BaiDangXeCoEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangXeCos.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public BaiDangXeCoEntities getPostByID(int IdPost)
        {
            return _context.BaiDangXeCos.Where(item => item.IdBaiDang == IdPost).FirstOrDefault();
        }
        public Dictionary<string, string> getPost_XeOto_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangXeCoEntities entity = _context.BaiDangXeCos.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hãng xe: ", entity.HangXe.ToString());
            post.Add("Năm sản xuất: ", entity.Nam.ToString());
            post.Add("Hộp số: ", entity.OtoHopSo.ToString());
            post.Add("Xuất xứ: ", entity.Xuatxu.ToString());
            post.Add("Số chỗ: ", entity.OtoSocho.ToString());
            post.Add("Dòng xe: ", entity.OtoDongXe.ToString());
            post.Add("Nhiên liệu: ", entity.OtoNhieuLieu.ToString());
            post.Add("Kiểu dáng: ", entity.OtoKieuDang.ToString());
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            return post;
        }
        public Dictionary<string, string> getPost_XeMay_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangXeCoEntities entity = _context.BaiDangXeCos.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hãng xe: ", entity.HangXe.ToString());
            post.Add("Năm đăng ký: ", entity.Nam.ToString());
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Dòng xe: ", entity.XeMayDongXe.ToString());
            post.Add("Số Km đã đi: ", entity.SoKmDaDi.ToString());
            post.Add("Loại xe: ", entity.XeMayLoaiXe.ToString());
            

            return post;
        }
        public Dictionary<string, string> getPost_XeTai_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangXeCoEntities entity = _context.BaiDangXeCos.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hãng xe tải: ", entity.HangXe.ToString());
            post.Add("Năm sản xuất: ", entity.Nam.ToString());
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Trọng tải: ", entity.XeTaiTrongTai.ToString());
            post.Add("Số Km đã đi: ", entity.SoKmDaDi.ToString());
            post.Add("Nhiên liệu: ", entity.XeTaiNhieuLieu.ToString());
            return post;
        }
        public Dictionary<string, string> getPost_XeDien_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangXeCoEntities entity = _context.BaiDangXeCos.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Loại xe: ", entity.XeDienLoaiXe.ToString());
            post.Add("Xuất xứ: ", entity.Xuatxu.ToString());
            post.Add("Hãng xe ", entity.HangXe.ToString());
            post.Add("Bảo hàng: ", entity.XeDienDaSuDung == true ? "Đã sử dụng" : "Mới");
            if (entity.XeDienMienPhi != null)
                if ((bool)entity.XeDienMienPhi) 
                    post.Add("Giá: ", "Cho tặng miễn phí");

            return post;
        }
        public Dictionary<string, string> getPost_XeDap_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangXeCoEntities entity = _context.BaiDangXeCos.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Dòng xe đạp thể thao: ", entity.XeDapLoaiXe.ToString());
            post.Add("Hãng xe ", entity.HangXe.ToString());
            post.Add("Tình trạng sử dụng: ", entity.XeDienDaSuDung == true ? "Đã sử dụng" : "Mới");
            if (entity.XeDapBaoHang != null)
                post.Add("Bảo hành: ", entity.XeDapBaoHang );
            if(entity.XeDapKichThuocKhung != null)
                post.Add("Kích thước khung: ", entity.XeDapKichThuocKhung );
            if (entity.XeDapChatLuongKhung != null)
                post.Add("Chất lượng khung: ", entity.XeDapChatLuongKhung );
            if (entity.XeDienMienPhi != null)
                if ((bool)entity.XeDienMienPhi)
                    post.Add("Giá: ", "Cho tặng miễn phí");

            return post;
        }
        public Dictionary<string, string> getPost_PhuongTienKhac_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangXeCoEntities entity = _context.BaiDangXeCos.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Loại xe: ", entity.HangXe.ToString());
            if(entity.Nam != null)
                post.Add("Năm sản xuất: ", entity.Nam.ToString());
            if (entity.PhuongTienKhacLoaiXeChuyenDung != null)
                post.Add("Loại xe chuyên dụng: ", entity.PhuongTienKhacNhienLieu.ToString());
            if (entity.PhuongTienKhacSoChoXeKhachXeBuyt != null)
                post.Add("Số chỗ: ", entity.PhuongTienKhacSoChoXeKhachXeBuyt.ToString());
            post.Add("Nhiên liệu ", entity.PhuongTienKhacNhienLieu.ToString());
            post.Add("Tình trạng sử dụng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            return post;
        }
        public Dictionary<string, string> getPost_PhuTungXe_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangXeCoEntities entity = _context.BaiDangXeCos.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Loại phụ tùng: ", entity.PhuTungXeLoaiPhuTung.ToString());
            if (entity.XeDienMienPhi != null)
                if ((bool)entity.XeDienMienPhi)
                    post.Add("Giá: ", "Cho tặng miễn phí");
            return post;
        }
    }
}
