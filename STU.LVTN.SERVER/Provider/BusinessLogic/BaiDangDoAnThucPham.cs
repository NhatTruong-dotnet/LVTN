using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangDoAnThucPham
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangDoAnThucPhamEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangDoAnThucPhams.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangDoAnThucPhams.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int UpdateBaiDang(BaiDangDoAnThucPhamEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangDoAnThucPhams.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public Dictionary<string, string> getPost_DoAn_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangDoAnThucPhamEntities entity = _context.BaiDangDoAnThucPhams.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Loại thực phẩm: ", entity.LoaiThucPham.ToString());
            return post;
        }
    }
}
