using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangThuCung
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangThuCungEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangThuCungs.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangDoDienTus.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int UpdateBaiDang(BaiDangThuCungEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangThuCungs.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public BaiDangThuCungEntities GetPostByID(int ID)
        {
            return _context.BaiDangThuCungs.Where(item => item.IdBaiDang == ID).FirstOrDefault();
        }
        public Dictionary<string, string> getPost_ThuCungGaMeoThuCungKhac_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangThuCungEntities entity = _context.BaiDangThuCungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Giống thú cưng: ", entity.GiongThuCung.ToString());
            post.Add("Độ tuổi: ", entity.DoTuoi.ToString());

            return post;
        }
        public Dictionary<string, string> getPost_ThuCungCho_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangThuCungEntities entity = _context.BaiDangThuCungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Giống thú cưng: ", entity.GiongThuCung.ToString());
            post.Add("Độ tuổi: ", entity.DoTuoi.ToString());
            post.Add("Kích cỡ: ", entity.ChoKichCo.ToString());

            return post;
        }
        public Dictionary<string, string> getPost_ThuCungChim_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangThuCungEntities entity = _context.BaiDangThuCungs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Giống thú cưng: ", entity.GiongThuCung.ToString());
            post.Add("Độ tuổi: ", entity.DoTuoi.ToString());
            post.Add("Giới tính: ", entity.ChimGioiTinh.ToString());

            return post;
        }
    }
}
