using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class ThongBao
    {
        private LVTNContext _context = new LVTNContext();
        public async Task<bool> AddThongBao(ThongBaoEntities thongBaoRequest)
        {
            try
            {
                _context.ThongBaos.Add(thongBaoRequest);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> UpdateThongBao(ThongBaoEntities thongBaoRequest)
        {
            try
            {
                _context.ThongBaos.Update(thongBaoRequest);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
