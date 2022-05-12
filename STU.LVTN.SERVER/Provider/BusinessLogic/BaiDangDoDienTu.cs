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
                baiDangRequest.IdBaiDang = _context.BaiDangDoDienTus.Count() + 1;
                _context.BaiDangDoDienTus.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangDoDienTus.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
