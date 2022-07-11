using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class HinhAnh_BaiDang
    {
        private LVTNContext _context = new LVTNContext();
        public void AddHinhAnh(HinhAnhBaiDangEntities hinhAnhRequest)
        {
            try
            {
                _context.HinhAnhBaiDangs.Add(hinhAnhRequest);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                
            }
        }
        public void RemoveHinhAnh(HinhAnhBaiDangEntities hinhAnhRequest)
        {
            _context.HinhAnhBaiDangs.Remove(hinhAnhRequest);
            _context.SaveChanges();
        }
        public async Task<List<HinhAnhBaiDangEntities>> getHinhAnhBaiDangByIDPost(int idPost)
        {
            List<HinhAnhBaiDangEntities> result = _context.HinhAnhBaiDangs.Where(item => item.IdSanPham == idPost).ToList();
            return result;
        }
    }
}
