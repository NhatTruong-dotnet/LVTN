using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangMeVaBe
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangMeVaBeEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangMeVaBes.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangMeVaBes.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int UpdateBaiDang(BaiDangMeVaBeEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangMeVaBes.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public Dictionary<string, string> getPost_MeVaBe_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangMeVaBeEntities entity = _context.BaiDangMeVaBes.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true?"Đã sử dụng":"Mới");
            post.Add("Loại sản phẩm: ", entity.LoaiSanPham);
            return post;
        }
    }
}
