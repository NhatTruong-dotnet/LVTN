﻿using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Provider.Handler
{
    public class BaiDangHandler
    {
        BaiDang baiDangHelper;
        private readonly IMapper _mapper;
        BaiDangBatDongSan baiDangBatDongSanHelper;
        public BaiDangHandler(IMapper mapper)
        {
            _mapper = mapper;
            baiDangHelper = new BaiDang(_mapper);
            baiDangBatDongSanHelper = new BaiDangBatDongSan();
        }
        public async Task<List<BaiDangHomePageDTO>> RenderHomePage(int lastestSubCategories)
        {
            return await baiDangHelper.RenderHomePage(lastestSubCategories);
        }

        public async Task<List<BaiDangHomePageDTO>> GetSoldPostBySoDienThoai(string soDienThoai)
        {
            return await baiDangHelper.GetSoldPostBySoDienThoai(soDienThoai);
        }

        public async Task<bool> AddBaiDangBatDongSanCC(BaiDangBatDongSanCC_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntites baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntites>(baiDangRequest);
            int lastIDPost = baiDangBatDongSanHelper.AddBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                return await baiDangHelper.AddBaiDang(baiDangGlobal);
            }
        }
    }
}
