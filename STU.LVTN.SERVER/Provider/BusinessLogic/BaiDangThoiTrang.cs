using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangThoiTrang
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangThoiTrangEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangThoiTrangs.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangThoiTrangs.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int UpdateBaiDang(BaiDangThoiTrangEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangThoiTrangs.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public Dictionary<string, string> getPost_ThoiTrang_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangThoiTrangEntities entity = _context.BaiDangThoiTrangs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            return post;
        }
    }
}
