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
    }
}
