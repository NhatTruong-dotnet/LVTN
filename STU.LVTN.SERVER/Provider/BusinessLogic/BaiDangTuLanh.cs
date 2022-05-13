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
    }
}
