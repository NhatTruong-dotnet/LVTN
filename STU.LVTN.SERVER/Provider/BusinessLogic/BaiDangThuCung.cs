﻿using STU.LVTN.SERVER.Model;

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
    }
}
