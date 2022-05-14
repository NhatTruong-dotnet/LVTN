using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangGiaiTri
    {
        private LVTNContext _context = new LVTNContext();

        public int AddBaiDang(BaiDangGiaiTriEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangGiaiTris.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangGiaiTris.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
