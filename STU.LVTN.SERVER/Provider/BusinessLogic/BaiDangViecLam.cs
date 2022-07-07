using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangViecLam
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangViecLamEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangViecLams.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangViecLams.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int UpdateBaiDang(BaiDangViecLamEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangViecLams.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public BaiDangViecLamEntities GetPostByID(int ID)
        {
            return _context.BaiDangViecLams.Where(item => item.IdBaiDang == ID).FirstOrDefault();
        }
        public Dictionary<string, string> getPost_ViecLam_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangViecLamEntities entity = _context.BaiDangViecLams.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Hình thức trả lương: ", entity.HinhThucTraLuong.ToString());
            post.Add("Ngành nghề: ", entity.NganhNghe);
            post.Add("Loại công việc: ", entity.LoaiCongViec);
            if (entity.LuongToiThieu != null)
                post.Add("Bảo hành: ", entity.LuongToiThieu.ToString());
            if (entity.LuongToiDa != null)
                post.Add("Bảo hành: ", entity.LuongToiDa.ToString());
            if (entity.Nam == null)
                post.Add("Giới tính: ","Không yêu cầu");
            else
                post.Add("Giới tính: ", entity.Nam == true? "Nam":"Nữ");
            if (entity.HocVanToiThieu != null)
                post.Add("Học vấn tối thiểu: ", entity.HocVanToiThieu);
            if (entity.KinhNghiem != null)
                post.Add("Yêu cầu kinh nghiệm: ", entity.KinhNghiem);
            if (entity.ChungChi != null)
                post.Add("Yêu cầu chứng chỉ: ", entity.ChungChi);
            post.Add("preflightKey: ", "viecLam");
            return post;
        }
    }
}
