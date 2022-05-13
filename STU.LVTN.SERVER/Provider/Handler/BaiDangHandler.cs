using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;
using STU.LVTN.SERVER.Model.DTO.ThuCung;
using STU.LVTN.SERVER.Model.DTO.ViecLam;
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Provider.Handler
{
    public class BaiDangHandler
    {
        BaiDang baiDangHelper;
        private readonly IMapper _mapper;
        BaiDangBatDongSan baiDangBatDongSanHelper;
        BaiDangXeCo baiDangXeCoHelper;
        BaiDangDoDienTu baiDangDoDienTuHelper;
        BaiDangViecLam baiDangViecLamHelper;
        BaiDangThuCung baiDangThuCungHelper;
        public BaiDangHandler(IMapper mapper)
        {
            _mapper = mapper;
            baiDangHelper = new BaiDang(_mapper);
            baiDangBatDongSanHelper = new BaiDangBatDongSan();
            baiDangXeCoHelper = new BaiDangXeCo();
            baiDangDoDienTuHelper = new BaiDangDoDienTu();
            baiDangViecLamHelper = new BaiDangViecLam();
            baiDangThuCungHelper = new BaiDangThuCung();


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
        public async Task<bool> AddBaiDangDoDienTuDienThoai(BaiDangDoDienTuDienThoai_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
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

        public async Task<bool> AddBaiDangDoDienTuLaptop(BaiDangDoDienTuLaptop_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
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

        public async Task<bool> AddBaiDangDoDienTuLinhKien(BaiDangDoDienTuLinhKien_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
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

        public async Task<bool> AddBaiDangDoDienTuMayAnh(BaiDangDoDienTuMayAnh_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
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

        public async Task<bool> AddBaiDangDoDienTuMayTinhBang(BaiDangDoDienTuMayTinhBang_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
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

        public async Task<bool> AddBaiDangDoDienTuMayTinhDeBan(BaiDangDoDienTuMayTinhDeBan_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
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

        public async Task<bool> AddBaiDangDoDienTuPhuKien(BaiDangDoDienTuPhuKien_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
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

        public async Task<bool> AddBaiDangDoDienTuThietBiDeoThongMinh(BaiDangDoDienTuThietBiDeoThongMinh_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
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

        public async Task<bool> AddBaiDangDoDienTuTivi(BaiDangDoDienTuTivi_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
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

        #region BaiDangViecLam
        public async Task<bool> AddBaiDangViecLam(BaiDangViecLamDTO baiDangRequest)
        {
            BaiDangViecLamEntities baiDangViecLam = _mapper.Map<BaiDangViecLamEntities>(baiDangRequest);
            int lastIDPost = baiDangViecLamHelper.AddBaiDang(baiDangViecLam);
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

        #region BaiDangThuCung
        public async Task<bool> AddBaiDangThuCungChim(BaiDangThuCungChim_DTO baiDangRequest)
        {
            BaiDangThuCungEntities baiDangThuCung = _mapper.Map<BaiDangThuCungEntities>(baiDangRequest);
            int lastIDPost = baiDangThuCungHelper.AddBaiDang(baiDangThuCung);
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

        public async Task<bool> AddBaiDangThuCungCho(BaiDangThuCungCho_DTO baiDangRequest)
        {
            BaiDangThuCungEntities baiDangThuCung = _mapper.Map<BaiDangThuCungEntities>(baiDangRequest);
            int lastIDPost = baiDangThuCungHelper.AddBaiDang(baiDangThuCung);
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

        public async Task<bool> AddBaiDangThuCungGaMeoThuCungKhac(BaiDangThuCungGaMeoThuCungKhac_DTO baiDangRequest)
        {
            BaiDangThuCungEntities baiDangThuCung = _mapper.Map<BaiDangThuCungEntities>(baiDangRequest);
            int lastIDPost = baiDangThuCungHelper.AddBaiDang(baiDangThuCung);
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
    }


}
