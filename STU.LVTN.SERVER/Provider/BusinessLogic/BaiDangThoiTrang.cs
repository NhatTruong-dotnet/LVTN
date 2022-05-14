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
    }
}
