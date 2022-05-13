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
    }
}
