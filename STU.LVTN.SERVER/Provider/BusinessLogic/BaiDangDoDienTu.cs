using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangDoDienTu
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangDoDienTuEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangDoDienTus.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangDoDienTus.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public Dictionary<string, string> getPost_DienThoai_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoDienTuEntities entity = _context.BaiDangDoDienTus.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hãng: ", entity.DienThoaiHang);
            post.Add("Tình trạng: ", entity.TinhTrang.ToString());
            post.Add("Dòng máy: ", entity.DienThoaiDongMay);
            post.Add("Màu sắc: ", entity.DienThoaiMauSac);
            if (entity.DienThoaiDungLuong != null)
                post.Add("Dung lượng: ", entity.DienThoaiDungLuong);
            if ((bool)entity.BaoHanh)
                post.Add("Bảo hành: ", entity.BaoHanh == true ? "Còn bảo hành" : "Hết bảo hành");
            return post;
        }
        public Dictionary<string, string> getPost_MayTinhBang_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoDienTuEntities entity = _context.BaiDangDoDienTus.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hãng: ", entity.MayTinhBangHang);
            post.Add("Tình trạng: ", entity.TinhTrang.ToString());
            post.Add("Dòng máy: ", entity.MayTinhBangDongMay);
            if (entity.MayTinhBangKichCoManHinh != null)
                post.Add("Kích cỡ màn hình: ", entity.MayTinhBangKichCoManHinh);
            if (entity.MayTinhBangDungLuong != null)
                post.Add("Dung lượng: ", entity.MayTinhBangDungLuong);
            if ((bool)entity.MayTinhBang4g)
                post.Add("Sử dụng 4G: ", entity.MayTinhBang4g == true? "Có sử dụng":"Không sử dụng");
            if ((bool)entity.MayTinhBangQuocTe)
                post.Add("Phiên bản: ", entity.MayTinhBangQuocTe == true?"Quốc tế":"Khóa mạng (lock)");
            if ((bool)entity.BaoHanh)
                post.Add("Bảo hành: ", entity.BaoHanh == true ? "Còn bảo hành" : "Hết bảo hành");
            return post;
        }
        public Dictionary<string, string> getPost_Laptop_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoDienTuEntities entity = _context.BaiDangDoDienTus.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hãng: ", entity.LaptopHang);
            post.Add("Tình trạng: ", entity.TinhTrang.ToString());
            post.Add("Dòng máy: ", entity.LaptopDongMay);
            if (entity.LaptopBoViXuly != null)
                post.Add("Bộ vi xử lý: ", entity.LaptopBoViXuly);
            if (entity.LaptopRam != null)
                post.Add("RAM: ", entity.MayTinhBangDungLuong);
            if (entity.LaptopOcung != null)
                post.Add("Dung lượng ổ cứng: ", entity.LaptopOcung );
            if ((bool)entity.LaptopHdd)
                post.Add("Loại ổ cứng: ", entity.LaptopHdd == true ? "HDD" : "SSD");
            if (entity.LaptopCardManHinh != null)
                post.Add("Card màn hình: ", entity.LaptopCardManHinh );
            if (entity.LaptopKichCoManHinh != null)
                post.Add("Kích cỡ: ", entity.LaptopKichCoManHinh);
            if ((bool)entity.BaoHanh)
                post.Add("Bảo hành: ", entity.BaoHanh == true ?"Còn bảo hành":"Hết bảo hành");
            return post;
        }
        public Dictionary<string, string> getPost_MayTinhDeBan_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoDienTuEntities entity = _context.BaiDangDoDienTus.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.TinhTrang.ToString());
            if (entity.LaptopBoViXuly != null)
                post.Add("Bộ vi xử lý: ", entity.MayTinhDeBanBoViXuly);
            if (entity.LaptopRam != null)
                post.Add("RAM: ", entity.MayTinhDeBanRam);
            if (entity.MayTinhDeBanOcung != null)
                post.Add("Dung lượng ổ cứng: ", entity.MayTinhDeBanOcung);
            if ((bool)entity.MayTinhDeBanHdd)
                post.Add("Loại ổ cứng: ", entity.MayTinhDeBanHdd == true ? "HDD" : "SSD");
            if (entity.MayTinhDeBanCardManHinh != null)
                post.Add("Card màn hình: ", entity.MayTinhDeBanCardManHinh);
            if (entity.MayTinhDeBanKichCoManHinh != null)
                post.Add("Kích cỡ màn hình: ", entity.MayTinhDeBanKichCoManHinh);
            if ((bool)entity.MayTinhDeBanMienPhi)
                post.Add("Cho tặng miễn phí","");
            
            return post;
        }
        public Dictionary<string, string> getPost_MayAnhMayQuayOngKinh_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoDienTuEntities entity = _context.BaiDangDoDienTus.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Thiết bị: ", entity.MayAnhThietBi.ToString());
            if (entity.ThietBiDongMay != null)
                post.Add("Dòng máy: ", entity.ThietBiDongMay);
            if (entity.TinhTrang != null)
                post.Add("Tình trạng: ", entity.TinhTrang);
            if (entity.BaoHanh != null)
                post.Add("Bảo hành: ", entity.BaoHanh == true ? "Còn bảo hành": "Hết bảo hành");
            if ((bool)entity.MayTinhDeBanHdd)
                post.Add("Loại ổ cứng: ", entity.MayTinhDeBanHdd == true ? "HDD" : "SSD");
            return post;
        }
        public Dictionary<string, string> getPost_TiviAmThanh_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoDienTuEntities entity = _context.BaiDangDoDienTus.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Thiết bị: ", entity.TiviThietBi.ToString());
            if (entity.TiviHang != null)
                post.Add("Hãng: ", entity.TiviHang);
            if (entity.TinhTrang != null)
                post.Add("Tình trạng: ", entity.TinhTrang);
            if (entity.BaoHanh != null)
                post.Add("Bảo hành: ", entity.BaoHanh == true ? "Còn bảo hành" : "Hết bảo hành");
            
            return post;
        }
        public Dictionary<string, string> getPost_ThietBiDeoThongMinh_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoDienTuEntities entity = _context.BaiDangDoDienTus.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Thiết bị: ", entity.ThietBiDeoThongMinhHang.ToString());
                post.Add("Hãng: ", entity.ThietBiDeoThongMinhHang);
                post.Add("Tình trạng: ", entity.TinhTrang);
            if (entity.BaoHanh != null)
                post.Add("Bảo hành: ", entity.BaoHanh == true ? "Còn bảo hành" : "Hết bảo hành");

            return post;
        }
        public Dictionary<string, string> getPost_PhuKien_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoDienTuEntities entity = _context.BaiDangDoDienTus.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Loại phụ kiện: ", entity.PhuKienLoaiPhuKien.ToString());
            post.Add("Thiết bị: ", entity.PhuKienThietBi);
            post.Add("Tình trạng: ", entity.PhuKienTinhTrang);
            if (entity.BaoHanh != null)
                post.Add("Bảo hành: ", entity.BaoHanh == true ? "Còn bảo hành" : "Hết bảo hành");

            return post;
        }
        public Dictionary<string, string> getPost_LinhKien_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoDienTuEntities entity = _context.BaiDangDoDienTus.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Loại linh kiện: ", entity.LinhKienLoaiPhuKien.ToString());
            post.Add("Thiết bị: ", entity.LinhKienThietBi);
            post.Add("Tình trạng: ", entity.LinhKienTinhTrang);
            if (entity.BaoHanh != null)
                post.Add("Bảo hành: ", entity.BaoHanh == true ? "Còn bảo hành" : "Hết bảo hành");

            return post;
        }
    }
}
