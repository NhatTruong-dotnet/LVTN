using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangTuLanh
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangTuLanhEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangTuLanhs.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangTuLanhs.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int UpdateBaiDang(BaiDangTuLanhEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangTuLanhs.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public Dictionary<string, string> getPost_TuLanh_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangTuLanhEntities entity = _context.BaiDangTuLanhs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hãng: ", entity.Hang.ToString());
            post.Add("Thể tích: ", entity.TuLanhTheTich);
            return post;
        }
        public Dictionary<string, string> getPost_MayLanhDieuHoa_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangTuLanhEntities entity = _context.BaiDangTuLanhs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hãng: ", entity.Hang.ToString());
            post.Add("Công suất: ", entity.MayLanhCongSuat);
            return post;
        }
        public Dictionary<string, string> getPost_MayGiat_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangTuLanhEntities entity = _context.BaiDangTuLanhs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hãng: ", entity.Hang.ToString());
            if (entity.MayGiatCuaMayGiat != null)
                post.Add("Cửa máy giặt: ", entity.MayGiatCuaMayGiat);
            if (entity.MayGiatKhoiLuongGiat != null)
                post.Add("Khối lượng giặt: ", entity.MayGiatKhoiLuongGiat);
            return post;
        }
    }
}
