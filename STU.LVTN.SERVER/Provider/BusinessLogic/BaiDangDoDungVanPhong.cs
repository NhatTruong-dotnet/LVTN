using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangDoDungVanPhong
    {
        private LVTNContext _context = new LVTNContext();

        public int AddBaiDang(BaiDangDoDungVanPhongEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangDoDungVanPhongs.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangDoDungVanPhongs.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
