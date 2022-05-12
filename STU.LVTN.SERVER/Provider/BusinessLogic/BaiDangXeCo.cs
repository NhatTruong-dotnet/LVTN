using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangXeCo
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangXeCoEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangXeCos.Add(baiDangRequest);
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
