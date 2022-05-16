using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class BaiDangBatDongSan
    {
        private LVTNContext _context = new LVTNContext();
        public int AddBaiDang(BaiDangBatDongSanEntities baiDangRequest)
        {
            try
            {
                baiDangRequest.IdBaiDang = _context.BaiDangBatDongSans.Count() + 1;
                _context.BaiDangBatDongSans.Add(baiDangRequest);
                _context.SaveChanges();
                return _context.BaiDangBatDongSans.Count();
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public Dictionary<string, string> getPost_CC_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangBatDongSanEntities entity = _context.BaiDangBatDongSans.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tên dự án: ", entity.TenDuAn);
            post.Add("Diện tích: ", entity.DienTich.ToString());
            post.Add("Cần bán: ", entity.CanBan == true? "true":"false");
            post.Add("Mã căn: ", entity.CcMaCan);
            post.Add("Tên phân khu/Lô/Block/Tháp: ", entity.CcBlock);
            post.Add("Tầng số: ", entity.CcTangSo);
            post.Add("Tình trạng bất động sản: ", entity.CcChuaBanGiao == true ? "Chưa bàn giao": "Đã bàn giao");
            post.Add("Loại hình chung cư: ", entity.CcLoaiHinh);
            post.Add("Số phòng ngủ: ", entity.CcSoPhongNgu.ToString());
            return post;
        }

        
    }
}
