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
        public int UpdateBaiDang(BaiDangGiaiTriEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangGiaiTris.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public BaiDangGiaiTriEntities GetPostByID(int ID)
        {
            return _context.BaiDangGiaiTris.Where(item => item.IdBaiDang == ID).FirstOrDefault();
        }
        public Dictionary<string, string> getPost_NhacCu_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangGiaiTriEntities entity = _context.BaiDangGiaiTris.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Loại nhạc cụ: ", entity.NhacCuLoaiNhacCu);
            return post;
        }
        public Dictionary<string, string> getPost_SachDoTheThaoThietBiChoiGameSoThichKhac_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangGiaiTriEntities entity = _context.BaiDangGiaiTris.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            return post;
        }
        public Dictionary<string, string> getPost_DoSuuTam_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangGiaiTriEntities entity = _context.BaiDangGiaiTris.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("Loại sản phảm: ", entity.DoSuuTamLoaiSanPham);
            return post;
        }
    }
}
