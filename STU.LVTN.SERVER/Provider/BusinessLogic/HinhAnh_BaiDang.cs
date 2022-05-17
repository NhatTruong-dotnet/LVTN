﻿using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class HinhAnh_BaiDang
    {
        private LVTNContext _context = new LVTNContext();
        public void AddHinhAnh(HinhAnhBaiDangEntities hinhAnhRequest)
        {
            try
            {
                _context.HinhAnhBaiDangs.Add(hinhAnhRequest);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
