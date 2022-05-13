using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangDoGiaDung
    {
        private LVTNContext _context = new LVTNContext();

        public int AddBaiDang(BaiDangDoGiaDungEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangDoGiaDungs.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangDoGiaDungs.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
