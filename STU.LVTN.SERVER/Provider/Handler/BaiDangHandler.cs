using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Provider.Handler
{
    public class BaiDangHandler
    {
        BaiDang baiDangHelper;
        private readonly IMapper _mapper;
        BaiDangBatDongSan baiDangBatDongSanHelper;
        BaiDangXeCo baiDangXeCoHelper;
        public BaiDangHandler(IMapper mapper)
        {
            _mapper = mapper;
            baiDangHelper = new BaiDang(_mapper);
            baiDangBatDongSanHelper = new BaiDangBatDongSan();
            baiDangXeCoHelper = new BaiDangXeCo();
        }
        public async Task<List<BaiDangHomePageDTO>> RenderHomePage(int lastestSubCategories)
        {
            return await baiDangHelper.RenderHomePage(lastestSubCategories);
        }

        public async Task<List<BaiDangHomePageDTO>> GetSoldPostBySoDienThoai(string soDienThoai)
        {
            return await baiDangHelper.GetSoldPostBySoDienThoai(soDienThoai);
        }

        #region BaiDangBatDongSan
        public async Task<bool> AddBaiDangBatDongSanCC(BaiDangBatDongSanCC_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
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
        public async Task<bool> AddBaiDangBatDongSanNhaO(BaiDangBatDongSanNhaO_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
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
        public async Task<bool> AddBaiDangBatDongSanDat(BaiDangBatDongSanDat_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
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
        public async Task<bool> AddBaiDangBatDongSanVanPhong(BaiDangBatDongSanVanPhong_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
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
        public async Task<bool> AddBaiDangBatDongSanPhongTro(BaiDangBatDongSanPhongTro_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
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
        #endregion

        #region BaiDangXeCo
        public async Task<bool> AddBaiDangXeCoOTo(BaiDangXeCoOto_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
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

        public async Task<bool> AddBaiDangXeCoXeMay(BaiDangXeCoXeMay_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
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

        public async Task<bool> AddBaiDangXeCoXeTai(BaiDangXeCoXeTai_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
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

        public async Task<bool> AddBaiDangXeCoXeDien(BaiDangXeCoXeDien_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
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

        public async Task<bool> AddBaiDangXeCoXeDap(BaiDangXeCoXeDap_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
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

        public async Task<bool> AddBaiDangXeCoPhuongTienKhac(BaiDangXeCoPhuongTienKhac_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
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

        public async Task<bool> AddBaiDangXeCoPhuTungKhac(BaiDangXeCoPhuTungXe_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
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
        #endregion

        #region BaiDangDoDienTu

        #endregion
    }
}
