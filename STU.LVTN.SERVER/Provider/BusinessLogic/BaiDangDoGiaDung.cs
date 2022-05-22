using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangDoGiaDung
    {
        private LVTNContext _context = new LVTNContext();

        public int AddBaiDang(BaiDangDoGiaDungEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangDoGiaDungs.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangDoGiaDungs.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public Dictionary<string, string> getPost_BanGhe_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoGiaDungEntities entity = _context.BaiDangDoGiaDungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Loại sản phẩm: ", entity.LoaiSanPham);
            if (entity.BanGheChatLieu != null)
                post.Add("Chất liệu: ", entity.BanGheChatLieu);

            return post;
        }
        public Dictionary<string, string> getPost_TuKe_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoGiaDungEntities entity = _context.BaiDangDoGiaDungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Loại sản phẩm: ", entity.LoaiSanPham);
            if (entity.BanGheChatLieu != null)
                post.Add("Chất liệu: ", entity.BanGheChatLieu);

            return post;
        }
        public Dictionary<string, string> getPost_Giuong_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoGiaDungEntities entity = _context.BaiDangDoGiaDungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Loại sản phẩm: ", entity.LoaiSanPham);
            if (entity.GiuongChatLieu != null)
                post.Add("Kích cỡ: ", entity.GiuongChatLieu);

            return post;
        }
        public Dictionary<string, string> getPost_Bep_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoGiaDungEntities entity = _context.BaiDangDoGiaDungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Loại sản phẩm: ", entity.LoaiSanPham);
            return post;
        }
        public Dictionary<string, string> getPost_DenCayCanhNoiThat_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoGiaDungEntities entity = _context.BaiDangDoGiaDungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Loại sản phẩm: ", entity.LoaiSanPham);
            return post;
        }
        public Dictionary<string, string> getPost_Quat_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoGiaDungEntities entity = _context.BaiDangDoGiaDungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Loại sản phẩm: ", entity.LoaiSanPham);
            post.Add("Thương hiệu: ", entity.QuatThuongHieu);
            return post;
        }
        public Dictionary<string, string> getPost_ThietBiVeSinh_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoGiaDungEntities entity = _context.BaiDangDoGiaDungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Loại sản phẩm: ", entity.LoaiSanPham);
            post.Add("Thương hiệu: ", entity.ThietBiVeSinhThuongHieu);
            return post;
        }
    }
}
