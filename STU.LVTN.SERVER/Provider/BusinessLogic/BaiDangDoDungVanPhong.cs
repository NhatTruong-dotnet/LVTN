﻿using STU.LVTN.SERVER.Model;

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
        public int UpdateBaiDang(BaiDangDoDungVanPhongEntities baiDangRequest)
        {
            try
            {
                _context.BaiDangDoDungVanPhongs.Update(baiDangRequest);
                _context.SaveChanges();
                return baiDangRequest.IdBaiDang;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public BaiDangDoDungVanPhongEntities GetPostByID(int ID)
        {
            return _context.BaiDangDoDungVanPhongs.Where(item => item.IdBaiDang == ID).FirstOrDefault();
        }
        public Dictionary<string, string> getPost_ThoiTrang_ByID(int? idPostDetail)
        {
            Dictionary<string, string> post = new Dictionary<string, string>();
            BaiDangThoiTrangEntities entity = _context.BaiDangThoiTrangs.Where(item => item.IdBaiDang == idPostDetail).FirstOrDefault();
            post.Add("Tình trạng: ", entity.DaSuDung == true ? "Đã sử dụng" : "Mới");
            post.Add("preflightKey: ", "baiDangDoDungVanPhong");
            return post;
        }
    }
}
