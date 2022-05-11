using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Provider.Handler
{
    public class BaiDangHandler
    {
        BaiDang baiDangHelper;
        public BaiDangHandler()
        {
            baiDangHelper = new BaiDang();
        }
        public async Task<List<BaiDangHomePageDTO>> RenderHomePage(int lastestSubCategories)
        {
            return await baiDangHelper.RenderHomePage(lastestSubCategories);
        }

        public async Task<List<BaiDangHomePageDTO>> GetSoldPostBySoDienThoai(string soDienThoai)
        {
            return await baiDangHelper.GetSoldPostBySoDienThoai(soDienThoai);
        }
    }
}
