using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;
using STU.LVTN.SERVER.Model.DTO.DoAnThucPham;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;
using STU.LVTN.SERVER.Model.DTO.DoDungVanPhong;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.BanGhe;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Bep;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.DenCayCanhNoiThat;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Giuong;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Quat;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.ThietBiVeSinh;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.TuKe;
using STU.LVTN.SERVER.Model.DTO.GiaiTri;
using STU.LVTN.SERVER.Model.DTO.GiaiTri.DoSuuTam;
using STU.LVTN.SERVER.Model.DTO.GiaiTri.NhacCu;
using STU.LVTN.SERVER.Model.DTO.MeVaBe;
using STU.LVTN.SERVER.Model.DTO.ThoiTrang;
using STU.LVTN.SERVER.Model.DTO.ThuCung;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayGiat;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;
using STU.LVTN.SERVER.Model.DTO.TuLanh.TuLanh;
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
        BaiDangDoAnThucPham baiDangDoAnThucPhamHelper;
        BaiDangTuLanh baiDangTuLanhHelper;
        BaiDangDoGiaDung baiDangDoGiaDungHelper;
        BaiDangMeVaBe baiDangMeVaBeHelper;
        BaiDangThoiTrang baiDangThoiTrangHelper;
        BaiDangGiaiTri baiDangGiaiTriHelper;
        BaiDangDoDungVanPhong baiDangDoDungVanPhongHelper;
        HinhAnh_BaiDang hinhAnhBaiDangHelper;
        public BaiDangHandler(IMapper mapper)
        {
            _mapper = mapper;
            baiDangHelper = new BaiDang(_mapper);
            baiDangBatDongSanHelper = new BaiDangBatDongSan();
            baiDangXeCoHelper = new BaiDangXeCo();
            baiDangDoDienTuHelper = new BaiDangDoDienTu();
            baiDangViecLamHelper = new BaiDangViecLam();
            baiDangThuCungHelper = new BaiDangThuCung();
            baiDangDoAnThucPhamHelper = new BaiDangDoAnThucPham();
            baiDangTuLanhHelper = new BaiDangTuLanh();
            baiDangDoGiaDungHelper = new BaiDangDoGiaDung();
            baiDangMeVaBeHelper = new BaiDangMeVaBe();
            baiDangThoiTrangHelper = new BaiDangThoiTrang();
            baiDangGiaiTriHelper = new BaiDangGiaiTri();
            baiDangDoDungVanPhongHelper = new BaiDangDoDungVanPhong();
            hinhAnhBaiDangHelper = new HinhAnh_BaiDang();
        }
        public async Task<List<BaiDangHomePageDTO>> RenderHomePage(int lastestSubCategories)
        {
            return await baiDangHelper.RenderHomePage(lastestSubCategories);
        }

        public async Task<List<BaiDangHomePageDTO>> GetSoldPostBySoDienThoai(string soDienThoai)
        {
            return await baiDangHelper.GetSoldPostBySoDienThoai(soDienThoai);
        }

        public async Task<Dictionary<string, Dictionary<string ,string>>> GetPostByID(int IDPost)
        {
            BaiDangEntities post = await baiDangHelper.GetPostByID(IDPost);
            Dictionary<string, Dictionary<string ,string>> result = new Dictionary<string, Dictionary<string ,string>>();
            int idDanhMucSanPham = post.IdDanhMucCha;
            int? idDanhMucBaiDang = post.IdDanhMucCon;
            #region BaiDang global
            Dictionary<string, string> postDictionary = new Dictionary<string, string>();
            postDictionary.Add("tieuDe", post.TieuDe);
            postDictionary.Add("moTa", post.Mota);
            postDictionary.Add("gia", post.Gia.ToString());
            postDictionary.Add("sdt", post.SdtNguoiBan);
            postDictionary.Add("khuVuc", post.PhuongXa + ", " + post.QuanHuyen + ", " + post.ThanhPho);
            result.Add("BaiDang", postDictionary);
            #endregion
            switch (idDanhMucBaiDang)
            {
                case 13:
                    result.Add("detail", baiDangBatDongSanHelper.getPost_CC_ByID(post.IdBaiDangChiTiet));
                    break;
                default:
                    break;
            }
            return result;
        }

        #region Create
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
                foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                {
                    HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                    hinhAnhRequest.IdSanPham = lastIDPost;
                    hinhAnhRequest.IdMediaCloud = item.id;
                    if (item.type.Contains("video"))
                        hinhAnhRequest.VideoType = true;
                    else
                        hinhAnhRequest.VideoType = false;
                    hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                }
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

        #region BaiDangDoAnThucPham
        public async Task<bool> AddBaiDangDoAnThucPham(BaiDangDoAnThucPham_DTO baiDangRequest)
        {
            BaiDangDoAnThucPhamEntities baiDangThucPham = _mapper.Map<BaiDangDoAnThucPhamEntities>(baiDangRequest);
            int lastIDPost = baiDangDoAnThucPhamHelper.AddBaiDang(baiDangThucPham);
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

        #region BaiDangTuLanh
        public async Task<bool> AddBaiDangTuLanh(BaiDangTuLanhTL_DTO baiDangRequest)
        {
            BaiDangTuLanhEntities baiDangTuLanh = _mapper.Map<BaiDangTuLanhEntities>(baiDangRequest);
            int lastIDPost = baiDangTuLanhHelper.AddBaiDang(baiDangTuLanh);
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

        public async Task<bool> AddBaiDangMayGiat(BaiDangTuLanhMayGiat_DTO baiDangRequest)
        {
            BaiDangTuLanhEntities baiDangMayGiat = _mapper.Map<BaiDangTuLanhEntities>(baiDangRequest);
            int lastIDPost = baiDangTuLanhHelper.AddBaiDang(baiDangMayGiat);
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

        public async Task<bool> AddBaiDangMayLanh(BaiDangTuLanhMayLanh_DTO baiDangRequest)
        {
            BaiDangTuLanhEntities baiDangMayLanh = _mapper.Map<BaiDangTuLanhEntities>(baiDangRequest);
            int lastIDPost = baiDangTuLanhHelper.AddBaiDang(baiDangMayLanh);
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

        #region BaiDang DoGiaDung
        public async Task<bool> AddBaiDangDoGiaDungBanGhe(BaiDangDoGiaDungBanGhe_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBanGhe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangBanGhe);
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
        public async Task<bool> AddBaiDangDoGiaDungBep(BaiDangDoGiaDungBep_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBep = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangBep);
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
        public async Task<bool> AddBaiDangDoGiaDungDenCayCanhNoiThat(BaiDangDoGiaDungDenCayCanhNoiThat_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangDenCayCanhNoiThat = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangDenCayCanhNoiThat);
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
        public async Task<bool> AddBaiDangDoGiaDungGiuong(BaiDangDoGiaDungGiuong_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangGiuong = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangGiuong);
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
        public async Task<bool> AddBaiDangDoGiaDungQuat(BaiDangDoGiaDungQuat_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangQuat = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangQuat);
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
        public async Task<bool> AddBaiDangDoGiaDungThietBiVeSinh(BaiDangDoGiaDungThietBiVeSinh_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangThietBiVeSinh = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangThietBiVeSinh);
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
        public async Task<bool> AddBaiDangDoGiaDungTuKe(BaiDangDoGiaDungTuKe_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangTuKe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangTuKe);
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

        #region BaiDang MeVaBe
        public async Task<bool> AddBaiDangMeVaBe(BaiDangMeVaBe_DTO baiDangRequest)
        {
            BaiDangMeVaBeEntities baiDangMeVaBe = _mapper.Map<BaiDangMeVaBeEntities>(baiDangRequest);
            int lastIDPost = baiDangMeVaBeHelper.AddBaiDang(baiDangMeVaBe);
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

        #region BaiDang ThoiTrang
        public async Task<bool> AddBaiDangThoiTrang(BaiDangThoiTrang_DTO baiDangRequest)
        {
            BaiDangThoiTrangEntities baiDangThoiTrang = _mapper.Map<BaiDangThoiTrangEntities>(baiDangRequest);
            int lastIDPost = baiDangThoiTrangHelper.AddBaiDang(baiDangThoiTrang);
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

        #region BaiDang GiaiTri
        public async Task<bool> AddBaiDangGiaiTri(BaiDangGiaiTri_DTO baiDangRequest)
        {
            BaiDangGiaiTriEntities baiDangGiaiTri = _mapper.Map<BaiDangGiaiTriEntities>(baiDangRequest);
            int lastIDPost = baiDangGiaiTriHelper.AddBaiDang(baiDangGiaiTri);
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
        public async Task<bool> AddBaiDangGiaiTriNhacCu(BaiDangGiaiTriDoNhacCu_DTO baiDangRequest)
        {
            BaiDangGiaiTriEntities baiDangGiaiTri = _mapper.Map<BaiDangGiaiTriEntities>(baiDangRequest);
            int lastIDPost = baiDangGiaiTriHelper.AddBaiDang(baiDangGiaiTri);
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
        public async Task<bool> AddBaiDangGiaiTriDoSuuTam(BaiDangGiaiTriDoSuuTam_DTO baiDangRequest)
        {
            BaiDangGiaiTriEntities baiDangGiaiTri = _mapper.Map<BaiDangGiaiTriEntities>(baiDangRequest);
            int lastIDPost = baiDangGiaiTriHelper.AddBaiDang(baiDangGiaiTri);
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

        #region BaiDang DoDungVanPhong
        public async Task<bool> AddBaiDangDoDungVanPhong(BaiDangDoDungVanPhong_DTO baiDangRequest)
        {
            BaiDangDoDungVanPhongEntities baiDangDoDungVanPhong = _mapper.Map<BaiDangDoDungVanPhongEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDungVanPhongHelper.AddBaiDang(baiDangDoDungVanPhong);
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
        #endregion
    }


}
