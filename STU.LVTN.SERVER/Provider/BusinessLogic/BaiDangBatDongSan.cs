using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangBatDongSan
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangBatDongSanEntities baiDangRequest)
        {
            try
            {
                baiDangRequest.IdBaiDang = _context.BaiDangBatDongSans.Count() + 1;
                _context.BaiDangBatDongSans.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangBatDongSans.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
