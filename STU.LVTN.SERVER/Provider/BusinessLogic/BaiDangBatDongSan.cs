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
            post.Add("Cần bán: ", entity.CanBan == true ? "true" : "false");
            post.Add("Mã căn: ", entity.CcMaCan);
            post.Add("Tên phân khu/Lô/Block/Tháp: ", entity.CcBlock);
            post.Add("Tầng số: ", entity.CcTangSo);
            post.Add("Tình trạng bất động sản: ", entity.CcChuaBanGiao == true ? "Chưa bàn giao" : "Đã bàn giao");
            post.Add("Loại hình chung cư: ", entity.CcLoaiHinh);
            post.Add("Số phòng ngủ: ", entity.CcSoPhongNgu.ToString());
            return post;
        }

        public Dictionary<string, string> getPost_NhaO_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangBatDongSanEntities entity = _context.BaiDangBatDongSans.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Diện tích đất : ", entity.NhaOSoPhongNgu.ToString());
            post.Add("Số phòng ngủ: ", entity.DienTich.ToString());
            post.Add("Giấy tờ pháp lí: ", entity.NhaOLoaiHinh);
            post.Add("Loại hình nhà ở: ", entity.NhaOLoaiHinh);
            post.Add("Chiều dài: ", entity.NhaOChieuDai.ToString());
            post.Add("Tổng số tầng: ", entity.NhaOTongSoTang.ToString());
            if ((bool)entity.NhaOHemXeHoi || (bool)entity.NhaONoHau)
                post.Add("Đặc điểm nhà đất: ", entity.NhaOHemXeHoi == true ? "Hẻm xe hơi" : entity.NhaONoHau == true ? "Nở hậu":"");
            post.Add("Chiều ngang: ", entity.NhaOChieuNgang.ToString());
            post.Add("Diện tích sử dụng : ", entity.DienTich.ToString());
            post.Add("Số phòng ngủ: ", entity.CcSoPhongNgu.ToString());
            return post;
        }
        public Dictionary<string, string> getPost_Dat_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangBatDongSanEntities entity = _context.BaiDangBatDongSans.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Diện tích đất : ", entity.DienTich.ToString());
            if ((bool)entity.DatHemXeHoi)
                post.Add("Đặc điểm đất: ",  "Hẻm xe hơi" );
            if ( (bool)entity.DatNoHau)
                post.Add("Đặc điểm đất: ",  "Nở hậu");
            if ((bool)entity.DatMatTien)
                post.Add("Đặc điểm đất: " ,"Đất mặt tiền");
            post.Add("Loại hình đất: ", entity.DatLoaiHinhDat.ToString());
            post.Add("Hướng đất: ", entity.DatHuongDat.ToString());
            post.Add("Chiều ngang: ", entity.DatChieuNgang.ToString());
            post.Add("Chiều dài: ", entity.DatChieuDai.ToString());
            return post;
        }
        public Dictionary<string, string> getPost_VanPhong_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangBatDongSanEntities entity = _context.BaiDangBatDongSans.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Diện tích: ", entity.DienTich.ToString());
            post.Add("Loại hình văn phòng: ", entity.VanPhongLoaiHinhVanPhong.ToString());
            
            return post;
        }
    }
}
