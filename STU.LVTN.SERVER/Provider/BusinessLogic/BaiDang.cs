using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDang
    {
        private LVTNContext _context = new LVTNContext();

        public async Task<List<BaiDangHomePageDTO>> RenderHomePage(int lastestSubCategories)
        {
            List<BaiDangHomePageDTO> baiDangHomePageDTOs = new List<BaiDangHomePageDTO>();
            if (lastestSubCategories == 0)
            {
                // an tin false, trang thai true
                _context.BaiDangs.Where(baiDang => baiDang.AnTin == false && baiDang.TrangThai == true).ToList();
            }
            else
            {

            }
            return baiDangHomePageDTOs;
        }
    }
}
