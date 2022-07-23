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

        public int UpdateBaiDang(BaiDangBatDongSanEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangBatDongSans.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public BaiDangBatDongSanEntities getPostByID(int IdPost)
        {
            return _context.BaiDangBatDongSans.Where(item => item.IdBaiDang == IdPost).FirstOrDefault();
        }
        public Dictionary<string, string> getPost_CC_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangBatDongSanEntities entity = _context.BaiDangBatDongSans.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tên dự án: ", entity.TenDuAn);
            post.Add("Diện tích: ", String.Format("{0:n0}",double.Parse(entity.DienTich?.ToString())) );
            post.Add("Nhu cầu: ", entity.CanBan == true ? "Bán" : "Cho thuê");
            post.Add("Mã căn: ", entity.CcMaCan);
            post.Add("Tên phân khu/Lô/Block/Tháp: ", entity.CcBlock);
            post.Add("Tầng số: ", entity.CcTangSo);
            post.Add("Tình trạng bất động sản: ", entity.CcChuaBanGiao == true ? "Chưa bàn giao" : "Đã bàn giao");
            post.Add("Loại hình chung cư: ", entity.CcLoaiHinh);
            post.Add("Số phòng ngủ: ", entity.CcSoPhongNgu.ToString());
            post.Add("Tình trạng chung cư: ", entity.CcChuaBanGiao == false ? "Chưa bàn giao" : "Đã bàn giao");
            if (entity.soToilet != null)
                post.Add("Số toilet: ", entity.soToilet.ToString());
            return post;
        }
        public Dictionary<string, string> getPost_NhaO_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangBatDongSanEntities entity = _context.BaiDangBatDongSans.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Diện tích đất : ", String.Format("{0:n0}",double.Parse(entity.DienTich?.ToString())));
            post.Add("Số phòng ngủ: ", entity.NhaOSoPhongNgu.ToString());
            if (entity.NhaOGiayToPhapLy != null) 
                post.Add("Giấy tờ pháp lí: ", entity.NhaOGiayToPhapLy);
            post.Add("Loại hình nhà ở: ", entity.NhaOLoaiHinh);
            post.Add("Chiều dài: ", String.Format("{0:n0}", double.Parse(entity.NhaOChieuDai?.ToString())));
            post.Add("Tổng số tầng: ", entity.NhaOTongSoTang.ToString());
            if ((bool)entity.NhaOHemXeHoi || (bool)entity.NhaONoHau)
                post.Add("Đặc điểm nhà đất: ", entity.NhaOHemXeHoi == true ? "Hẻm xe hơi" : entity.NhaONoHau == true ? "Nở hậu":"");
            post.Add("Chiều ngang: ",  String.Format("{0:n0}", double.Parse(entity.NhaOChieuNgang?.ToString())));
            post.Add("Diện tích sử dụng : ", entity.DienTich.ToString());
            
            return post;
        }
        public Dictionary<string, string> getPost_Dat_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangBatDongSanEntities entity = _context.BaiDangBatDongSans.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            string DacDiemDat = null;
            post.Add("Diện tích đất : ", entity.DienTich.ToString());
            if ((bool)entity.DatHemXeHoi)
                DacDiemDat += "Hẻm xe hơi";
            if ( (bool)entity.DatNoHau)
                DacDiemDat += ", Nở hậu";
            if ((bool)entity.DatMatTien)
                DacDiemDat += ", Đất mặt tiền";
            if(DacDiemDat != null)
                post.Add("Đặc điểm đất: ",DacDiemDat);
            post.Add("Loại hình đất: ", entity.DatLoaiHinhDat.ToString());
            post.Add("Hướng đất: ", entity.DatHuongDat.ToString());
            post.Add("Chiều ngang: ",  String.Format("{0:n0}", double.Parse(entity.DatChieuNgang?.ToString())));
            post.Add("Chiều dài: ",  String.Format("{0:n0}", double.Parse(entity.DatChieuDai?.ToString())));
            if (entity.DatGiayToPhapLy != null)
                post.Add("Giấy tờ pháp lý: ", entity.DatGiayToPhapLy);
            return post;
        }
        public Dictionary<string, string> getPost_VanPhong_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangBatDongSanEntities entity = _context.BaiDangBatDongSans.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Diện tích: ", entity.DienTich.ToString());
            
            if (entity.VanPhongGiayToPhapLy != null)
                post.Add("Giấy tờ pháp lý: ", entity.VanPhongGiayToPhapLy);
            if (entity.VanPhongHuongCuaChinh != null)
                post.Add("Hướng cửa chính: ", entity.VanPhongHuongCuaChinh);
            return post;
        }
    }
}
