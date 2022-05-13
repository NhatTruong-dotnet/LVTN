using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangViecLam
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangViecLamEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangViecLams.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangViecLams.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
